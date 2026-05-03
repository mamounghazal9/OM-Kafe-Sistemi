using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace OM_Kafe_Sistemi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            SetPanelPosition();
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            SetPanelPosition();
        }
        private void ArrangeButtonsAtRedCirclePosition()
        {
            // تحديد المكان الذي تريد وضع الأزرار فيه (محل الدائرة الحمراء)
            int startX = 150;  // الإحداثي X للمكان المطلوب
            int startY = 80;   // الإحداثي Y للمكان المطلوب

            // ترتيب الأزرار عمودياً في ذلك المكان
            usernametxt.Location = new Point(startX, startY);
            passwordtxt.Location = new Point(startX, startY + 40);
            loginbtn.Location = new Point(startX, startY + 100);

            // أو إذا أزرار أخرى مثل:
            // buttonOM.Location = new Point(startX, startY);
            // buttonCoffee.Location = new Point(startX + 60, startY);
        }
        private void SetPanelPosition()
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
            int marginRight = 25;
            int yPercent = 52;

            panel1.Left = this.ClientSize.Width - panel1.Width - marginRight;
            panel1.Top = (this.ClientSize.Height * yPercent) / 100;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            if (username == "" && password == "")
            {
                MessageBox.Show("Please fill the blanks", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (username == "")
            {
                MessageBox.Show("Please fill username blank", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (password == "")
            {
                MessageBox.Show("Please fill passwird blank", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username == "OM" && password == "2005")
            {
                TableForm tableForm = new TableForm();
                tableForm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username or password is wrong", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
