namespace MDWquizz
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_register = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(91, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "PalyerID:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(169, 81);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 21);
            this.tb_id.TabIndex = 1;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(169, 125);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(100, 21);
            this.tb_pwd.TabIndex = 3;
            this.tb_pwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(91, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // bt_register
            // 
            this.bt_register.Image = global::MDWquizz.Properties.Resources._1434595098_users_groups;
            this.bt_register.Location = new System.Drawing.Point(205, 176);
            this.bt_register.Name = "bt_register";
            this.bt_register.Size = new System.Drawing.Size(35, 35);
            this.bt_register.TabIndex = 5;
            this.bt_register.UseVisualStyleBackColor = true;
            this.bt_register.Click += new System.EventHandler(this.bt_register_Click);
            // 
            // bt_login
            // 
            this.bt_login.Image = global::MDWquizz.Properties.Resources._1434595084_lock;
            this.bt_login.Location = new System.Drawing.Point(114, 176);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(35, 35);
            this.bt_login.TabIndex = 4;
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MDWquizz.Properties.Resources.light_blue_background_2;
            this.ClientSize = new System.Drawing.Size(428, 302);
            this.Controls.Add(this.bt_register);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_register;
    }
}