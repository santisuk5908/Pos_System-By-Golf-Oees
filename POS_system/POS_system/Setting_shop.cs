using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class Setting_shop : Form
    {
        
        public Setting_shop()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importPic_Click(object sender, EventArgs e) //import ภาพ
        {
            string imglocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png";
            dialog.Multiselect = false;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                ExsamplePic.Image = Image.FromFile(dialog.FileName);
                imgMap.Text = dialog.FileName;
            }
        }

        private void Setting_shop_Load(object sender, EventArgs e) //โหลดข้อมูลลง textbox
        {
            try
            {
                string IDtexDB = "";
                string nameshopDB = "";
                string addressDB = "";
                string telDB = "";
                string logoDB = "";
                MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM shop_info", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Program.IDshopDB = reader.GetString("IDshop_info");
                    IDtexDB = reader.GetString("IDtex_info");
                    nameshopDB = reader.GetString("nameshop_info");
                    addressDB = reader.GetString("address_info");
                    telDB = reader.GetString("tel_info");
                    logoDB = reader.GetString("logo_info");
                }
                con.Close();
                IDshop.Text = string.Format(Program.IDshopDB);
                IDtex.Text = string.Format(IDtexDB);
                nameshop.Text = string.Format(nameshopDB);
                address.Text = string.Format(addressDB);
                tel.Text = string.Format(telDB);
                imgMap.Text = string.Format(logoDB);
                //ดึงภาrออกมา
                ExsamplePic.Image = Image.FromFile(logoDB);
            }
            catch (Exception)
            {
                MessageBox.Show("เกิดของผิดพลาดในการโลหดข้อมูล", "การแจ้งเตือน");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if ((IDshop.Text).Length > 10 || (IDtex.Text).Length > 20)
            {
                MessageBox.Show("!! บันทึกข้อมูลไม่สำเร็จ !!\nเนื่องจากคุณกรอกรหัสสาขา หรือหมายเลขประจำตัวผู้เสียภาษี เกินกำหนด", "การแจ้งเตือน");
            }
            else if (IDshop.Text == "" || IDtex.Text == "" || nameshop.Text == "" || address.Text == "" || tel.Text == "")
            {
                MessageBox.Show("!! บันทึกข้อมูลไม่สำเร็จ !!\nเนื่องจากคุณกรอกข้อมูลไม่ครบถ้วน", "การแจ้งเตือน");
            }
            else
            {
                string imgOld = imgMap.Text; // เพิ่ม \ ให้เป็น \\
                string imgNew = "";
                string stringcheck = "";
                string Backslash = "\\";
                int i = 0;
                while (i < imgOld.Length)
                {
                    if (imgOld.Substring(i, 1) == Backslash)
                    {
                        imgNew = string.Format(imgNew + Backslash + imgOld.Substring(i, 1));
                    }
                    else
                    {
                        imgNew = string.Format(imgNew + imgOld.Substring(i, 1));
                    }
                    i = i + 1;
                }
                try
                {
                    //เชื่อมต่อข้อมูล
                    MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
                    con.Open();
                    //ลบอันเก่าออก
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM shop_info WHERE IDshop_info = '" + Program.IDshopDB + "'", con);
                    cmd.ExecuteReader();
                    con.Close();
                    //อัพเดทข้อมูล
                    con.Open();
                    MySqlCommand cmd2 = new MySqlCommand("INSERT INTO shop_info (IDshop_info, IDtex_info, nameshop_info, address_info, tel_info, logo_info) VALUES ('" + IDshop.Text + "', '" + IDtex.Text + "', '" + nameshop.Text + "', '" + address.Text + "', '" + tel.Text + "', '" + imgNew + "')", con);
                    cmd2.ExecuteReader();
                    MessageBox.Show("บันทึกข้อมูลสำเร็จ", "ทำรายการสำเร็จ");
                    con.Close();
                    Program.IDshopForPos = IDshop.Text;
                    Program.NameshopForPos = nameshop.Text;
                    Program.IDtexForPos = IDtex.Text;
                    Program.AddressForPos = address.Text;
                    Program.TelForPos = tel.Text;
                    Program.ImageLogoLocationForPos = imgNew;
                }
                catch (Exception)
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "การแจ้งเตือน");
                }
            }
        }
    }
}
