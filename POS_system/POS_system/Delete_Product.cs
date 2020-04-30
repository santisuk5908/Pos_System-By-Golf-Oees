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
    public partial class Delete_Product : Form
    {
        MySqlDataAdapter oda;
        DataTable dt;
        public Delete_Product()
        {
            InitializeComponent();
        }

        private void Delete_Product_Load(object sender, EventArgs e)
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
                MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
            }
            LoaddataNew();
            save.Enabled = false;
        }

        private void LoaddataNew()
        {
            //โหลดข้อมูลใหม่
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            try //ดึงข้อมูล DB ลง datagridview
            {
                //con.Open();
                oda = new MySqlDataAdapter("SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product", con);
                dt = new DataTable();
                oda.Fill(dt);
                dataProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
            }
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
                LoaddataNew();

            }
            else if (typeProduct.Text == "กรุณาเลือกประเภท")
            {
                //หาเฉพาะชื่อ
                try //ดึงข้อมูล DB ลง datagridview
                {
                    //con.Open();
                    oda = new MySqlDataAdapter("SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product WHERE name_product like '%" + nameProduct.Text + "%'", con);
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

        private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ส่งค่าไปยัง textbox
            if (e.RowIndex == -1) return;
            nameProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            manyProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
            countProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
            barcodeProductEdit.Text = dataProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            save.Enabled = true;
        }

        private void save_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            //โหลด ไอดีผู้ใช้ใหม่
            try // ลบข้อมูลที่ต้องการ
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM list_product WHERE barcode_product = '"+ barcodeProductEdit.Text +"';", con);
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("**** ลบรายการสินค้าสำเร็จ ****", "ทำรายการสำเร็จ");
            }
            catch (Exception)
            {
                MessageBox.Show("!!!! บันทึกไม่สำเร็จ !!!!\nเกิดข้อผิดพลาดในการเชื่อมต่อฐานข้อมูล", "การแจ้งเตือน");
            }
            LoaddataNew();
            //con.Close();
            save.Enabled = false;
            nameProductEdit.Text = "";
            manyProductEdit.Text = "";
            priceProductEdit.Text = "";
            countProductEdit.Text = "";
            barcodeProductEdit.Text = "";
        }
    }
}
