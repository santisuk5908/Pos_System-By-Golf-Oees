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
    public partial class Show_Product : Form
    {
        public Show_Product()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Show_Product_Load(object sender, EventArgs e)
        {
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
            try //ดึงข้อมูล DB ลง datagridview
            {
                con.Open();
                string sql = "SELECT name_product AS "+"'ชื่อสินค้า'"+", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);
                dataProduct.DataSource = ds.Tables[0].DefaultView;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล\n" + ex, "เกิดข้อผิดพลาด");
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            typeProduct.Text = string.Format("");
            nameProduct.Text = string.Format("");
            barcodeProduct.Text = string.Format("");
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (typeProduct.Text == "" && nameProduct.Text == "" && barcodeProduct.Text == "") //กรณีช่องว่าง
                {
                    MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
                    try //ดึงข้อมูล DB ลง datagridview
                    {
                        con.Open();
                        string sql = "SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product WHERE name_product like '%" + nameProduct.Text + "%' AND category_product like '%%' " + "AND barcode_product like '%" + barcodeProduct.Text + "%'";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        DataSet ds = new DataSet();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(ds);
                        dataProduct.DataSource = ds.Tables[0].DefaultView;
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล\n", "เกิดข้อผิดพลาด");
                    }
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
                    try //ดึงข้อมูล DB ลง datagridview
                    {
                        con.Open();
                        string sql = "SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product WHERE name_product like '%" + nameProduct.Text + "%' AND category_product like '%" + typeProduct.Text + "%' " + "AND barcode_product like '%" + barcodeProduct.Text + "%'";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        DataSet ds = new DataSet();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(ds);
                        dataProduct.DataSource = ds.Tables[0].DefaultView;
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล\n", "เกิดข้อผิดพลาด");
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง", "การแจ้งเตือน");
            }
            
        }
    }
}
