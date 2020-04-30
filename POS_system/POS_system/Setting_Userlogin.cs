using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class Setting_Userlogin : Form
    {
        MySqlDataAdapter oda;
        DataTable dt;
        string IDForWork;
        string IDForDelete;
        string Check_OldUser; //ไว้เช็คชื่อว่า เปลี่ยน User หรือไม่
        public Setting_Userlogin()
        {
            InitializeComponent();
        }

        private void LoaddataNew()
        {
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            try //ดึงข้อมูล DB ลง datagridview
            {
                oda = new MySqlDataAdapter("SELECT id_login AS " + "'ID ผู้ใช้'" + ", user_login AS " + "'Username'" + ", password_login AS " + "'Password'" + ", status_login AS " + "'สถานะผู้ใช้งาน'" + ", name_login AS " + "'ชื่อจริง'" + ", lastname_login AS " + "'นามสกุล'" + ", tel_login AS " + "'เบอร์โทรศัพท์'" + " FROM login", con);
                dt = new DataTable();
                oda.Fill(dt);
                dataMemberAddMode.DataSource = dt;
                dataMemberEditMode.DataSource = dt;
                dataMemberDeleteMode.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
            }
        }

        private void SelectAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAdd.Checked == true)
            {
                AddMode.Enabled = true;
                EditMode.Enabled = false;
                DeleteMode.Enabled = false;
            }
        }

        private void Setting_Userlogin_Load(object sender, EventArgs e)
        {
            AddMode.Enabled = false;
            EditMode.Enabled = false;
            DeleteMode.Enabled = false;
            //โหลดข้อมูลลง datagrid
            LoaddataNew();
        }

        private void SelectEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectEdit.Checked == true)
            {
                AddMode.Enabled = false;
                EditMode.Enabled = true;
                DeleteMode.Enabled = false;
            }
        }

        private void Selectdelete_CheckedChanged(object sender, EventArgs e)
        {
            if (Selectdelete.Checked == true)
            {
                AddMode.Enabled = false;
                EditMode.Enabled = false;
                DeleteMode.Enabled = true;
            }
        }
        //ส่วนการทำงานทั้งสามส่วน -----------------------------------------------------------------------------------!
        private void resetAddMode_BT_Click(object sender, EventArgs e)
        {
            BoxUserAddMode.Text = "";
            BoxPasswordAddMode.Text = "";
            BoxStatusAddMode.Text = "กรุณาเลือกประเภท";
        }

        private void dataMemberEditMode_CellContentClick(object sender, DataGridViewCellEventArgs e) //เมื่อเลือกข้อมูลในตาราง EditMode
        {
            //ส่งค่าไปยัง textbox
            if (e.RowIndex == -1) return;
            BoxUserEditMode.Text = dataMemberEditMode.Rows[e.RowIndex].Cells[1].Value.ToString();
            BoxPasswordEditMode.Text = dataMemberEditMode.Rows[e.RowIndex].Cells[2].Value.ToString();
            BoxStatusEditMode.Text = dataMemberEditMode.Rows[e.RowIndex].Cells[3].Value.ToString();
            SaveEditMode_BT.Enabled = true;
            Check_OldUser = dataMemberEditMode.Rows[e.RowIndex].Cells[1].Value.ToString();
            IDForWork = dataMemberEditMode.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataMemberDeleteMode_CellContentClick(object sender, DataGridViewCellEventArgs e) //เมื่อเลือกข้อมูลในตาราง DeleteMode
        {
            //ส่งค่าไปยัง textbox
            if (e.RowIndex == -1) return;
            BoxUserDeleteMode.Text = dataMemberDeleteMode.Rows[e.RowIndex].Cells[1].Value.ToString();
            BoxStatusDeleteMode.Text = dataMemberDeleteMode.Rows[e.RowIndex].Cells[3].Value.ToString();
            SaveDeleteMode_BT.Enabled = true;
            IDForDelete = dataMemberDeleteMode.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void SaveAddMode_BT_Click(object sender, EventArgs e)
        {
            if (BoxStatusAddMode.Text == "Admin" || BoxStatusAddMode.Text == "Manager" || BoxStatusAddMode.Text == "Salesperson")
            {
                if (BoxIDAddMode.Text != "" && BoxUserAddMode.Text != "" && BoxPasswordAddMode.Text != "")
                {
                    if ((BoxIDAddMode.Text).Length <= 10 && (BoxUserAddMode.Text).Length <= 20  && (BoxPasswordAddMode.Text).Length <= 20)
                    {
                        MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //จะทำการเช็คว่า ID และ User ซ้ำกันกับข้อมูลเดิมหรือไม่
                        try //ตรวจสอบการเชือมต่อ Database
                        {
                            con.Open();
                            string sql = "SELECT * FROM login WHERE id_login = '" + BoxIDAddMode.Text + "' OR user_login = '" + BoxUserAddMode.Text + "'";
                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            MySqlDataReader reader = cmd.ExecuteReader();
                            bool check = true; //เช็คว่าเงื่อนไขใน cmd ว่าข้อมูลซ้ำกันหรือไม่
                            while (reader.Read())
                            {
                                check = false; //ถ้าข้อมูลซ้ำใน DB ให้เป็น False
                            }
                            con.Close();
                            if (check == true) //ถ้าไม่มีข้อมูลซ้ำ
                            {
                                try //ทำการเชื่อมต่อข้อมูล และบันทึกลง DB
                                {
                                    con.Open();
                                    sql = "INSERT INTO login(id_login, user_login, password_login, status_login, name_login, lastname_login, address_login, tel_login) VALUES('" + BoxIDAddMode.Text + "', '" + BoxUserAddMode.Text + "', '" + BoxPasswordAddMode.Text + "', '" + BoxStatusAddMode.Text + "', '-', '-', '-', '-')";
                                    cmd = new MySqlCommand(sql, con);
                                    cmd.ExecuteReader();
                                    MessageBox.Show("บันทึกข้อมูลเป็นที่เรียบร้อยแล้ว สรุปผลดังนี้\nUser : "+ BoxUserAddMode.Text +"\nPassword : " + BoxPasswordAddMode.Text, "ทำรายการสำเร็จ");
                                    con.Close();
                                    BoxIDAddMode.Text = string.Format("");
                                    BoxUserAddMode.Text = string.Format("");
                                    BoxPasswordAddMode.Text = string.Format("");
                                    BoxStatusAddMode.Text = string.Format("กรุณาเลือกสถานะ");
                                    LoaddataNew(); //โหลดข้อมูลใหม่
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("กรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง", "เกิดข้อผิดพลาด");
                                }
                            }
                            else if (check == false) //ถ้ามีข้อมูลซ้ำ
                            {
                                MessageBox.Show("มี ID ผู้ใช้ หรือ User\nซ้ำกันกับสินค้าเดิมที่มีอยู่ในฐานข้อมูล\n*** กรุณาเปลี่ยนใหม่ ***", "การแจ้งเตือน");
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("กรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
                        }
                    }
                    else
                    {
                        MessageBox.Show("มีช่อง ID ผู้ใช้ หรือ Username หรือ Password ใช้ตัวอักษรเกินที่กำหนด","การแจ้งเตือน");
                    }
                }
                else //กรณีมีช่องที่เว้นว่าง
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "การแจ้งเตือน");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสถานะผู้ใช้ ตามที่กำหนดให้เท่านั้น", "การแจ้งเตือน");
            }
        }

        private void SaveEditMode_BT_Click(object sender, EventArgs e)
        {
            if (BoxStatusEditMode.Text == "Admin" || BoxStatusEditMode.Text == "Manager" || BoxStatusEditMode.Text == "Salesperson")
            {
                if (BoxUserEditMode.Text != "" && BoxPasswordEditMode.Text != "")
                {
                    if ((BoxUserEditMode.Text).Length <= 20 && (BoxPasswordEditMode.Text).Length <= 20)
                    {
                        if (BoxUserEditMode.Text == Check_OldUser) //เช็คว่า ได้แก้ไข User มั้ย ถ้าไม่แก้ ไม่ต้องเช็ค
                        {
                            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //จะทำการเช็คว่า ID และ User ซ้ำกันกับข้อมูลเดิมหรือไม่
                            MySqlCommand cmd = cmd = new MySqlCommand("UPDATE login SET password_login = '" + BoxPasswordEditMode.Text + "', status_login = '" + BoxStatusEditMode.Text + "' WHERE id_login = '" + IDForWork + "'; ", con);
                            try //ทำการเชื่อมต่อข้อมูล และบันทึกลง DB
                            {
                                con.Open();
                                cmd.ExecuteReader();
                                MessageBox.Show("แก้ไขข้อมูลเป็นที่เรียบร้อยแล้ว สรุปผลดังนี้\nUser : " + BoxUserEditMode.Text + "\nPassword : " + BoxPasswordEditMode.Text, "ทำรายการสำเร็จ");
                                con.Close();
                                BoxUserEditMode.Text = string.Format("");
                                BoxPasswordEditMode.Text = string.Format("");
                                BoxStatusEditMode.Text = string.Format("กรุณาเลือกสถานะ");
                                LoaddataNew(); //โหลดข้อมูลใหม่
                                SaveEditMode_BT.Enabled = false;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("กรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง", "เกิดข้อผิดพลาด");
                            }
                        }
                        else //ถ้าแก้ไข ให้เช็คว่า ซ้ำกันกับอันเก่ามั้ย
                        {
                            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //จะทำการเช็คว่า ID และ User ซ้ำกันกับข้อมูลเดิมหรือไม่
                            try //ตรวจสอบการเชือมต่อ Database
                            {
                                con.Open();
                                string sql = "SELECT * FROM login WHERE user_login = '" + BoxUserEditMode.Text + "'";
                                MySqlCommand cmd = new MySqlCommand(sql, con);
                                MySqlDataReader reader = cmd.ExecuteReader();
                                bool check = true; //เช็คว่าเงื่อนไขใน cmd ว่าข้อมูลซ้ำกันหรือไม่
                                while (reader.Read())
                                {
                                    check = false; //ถ้าข้อมูลซ้ำใน DB ให้เป็น False
                                }
                                con.Close();
                                if (check == true) //ถ้าไม่มีข้อมูลซ้ำ
                                {
                                    try //ทำการเชื่อมต่อข้อมูล และบันทึกลง DB
                                    {
                                        con.Open();
                                        sql = "UPDATE login SET user_login='" + BoxUserEditMode.Text + "', password_login='" + BoxPasswordEditMode.Text + "', status_login='" + BoxStatusEditMode.Text + "' WHERE id_login = '" + IDForWork + "';";
                                        cmd = new MySqlCommand(sql, con);
                                        cmd.ExecuteReader();
                                        MessageBox.Show("แก้ไขข้อมูลเป็นที่เรียบร้อยแล้ว สรุปผลดังนี้\nUser : " + BoxUserEditMode.Text + "\nPassword : " + BoxPasswordEditMode.Text, "ทำรายการสำเร็จ");
                                        con.Close();
                                        BoxUserEditMode.Text = string.Format("");
                                        BoxPasswordEditMode.Text = string.Format("");
                                        BoxStatusEditMode.Text = string.Format("กรุณาเลือกสถานะ");
                                        LoaddataNew(); //โหลดข้อมูลใหม่
                                        SaveEditMode_BT.Enabled = false;
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("กรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง", "เกิดข้อผิดพลาด");
                                    }
                                }
                                else if (check == false) //ถ้ามีข้อมูลซ้ำ
                                {
                                    MessageBox.Show("มี User\nซ้ำกันกับสินค้าเดิมที่มีอยู่ในฐานข้อมูล\n*** กรุณาเปลี่ยนใหม่ ***", "การแจ้งเตือน");
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("กรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("มีช่อง Username หรือ Password ใช้ตัวอักษรเกินที่กำหนด", "การแจ้งเตือน");
                    }
                }
                else //กรณีมีช่องที่เว้นว่าง
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "การแจ้งเตือน");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสถานะผู้ใช้ ตามที่กำหนดให้เท่านั้น", "การแจ้งเตือน");
            }
        }

        private void SaveDeleteMode_BT_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            try // ลบข้อมูลที่ต้องการ
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM login WHERE id_login = '" + IDForDelete + "';", con);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("**** ลบบัญชีสำเร็จ ****", "ทำรายการสำเร็จ");
            }
            catch (Exception)
            {
                MessageBox.Show("!!!! บันทึกไม่สำเร็จ !!!!\nเกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล", "การแจ้งเตือน");
            }
            LoaddataNew();
            SaveDeleteMode_BT.Enabled = false;
            BoxUserDeleteMode.Text = "";
            BoxStatusDeleteMode.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
