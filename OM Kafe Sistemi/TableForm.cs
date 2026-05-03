using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OM_Kafe_Sistemi
{
    public partial class TableForm : Form
    {
        public TableForm()
        {
            InitializeComponent();
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Button btn = new Button();
                btn.Text = "M " + i;
                btn.Width = 100;
                btn.Height = 100;
                btn.BackColor = Color.LightGreen;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.Black;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
