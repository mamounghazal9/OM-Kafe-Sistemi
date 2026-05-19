using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace OM_Kafe_Sistemi
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
                DialogResult result = MessageBox.Show
                ("Yes = Table\nNo = Take Away",
                "Choose Order Type",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    TableForm tableForm = new TableForm();
                    tableForm.Show();
                }
                else
                {
                    OrderForm orderForm = new OrderForm();
                    orderForm.Show();
                }

                this.Hide();
            }

            else
            {
                MessageBox.Show("Username or password is wrong", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usernamelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
