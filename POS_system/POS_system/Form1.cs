using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            inputuser.Text = string.Format("");
            inputpassword.Text = string.Format("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputuser.Text == "" || inputpassword.Text == "") //เมื่อมีช่องชื่อผู้ใช้ หรือรหัสผ่านว่างไว้
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "การแจ้งเตือน");
                }
                else
                {
                    string sql = "SELECT * FROM login WHERE user_login = '" + inputuser.Text + "' AND password_login = '" + inputpassword.Text + "'";
                    MySqlConnection con = new MySqlConnection("host=" + Program.ip + ";user=pos_admin;password=123456;database=pos_db");
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    bool check = false; //เช็คว่ารหัสถูกต้องหรือไม่
                    while (reader.Read())
                    {
                        Program.id_login = reader.GetString("id_login"); //ดึงข้อมูลจากแอททริบิวต์ id_login
                        Program.status_login = reader.GetString("status_login"); //ดึงข้อมูลจากแอททริบิวต์ status_login
                        Program.name_login = reader.GetString("name_login"); //ดึงข้อมูลจากแอททริบิวต์ name_login
                        Program.globalSQLConnect = "host=" + Program.ip + ";user=pos_admin;password=123456;database=pos_db";
                        check = true;
                    }
                    if (check == true) //เมื่อรหัสผ่านถูกต้อง
                    {
                        if (Program.status_login == "Admin" || Program.status_login == "Manager") //เมื่อสถานะเป็นผู้ดูแลระบบ หรือผู้จัดการร้าน
                        {
                            adminMenu adMenu = new adminMenu();
                            //this.Hide();
                            con.Close();
                            MessageBox.Show("ยินดีต้อนรับ : " + Program.name_login, "ยินดีต้อนรับ");
                            inputpassword.Text = "";
                            Loadshop_info();
                            adMenu.ShowDialog();
                        }
                        else //ถ้าไม่ใช่ ให้เปิดเมนูปกติ
                        {
                            normalMenu normalMenu = new normalMenu();
                            con.Close();
                            MessageBox.Show("ยินดีต้อนรับ : " + Program.name_login, "ยินดีต้อนรับ");
                            inputpassword.Text = "";
                            Loadshop_info();
                            normalMenu.ShowDialog();
                        }
                    }
                    else //เมื่อรหัสผ่านไม่ถูกต้อง
                    {
                        MessageBox.Show("ชื่อผู้ใช้ และรหัสผ่านไม่ถูกต้อง", "การแจ้งเตือน");
                        con.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
            }
        }

        private void label3_Click(object sender, EventArgs e) //ลืมรหัสผ่าน
        {
            MessageBox.Show("กรุณาติดต่อผู้จัดการร้าน หรือแอดมินเพื่อแก้ไขข้อมูล", "การแจ้งเตือน");
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {
            //หา IP เครื่องตัวเอง
            IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in localIP)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    Program.My_ip = address.ToString();
                    Program.ip = address.ToString();
                    localhost.Text = Program.My_ip;
                }
            }
            //เชื่อมต่อกับ database
            string nameSQLconnect = "host=" + Program.My_ip + ";user=pos_admin;password=123456;database=pos_db";
            MySqlConnection con = new MySqlConnection(nameSQLconnect);
            try
            {
                con.Open();
                status.Text = "True";
                status.ForeColor = System.Drawing.Color.Green;
                con.Close();
                login.Enabled = true;
            }
            catch (Exception ex)
            {
                status.Text = "False";
                status.ForeColor = System.Drawing.Color.Red;
                login.Enabled = false;
            }
      
        }

        private void submitlocalhost_Click(object sender, EventArgs e)
        {
            Program.ip = localhost.Text; //รับค่าจากกล่อง host
            string nameSQLconnect = "host=" + Program.ip + ";user=pos_admin;password=123456;database=pos_db";
            MySqlConnection con = new MySqlConnection(nameSQLconnect);
            try
            {
                con.Open();
                status.Text = "True";
                status.ForeColor = System.Drawing.Color.Green;
                con.Close();
                login.Enabled = true;
                MessageBox.Show("** เชื่อมต่อกับฐานข้อมูลสำเร็จ **", "การแจ้งเตือน");
            }
            catch (Exception ex)
            {
                status.Text = "False";
                status.ForeColor = System.Drawing.Color.Red;
                login.Enabled = false;
                MessageBox.Show("!! เชื่อมต่อกับฐานข้อมูลไมได้ !!", "การแจ้งเตือน");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Loadshop_info()
        {
            MySqlConnection con = new MySqlConnection("host=" + Program.ip + ";user=pos_admin;password=123456;database=pos_db");
            try
            {
                con.Open(); //ดึงข้อมูลร้าน
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM shop_info", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Program.IDshopForPos = reader.GetString("IDshop_info"); //ดึงข้อมูลจากแอททริบิวต์ IDshop_info
                    Program.NameshopForPos = reader.GetString("nameshop_info"); //ดึงข้อมูลจากแอททริบิวต์ nameshop_info
                    Program.IDtexForPos = reader.GetString("IDtex_info"); //ดึงข้อมูลจากแอททริบิวต์ IDtex_info
                    Program.AddressForPos = reader.GetString("address_info"); //ดึงข้อมูลจากแอททริบิวต์address_info
                    Program.TelForPos = reader.GetString("tel_info"); //ดึงข้อมูลจากแอททริบิวต์ tel_info
                    Program.ImageLogoLocation = reader.GetString("logo_info"); //ดึงข้อมูลจากแอททริบิวต์ logo_info
                }
                con.Close();
                string imgOld = Program.ImageLogoLocation;
                string imgNew = "";
                //string stringcheck = "";
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
                Program.ImageLogoLocationForPos = imgNew;
                //Console.WriteLine(Program.ImageLogoLocationForPos);
            }
            catch (Exception)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการโหลดข้อมูลร้าน", "การแจ้งเตือน");
            }
        }
    }
}
