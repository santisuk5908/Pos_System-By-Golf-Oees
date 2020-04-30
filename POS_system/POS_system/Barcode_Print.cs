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
    public partial class Barcode_Print : Form
    {
        Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
        MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
        Image ImageForPrint;
        string TextForPrint;
        public Barcode_Print()
        {
            InitializeComponent();
        }

        private void Barcode_Print_Load(object sender, EventArgs e)
        {
            //MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
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
            catch (Exception)
            {
                MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
            }
            LoaddataNew();
            typeProduct.Text = "กรุณาเลือกประเภท";
        }

        private void LoaddataNew()
        {
            try //ดึงข้อมูล DB ลง datagridview
            {
                con.Open();
                string sql = "SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product";
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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            typeProduct.Text = "กรุณาเลือกประเภท";
            nameProduct.Text = "";
            barcodeProduct.Text = "";
            Print_barcode.Enabled = false;
            
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (typeProduct.Text == "กรุณาเลือกประเภท")
                {
                    con.Open();
                    string sql = "SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product WHERE name_product like '%" + nameProduct.Text + "%' AND barcode_product like '%" + barcodeProduct.Text + "%'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    DataSet ds = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(ds);
                    dataProduct.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                    Print_barcode.Enabled = false;
                }
                else
                {
                    con.Open();
                    string sql = "SELECT name_product AS " + "'ชื่อสินค้า'" + ", many_product AS " + "'จำนวน'" + ", price_product AS " + "'ราคา'" + ", count_product AS " + "'หน่วยนับ'" + ", category_product AS " + "'ประเภท'" + ", barcode_product AS " + "'บาร์โค้ด'" + " FROM list_product WHERE category_product like '%" + typeProduct.Text + "%' AND name_product like '%" + nameProduct.Text + "%' AND barcode_product like '%" + barcodeProduct.Text + "%'";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    DataSet ds = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(ds);
                    dataProduct.DataSource = ds.Tables[0].DefaultView;
                    con.Close();
                    Print_barcode.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง", "การแจ้งเตือน");
            }
        }

        private void dataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //ส่งค่าไปยัง textbox
            if (e.RowIndex == -1) return;
            ShowName.Text = dataProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            ShowBarcode.Text = dataProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
            Print_barcode.Enabled = true;
            //ส่วนแสดงผลตัวอย่าง
            ShowPicture_Barcode.Image = barcode.Draw(ShowBarcode.Text, 40);
            ImageForPrint = ShowPicture_Barcode.Image;
            if ((ShowName.Text).Length > 25)
            {
                ShowText_Barcode.Text = (ShowName.Text).Substring(0, 24);
                TextForPrint = (ShowName.Text).Substring(0, 24);
            }
            else
            {
                ShowText_Barcode.Text = ShowName.Text;
                TextForPrint = ShowName.Text;
            }
            
        }

        private void Print_barcode_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 100));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 150));
            
            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 100));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 150));
            
            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 100));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 150));

            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 200));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 250));

            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 200));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 250));

            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 200));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 250));

            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 300));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 350));

            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 300));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 350));
            
            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 300));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 350));

            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 400));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 450));

            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 400));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 450));

            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 400));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 450));

            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 500));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 550));

            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 500));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 550));

            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 500));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 550));

            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 600));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 650));

            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 600));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 650));

            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 600));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 650));

            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 700));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 750));

            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 700));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 750));

            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 700));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 750));

            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 800));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 850));

            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 800));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 850));

            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 800));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 850));

            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 900));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 950));

            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 900));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 950));

            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 900));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 950));

            e.Graphics.DrawImage(ImageForPrint, new PointF(100, 1000));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(100, 1050));

            e.Graphics.DrawImage(ImageForPrint, new PointF(350, 1000));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(350, 1050));

            e.Graphics.DrawImage(ImageForPrint, new PointF(600, 1000));
            e.Graphics.DrawString(TextForPrint, new Font("RSU", 10, FontStyle.Bold), Brushes.Black, new PointF(600, 1050));
        }

        private void ShowName_TextChanged(object sender, EventArgs e)
        {
            if ((ShowName.Text).Length > 25)
            {
                ShowText_Barcode.Text = (ShowName.Text).Substring(0, 24);
                TextForPrint = (ShowName.Text).Substring(0, 24);
            }
            else
            {
                ShowText_Barcode.Text = ShowName.Text;
                TextForPrint = ShowName.Text;
            }
            
        }

        private void ShowBarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ShowBarcode.Text == "")
                {
                    ShowPicture_Barcode.Image = barcode.Draw(" ", 40);
                    ImageForPrint = ShowPicture_Barcode.Image;
                }
                else
                {
                    ShowPicture_Barcode.Image = barcode.Draw(ShowBarcode.Text, 40);
                    ImageForPrint = ShowPicture_Barcode.Image;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Barcode นี้ไม่รองรับการใช้ภาษาไทย  และอักษรพิเศษ\n**** กรุณาใช้ภาษาอังกฤษ หรือตัวเลขเท่านั้น ****", "การแจ้งเตือน");
            }
            
        }
    }
}
