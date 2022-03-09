namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose() ;
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.textboxmatkhau = new System.Windows.Forms.TextBox();
=======
            this.textboxpassword = new System.Windows.Forms.TextBox();
>>>>>>> 7f65ab151f98aa147911f2f4d430f5ee5c7c46bd
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên đăng nhập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textboxusername
            // 
<<<<<<< HEAD
            this.textboxusername.Location = new System.Drawing.Point(238, 100);
            this.textboxusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(413, 27);
=======
            this.textboxusername.Location = new System.Drawing.Point(208, 75);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(362, 23);
>>>>>>> 7f65ab151f98aa147911f2f4d430f5ee5c7c46bd
            this.textboxusername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "mật khẩu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
<<<<<<< HEAD
            // textboxmatkhau
            // 
            this.textboxmatkhau.Location = new System.Drawing.Point(238, 177);
            this.textboxmatkhau.Name = "textboxmatkhau";
            this.textboxmatkhau.Size = new System.Drawing.Size(413, 27);
            this.textboxmatkhau.TabIndex = 3;
=======
            // textboxpassword
            // 
            this.textboxpassword.Location = new System.Drawing.Point(208, 133);
            this.textboxpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.Size = new System.Drawing.Size(362, 23);
            this.textboxpassword.TabIndex = 3;
>>>>>>> 7f65ab151f98aa147911f2f4d430f5ee5c7c46bd
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(336, 208);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 378);
            this.Controls.Add(this.btnlogin);
<<<<<<< HEAD
            this.Controls.Add(this.textboxmatkhau);
=======
            this.Controls.Add(this.textboxpassword);
>>>>>>> 7f65ab151f98aa147911f2f4d430f5ee5c7c46bd
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textboxusername;
        private Label label2;
<<<<<<< HEAD
        private TextBox textboxmatkhau;
=======
        private TextBox textboxpassword;
>>>>>>> 7f65ab151f98aa147911f2f4d430f5ee5c7c46bd
        private Button btnlogin;
    }
}