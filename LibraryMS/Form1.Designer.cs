using System;
using System.Data.SqlClient;

namespace LibraryMS
{
    partial class Form1
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
            this.txtusernamebtn = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Signbtn = new System.Windows.Forms.Button();
            this.picboxYoutude = new System.Windows.Forms.PictureBox();
            this.picboxFacebook = new System.Windows.Forms.PictureBox();
            this.picboxinsta = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxYoutude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxinsta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusernamebtn
            // 
            this.txtusernamebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtusernamebtn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusernamebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusernamebtn.ForeColor = System.Drawing.SystemColors.Window;
            this.txtusernamebtn.Location = new System.Drawing.Point(69, 241);
            this.txtusernamebtn.Name = "txtusernamebtn";
            this.txtusernamebtn.Size = new System.Drawing.Size(183, 19);
            this.txtusernamebtn.TabIndex = 6;
            this.txtusernamebtn.Text = "Username";
            this.txtusernamebtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtusername);
            this.txtusernamebtn.MouseEnter += new System.EventHandler(this.txtusername);
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpassword.Location = new System.Drawing.Point(69, 330);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(183, 19);
            this.txtpassword.TabIndex = 7;
            this.txtpassword.Text = "Password";
            this.txtpassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword);
            this.txtpassword.MouseEnter += new System.EventHandler(this.txtPassword);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(69, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(69, 348);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 1);
            this.panel2.TabIndex = 9;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Cyan;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Loginbtn.Location = new System.Drawing.Point(69, 374);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(183, 42);
            this.Loginbtn.TabIndex = 10;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this. Loginbtn_Click);
            // 
            // Signbtn
            // 
            this.Signbtn.BackColor = System.Drawing.Color.Gray;
            this.Signbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Signbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signbtn.ForeColor = System.Drawing.SystemColors.Info;
            this.Signbtn.Location = new System.Drawing.Point(69, 435);
            this.Signbtn.Name = "Signbtn";
            this.Signbtn.Size = new System.Drawing.Size(183, 42);
            this.Signbtn.TabIndex = 11;
            this.Signbtn.Text = "Sign Up";
            this.Signbtn.UseVisualStyleBackColor = false;
            this.Signbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // picboxYoutude
            // 
            this.picboxYoutude.Image = global::LibraryMS.Properties.Resources.images__3_;
            this.picboxYoutude.Location = new System.Drawing.Point(195, 492);
            this.picboxYoutude.Name = "picboxYoutude";
            this.picboxYoutude.Size = new System.Drawing.Size(74, 72);
            this.picboxYoutude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxYoutude.TabIndex = 15;
            this.picboxYoutude.TabStop = false;
            this.picboxYoutude.Click += new System.EventHandler(this.picboxYoutude_Click);
            // 
            // picboxFacebook
            // 
            this.picboxFacebook.Image = global::LibraryMS.Properties.Resources.images__4_;
            this.picboxFacebook.Location = new System.Drawing.Point(104, 492);
            this.picboxFacebook.Name = "picboxFacebook";
            this.picboxFacebook.Size = new System.Drawing.Size(72, 72);
            this.picboxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxFacebook.TabIndex = 14;
            this.picboxFacebook.TabStop = false;
            this.picboxFacebook.Click += new System.EventHandler(this.picboxFacebook_Click);
            // 
            // picboxinsta
            // 
            this.picboxinsta.Image = global::LibraryMS.Properties.Resources.images__2_1;
            this.picboxinsta.Location = new System.Drawing.Point(12, 492);
            this.picboxinsta.Name = "picboxinsta";
            this.picboxinsta.Size = new System.Drawing.Size(76, 64);
            this.picboxinsta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxinsta.TabIndex = 12;
            this.picboxinsta.TabStop = false;
            this.picboxinsta.Click += new System.EventHandler(this.picboxinsta_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibraryMS.Properties.Resources.download__8_1;
            this.pictureBox4.Location = new System.Drawing.Point(12, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibraryMS.Properties.Resources.download__7_;
            this.pictureBox3.Location = new System.Drawing.Point(12, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryMS.Properties.Resources.download__2_;
            this.pictureBox1.Location = new System.Drawing.Point(95, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryMS.Properties.Resources.boxloading;
            this.pictureBox2.Location = new System.Drawing.Point(12, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(55)))));
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.ForeColor = System.Drawing.SystemColors.Window;
            this.closebtn.Location = new System.Drawing.Point(275, 1);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(45, 41);
            this.closebtn.TabIndex = 16;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(322, 576);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.picboxYoutude);
            this.Controls.Add(this.picboxFacebook);
            this.Controls.Add(this.picboxinsta);
            this.Controls.Add(this.Signbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusernamebtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxYoutude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxinsta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtusernamebtn;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Signbtn;
        private System.Windows.Forms.PictureBox picboxinsta;
        private System.Windows.Forms.PictureBox picboxFacebook;
        private System.Windows.Forms.PictureBox picboxYoutude;
        private System.Windows.Forms.Button closebtn;
    }
}

