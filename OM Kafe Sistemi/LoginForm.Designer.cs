namespace OM_Kafe_Sistemi
{
    partial class LoginForm
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
            usernamelbl = new Label();
            passwordlab = new Label();
            usernametxt = new TextBox();
            passwordtxt = new TextBox();
            loginbtn = new Button();
            SuspendLayout();
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.BackColor = Color.FromArgb(26, 16, 8);
            usernamelbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamelbl.ForeColor = Color.Moccasin;
            usernamelbl.Location = new Point(788, 532);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(170, 38);
            usernamelbl.TabIndex = 0;
            usernamelbl.Text = "USERNAME";
            usernamelbl.Click += label1_Click;
            // 
            // passwordlab
            // 
            passwordlab.AutoSize = true;
            passwordlab.BackColor = Color.FromArgb(26, 16, 8);
            passwordlab.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordlab.ForeColor = Color.Moccasin;
            passwordlab.Location = new Point(811, 585);
            passwordlab.Name = "passwordlab";
            passwordlab.Size = new Size(147, 31);
            passwordlab.TabIndex = 1;
            passwordlab.Text = " PASSWORD";
            passwordlab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernametxt
            // 
            usernametxt.BackColor = Color.FromArgb(26, 16, 8);
            usernametxt.BorderStyle = BorderStyle.FixedSingle;
            usernametxt.ForeColor = Color.Moccasin;
            usernametxt.Location = new Point(1079, 532);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(279, 27);
            usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.FromArgb(26, 16, 8);
            passwordtxt.BorderStyle = BorderStyle.FixedSingle;
            passwordtxt.ForeColor = Color.Moccasin;
            passwordtxt.Location = new Point(1079, 591);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(279, 27);
            passwordtxt.TabIndex = 3;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(1264, 734);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(94, 29);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "LOGİN";
            loginbtn.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_05_02_at_12_111;
            ClientSize = new Size(1518, 955);
            Controls.Add(loginbtn);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(passwordlab);
            Controls.Add(usernamelbl);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernamelbl;
        private Label passwordlab;
        private TextBox usernametxt;
        private TextBox passwordtxt;
        private Button loginbtn;
    }
}