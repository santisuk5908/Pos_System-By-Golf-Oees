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
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {
            statusUser.Text = Program.status_login;
            MyIP.Text = Program.My_ip;
            Show_host.Text = Program.ip;
            Show_name.Text = Program.name_login;
        }


        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_productBT_Click(object sender, EventArgs e)
        {
            Add_Product f_open = new Add_Product();
            f_open.ShowDialog();
        }

        private void Show_Product_Click(object sender, EventArgs e)
        {
            Show_Product f_open = new Show_Product();
            f_open.ShowDialog();
        }

        private void Formsetting_shop_Click(object sender, EventArgs e)
        {
            Setting_shop f_open = new Setting_shop();
            f_open.ShowDialog();
        }

        private void Form_Edit_MyUser_Click(object sender, EventArgs e)
        {
            Edit_MyUser f_open = new Edit_MyUser();
            f_open.ShowDialog();
        }

        private void formEdit_product_Click(object sender, EventArgs e)
        {
            Edit_Product f_open = new Edit_Product();
            f_open.ShowDialog();
        }

        private void formdelete_product_Click(object sender, EventArgs e)
        {
            Delete_Product f_open = new Delete_Product();
            f_open.ShowDialog();
        }

        private void formSetting_Userlogin_Click(object sender, EventArgs e)
        {
            Setting_Userlogin f_open = new Setting_Userlogin();
            f_open.ShowDialog();
        }

        private void formbarcode_print_Click(object sender, EventArgs e)
        {
            Barcode_Print f_open = new Barcode_Print();
            f_open.ShowDialog();
        }

        private void formPos_system_Click(object sender, EventArgs e)
        {
            Pos_System f_open = new Pos_System();
            f_open.ShowDialog();
        }

        private void ChatGroup_Click(object sender, EventArgs e)
        {
            Chat_group f_open = new Chat_group();
            f_open.ShowDialog();
        }

        private void ReportSell_BT_Click(object sender, EventArgs e)
        {
            ReportForManager openform = new ReportForManager();
            openform.ShowDialog();

            
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("หากมีข้อสงสัย ติดต่อสอบถามได้ที่\n แอดมินหรือผู้จัดการได้เลย", "Help");
        }
    }
}
