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
            loginbtn = new Button();
            passwordtxt = new TextBox();
            usernametxt = new TextBox();
            passwordlab = new Label();
            usernamelbl = new Label();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.Anchor = AnchorStyles.None;
            loginbtn.BackColor = Color.FromArgb(26, 16, 8);
            loginbtn.FlatAppearance.BorderColor = Color.Moccasin;
            loginbtn.Font = new Font("Castellar", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.Moccasin;
            loginbtn.Location = new Point(554, 452);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(94, 29);
            loginbtn.TabIndex = 14;
            loginbtn.Text = "LOGİN";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.Anchor = AnchorStyles.None;
            passwordtxt.BackColor = Color.FromArgb(26, 16, 8);
            passwordtxt.BorderStyle = BorderStyle.FixedSingle;
            passwordtxt.ForeColor = Color.Moccasin;
            passwordtxt.Location = new Point(554, 400);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.PasswordChar = '*';
            passwordtxt.Size = new Size(279, 27);
            passwordtxt.TabIndex = 13;
            // 
            // usernametxt
            // 
            usernametxt.Anchor = AnchorStyles.None;
            usernametxt.BackColor = Color.FromArgb(26, 16, 8);
            usernametxt.BorderStyle = BorderStyle.FixedSingle;
            usernametxt.ForeColor = Color.Moccasin;
            usernametxt.Location = new Point(554, 303);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(279, 27);
            usernametxt.TabIndex = 12;
            // 
            // passwordlab
            // 
            passwordlab.Anchor = AnchorStyles.None;
            passwordlab.AutoSize = true;
            passwordlab.BackColor = Color.FromArgb(26, 16, 8);
            passwordlab.Font = new Font("Castellar", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordlab.ForeColor = Color.Moccasin;
            passwordlab.Location = new Point(587, 348);
            passwordlab.Name = "passwordlab";
            passwordlab.Size = new Size(205, 36);
            passwordlab.TabIndex = 11;
            passwordlab.Text = " PASSWORD";
            passwordlab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernamelbl
            // 
            usernamelbl.Anchor = AnchorStyles.None;
            usernamelbl.AutoSize = true;
            usernamelbl.BackColor = Color.FromArgb(26, 16, 8);
            usernamelbl.Font = new Font("Castellar", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelbl.ForeColor = Color.Moccasin;
            usernamelbl.Location = new Point(587, 249);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(195, 36);
            usernamelbl.TabIndex = 10;
            usernamelbl.Text = "USERNAME";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_05_02_at_12_111;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(929, 582);
            Controls.Add(loginbtn);
            Controls.Add(passwordtxt);
            Controls.Add(usernametxt);
            Controls.Add(passwordlab);
            Controls.Add(usernamelbl);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private TextBox passwordtxt;
        private TextBox usernametxt;
        private Label passwordlab;
        private Label usernamelbl;
    }
}