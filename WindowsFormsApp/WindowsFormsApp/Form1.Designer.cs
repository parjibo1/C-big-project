﻿namespace WindowsFormsApp
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
            this.Textbox2 = new System.Windows.Forms.TextBox();
            this.UserName1 = new System.Windows.Forms.Label();
            this.Password1 = new System.Windows.Forms.Label();
            this.Textbox1 = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Longin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Textbox2
            // 
            this.Textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox2.Location = new System.Drawing.Point(304, 198);
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.PasswordChar = '*';
            this.Textbox2.Size = new System.Drawing.Size(264, 26);
            this.Textbox2.TabIndex = 1;
            this.Textbox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UserName1
            // 
            this.UserName1.AutoSize = true;
            this.UserName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName1.Location = new System.Drawing.Point(162, 140);
            this.UserName1.Name = "UserName1";
            this.UserName1.Size = new System.Drawing.Size(120, 24);
            this.UserName1.TabIndex = 2;
            this.UserName1.Text = "User Name:";
            this.UserName1.Click += new System.EventHandler(this.UserName_Click);
            // 
            // Password1
            // 
            this.Password1.AutoSize = true;
            this.Password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password1.Location = new System.Drawing.Point(172, 198);
            this.Password1.Name = "Password1";
            this.Password1.Size = new System.Drawing.Size(106, 24);
            this.Password1.TabIndex = 3;
            this.Password1.Text = "Password:";
            this.Password1.Click += new System.EventHandler(this.Password_Click);
            // 
            // Textbox1
            // 
            this.Textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox1.Location = new System.Drawing.Point(304, 138);
            this.Textbox1.Name = "Textbox1";
            this.Textbox1.Size = new System.Drawing.Size(264, 26);
            this.Textbox1.TabIndex = 4;
            this.Textbox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(421, 248);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 33);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Longin
            // 
            this.Longin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Longin.Location = new System.Drawing.Point(304, 248);
            this.Longin.Name = "Longin";
            this.Longin.Size = new System.Drawing.Size(96, 33);
            this.Longin.TabIndex = 6;
            this.Longin.Text = "Longin";
            this.Longin.UseVisualStyleBackColor = true;
            this.Longin.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 302);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Longin\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "version 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 388);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Longin);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Textbox1);
            this.Controls.Add(this.Password1);
            this.Controls.Add(this.UserName1);
            this.Controls.Add(this.Textbox2);
            this.MaximumSize = new System.Drawing.Size(596, 427);
            this.MinimumSize = new System.Drawing.Size(596, 427);
            this.Name = "Form1";
            this.Text = "                                                                                 " +
    "                        ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Textbox2;
        private System.Windows.Forms.Label UserName1;
        private System.Windows.Forms.Label Password1;
        private System.Windows.Forms.TextBox Textbox1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Longin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

