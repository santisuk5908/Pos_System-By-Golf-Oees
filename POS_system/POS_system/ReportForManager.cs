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
    public partial class ReportForManager : Form
    {
        string dataSearch;
        private List<Bill_Item> Bill_Show = new List<Bill_Item>();
        string Total;
        float SumTotal;
        
        public ReportForManager()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataSearch = dateTimePicker1.Value.ToString("yyyyMMdd"); //ดึงวันที่ออกมาค้นหา
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportForManager_Load(object sender, EventArgs e)
        {
            dataSearch = dateTimePicker1.Value.ToString("yyyyMMdd");
            PrintReport_BT.Enabled = false;
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            try
            {
                con.Open();
                string sql = "SELECT * FROM bill_info WHERE date_info like '" + dataSearch + "%'";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                bool checkhave = false;
                Bill_Show.Clear();
                while (reader.Read())
                {
                    Total = reader.GetString("total_info");
                    Bill_Item item = new Bill_Item()
                    {
                        เลขที่ใบเสร็จ = reader.GetString("IDbill_info"),
                        ผู้ขาย = reader.GetString("sell_info"),
                        ลูกค้า = reader.GetString("customer_info"),
                        เวลา = reader.GetString("date_info"),
                        จำนวน = reader.GetString("many_info"),
                        ราคา = reader.GetString("price_info"),
                        ส่วนลด = reader.GetString("discount_info"),
                        รวมทั้งสิ้น = float.Parse(Total)
                    };
                    Bill_Show.Add(item); //เพิ่มข้อมูล
                    checkhave = true;
                }
                if (checkhave == true)
                {
                    con.Close();
                    SumTotal = Bill_Show.Sum(y => y.รวมทั้งสิ้น);
                    DataGridView.DataSource = null; //แสดงข้อมูลใน datagrid
                    DataGridView.DataSource = Bill_Show;
                    PrintReport_BT.Enabled = true;
                }
                else if (checkhave == false)
                {
                    con.Close();
                    DataGridView.DataSource = null;
                    MessageBox.Show("ไม่มีฐานข้อมูลใบเสร็จรับเงินในวันที่เลือกนี้", "เกิดข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PrintReport_BT.Enabled = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือมีข้อผิดพลาดเกี่ยวกับฐานข้อมูล กรุณาลองใหม่อีกครั้ง", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintReport_BT_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (Bill_Show.Count <= 35)
            {
                Image logo = Image.FromFile(Program.ImageLogoLocationForPos);
                e.Graphics.DrawImage(logo, new PointF(50, 50)); //แสดง logo ร้าน
                e.Graphics.DrawString("เมื่อวันที่ " + System.DateTime.Now.ToString("dd / MM / yyyy เวลา HH:mm"), new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(550, 60));
                e.Graphics.DrawString("รายงานผลการขาย", new Font("RSU", 24, FontStyle.Bold), Brushes.Black, new PointF(200, 60));
                e.Graphics.DrawString("ร้าน " + Program.NameshopForPos + "   รหัสสาขา " + Program.IDshopForPos, new Font("RSU", 18, FontStyle.Bold), Brushes.Black, new PointF(200, 100));
                e.Graphics.DrawString("หมายเลขประจำตัวผู้เสียภาษี  " + Program.IDtexForPos + "   โทร." + Program.TelForPos, new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(200, 140));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 175));
                e.Graphics.DrawString("เลขที่ใบเสร็จฯ", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 200));
                e.Graphics.DrawString("ผู้ขาย", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(210, 200));
                e.Graphics.DrawString("ลูกค้า", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(300, 200));
                e.Graphics.DrawString("จำนวน", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(430, 200));
                e.Graphics.DrawString("ราคา", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(520, 200));
                e.Graphics.DrawString("ส่วนลด", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 200));
                e.Graphics.DrawString("ราคาทั้งสิ้น", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(680, 200));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 220));
                int yPos = 240;
                foreach (var i in Bill_Show)
                {
                    e.Graphics.DrawString(i.เลขที่ใบเสร็จ, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(50, yPos));
                    if (i.ผู้ขาย.Length >= 10)
                    {
                        e.Graphics.DrawString(i.ผู้ขาย.Substring(0, 9), new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(210, yPos));
                    }
                    else
                    {
                        e.Graphics.DrawString(i.ผู้ขาย, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(210, yPos));
                    }
                    if (i.ลูกค้า.Length >= 15)
                    {
                        e.Graphics.DrawString(i.ลูกค้า.Substring(0, 14), new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(300, yPos));
                    }
                    else
                    {
                        e.Graphics.DrawString(i.ลูกค้า, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(300, yPos));
                    }
                    e.Graphics.DrawString(i.จำนวน, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(430, yPos));
                    e.Graphics.DrawString(i.ราคา, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(520, yPos));
                    e.Graphics.DrawString(i.ส่วนลด, new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(600, yPos));
                    e.Graphics.DrawString(i.รวมทั้งสิ้น.ToString(), new Font("RSU", 12, FontStyle.Regular), Brushes.Black, new PointF(680, yPos));
                    yPos = yPos + 20;
                }
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, yPos));
                yPos = yPos + 20;
                e.Graphics.DrawString("รวมทั้งหมด :  " + String.Format("{0:F2}", SumTotal), new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(520, yPos));
                yPos = yPos + 20;
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, yPos));
                e.Graphics.DrawString("ลงชื่อ..............................", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 1060)); //จุดลงชื่อ
                e.Graphics.DrawString("     (        ผู้พิมพ์       )", new Font("RSU", 14, FontStyle.Bold), Brushes.Black, new PointF(50, 1090));
            }
            else
            {
                MessageBox.Show("ระบบนี้รองรับการพิมพ์รายการใบเสร็จ สูงสุด 35 ใบ เท่านั้น !!!", "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
