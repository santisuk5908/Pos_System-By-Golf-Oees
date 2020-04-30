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
    public partial class Edit_Product : Form
    {
        MySqlDataAdapter oda;
        //MySqlCommandBuilder ocb;
        DataTable dt;
        string Check_OldName_Product;
        public Edit_Product()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            typeProduct.Text = "กรุณาเลือกประเภท";
            nameProduct.Text = "";
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            if (typeProduct.Text == "กรุณาเลือกประเภท" && nameProduct.Text == "")
            {
                //แสดงทั้งหมด
                loadDataNew();

            }
            else if (typeProduct.Text == "กรุณาเลือกประเภท")
            {
                //หาเฉพาะชื่อ
                try //ดึงข้อมูล DB ลง datagridview
                {
                    //con.Open();
                    oda = new MySqlDataAdapter("SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product WHERE name_product like '%" + nameProduct.Text +"%'", con);
                    dt = new DataTable();
                    oda.Fill(dt);
                    dataProduct.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
                }
            }
            else
            {
                //หาทั้งสอง
                try //ดึงข้อมูล DB ลง datagridview
                {
                    //con.Open();
                    oda = new MySqlDataAdapter("SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product WHERE category_product like '%" + typeProduct.Text + "%' AND name_product like '%" + nameProduct.Text + "%'", con);
                    dt = new DataTable();
                    oda.Fill(dt);
                    dataProduct.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            if (nameProductEdit.Text == "" || manyProductEdit.Text == "" || priceProductEdit.Text == "" || countProductEdit.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน ห้ามเว้นว่างไว้", "การแจ้งเตือน");
            }
            else if ((nameProductEdit.Text).Length > 50)
            {
                MessageBox.Show("กรุณากรอกตัวอักษรช่องชื่อสินค้า เกินที่กำหนด", "การแจ้งเตือน");
            }
            else
            {
                if (nameProductEdit.Text == Check_OldName_Product)//ถ้ามีการแก้ไขช่องชื่อสินค้า ให้เช็คว่า เหมือนกันกับอันเก่าหรือไม่
                {
                    try // บันทึกข้อมูล
                    {
                        con.Open();
                        MySqlCommand cmd = new MySqlCommand("UPDATE list_product SET name_product='" + nameProductEdit.Text + "', many_product='" + manyProductEdit.Text + "', price_product='" + priceProductEdit.Text + "', count_product='" + countProductEdit.Text + "' WHERE barcode_product = '" + barcodeProductEdit.Text + "';", con);
                        cmd.ExecuteReader();
                        con.Close();
                        MessageBox.Show("**** บันทึกสำเร็จ ****", "ทำรายการสำเร็จ");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("!!!! บันทึกไม่สำเร็จ !!!!\nเกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล", "การแจ้งเตือน");
                    }
                }
                else if (nameProductEdit.Text != Check_OldName_Product)
                {
                    //จะทำการเช็คว่า name_product ซ้ำกันกับข้อมูลเดิมหรือไม่
                    try //ตรวจสอบการเชือมต่อ Database
                    {
                        con.Open();
                        string sql = "SELECT * FROM list_product WHERE name_product = '" + nameProductEdit.Text + "'";
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
                            try // บันทึกข้อมูล
                            {
                                con.Open();
                                cmd = new MySqlCommand("UPDATE list_product SET name_product='" + nameProductEdit.Text + "', many_product='" + manyProductEdit.Text + "', price_product='" + priceProductEdit.Text + "', count_product='" + countProductEdit.Text + "' WHERE barcode_product = '" + barcodeProductEdit.Text + "';", con);
                                cmd.ExecuteReader();
                                con.Close();
                                MessageBox.Show("**** บันทึกสำเร็จ ****", "ทำรายการสำเร็จ");
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("!!!! บันทึกไม่สำเร็จ !!!!\nเกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล", "การแจ้งเตือน");
                            }
                        }
                        else if (check == false) //ถ้ามีข้อมูลซ้ำ
                        {
                            MessageBox.Show("มีชื่อสินค้า\nซ้ำกันกับสินค้าเดิมที่มีอยู่ในฐานข้อมูล\n*** กรุณาเปลี่ยนใหม่ ***", "การแจ้งเตือน");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
                    }
                }
            }
            //โหลด ไอดีผู้ใช้ใหม่
            loadDataNew();
            save.Enabled = false;
            nameProductEdit.Text = "";
            manyProductEdit.Text = "";
            priceProductEdit.Text = "";
            countProductEdit.Text = "";
            barcodeProductEdit.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Product_Load(object sender, EventArgs e)
        {
            manyProductEdit.Text = "";
            priceProductEdit.Text = "";
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            try //ดึงข้อมูล ชนิดของสินค้า ลง combobox
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM type_product", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("type_name", typeof(string));
                dt.Load(reader);
                typeProduct.DataSource = dt;
                typeProduct.ValueMember = "type_name";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
            }
            loadDataNew();
            save.Enabled = false;
            typeProduct.Text = "กรุณาเลือกประเภท";
        }

        private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e) //เมื่อมีการเลือกข้อมูลสินค้า จาก datagrid
        {
            //ส่งค่าไปยัง textbox
            if (e.RowIndex == -1) return;
            nameProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            manyProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            countProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            barcodeProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            Check_OldName_Product = dataProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            save.Enabled = true;
        }
        private void loadDataNew()
        {
            //โหลดข้อมูลใหม่
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            try //ดึงข้อมูล DB ลง datagridview
            {
                oda = new MySqlDataAdapter("SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product", con);
                dt = new DataTable();
                oda.Fill(dt);
                dataProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
            }
        }
    }
}
