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
            panel1 = new Panel();
            loginbtn = new Button();
            passwordtxt = new TextBox();
            usernametxt = new TextBox();
            passwordlab = new Label();
            usernamelbl = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(loginbtn);
            panel1.Controls.Add(passwordtxt);
            panel1.Controls.Add(usernametxt);
            panel1.Controls.Add(passwordlab);
            panel1.Controls.Add(usernamelbl);
            panel1.Location = new Point(684, 444);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 330);
            panel1.TabIndex = 5;
            // 
            // loginbtn
            // 
            loginbtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginbtn.Location = new Point(543, 250);
            loginbtn.Margin = new Padding(5);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(153, 46);
            loginbtn.TabIndex = 9;
            loginbtn.Text = "LOGİN";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordtxt.BackColor = Color.FromArgb(26, 16, 8);
            passwordtxt.BorderStyle = BorderStyle.FixedSingle;
            passwordtxt.ForeColor = Color.Moccasin;
            passwordtxt.Location = new Point(330, 137);
            passwordtxt.Margin = new Padding(5);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new Size(452, 39);
            passwordtxt.TabIndex = 8;
            // 
            // usernametxt
            // 
            usernametxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernametxt.BackColor = Color.FromArgb(26, 16, 8);
            usernametxt.BorderStyle = BorderStyle.FixedSingle;
            usernametxt.ForeColor = Color.Moccasin;
            usernametxt.Location = new Point(330, 42);
            usernametxt.Margin = new Padding(5);
            usernametxt.Name = "usernametxt";
            usernametxt.Size = new Size(452, 39);
            usernametxt.TabIndex = 7;
            // 
            // passwordlab
            // 
            passwordlab.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordlab.AutoSize = true;
            passwordlab.BackColor = Color.FromArgb(26, 16, 8);
            passwordlab.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordlab.ForeColor = Color.Moccasin;
            passwordlab.Location = new Point(69, 126);
            passwordlab.Margin = new Padding(5, 0, 5, 0);
            passwordlab.Name = "passwordlab";
            passwordlab.Size = new Size(229, 48);
            passwordlab.TabIndex = 6;
            passwordlab.Text = " PASSWORD";
            passwordlab.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usernamelbl
            // 
            usernamelbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            usernamelbl.AutoSize = true;
            usernamelbl.BackColor = Color.FromArgb(26, 16, 8);
            usernamelbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamelbl.ForeColor = Color.Moccasin;
            usernamelbl.Location = new Point(33, 23);
            usernamelbl.Margin = new Padding(5, 0, 5, 0);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(265, 60);
            usernamelbl.TabIndex = 5;
            usernamelbl.Text = "USERNAME";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2026_05_02_at_12_111;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1510, 931);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button loginbtn;
        private TextBox passwordtxt;
        private TextBox usernametxt;
        private Label passwordlab;
        private Label usernamelbl;
    }
}