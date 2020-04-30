namespace POS_system
{
    partial class Delete_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Product));
            this.barcodeProductEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.countProductEdit = new System.Windows.Forms.ComboBox();
            this.priceProductEdit = new System.Windows.Forms.NumericUpDown();
            this.manyProductEdit = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameProductEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.typeProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.SearchBT = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceProductEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manyProductEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // barcodeProductEdit
            // 
            this.barcodeProductEdit.Enabled = false;
            this.barcodeProductEdit.Font = new System.Drawing.Font("RSU", 12F);
            this.barcodeProductEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.barcodeProductEdit.Location = new System.Drawing.Point(591, 434);
            this.barcodeProductEdit.Margin = new System.Windows.Forms.Padding(2);
            this.barcodeProductEdit.Name = "barcodeProductEdit";
            this.barcodeProductEdit.Size = new System.Drawing.Size(204, 31);
            this.barcodeProductEdit.TabIndex = 119;
            this.barcodeProductEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Pink;
            this.label8.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 29);
            this.label8.TabIndex = 118;
            this.label8.Text = "Barcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Pink;
            this.label7.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(510, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 29);
            this.label7.TabIndex = 117;
            this.label7.Text = "หน่วยนับ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Pink;
            this.label6.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 29);
            this.label6.TabIndex = 116;
            this.label6.Text = "ราคา";
            // 
            // countProductEdit
            // 
            this.countProductEdit.Enabled = false;
            this.countProductEdit.Font = new System.Drawing.Font("RSU", 12F);
            this.countProductEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.countProductEdit.FormattingEnabled = true;
            this.countProductEdit.Items.AddRange(new object[] {
            "ชิ้น",
            "อัน",
            "คู่",
            "กล่อง",
            "เครื่อง",
            "คิว",
            "เมตร",
            "ต้น",
            "แผ่น",
            "ชุด",
            "ตัน",
            "เส้น",
            "ตัว"});
            this.countProductEdit.Location = new System.Drawing.Point(591, 391);
            this.countProductEdit.Name = "countProductEdit";
            this.countProductEdit.Size = new System.Drawing.Size(204, 32);
            this.countProductEdit.TabIndex = 115;
            this.countProductEdit.Text = "กรุณาเลือกหน่วยนับ";
            // 
            // priceProductEdit
            // 
            this.priceProductEdit.Enabled = false;
            this.priceProductEdit.Font = new System.Drawing.Font("RSU", 12F);
            this.priceProductEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceProductEdit.Location = new System.Drawing.Point(591, 347);
            this.priceProductEdit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.priceProductEdit.Name = "priceProductEdit";
            this.priceProductEdit.Size = new System.Drawing.Size(134, 31);
            this.priceProductEdit.TabIndex = 114;
            this.priceProductEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // manyProductEdit
            // 
            this.manyProductEdit.Enabled = false;
            this.manyProductEdit.Font = new System.Drawing.Font("RSU", 12F);
            this.manyProductEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manyProductEdit.Location = new System.Drawing.Point(591, 304);
            this.manyProductEdit.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.manyProductEdit.Name = "manyProductEdit";
            this.manyProductEdit.Size = new System.Drawing.Size(135, 31);
            this.manyProductEdit.TabIndex = 113;
            this.manyProductEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Pink;
            this.label5.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 29);
            this.label5.TabIndex = 112;
            this.label5.Text = "จำนวน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Pink;
            this.label4.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 111;
            this.label4.Text = "ชื่อสินค้า";
            // 
            // nameProductEdit
            // 
            this.nameProductEdit.Enabled = false;
            this.nameProductEdit.Font = new System.Drawing.Font("RSU", 12F);
            this.nameProductEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameProductEdit.Location = new System.Drawing.Point(591, 259);
            this.nameProductEdit.Margin = new System.Windows.Forms.Padding(2);
            this.nameProductEdit.Name = "nameProductEdit";
            this.nameProductEdit.Size = new System.Drawing.Size(204, 31);
            this.nameProductEdit.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 29);
            this.label3.TabIndex = 109;
            this.label3.Text = "เลือกรายการที่ต้องการลบ";
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Location = new System.Drawing.Point(30, 252);
            this.dataProduct.MultiSelect = false;
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.ReadOnly = true;
            this.dataProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProduct.Size = new System.Drawing.Size(436, 273);
            this.dataProduct.TabIndex = 108;
            this.dataProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduct_CellContentClick);
            // 
            // typeProduct
            // 
            this.typeProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.typeProduct.FormattingEnabled = true;
            this.typeProduct.Location = new System.Drawing.Point(303, 76);
            this.typeProduct.Name = "typeProduct";
            this.typeProduct.Size = new System.Drawing.Size(163, 32);
            this.typeProduct.TabIndex = 104;
            this.typeProduct.Text = "กรุณาเลือกประเภท";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Pink;
            this.label2.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 106;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Pink;
            this.label1.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 105;
            this.label1.Text = "ประเภทสินค้า";
            // 
            // nameProduct
            // 
            this.nameProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameProduct.Location = new System.Drawing.Point(262, 116);
            this.nameProduct.Margin = new System.Windows.Forms.Padding(2);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(204, 31);
            this.nameProduct.TabIndex = 102;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Crimson;
            this.pictureBox7.Location = new System.Drawing.Point(485, 76);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 455);
            this.pictureBox7.TabIndex = 122;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Pink;
            this.pictureBox6.Image = global::POS_system.Properties.Resources.delete2;
            this.pictureBox6.Location = new System.Drawing.Point(582, 76);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(160, 152);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 121;
            this.pictureBox6.TabStop = false;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Image = global::POS_system.Properties.Resources.icon_menu_clean3;
            this.reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset.Location = new System.Drawing.Point(184, 162);
            this.reset.Margin = new System.Windows.Forms.Padding(2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 35);
            this.reset.TabIndex = 107;
            this.reset.Text = "ล้างกล่องข้อมูล";
            this.reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // SearchBT
            // 
            this.SearchBT.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBT.Image = global::POS_system.Properties.Resources.icon_menu_search;
            this.SearchBT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBT.Location = new System.Drawing.Point(331, 162);
            this.SearchBT.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(135, 35);
            this.SearchBT.TabIndex = 103;
            this.SearchBT.Text = "Search / ค้นหา";
            this.SearchBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = global::POS_system.Properties.Resources.icon_menu_bin;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(561, 487);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(194, 35);
            this.save.TabIndex = 101;
            this.save.Text = "Delete / ลบรายการที่เลือก";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Pink;
            this.pictureBox5.Image = global::POS_system.Properties.Resources.delete;
            this.pictureBox5.Location = new System.Drawing.Point(35, 77);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(131, 129);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 100;
            this.pictureBox5.TabStop = false;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = global::POS_system.Properties.Resources.icon_menu_exit;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(679, 555);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(149, 35);
            this.exit.TabIndex = 98;
            this.exit.Text = "Exit / ปิดหน้าต่าง";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox2.Location = new System.Drawing.Point(0, 549);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(836, 47);
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::POS_system.Properties.Resources.Delete_product_menubar;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(836, 47);
            this.pictureBox3.TabIndex = 95;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Pink;
            this.pictureBox4.Location = new System.Drawing.Point(15, 56);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(809, 486);
            this.pictureBox4.TabIndex = 99;
            this.pictureBox4.TabStop = false;
            // 
            // Delete_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 596);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.barcodeProductEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.countProductEdit);
            this.Controls.Add(this.priceProductEdit);
            this.Controls.Add(this.manyProductEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameProductEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataProduct);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.SearchBT);
            this.Controls.Add(this.typeProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Delete_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Product / ลบรายการสินค้า";
            this.Load += new System.EventHandler(this.Delete_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceProductEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manyProductEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox barcodeProductEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox countProductEdit;
        private System.Windows.Forms.NumericUpDown priceProductEdit;
        private System.Windows.Forms.NumericUpDown manyProductEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameProductEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.ComboBox typeProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}