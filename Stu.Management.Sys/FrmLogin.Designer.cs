namespace Stu.Management.Sys
{
    partial class FrmLogin
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.linklRes = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(75, 175);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "登录";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnCancal
            // 
            this.btnCancal.Location = new System.Drawing.Point(156, 175);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(75, 23);
            this.btnCancal.TabIndex = 1;
            this.btnCancal.Text = "取消";
            this.btnCancal.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(32, 57);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 12);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "用户名";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(32, 110);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(41, 12);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "密  码";
            // 
            // linklRes
            // 
            this.linklRes.AutoSize = true;
            this.linklRes.Location = new System.Drawing.Point(32, 180);
            this.linklRes.Name = "linklRes";
            this.linklRes.Size = new System.Drawing.Size(29, 12);
            this.linklRes.TabIndex = 7;
            this.linklRes.TabStop = true;
            this.linklRes.Text = "注册";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.linklRes);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.btnEnter);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.LinkLabel linklRes;
    }
}