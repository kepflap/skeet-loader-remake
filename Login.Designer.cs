namespace Loader
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.tbox_pass = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.chbox_savecredentials = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbox_name
            // 
            this.tbox_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.tbox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_name.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbox_name.Location = new System.Drawing.Point(129, 151);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(256, 23);
            this.tbox_name.TabIndex = 1;
            this.tbox_name.TextChanged += new System.EventHandler(this.tbox_name_TextChanged);
            // 
            // tbox_pass
            // 
            this.tbox_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.tbox_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbox_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbox_pass.Location = new System.Drawing.Point(129, 180);
            this.tbox_pass.Name = "tbox_pass";
            this.tbox_pass.PasswordChar = '●';
            this.tbox_pass.Size = new System.Drawing.Size(256, 23);
            this.tbox_pass.TabIndex = 2;
            this.tbox_pass.UseSystemPasswordChar = true;
            // 
            // label_username
            // 
            this.label_username.BackColor = System.Drawing.Color.Transparent;
            this.label_username.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(63, 154);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(60, 20);
            this.label_username.TabIndex = 5;
            this.label_username.Text = "Username";
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // label_pass
            // 
            this.label_pass.BackColor = System.Drawing.Color.Transparent;
            this.label_pass.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_pass.ForeColor = System.Drawing.Color.White;
            this.label_pass.Location = new System.Drawing.Point(63, 181);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(60, 22);
            this.label_pass.TabIndex = 6;
            this.label_pass.Text = "Password";
            this.label_pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chbox_savecredentials
            // 
            this.chbox_savecredentials.AutoSize = true;
            this.chbox_savecredentials.BackColor = System.Drawing.Color.Transparent;
            this.chbox_savecredentials.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbox_savecredentials.ForeColor = System.Drawing.Color.White;
            this.chbox_savecredentials.Location = new System.Drawing.Point(335, 258);
            this.chbox_savecredentials.Name = "chbox_savecredentials";
            this.chbox_savecredentials.Size = new System.Drawing.Size(107, 19);
            this.chbox_savecredentials.TabIndex = 7;
            this.chbox_savecredentials.Text = "Remember me ";
            this.chbox_savecredentials.UseVisualStyleBackColor = false;
            this.chbox_savecredentials.CheckedChanged += new System.EventHandler(this.chbox_savecredentials_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Control;
            this.btn_login.Location = new System.Drawing.Point(129, 218);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(120, 24);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(255, 218);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(130, 24);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Register";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(491, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(517, 387);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.chbox_savecredentials);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.tbox_pass);
            this.Controls.Add(this.tbox_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.TextBox tbox_pass;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.CheckBox chbox_savecredentials;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label3;
    }
}