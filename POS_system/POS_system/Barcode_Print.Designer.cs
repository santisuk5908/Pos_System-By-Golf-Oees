namespace POS_system
{
    partial class Barcode_Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode_Print));
            this.label3 = new System.Windows.Forms.Label();
            this.typeProduct = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.barcodeProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.dataProduct = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ShowBarcode = new System.Windows.Forms.TextBox();
            this.ShowName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowText_Barcode = new System.Windows.Forms.Label();
            this.ShowPicture_Barcode = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Print_barcode = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.reset = new System.Windows.Forms.Button();
            this.SearchBT = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPicture_Barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 72;
            this.label3.Text = "Barcode";
            // 
            // typeProduct
            // 
            this.typeProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.typeProduct.FormattingEnabled = true;
            this.typeProduct.Location = new System.Drawing.Point(315, 73);
            this.typeProduct.Name = "typeProduct";
            this.typeProduct.Size = new System.Drawing.Size(183, 32);
            this.typeProduct.TabIndex = 69;
            this.typeProduct.Text = "กรุณาเลือกประเภท";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 71;
            this.label2.Text = "ชื่อสินค้า";
            // 
            // barcodeProduct
            // 
            this.barcodeProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.barcodeProduct.Location = new System.Drawing.Point(274, 151);
            this.barcodeProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.barcodeProduct.Name = "barcodeProduct";
            this.barcodeProduct.Size = new System.Drawing.Size(224, 31);
            this.barcodeProduct.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 70;
            this.label1.Text = "ประเภทสินค้า";
            // 
            // nameProduct
            // 
            this.nameProduct.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nameProduct.Location = new System.Drawing.Point(274, 113);
            this.nameProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(224, 31);
            this.nameProduct.TabIndex = 66;
            // 
            // dataProduct
            // 
            this.dataProduct.AllowUserToAddRows = false;
            this.dataProduct.AllowUserToDeleteRows = false;
            this.dataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProduct.Location = new System.Drawing.Point(30, 236);
            this.dataProduct.MultiSelect = false;
            this.dataProduct.Name = "dataProduct";
            this.dataProduct.ReadOnly = true;
            this.dataProduct.RowHeadersWidth = 51;
            this.dataProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataProduct.Size = new System.Drawing.Size(468, 155);
            this.dataProduct.TabIndex = 74;
            this.dataProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProduct_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 29);
            this.label4.TabIndex = 80;
            this.label4.Text = "Barcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label5.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 79;
            this.label5.Text = "ชื่อสินค้า";
            // 
            // ShowBarcode
            // 
            this.ShowBarcode.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBarcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowBarcode.Location = new System.Drawing.Point(99, 484);
            this.ShowBarcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowBarcode.Name = "ShowBarcode";
            this.ShowBarcode.Size = new System.Drawing.Size(169, 31);
            this.ShowBarcode.TabIndex = 78;
            this.ShowBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShowBarcode.TextChanged += new System.EventHandler(this.ShowBarcode_TextChanged);
            // 
            // ShowName
            // 
            this.ShowName.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowName.Location = new System.Drawing.Point(99, 434);
            this.ShowName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowName.Name = "ShowName";
            this.ShowName.Size = new System.Drawing.Size(169, 31);
            this.ShowName.TabIndex = 77;
            this.ShowName.TextChanged += new System.EventHandler(this.ShowName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.ShowText_Barcode);
            this.groupBox1.Controls.Add(this.ShowPicture_Barcode);
            this.groupBox1.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(287, 397);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 123);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ตัวอย่างภาพ";
            // 
            // ShowText_Barcode
            // 
            this.ShowText_Barcode.AutoSize = true;
            this.ShowText_Barcode.BackColor = System.Drawing.SystemColors.Window;
            this.ShowText_Barcode.Font = new System.Drawing.Font("RSU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowText_Barcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ShowText_Barcode.Location = new System.Drawing.Point(40, 92);
            this.ShowText_Barcode.Name = "ShowText_Barcode";
            this.ShowText_Barcode.Size = new System.Drawing.Size(105, 20);
            this.ShowText_Barcode.TabIndex = 82;
            this.ShowText_Barcode.Text = "     ( กำลังรอข้อมูล )";
            this.ShowText_Barcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowPicture_Barcode
            // 
            this.ShowPicture_Barcode.BackColor = System.Drawing.SystemColors.Window;
            this.ShowPicture_Barcode.Location = new System.Drawing.Point(6, 22);
            this.ShowPicture_Barcode.Name = "ShowPicture_Barcode";
            this.ShowPicture_Barcode.Size = new System.Drawing.Size(199, 95);
            this.ShowPicture_Barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ShowPicture_Barcode.TabIndex = 0;
            this.ShowPicture_Barcode.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label6.Font = new System.Drawing.Font("RSU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(138, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "พิมพ์แค่ 25 ตัวอักษรเท่านั้น";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("RSU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 29);
            this.label7.TabIndex = 85;
            this.label7.Text = "1 แผ่น มี 30 ตัว";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox7.Image = global::POS_system.Properties.Resources.print_paper;
            this.pictureBox7.Location = new System.Drawing.Point(366, 7);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(33, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 86;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pictureBox6.Location = new System.Drawing.Point(23, 406);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(258, 10);
            this.pictureBox6.TabIndex = 83;
            this.pictureBox6.TabStop = false;
            // 
            // Print_barcode
            // 
            this.Print_barcode.Enabled = false;
            this.Print_barcode.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_barcode.Image = global::POS_system.Properties.Resources.icon_menu_printbarcode;
            this.Print_barcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Print_barcode.Location = new System.Drawing.Point(9, 544);
            this.Print_barcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Print_barcode.Name = "Print_barcode";
            this.Print_barcode.Size = new System.Drawing.Size(217, 35);
            this.Print_barcode.TabIndex = 82;
            this.Print_barcode.Text = "Print Barcode / พิมพ์บาร์โค้ด";
            this.Print_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Print_barcode.UseVisualStyleBackColor = true;
            this.Print_barcode.Click += new System.EventHandler(this.Print_barcode_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Image = global::POS_system.Properties.Resources.icon_menu_exit;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(373, 544);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(149, 35);
            this.exit.TabIndex = 76;
            this.exit.Text = "Exit / ปิดหน้าต่าง";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox5.Location = new System.Drawing.Point(0, 538);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(530, 47);
            this.pictureBox5.TabIndex = 75;
            this.pictureBox5.TabStop = false;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("RSU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Image = global::POS_system.Properties.Resources.icon_menu_clean3;
            this.reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset.Location = new System.Drawing.Point(205, 191);
            this.reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(133, 35);
            this.reset.TabIndex = 73;
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
            this.SearchBT.Location = new System.Drawing.Point(362, 191);
            this.SearchBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBT.Name = "SearchBT";
            this.SearchBT.Size = new System.Drawing.Size(136, 35);
            this.SearchBT.TabIndex = 68;
            this.SearchBT.Text = "Search / ค้นหา";
            this.SearchBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBT.UseVisualStyleBackColor = true;
            this.SearchBT.Click += new System.EventHandler(this.SearchBT_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox2.Image = global::POS_system.Properties.Resources.search_barcode;
            this.pictureBox2.Location = new System.Drawing.Point(30, 74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox4.Location = new System.Drawing.Point(10, 58);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(509, 474);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Image = global::POS_system.Properties.Resources.barcode_print_menubar;
            this.pictureBox1.Location = new System.Drawing.Point(9, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(530, 47);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // Barcode_Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 585);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ShowBarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Print_barcode);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShowName);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataProduct);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.SearchBT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barcodeProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameProduct);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Barcode_Print";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Barcode / พิมพ์บาร์โค้ด";
            this.Load += new System.EventHandler(this.Barcode_Print_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPicture_Barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button SearchBT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox barcodeProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameProduct;
        private System.Windows.Forms.DataGridView dataProduct;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ShowBarcode;
        private System.Windows.Forms.TextBox ShowName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ShowText_Barcode;
        private System.Windows.Forms.PictureBox ShowPicture_Barcode;
        private System.Windows.Forms.Button Print_barcode;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}