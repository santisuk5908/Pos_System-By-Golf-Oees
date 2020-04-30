namespace POS_system
{
    partial class Chat_group
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat_group));
            this.name_Send = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Send_Text = new System.Windows.Forms.TextBox();
            this.Chat_data = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.name_Receive = new System.Windows.Forms.ComboBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.switch_bt = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Send_BT = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.passwordforget = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chat_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // name_Send
            // 
            this.name_Send.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.name_Send.ForeColor = System.Drawing.SystemColors.ControlText;
            this.name_Send.Location = new System.Drawing.Point(138, 73);
            this.name_Send.Margin = new System.Windows.Forms.Padding(2);
            this.name_Send.Name = "name_Send";
            this.name_Send.Size = new System.Drawing.Size(243, 31);
            this.name_Send.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(71, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 76;
            this.label1.Text = "ชื่อผู้ส่ง";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(71, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 78;
            this.label2.Text = "ชื่อผู้รับ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(37, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 79;
            this.label3.Text = "ข้อความที่ส่ง";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Send_Text
            // 
            this.Send_Text.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Send_Text.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Send_Text.Location = new System.Drawing.Point(138, 404);
            this.Send_Text.Margin = new System.Windows.Forms.Padding(2);
            this.Send_Text.Multiline = true;
            this.Send_Text.Name = "Send_Text";
            this.Send_Text.Size = new System.Drawing.Size(243, 102);
            this.Send_Text.TabIndex = 80;
            // 
            // Chat_data
            // 
            this.Chat_data.AllowUserToAddRows = false;
            this.Chat_data.AllowUserToDeleteRows = false;
            this.Chat_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Chat_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Chat_data.Location = new System.Drawing.Point(27, 142);
            this.Chat_data.MultiSelect = false;
            this.Chat_data.Name = "Chat_data";
            this.Chat_data.ReadOnly = true;
            this.Chat_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Chat_data.Size = new System.Drawing.Size(444, 207);
            this.Chat_data.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(34, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 29);
            this.label4.TabIndex = 82;
            this.label4.Text = "แชทข้อความ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // name_Receive
            // 
            this.name_Receive.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.name_Receive.FormattingEnabled = true;
            this.name_Receive.Location = new System.Drawing.Point(138, 365);
            this.name_Receive.Name = "name_Receive";
            this.name_Receive.Size = new System.Drawing.Size(191, 32);
            this.name_Receive.TabIndex = 84;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox8.Image = global::POS_system.Properties.Resources.plane;
            this.pictureBox8.Location = new System.Drawing.Point(399, 384);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(61, 60);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 93;
            this.pictureBox8.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.logo.Image = global::POS_system.Properties.Resources.sender;
            this.logo.Location = new System.Drawing.Point(399, 64);
            this.logo.Margin = new System.Windows.Forms.Padding(2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(70, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 92;
            this.logo.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox7.Image = global::POS_system.Properties.Resources.speak;
            this.pictureBox7.Location = new System.Drawing.Point(55, 445);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(61, 60);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 91;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox6.Image = global::POS_system.Properties.Resources.sender;
            this.pictureBox6.Location = new System.Drawing.Point(32, 68);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 90;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox3.Image = global::POS_system.Properties.Resources.receiver;
            this.pictureBox3.Location = new System.Drawing.Point(32, 359);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // switch_bt
            // 
            this.switch_bt.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switch_bt.Image = global::POS_system.Properties.Resources.switch_off;
            this.switch_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.switch_bt.Location = new System.Drawing.Point(9, 547);
            this.switch_bt.Margin = new System.Windows.Forms.Padding(2);
            this.switch_bt.Name = "switch_bt";
            this.switch_bt.Size = new System.Drawing.Size(157, 35);
            this.switch_bt.TabIndex = 88;
            this.switch_bt.Text = "ปิดการรับข้อความ";
            this.switch_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.switch_bt.UseVisualStyleBackColor = true;
            this.switch_bt.Click += new System.EventHandler(this.switch_bt_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Image = global::POS_system.Properties.Resources.Send_Message_menubar;
            this.pictureBox2.Location = new System.Drawing.Point(8, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 87;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 47);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // Send_BT
            // 
            this.Send_BT.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_BT.Image = global::POS_system.Properties.Resources.icon_menu_chat11;
            this.Send_BT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Send_BT.Location = new System.Drawing.Point(388, 470);
            this.Send_BT.Margin = new System.Windows.Forms.Padding(2);
            this.Send_BT.Name = "Send_BT";
            this.Send_BT.Size = new System.Drawing.Size(83, 35);
            this.Send_BT.TabIndex = 74;
            this.Send_BT.Text = "Send ";
            this.Send_BT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Send_BT.UseVisualStyleBackColor = true;
            this.Send_BT.Click += new System.EventHandler(this.Send_BT_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox4.Location = new System.Drawing.Point(10, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(482, 476);
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = global::POS_system.Properties.Resources.icon_menu_exit;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(347, 547);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(149, 35);
            this.exit.TabIndex = 68;
            this.exit.Text = "Exit / ปิดหน้าต่าง";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox5.Location = new System.Drawing.Point(1, 540);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(503, 47);
            this.pictureBox5.TabIndex = 67;
            this.pictureBox5.TabStop = false;
            // 
            // passwordforget
            // 
            this.passwordforget.AutoSize = true;
            this.passwordforget.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordforget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwordforget.Font = new System.Drawing.Font("RSU", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordforget.ForeColor = System.Drawing.Color.DarkBlue;
            this.passwordforget.Location = new System.Drawing.Point(199, 508);
            this.passwordforget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordforget.Name = "passwordforget";
            this.passwordforget.Size = new System.Drawing.Size(178, 21);
            this.passwordforget.TabIndex = 94;
            this.passwordforget.Text = "คำสั่งพิเศษ สำหรับจัดการข้อความ";
            this.passwordforget.Click += new System.EventHandler(this.passwordforget_Click);
            // 
            // Chat_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 587);
            this.Controls.Add(this.passwordforget);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.switch_bt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.name_Receive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Chat_data);
            this.Controls.Add(this.Send_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name_Send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Send_BT);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chat_group";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat Group / แชทภายในร้าน";
            this.Load += new System.EventHandler(this.Chat_group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chat_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button Send_BT;
        private System.Windows.Forms.TextBox name_Send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Send_Text;
        private System.Windows.Forms.DataGridView Chat_data;
        private System.Windows.Forms.Label label4;
        private System.Timers.Timer timer1;
        private System.Windows.Forms.ComboBox name_Receive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button switch_bt;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label passwordforget;
    }
}