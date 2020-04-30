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
    public partial class Edit_MyUser : Form
    {
        string Check_Olduser;
        string Check_OldID;
        public Edit_MyUser()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_MyUser_Load(object sender, EventArgs e)
        {
            try
            {
                string IDuserDB = "";
                string UsernameDB = "";
                string PasswordDB = "";
                string FristnameDB = "";
                string LastnameDB = "";
                string AddressDB = "";
                string telDB = "";

                MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); // โหลดข้อมูลลง textbox
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM login WHERE id_login = '" + Program.id_login + "'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    IDuserDB = reader.GetString("id_login");
                    UsernameDB = reader.GetString("user_login");
                    PasswordDB = reader.GetString("password_login");
                    FristnameDB = reader.GetString("name_login");
                    LastnameDB = reader.GetString("lastname_login");
                    AddressDB = reader.GetString("address_login");
                    telDB = reader.GetString("tel_login");
                }
                con.Close();
                IDuser.Text = string.Format(IDuserDB);
                user.Text = string.Format(UsernameDB);
                password.Text = string.Format(PasswordDB);
                fristname.Text = string.Format(FristnameDB);
                lastname.Text = string.Format(LastnameDB);
                address.Text = string.Format(AddressDB);
                tel.Text = string.Format(telDB);
                Check_Olduser = string.Format(UsernameDB);
                Check_OldID = string.Format(IDuserDB);
            }
            catch (Exception)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล", "การแจ้งเตือน");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if ((IDuser.Text).Length > 10) //เช็คว่ากรอกข้อมูลเกินกำหนดหรือไม่
            {
                MessageBox.Show("ช่องกรอก ID ผู้ใช้ ใช้ตัวอักษรเกินกำหนด", "การแจ้งเตือน");
            }
            else if ((user.Text).Length > 20 || (password.Text).Length > 20)
            {
                MessageBox.Show("ช่องกรอก Username หรือ Lastname ใช้ตัวอักษรเกินกำหนด", "การแจ้งเตือน");
            }
            else if ((tel.Text).Length > 20)
            {
                MessageBox.Show("ช่องกรอกเบอร์โทรศัพท์ ใช้ตัวอักษรเกินกำหนด", "การแจ้งเตือน");
            }
            else if (IDuser.Text == "" || user.Text == "" || password.Text == "" || fristname.Text == "" || lastname.Text == "" || address.Text == "" || tel.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน\nห้ามเว้นว่างไว้", "การแจ้งเตือน");
            }
            else
            {
                if (IDuser.Text == Check_OldID && user.Text == Check_Olduser) //กรณี ID ไม่เปลี่ยน และ User ไม่เปลี่ยน
                {
                    MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //โหลด ไอดีผู้ใช้ใหม่
                    try // บันทึกข้อมูล
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE login SET id_login='" + IDuser.Text + "', user_login='" + user.Text + "', password_login='" + password.Text + "', name_login='" + fristname.Text + "', lastname_login='" + lastname.Text + "', address_login='" + address.Text + "', tel_login='" + tel.Text + "' WHERE id_login = '" + Program.id_login + "';", con);
                        cmd.ExecuteReader();
                        con.Close();
                        Program.id_login = string.Format(IDuser.Text);
                        MessageBox.Show("**** บันทึกสำเร็จ ****\n---- สรุปการบันทึกการเข้าระบบ ----\nUser : " + user.Text + "\nPassword : " + password.Text, "ทำรายการสำเร็จ");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("!!!! บันทึกไม่สำเร็จ !!!!\nเนื่องจากเกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล", "การแจ้งเตือน");
                    }
                }
                else if (IDuser.Text != Check_OldID && user.Text == Check_Olduser) //กรณี ID เปลี่ยน และ User ไม่เปลี่ยน
                {
                    MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //จะทำการเช็คว่า ID และ User ซ้ำกันกับข้อมูลเดิมหรือไม่
                    try //ตรวจสอบการเชือมต่อ Database
                    {
                        con.Open();
                        string sql = "SELECT * FROM login WHERE id_login = '" + IDuser.Text + "'";
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
                                sql = "UPDATE login SET id_login='" + IDuser.Text + "', user_login='" + user.Text + "', password_login='" + password.Text + "', name_login='" + fristname.Text + "', lastname_login='" + lastname.Text + "', address_login='" + address.Text + "', tel_login='" + tel.Text + "' WHERE id_login = '" + Program.id_login + "';";
                                cmd = new MySqlCommand(sql, con);
                                cmd.ExecuteReader();
                                con.Close();
                                MessageBox.Show("**** บันทึกสำเร็จ ****\n---- สรุปการบันทึกการเข้าระบบ ----\nUser : " + user.Text + "\nPassword : " + password.Text, "ทำรายการสำเร็จ");
                                Program.id_login = string.Format(IDuser.Text);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง", "เกิดข้อผิดพลาด");
                            }
                        }
                        else if (check == false) //ถ้ามีข้อมูลซ้ำ
                        {
                            MessageBox.Show("มี ID ผู้ใช้\nซ้ำกันกับข้อมูลเดิมที่มีอยู่ในฐานข้อมูล\n*** กรุณาเปลี่ยนใหม่ ***", "การแจ้งเตือน");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
                    }
                }
                else if (IDuser.Text == Check_OldID && user.Text != Check_Olduser) //กรณี ID ไม่เปลี่ยน และ User เปลี่ยน
                {
                    MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //จะทำการเช็คว่า ID และ User ซ้ำกันกับข้อมูลเดิมหรือไม่
                    try //ตรวจสอบการเชือมต่อ Database
                    {
                        con.Open();
                        string sql = "SELECT * FROM login WHERE user_login = '" + user.Text + "'";
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
                                sql = "UPDATE login SET id_login='" + IDuser.Text + "', user_login='" + user.Text + "', password_login='" + password.Text + "', name_login='" + fristname.Text + "', lastname_login='" + lastname.Text + "', address_login='" + address.Text + "', tel_login='" + tel.Text + "' WHERE id_login = '" + Program.id_login + "';";
                                cmd = new MySqlCommand(sql, con);
                                cmd.ExecuteReader();
                                con.Close();
                                MessageBox.Show("**** บันทึกสำเร็จ ****\n---- สรุปการบันทึกการเข้าระบบ ----\nUser : " + user.Text + "\nPassword : " + password.Text, "ทำรายการสำเร็จ");
                                Program.id_login = string.Format(IDuser.Text);
                                Program.name_login = string.Format(user.Text);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง", "เกิดข้อผิดพลาด");
                            }
                        }
                        else if (check == false) //ถ้ามีข้อมูลซ้ำ
                        {
                            MessageBox.Show("มี Username\nซ้ำกันกับข้อมูลเดิมที่มีอยู่ในฐานข้อมูล\n*** กรุณาเปลี่ยนใหม่ ***", "การแจ้งเตือน");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
                    }
                }
                else if (IDuser.Text != Check_OldID && user.Text != Check_Olduser) //กรณี ID เปลี่ยน และ User เปลี่ยน
                {
                    MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //จะทำการเช็คว่า ID และ User ซ้ำกันกับข้อมูลเดิมหรือไม่
                    try //ตรวจสอบการเชือมต่อ Database
                    {
                        con.Open();
                        string sql = "SELECT * FROM login WHERE id_login = '" + IDuser.Text + "' OR user_login = '" + user.Text + "'";
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
                                sql = "UPDATE login SET id_login='" + IDuser.Text + "', user_login='" + user.Text + "', password_login='" + password.Text + "', name_login='" + fristname.Text + "', lastname_login='" + lastname.Text + "', address_login='" + address.Text + "', tel_login='" + tel.Text + "' WHERE id_login = '" + Program.id_login + "';";
                                cmd = new MySqlCommand(sql, con);
                                cmd.ExecuteReader();
                                con.Close();
                                MessageBox.Show("**** บันทึกสำเร็จ ****\n---- สรุปการบันทึกการเข้าระบบ ----\nUser : " + user.Text + "\nPassword : " + password.Text, "ทำรายการสำเร็จ");
                                Program.id_login = string.Format(IDuser.Text);
                                Program.name_login = string.Format(user.Text);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง", "เกิดข้อผิดพลาด");
                            }
                        }
                        else if (check == false) //ถ้ามีข้อมูลซ้ำ
                        {
                            MessageBox.Show("มี ID ผู้ใช้ หรือ Username\nซ้ำกันกับข้อมูลเดิมที่มีอยู่ในฐานข้อมูล\n*** กรุณาเปลี่ยนใหม่ ***", "การแจ้งเตือน");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
                    }
                }
                
            }
        }
    }
}
