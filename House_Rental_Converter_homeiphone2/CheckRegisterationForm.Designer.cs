namespace House_Rental_Converter_homeiphone2
{
    partial class CheckRegisterationForm
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
            linkLabel1 = new LinkLabel();
            check_btn = new Button();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Gray;
            linkLabel1.Location = new Point(29, 244);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "homeiphone.ir";
            linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // check_btn
            // 
            check_btn.BackColor = SystemColors.ActiveCaption;
            check_btn.Location = new Point(12, 142);
            check_btn.Margin = new Padding(3, 5, 3, 5);
            check_btn.Name = "check_btn";
            check_btn.Size = new Size(450, 50);
            check_btn.TabIndex = 0;
            check_btn.Text = "Register Check";
            check_btn.UseVisualStyleBackColor = false;
            check_btn.Click += check_btn_Click;
            // 
            // CheckRegisterationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(482, 453);
            Controls.Add(linkLabel1);
            Controls.Add(check_btn);
            Margin = new Padding(3, 5, 3, 5);
            MaximumSize = new Size(500, 500);
            MinimumSize = new Size(500, 500);
            Name = "CheckRegisterationForm";
            Text = "Check Registration Form";
            Load += CheckRegisterationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private System.Windows.Forms.Button check_btn;
    }
}