namespace Stu.Management.Sys
{
    partial class FrmRes
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
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnCancal = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblip_addr = new System.Windows.Forms.Label();
            this.txtip_addr = new System.Windows.Forms.TextBox();
            this.lblmac_addr = new System.Windows.Forms.Label();
            this.txtmac_addr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(34, 73);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(41, 12);
            this.lblPwd.TabIndex = 13;
            this.lblPwd.Text = "密  码";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(34, 29);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(41, 12);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "用户名";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(81, 70);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(152, 21);
            this.txtPwd.TabIndex = 11;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(81, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(152, 21);
            this.txtUser.TabIndex = 10;
            // 
            // btnCancal
            // 
            this.btnCancal.Location = new System.Drawing.Point(158, 225);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.Size = new System.Drawing.Size(75, 23);
            this.btnCancal.TabIndex = 9;
            this.btnCancal.Text = "取消";
            this.btnCancal.UseVisualStyleBackColor = true;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(77, 225);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 23);
            this.btnRes.TabIndex = 8;
            this.btnRes.Text = "注册";
            this.btnRes.UseVisualStyleBackColor = true;
            // 
            // lblip_addr
            // 
            this.lblip_addr.AutoSize = true;
            this.lblip_addr.Location = new System.Drawing.Point(34, 120);
            this.lblip_addr.Name = "lblip_addr";
            this.lblip_addr.Size = new System.Drawing.Size(41, 12);
            this.lblip_addr.TabIndex = 16;
            this.lblip_addr.Text = "限制IP";
            // 
            // txtip_addr
            // 
            this.txtip_addr.Location = new System.Drawing.Point(81, 117);
            this.txtip_addr.Name = "txtip_addr";
            this.txtip_addr.Size = new System.Drawing.Size(152, 21);
            this.txtip_addr.TabIndex = 15;
            // 
            // lblmac_addr
            // 
            this.lblmac_addr.AutoSize = true;
            this.lblmac_addr.Location = new System.Drawing.Point(34, 163);
            this.lblmac_addr.Name = "lblmac_addr";
            this.lblmac_addr.Size = new System.Drawing.Size(47, 12);
            this.lblmac_addr.TabIndex = 18;
            this.lblmac_addr.Text = "限制MAC";
            // 
            // txtmac_addr
            // 
            this.txtmac_addr.Location = new System.Drawing.Point(81, 160);
            this.txtmac_addr.Name = "txtmac_addr";
            this.txtmac_addr.Size = new System.Drawing.Size(152, 21);
            this.txtmac_addr.TabIndex = 17;
            // 
            // FrmRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.lblmac_addr);
            this.Controls.Add(this.txtmac_addr);
            this.Controls.Add(this.lblip_addr);
            this.Controls.Add(this.txtip_addr);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.btnRes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 340);
            this.MinimumSize = new System.Drawing.Size(300, 340);
            this.Name = "FrmRes";
            this.Text = "FrmRes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnCancal;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lblip_addr;
        private System.Windows.Forms.TextBox txtip_addr;
        private System.Windows.Forms.Label lblmac_addr;
        private System.Windows.Forms.TextBox txtmac_addr;
    }
}