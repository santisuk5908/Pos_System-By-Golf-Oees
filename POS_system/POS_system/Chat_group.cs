using MySql.Data.MySqlClient;
using POS_system.Properties;
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
    public partial class Chat_group : Form
    {
        bool switchText;
        public Chat_group()
        {
            InitializeComponent();
        }

        private void Chat_group_Load(object sender, EventArgs e)
        {
            name_Send.Text = Program.name_login;
            LoaddataNew();
            LoaddataName();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            switchText = false;
            logo.Image = Image.FromFile(Program.ImageLogoLocationForPos);
        }

        private void LoaddataNew()
        {
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //ดึงข้อมูล ชนิดของสินค้า ลง datagrid
            try //ดึงข้อมูล DB ลง datagridview
            {
                MySqlDataAdapter oda = new MySqlDataAdapter("SELECT sender AS " + "'ชื่อผู้ส่ง'" + ", receiver AS " + "'ชื่อผู้รับ'" + ", text AS " + "'ข้อความ'" + ", datetime AS " + "'วันที่ส่ง'"+" FROM chat_group", con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                Chat_data.DataSource = dt;
                Chat_data.CurrentCell = Chat_data.Rows[Chat_data.Rows.Count - 1].Cells[0];
            }
            catch (Exception)
            {
                timer1.Stop();
                MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล กรุณาเข้าใหม่ในภายหลัง", "เกิดข้อผิดพลาด");
                
            }
        }

        private void LoaddataName()
        {
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect); //ดึงข้อมูล ชนิดของสินค้า ลง combobox
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM login", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("name_login", typeof(string));
                dt.Load(reader);
                name_Receive.DataSource = dt;
                name_Receive.ValueMember = "name_login";
                name_Receive.Text = "กรุณาเลือกผู้รับ";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล", "เกิดข้อผิดพลาด");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            this.Close();
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            LoaddataNew();
        }


        private void Send_BT_Click(object sender, EventArgs e)
        {
            if (name_Receive.Text == "กรุณาเลือกผู้รับ" || name_Send.Text == "" || name_Receive.Text == "" || Send_Text.Text == "")
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง", "การแจ้งเตือน",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (Send_Text.Text == "#DELETE")
            {
                DeleteTextAll();
                LoaddataNew();
            }
            else
            {
                MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
                try //ทำการเชื่อมต่อข้อมูล และบันทึกลง DB
                {
                    con.Open();
                    string time = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO chat_group(sender, receiver, text, datetime) VALUES('" + name_Send.Text + "', '" + name_Receive.Text + "', '" + Send_Text.Text + "', '" + time + "')", con);
                    cmd.ExecuteReader();
                    con.Close();
                    Send_Text.Text = ""; //ล้างกล่องข้อความ
                    Send_Text.Focus();
                    LoaddataNew(); //โหลดใหม่                  
                }
                catch (Exception asd)
                {
                    MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับอักขระพิเศษที่ส่ง หรือเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง ", "เกิดข้อผิดพลาด");
                }
                
            }
            
        }

        private void switch_bt_Click(object sender, EventArgs e)
        {
            if (switchText == false)
            {
                switch_bt.Text = "เปิดการรับข้อความ";
                timer1.Stop();
                switch_bt.Image = Resources.switch_on;
                switchText = true;
            }
            else if (switchText == true)
            {
                switch_bt.Text = "ปิดการรับข้อความ";
                timer1.Start();
                switch_bt.Image = Resources.switch_off;
                switchText = false;
            }
        }

        private void passwordforget_Click(object sender, EventArgs e)
        {
            MessageBox.Show("พิมพ์ข้อความด้านล่างนี้ เพื่อลบข้อความแชททั้งหมดในฐานข้อมูล\n\n                                #DELETE", "คำสั่งพิเศษ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DeleteTextAll()
        {
            timer1.Stop();
            MySqlConnection con = new MySqlConnection(Program.globalSQLConnect);
            try //ทำการเชื่อมต่อข้อมูล และบันทึกลง DB
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM chat_group WHERE sender like '%%'", con);
                cmd.ExecuteReader();
                con.Close();
                con.Open();
                cmd = new MySqlCommand("INSERT INTO chat_group(sender, receiver, text, datetime) VALUES(' ', ' ', 'ลบข้อความเรียบร้อยแล้ว', ' ')", con);
                cmd.ExecuteReader();
                con.Close();
                Send_Text.Text = ""; //ล้างกล่องข้อความ
                Send_Text.Focus();
                timer1.Start();     
            }
            catch (Exception asd)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ถูกต้อง หรือเกิดข้อผิดพลาดเกี่ยวกับฐานข้อมูล \nกรุณาลองใหม่อีกครั้ง " + asd, "เกิดข้อผิดพลาด");
            }
        }
    }
}
