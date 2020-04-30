using MySql.Data.MySqlClient;
using POS_system.Models;
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
    public partial class Pos_System : Form
    {
        public Pos_System()
        {
            InitializeComponent();
        }

        private List<CartItem> shoppingCart = new List<CartItem>();
        int Sumcount_product; //นับจำนวนขาย
        string IDbillcheck;
        string Count; //ไว้หักสต๊อก
        int CountOld;
        int CountNew;

        public static object Properties { get; internal set; }

        private void Pos_System_Load(object sender, EventArgs e)
        {
            LogoBox.Image = Image.FromFile(Program.ImageLogoLocationForPos); //ตำแหน่งรูป
            BoxNameShop.Text = Program.NameshopForPos; //ชื่อร้าน
            BoxIDTex.Text = Program.IDtexForPos; //เลขผู้เสียภาษี
            BoxDateTime.Text = System.DateTime.Now.ToString("dd / MM / yyyy"); //วันเดือนปี
            BoxNameSell.Text = Program.name_login; //ชื่อผู้ใช้
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            NewOrderButton.Enabled = false;
            CancelOrderButton.Enabled = true;
            ItemGroupBox.Enabled = true; //เปิดกลุ่มขาย
            //โหลดเลขที่ใบเสร็จ
            Program.Receipt_NO = "ETS-" + System.DateTime.Now.ToString("yyyyMMddHHmmss");
            ReceiptLabal.Text = Program.Receipt_NO;
            //เลื่อนเคอร์เซอร์ไปกล่องชื่อลูกค้า
            nameCustomer.Focus();
            
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            NewOrderButton.Enabled = true;
            PrintOrderButton.Enabled = false;
            SaveSellButton.Enabled = false;
            CancelOrderButton.Enabled = false;
            ItemGroupBox.Enabled = false; //ปิดกลุ่มขาย
            ReceiptLabal.Text = "";//textbox ส่วนบน
            nameCustomer.Text = "";
            addressCustomer.Text = "-";
            Barcode.Text = "";
            manyBuy.Text = "1";
            //textbox ส่วนล่างด้วย
            TotalAmountTextbox.Text = "0";
            TotalToPayTextBox.Text = "0";
            SalesTaxTextBox.Text = "0";
            SalesTaxTextBox.Enabled = false;
            //เคลียร์ค่า datagrid และ class
            CartDataGridView.DataSource = null;
            shoppingCart.Clear();
        }

        private void SearchBarcode_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameCustomer.Text == "")
                {
                    MessageBox.Show("กรุณากรอกชื่อลูกค้า", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nameCustomer.Focus();
                }
                else if (Barcode.Text == "")
                {
                    MessageBox.Show("กรุณากรอกบาร์โค้ด", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Barcode.Focus();
                }
                else if (int.Parse(manyBuy.Text) <= 0 || manyBuy.Text == "")
                {
                    MessageBox.Show("กรุณาจำนวนสินค้าที่ต้องการ มากกว่า 0", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    manyBuy.Clear();
                    manyBuy.Focus();
                }
                else
                {
                    MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //จะทำการเช็คว่า ID และ User ซ้ำกันกับข้อมูลเดิมหรือไม่
                    try //ตรวจสอบการเชือมต่อ Database
                    {
                        con.Open();
                        string sql = "SELECT * FROM list_product WHERE barcode_product = '" + Barcode.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        bool checkhave = false;
                        while (reader.Read())
                        {
                            Program.BarcodeForPrint = reader.GetString("barcode_product");
                            Program.NameForPrint = reader.GetString("name_product");
                            Program.CountForPrint = reader.GetString("count_product");
                            Program.PriceForPrint = reader.GetString("price_product");
                            Program.CategoryForPrint = reader.GetString("category_product");
                            checkhave = true;
                        }
                        if (checkhave == true)
                        {
                            con.Close();
                            //เอาข้อมูลที่ได้ ลง datagrid
                            CartItem item = new CartItem()
                            {
                                บาร์โค้ด = Barcode.Text,
                                ชื่อสินค้า = Program.NameForPrint,
                                ประเภทสินค้า = Program.CategoryForPrint,
                                จำนวน = int.Parse(manyBuy.Text),
                                หน่วยนับ = Program.CountForPrint,
                                ราคาต่อหน่วย = float.Parse(Program.PriceForPrint),
                                ราคารวม = int.Parse(manyBuy.Text) * float.Parse(Program.PriceForPrint)

                            };
                            //เพิ่มเข้า datagrid
                            shoppingCart.Add(item);
                            CartDataGridView.DataSource = null;
                            CartDataGridView.DataSource = shoppingCart;
                            CartDataGridView.CurrentCell = CartDataGridView.Rows[CartDataGridView.Rows.Count - 1].Cells[0];
                            //รวมค่า
                            Sumcount_product = shoppingCart.Sum(y => y.จำนวน); //นับจำนวนที่ขาย
                            float SumPrice_product = shoppingCart.Sum(x => x.ราคารวม); //นับราคาขาย
                            TotalAmountTextbox.Text = SumPrice_product.ToString();
                            float Sumsale_product = float.Parse(SalesTaxTextBox.Text);
                            float TotalTopay = SumPrice_product - Sumsale_product;
                            TotalToPayTextBox.Text = TotalTopay.ToString();
                            Barcode.Text = "";
                            manyBuy.Text = "1";
                            SalesTaxTextBox.Enabled = true;
                            PrintOrderButton.Enabled = true; //ปุ่ม พิมพ์กับบันทึก เปิดใช้งาน
                            SaveSellButton.Enabled = true;
                            CartDataGridView.Enabled = true;
                        }
                        
                        else if (checkhave == false)
                        {
                            con.Close();
                            MessageBox.Show("ไม่มีบาร์โค้ดนี้ในฐานข้อมูลสินค้า", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Barcode.Clear();
                            Barcode.Focus();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("กรุณากรอกข้อมูล บาร์โค้ด หรือ จำนวนสินค้าที่ต้องการให้ถูกต้อง", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                manyBuy.Clear();
            }
        }

        private void SalesTaxTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (SalesTaxTextBox.Text == "")
                {
                    MessageBox.Show("ห้ามเว้นว่างช่องนี้", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SalesTaxTextBox.Text = "0";
                }
                else if (float.Parse(SalesTaxTextBox.Text) < 0)
                {
                    MessageBox.Show("ส่วนลด ต้องมีค่ามากกว่า 0", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (float.Parse(SalesTaxTextBox.Text) > float.Parse(TotalAmountTextbox.Text))
                {
                    MessageBox.Show("ส่วนลด ต้องมีค่าน้อยกว่าราคาขาย\nร้านจะขาดทุนได้", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    float a = float.Parse(TotalAmountTextbox.Text);
                    float b = float.Parse(SalesTaxTextBox.Text);
                    TotalToPayTextBox.Text = (a - b).ToString();
                }
            }
            catch
            {
                MessageBox.Show("กรอกเพียงตัวเลขเท่านั้น", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CartDataGridView_MouseDown(object sender, MouseEventArgs e) //เมื่อคลิกขวาที่ตาราง
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hti = CartDataGridView.HitTest(e.X, e.Y);
                CartDataGridView.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(CartDataGridView, e.X, e.Y); //ให้โชว์ที่ติดแหน่งนั้น
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = CartDataGridView.CurrentCell.RowIndex; //เก็บค่า index แถว
            shoppingCart.RemoveAt(index); //ลบข้อมูลที่เลือก
            //รีเฟชรตาราง
            CartDataGridView.DataSource = null;
            CartDataGridView.DataSource = shoppingCart;
            //รวมค่า
            Sumcount_product = shoppingCart.Sum(y => y.จำนวน); //นับจำนวนที่ขาย
            float SumPrice_product = shoppingCart.Sum(x => x.ราคารวม); //นับราคาขาย
            TotalAmountTextbox.Text = SumPrice_product.ToString();
            float Sumsale_product = float.Parse(SalesTaxTextBox.Text);
            float TotalTopay = SumPrice_product - Sumsale_product;
            TotalToPayTextBox.Text = TotalTopay.ToString();
            Barcode.Text = "";
            manyBuy.Text = "1";
            SalesTaxTextBox.Enabled = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (shoppingCart.Count <= 18)
            {
                Image logo = LogoBox.Image;
                e.Graphics.DrawImage(logo, new PointF(50, 50)); //แสดง logo ร้าน
                e.Graphics.DrawString("เลขที่ใบเสร็จ " + ReceiptLabal.Text, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(560, 30));
                e.Graphics.DrawString("พนักงานขาย  " + Program.name_login, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(50, 30));
                e.Graphics.DrawString("เมื่อวันที่ " + System.DateTime.Now.ToString("dd / MM / yyyy"), new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(560, 60));
                e.Graphics.DrawString("ใบเสร็จรับเงิน", new Font("RSU", 24, FontStyle.Bold), Brushes.Black, new PointF(200, 60));
                e.Graphics.DrawString("ร้าน " + Program.NameshopForPos + "   รหัสสาขา " + Program.IDshopForPos, new Font("RSU", 18, FontStyle.Bold), Brushes.Black, new PointF(200, 100));
                e.Graphics.DrawString("หมายเลขประจำตัวผู้เสียภาษี  " + Program.IDtexForPos + "   โทร." + Program.TelForPos, new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 140));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 175));
                e.Graphics.DrawString("ที่อยู่ร้าน", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 200));
                e.Graphics.DrawString(Program.AddressForPos, new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(120, 200));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 250));
                e.Graphics.DrawString("ชื่อลูกค้า   " + nameCustomer.Text, new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 280));
                e.Graphics.DrawString("ที่อยู่ลูกค้า", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 310));
                e.Graphics.DrawString(addressCustomer.Text, new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(150, 310));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 360));
                e.Graphics.DrawString("บาร์โค้ด", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 380));
                e.Graphics.DrawString("ชื่อสินค้า", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(190, 380));
                e.Graphics.DrawString("จำนวน", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(450, 380));
                e.Graphics.DrawString("ราคาต่อหน่วย", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(530, 380));
                e.Graphics.DrawString("ราคารวม", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(650, 380));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 400));
                int yPos = 430;
                foreach (var i in shoppingCart) //แสดงรายการสินค้า
                {
                    e.Graphics.DrawString(i.บาร์โค้ด, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(50, yPos));
                    if (i.ชื่อสินค้า.Length > 35)
                    {
                        e.Graphics.DrawString(i.ชื่อสินค้า.Substring(0, 34), new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(190, yPos));
                    }
                    else
                    {
                        e.Graphics.DrawString(i.ชื่อสินค้า, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(190, yPos));
                    }
                    e.Graphics.DrawString("  " + i.จำนวน.ToString() + " " + i.หน่วยนับ, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(450, yPos));
                    e.Graphics.DrawString("  " + i.ราคาต่อหน่วย.ToString(), new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(530, yPos));
                    e.Graphics.DrawString("  " + i.ราคารวม.ToString(), new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(650, yPos));
                    yPos = yPos + 30;
                }
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, yPos));
                yPos = yPos + 30;
                e.Graphics.DrawString("ราคารวม \t" + ": " + TotalAmountTextbox.Text + " บาท", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(500, yPos));
                yPos = yPos + 30;
                e.Graphics.DrawString("ส่วนลด \t" + ": " + SalesTaxTextBox.Text + " บาท", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(500, yPos));
                yPos = yPos + 30;
                e.Graphics.DrawString("รวมทั้งสิ้น \t" + ": " + TotalToPayTextBox.Text + " บาท", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(500, yPos));
                e.Graphics.DrawString("ลงชื่อ..............................", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 1030)); //จุดลงชื่อ
                e.Graphics.DrawString("     (       ผู้รับเงิน      )", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 1060));
                e.Graphics.DrawString("ลงชื่อ..............................", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(250, 1030));
                e.Graphics.DrawString("     (       ผู้จ่ายเงิน      )", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(250, 1060));
            }
            else
            {
                MessageBox.Show("ระบบการทำงานนี้รองรับการพิมพ์ใบเสร็จที่มีรายการสินค้าสูงสุด 18 รายการเท่านั้น\n!!!! ขออภัยในความไม่สะดวก !!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintOrderButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveSellButton_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.No;
            if (nameCustomer.Text == "" || addressCustomer.Text == "")
            {
                MessageBox.Show("กรุณากรอกชื่อลูกค้า และที่อยู่ลูกค้าให้ครบถ้วน", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                result = MessageBox.Show("!!! คุณแน่ใจแล้วหรือไม่ ว่าจะบันทึกใบเสร็จ !!!\nเพราะคุณจะไม่สามารถแก้ไขรายการได้อีก", "การแจ้งเตือน",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            if (result == DialogResult.Yes)
            {
                MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
                string sql;
                MySqlCommand cmd;
                MySqlDataReader reader;
                try
                {
                    foreach (var i in shoppingCart)
                    {
                        con.Open(); //1.ทำการเซฟรายการขายเข้าไปใน product_sell
                        sql = "INSERT INTO product_sell(name_sell, many_sell, price_sell, category_sell, barcode_sell, IDbill_sell) VALUES('" + i.ชื่อสินค้า + "', '" + i.จำนวน.ToString() + "', '" + i.ราคารวม.ToString() + "', '" + i.ประเภทสินค้า + "', '" + i.บาร์โค้ด + "', '" + ReceiptLabal.Text + "')";
                        cmd = new MySqlCommand(sql, con);
                        cmd.ExecuteReader();
                        con.Close();
                    }
                    con.Open(); //2.ทำการเซฟข้อมูลใบเสร็จเข้าไปใน bill_info
                    sql = "INSERT INTO bill_info(IDbill_info, sell_info, customer_info, customeraddrress_info, date_info, many_info, price_info, discount_info, total_info) VALUES('" + ReceiptLabal.Text + "', '" + Program.name_login + "', '" + nameCustomer.Text + "', '" + addressCustomer.Text + "', '" + System.DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + "', '" + Sumcount_product.ToString() + "', '" + TotalAmountTextbox.Text + "', '" + SalesTaxTextBox.Text + "', '" + TotalToPayTextBox.Text + "')";
                    cmd = new MySqlCommand(sql, con);
                    cmd.ExecuteReader();
                    con.Close();
                    try
                    {
                        foreach (var z in shoppingCart) //3.หักสต๊อกแล้วทำการเซฟข้อมูลใบเสร็จเข้าไปใน list_product
                        {
                            con.Open(); //เริ่มจากดึงข้อมูลออกมา โดยใช้บาร์โค้ด
                            cmd = new MySqlCommand("SELECT * FROM list_product WHERE barcode_product = '" + z.บาร์โค้ด + "'", con);
                            reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                Count = reader.GetString("many_product");
                            }
                            con.Close();
                            int CountOld = int.Parse(Count);
                            int CountNew = CountOld - z.จำนวน;
                            con.Open(); //หลังจากลบกันแล้ว นำมาบันทึกเข้าที่เดิม
                            cmd = new MySqlCommand("UPDATE list_product SET many_product = '" + CountNew.ToString() + "' WHERE barcode_product = '" + z.บาร์โค้ด + "'", con);
                            cmd.ExecuteReader();
                            con.Close();
                        }
                        SaveSellButton.Enabled = false;
                        ItemGroupBox.Enabled = false;
                        CartDataGridView.Enabled = false;
                        SalesTaxTextBox.Enabled = false;
                        MessageBox.Show("บันทึกใบเสร็จรับเงินเป็นที่เรียบร้อยแล้ว", "ทำรายการสำเร็จ");
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง ขั้นสต๊อกสินค้า" + err, "เกิดข้อผิดพลาด");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง ขั้น 1,2", "เกิดข้อผิดพลาด");
                }
            }
            else
            {
                Barcode.Focus();
            }
        }
    }
}
