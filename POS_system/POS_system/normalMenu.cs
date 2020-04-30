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
    public partial class normalMenu : Form
    {
        public normalMenu()
        {
            InitializeComponent();
        }

        private void normalMenu_Load(object sender, EventArgs e)
        {
            MyIP.Text = Program.My_ip;
            Show_name.Text = Program.name_login;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Pos_BT_Click(object sender, EventArgs e)
        {
            Pos_System f_open = new Pos_System();
            f_open.ShowDialog();
        }

        private void Add_Product_BT_Click(object sender, EventArgs e)
        {
            Add_Product f_open = new Add_Product();
            f_open.ShowDialog();
        }

        private void Delete_Product_BT_Click(object sender, EventArgs e)
        {
            Delete_Product f_open = new Delete_Product();
            f_open.ShowDialog();
        }

        private void Edit_Product_BT_Click(object sender, EventArgs e)
        {
            Edit_Product f_open = new Edit_Product();
            f_open.ShowDialog();
        }

        private void Show_Product_bt_Click(object sender, EventArgs e)
        {
            Show_Product f_open = new Show_Product();
            f_open.ShowDialog();
        }

        private void Edit_User_Bt_Click(object sender, EventArgs e)
        {
            Edit_MyUser f_open = new Edit_MyUser();
            f_open.ShowDialog();
        }

        private void Print_Barcode_BT_Click(object sender, EventArgs e)
        {
            Barcode_Print f_open = new Barcode_Print();
            f_open.ShowDialog();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("หากมีข้อสงสัย ติดต่อสอบถามได้ที่\n แอดมินหรือผู้จัดการได้เลย", "Help");
        }

        private void Chat_BT_Click(object sender, EventArgs e)
        {
            Chat_group f_open = new Chat_group();
            f_open.ShowDialog();
        }
    }
}
