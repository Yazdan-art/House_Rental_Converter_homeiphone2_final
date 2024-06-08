namespace House_Rental_Converter_homeiphone2
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            linkLabel1 = new LinkLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            دربارهماToolStripMenuItem = new ToolStripMenuItem();
            دربارهبرنامهنویسانToolStripMenuItem = new ToolStripMenuItem();
            rent_num = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            prepeyment_number = new NumericUpDown();
            prepayment_lbl = new Label();
            rent_lbl = new Label();
            rent_to_prepeyment_btn = new Button();
            prepeyment_to_rent_btn = new Button();
            comboBox1 = new ComboBox();
            total_txt = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)rent_num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prepeyment_number).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 655);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(90, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "another app";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(868, 24);
            menuStrip1.TabIndex = 46;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, دربارهماToolStripMenuItem, دربارهبرنامهنویسانToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(100, 24);
            fileToolStripMenuItem.Text = "Application";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(225, 26);
            exitToolStripMenuItem.Text = "سایر برنامه‌های رایگان";
            // 
            // دربارهماToolStripMenuItem
            // 
            دربارهماToolStripMenuItem.Name = "دربارهماToolStripMenuItem";
            دربارهماToolStripMenuItem.Size = new Size(225, 26);
            دربارهماToolStripMenuItem.Text = "درباره ما";
            // 
            // دربارهبرنامهنویسانToolStripMenuItem
            // 
            دربارهبرنامهنویسانToolStripMenuItem.Name = "دربارهبرنامهنویسانToolStripMenuItem";
            دربارهبرنامهنویسانToolStripMenuItem.Size = new Size(225, 26);
            دربارهبرنامهنویسانToolStripMenuItem.Text = "درباره برنامه نویسان";
            // 
            // rent_num
            // 
            rent_num.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rent_num.Location = new Point(12, 72);
            rent_num.Margin = new Padding(3, 4, 3, 4);
            rent_num.Maximum = new decimal(new int[] { 50000000, 0, 0, 0 });
            rent_num.Name = "rent_num";
            rent_num.Size = new Size(420, 49);
            rent_num.TabIndex = 33;
            rent_num.ThousandsSeparator = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 122);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 34;
            label1.Text = "مبلغ اجاره را به تومان وارد کنید";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(223, 431);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 35;
            label2.Text = "مبلغ رهن را به تومان وارد کنید";
            // 
            // prepeyment_number
            // 
            prepeyment_number.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prepeyment_number.Location = new Point(24, 378);
            prepeyment_number.Margin = new Padding(3, 4, 3, 4);
            prepeyment_number.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            prepeyment_number.Name = "prepeyment_number";
            prepeyment_number.Size = new Size(408, 49);
            prepeyment_number.TabIndex = 36;
            prepeyment_number.ThousandsSeparator = true;
            // 
            // prepayment_lbl
            // 
            prepayment_lbl.BackColor = Color.FromArgb(192, 255, 192);
            prepayment_lbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prepayment_lbl.Location = new Point(679, 82);
            prepayment_lbl.Name = "prepayment_lbl";
            prepayment_lbl.Size = new Size(159, 50);
            prepayment_lbl.TabIndex = 37;
            prepayment_lbl.Text = "مبلغ رهن ";
            prepayment_lbl.TextAlign = ContentAlignment.TopRight;
            // 
            // rent_lbl
            // 
            rent_lbl.BackColor = Color.FromArgb(192, 255, 192);
            rent_lbl.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rent_lbl.Location = new Point(680, 376);
            rent_lbl.Name = "rent_lbl";
            rent_lbl.Size = new Size(165, 50);
            rent_lbl.TabIndex = 38;
            rent_lbl.Text = "مبلغ اجاره";
            rent_lbl.TextAlign = ContentAlignment.TopRight;
            // 
            // rent_to_prepeyment_btn
            // 
            rent_to_prepeyment_btn.BackColor = SystemColors.ActiveCaption;
            rent_to_prepeyment_btn.Location = new Point(462, 82);
            rent_to_prepeyment_btn.Margin = new Padding(3, 4, 3, 4);
            rent_to_prepeyment_btn.Name = "rent_to_prepeyment_btn";
            rent_to_prepeyment_btn.Size = new Size(168, 41);
            rent_to_prepeyment_btn.TabIndex = 39;
            rent_to_prepeyment_btn.Text = "تبدیل اجاره به رهن";
            rent_to_prepeyment_btn.UseVisualStyleBackColor = false;
            rent_to_prepeyment_btn.Click += rent_to_prepeyment_btn_Click;
            // 
            // prepeyment_to_rent_btn
            // 
            prepeyment_to_rent_btn.BackColor = SystemColors.ActiveCaption;
            prepeyment_to_rent_btn.Location = new Point(462, 379);
            prepeyment_to_rent_btn.Margin = new Padding(3, 4, 3, 4);
            prepeyment_to_rent_btn.Name = "prepeyment_to_rent_btn";
            prepeyment_to_rent_btn.Size = new Size(168, 49);
            prepeyment_to_rent_btn.TabIndex = 40;
            prepeyment_to_rent_btn.Text = "تبدیل رهن به اجاره";
            prepeyment_to_rent_btn.UseVisualStyleBackColor = false;
            prepeyment_to_rent_btn.Click += prepeyment_to_rent_btn_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "راه‌اندازی مجدد", "جمع اجاره", "جمع رهن" });
            comboBox1.Location = new Point(24, 549);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 39);
            comboBox1.TabIndex = 42;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // total_txt
            // 
            total_txt.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_txt.Location = new Point(299, 549);
            total_txt.Margin = new Padding(3, 4, 3, 4);
            total_txt.Name = "total_txt";
            total_txt.Size = new Size(237, 38);
            total_txt.TabIndex = 45;
            total_txt.Text = "جمع ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(169, 132);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(0, 0, 50, 0);
            pictureBox2.Size = new Size(635, 239);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 131);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(628, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // Converter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(868, 698);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(total_txt);
            Controls.Add(pictureBox2);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(prepeyment_to_rent_btn);
            Controls.Add(rent_to_prepeyment_btn);
            Controls.Add(rent_lbl);
            Controls.Add(prepayment_lbl);
            Controls.Add(prepeyment_number);
            Controls.Add(rent_num);
            Controls.Add(menuStrip1);
            Controls.Add(linkLabel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(886, 745);
            MinimumSize = new Size(886, 745);
            Name = "Converter";
            Text = "مبدل رهن و اجاره";
            Load += Converter_Load;
            ((System.ComponentModel.ISupportInitialize)rent_num).EndInit();
            ((System.ComponentModel.ISupportInitialize)prepeyment_number).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown rent_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown prepeyment_number;
        private System.Windows.Forms.Label prepayment_lbl;
        private System.Windows.Forms.Label rent_lbl;
        private System.Windows.Forms.Button rent_to_prepeyment_btn;
        private System.Windows.Forms.Button prepeyment_to_rent_btn;
        private System.Windows.Forms.ToolStripMenuItem دربارهماToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دربارهبرنامهنویسانToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox total_txt;
    }
}