namespace POS_system
{
    partial class Add_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Product));
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.barcodeProduct = new System.Windows.Forms.TextBox();
            this.typeProduct = new System.Windows.Forms.ComboBox();
            this.priceProduct = new System.Windows.Forms.NumericUpDown();
            this.manyProduct = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordforget = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Generate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.countProduct = new System.Windows.Forms.ComboBox();
            this.dataProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.priceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manyProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // nameProduct
            // 
            this.nameProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.nameProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameProduct.Location = new System.Drawing.Point(234, 71);
            this.nameProduct.Margin = new System.Windows.Forms.Padding(2);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(267, 31);
            this.nameProduct.TabIndex = 3;
            // 
            // barcodeProduct
            // 
            this.barcodeProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.barcodeProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.barcodeProduct.Location = new System.Drawing.Point(146, 287);
            this.barcodeProduct.Margin = new System.Windows.Forms.Padding(2);
            this.barcodeProduct.Name = "barcodeProduct";
            this.barcodeProduct.Size = new System.Drawing.Size(207, 31);
            this.barcodeProduct.TabIndex = 4;
            this.barcodeProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // typeProduct
            // 
            this.typeProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.typeProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.typeProduct.FormattingEnabled = true;
            this.typeProduct.Location = new System.Drawing.Point(146, 242);
            this.typeProduct.Name = "typeProduct";
            this.typeProduct.Size = new System.Drawing.Size(314, 32);
            this.typeProduct.TabIndex = 6;
            this.typeProduct.Text = "กรุณาเลือกประเภท";
            // 
            // priceProduct
            // 
            this.priceProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.priceProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.priceProduct.Location = new System.Drawing.Point(267, 158);
            this.priceProduct.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Size = new System.Drawing.Size(134, 31);
            this.priceProduct.TabIndex = 7;
            this.priceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // manyProduct
            // 
            this.manyProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.manyProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manyProduct.Location = new System.Drawing.Point(267, 119);
            this.manyProduct.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.manyProduct.Name = "manyProduct";
            this.manyProduct.Size = new System.Drawing.Size(135, 31);
            this.manyProduct.TabIndex = 8;
            this.manyProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(161, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "ชื่อสินค้า";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(160, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "จำนวนสินค้า";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(161, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "ราคา / หน่วย";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(39, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "ประเภทสินค้า";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(39, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "บาร์โค้ดสินค้า";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passwordforget
            // 
            this.passwordforget.AutoSize = true;
            this.passwordforget.BackColor = System.Drawing.Color.LightSkyBlue;
            this.passwordforget.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.passwordforget.Font = new System.Drawing.Font("RSU", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordforget.ForeColor = System.Drawing.Color.DarkBlue;
            this.passwordforget.Location = new System.Drawing.Point(400, 101);
            this.passwordforget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordforget.Name = "passwordforget";
            this.passwordforget.Size = new System.Drawing.Size(102, 21);
            this.passwordforget.TabIndex = 50;
            this.passwordforget.Text = "ไม่เกิน 50 ตัวอักษร";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("RSU", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(144, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "ตัวเลขไม่น้อยกว่า 5 และไม่เกิน 13 ตัวอักษร";
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Image = global::POS_system.Properties.Resources.icon_menu_clean3;
            this.reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset.Location = new System.Drawing.Point(8, 545);
            this.reset.Margin = new System.Windows.Forms.Padding(2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 35);
            this.reset.TabIndex = 56;
            this.reset.Text = "ล้างกล่องข้อมูล";
            this.reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = global::POS_system.Properties.Resources.icon_menu_save;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(245, 545);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(124, 35);
            this.save.TabIndex = 55;
            this.save.Text = "Save / บันทึก";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = global::POS_system.Properties.Resources.icon_menu_exit;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(375, 545);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(149, 35);
            this.exit.TabIndex = 54;
            this.exit.Text = "Exit / ปิดหน้าต่าง";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox5.Location = new System.Drawing.Point(1, 539);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(530, 47);
            this.pictureBox5.TabIndex = 52;
            this.pictureBox5.TabStop = false;
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Generate.Image = global::POS_system.Properties.Resources.icon_menu_genalate_bar;
            this.Generate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Generate.Location = new System.Drawing.Point(360, 284);
            this.Generate.Margin = new System.Windows.Forms.Padding(2);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(100, 35);
            this.Generate.TabIndex = 49;
            this.Generate.Text = "Generate";
            this.Generate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox2.Image = global::POS_system.Properties.Resources.trolley;
            this.pictureBox2.Location = new System.Drawing.Point(39, 71);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::POS_system.Properties.Resources.add_product_menubar;
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Location = new System.Drawing.Point(1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(530, 47);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox4.Location = new System.Drawing.Point(10, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(509, 470);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(39, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "หน่วยนับ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // countProduct
            // 
            this.countProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.countProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.countProduct.FormattingEnabled = true;
            this.countProduct.Items.AddRange(new object[] {
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
            this.countProduct.Location = new System.Drawing.Point(116, 198);
            this.countProduct.Name = "countProduct";
            this.countProduct.Size = new System.Drawing.Size(344, 32);
            this.countProduct.TabIndex = 58;
            this.countProduct.Text = "กรุณาเลือกหน่วยนับ";
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Location = new System.Drawing.Point(32, 347);
            this.dataProduct.MultiSelect = false;
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.ReadOnly = true;
            this.dataProduct.Size = new System.Drawing.Size(462, 168);
            this.dataProduct.TabIndex = 59;
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 586);
            this.Controls.Add(this.dataProduct);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.countProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.save);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordforget);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.manyProduct);
            this.Controls.Add(this.priceProduct);
            this.Controls.Add(this.typeProduct);
            this.Controls.Add(this.barcodeProduct);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product / เพิ่มรายการสินค้า";
            this.Load += new System.EventHandler(this.Add_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.priceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manyProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.TextBox barcodeProduct;
        private System.Windows.Forms.ComboBox typeProduct;
        private System.Windows.Forms.NumericUpDown priceProduct;
        private System.Windows.Forms.NumericUpDown manyProduct;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label passwordforget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox countProduct;
        private System.Windows.Forms.DataGridView dataProduct;
    }
}