using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class Add_Product : Form
    {
        MySqlDataAdapter oda;
        DataTable dt;
        public Add_Product()
        {
            InitializeComponent();
        }


        private void reset_Click(object sender, EventArgs e)
        {
            nameProduct.Text = string.Format("");
            manyProduct.Text = string.Format("0");
            priceProduct.Text = string.Format("0");
            typeProduct.Text = string.Format("กรุณาเลือกประเภท");
            countProduct.Text = string.Format("กรุณาเลือกประเภท");
            barcodeProduct.Text = string.Format("");
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            string barcode = System.DateTime.Now.ToString("yyyyMMddHHmmss");
            barcodeProduct.Text = string.Format(barcode.Substring(1,13));
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (nameProduct.Text == "") //ตรวจสอบการกรอกข้อมูลครบถ้วน
            {
                MessageBox.Show("กรุณากรอกชื่อสินค้า", "การแจ้งเตือน");
            }
            else if (manyProduct.Text == "0")
            {
                MessageBox.Show("กรุณากรอกจำนวนสินค้า", "การแจ้งเตือน");
            }
            else if (countProduct.Text == "กรุณาเลือกหน่วยนับ")
            {
                MessageBox.Show("กรุณาเลือกหน่วยนับ", "การแจ้งเตือน");
            }
            else if (typeProduct.Text == "กรุณาเลือกประเภท")
            {
                MessageBox.Show("กรุณาเลือกประเภท", "การแจ้งเตือน");
            }
            else if (barcodeProduct.Text == "")
            {
                MessageBox.Show("กรุณากรอก Barcode ของสินค้า\nหรือกดปุ่ม Genalate เพื่อสร้าง Barcode ใหม่", "การแจ้งเตือน");
            }
            else if ((barcodeProduct.Text).Length < 5)
            {
                MessageBox.Show("กรุณากรอก Barcode ของสินค้าอย่างน้อย 5 ตัวอักษร", "การแจ้งเตือน");
            }
            else
            {
                try //เช็ตว่าบาร์โค้ด format ถูกต้องหรือไม่
                {
                    double barcodecheck = Convert.ToInt64(barcodeProduct.Text);
                    MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
                    try //ตรวจสอบการเชือมต่อ Database
                    {
                        con.Open();
                        string sql = "SELECT * FROM list_product WHERE barcode_product = '" + barcodeProduct.Text + "' OR name_product = '" + nameProduct.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        bool check = true; //เช็คว่าเงื่อนไขใน cmd ว่าข้อมูลซ้ำกันหรือไม่
                        while (reader.Read())
                        {
                            check = false; //ถ้าข้อมูลซ้ำใน DB ให้เป็น False
                        }
                        con.Close();
                        if(check == true) //ถ้าไม่มีข้อมูลซ้ำ
                        {
                            try //ทำการเชื่อมต่อข้อมูล และบันทึกลง DB
                            {
                                con.Open();
                                sql = "INSERT INTO list_product(name_product, many_product, price_product, count_product, category_product, barcode_product) VALUES('"+ nameProduct.Text + "', '" + manyProduct.Text + "', '" + priceProduct.Text + "', '" + countProduct.Text + "', '" + typeProduct.Text + "', '" + barcodeProduct.Text + "')";
                                cmd = new MySqlCommand(sql, con);
                                cmd.ExecuteReader();
                                MessageBox.Show("บันทึกรายการสินค้าเป็นที่เรียบร้อยแล้ว", "ทำรายการสำเร็จ");
                                con.Close();
                                nameProduct.Text = string.Format("");
                                manyProduct.Text = string.Format("0");
                                priceProduct.Text = string.Format("0");
                                typeProduct.Text = string.Format("กรุณาเลือกประเภท");
                                countProduct.Text = string.Format("กรุณาเลือกประเภท");
                                barcodeProduct.Text = string.Format("");
                                LoaddataNew();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง", "เกิดข้อผิดพลาด");
                            }
                        }
                        else if (check == false) //ถ้ามีข้อมูลซ้ำ
                        {
                            MessageBox.Show("มีชื่อสินค้า หรือบาร์โค้ดสินค้า\nซ้ำกันกับสินค้าเดิมที่มีอยู่ในฐานข้อมูล\n*** กรุณาเปลี่ยนใหม่ ***", "การแจ้งเตือน");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("กรุณากรอกบาร์โค้ดให้อยู่ในรูปแบบที่ถูกต้อง", "การแจ้งเตือน");
                }
            }
        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //ดึงข้อมูล ชนิดของสินค้า ลง combobox
            try
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
            catch (Exception)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
            }
            LoaddataNew(); //ดึงข้อมูลลงตาราง
        }

        private void LoaddataNew()
        {
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
