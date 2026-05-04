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
            flowLayoutPanel1.Controls.Clear();

            flowLayoutPanel1.Padding = new Padding(60, 50, 60, 50);
            flowLayoutPanel1.BackColor = Color.FromArgb(25, 12, 5);
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.WrapContents = true;
            flowLayoutPanel1.AutoScroll = true;

            for (int i = 1; i <= 18; i++)
            {
                Button btn = new Button();

                btn.Text = "Masa " + i;
                btn.Width = 150;
                btn.Height = 130;
                btn.Margin = new Padding(25);

                btn.BackColor = Color.FromArgb(70, 45, 25);
                btn.ForeColor = Color.Gold;
                btn.Font = new Font("Arial", 13, FontStyle.Bold);

                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor = Color.Gold;

                btn.Tag = "empty";
                btn.Click += Table_Click;

                flowLayoutPanel1.Controls.Add(btn);
            }
        }
        
        private void Table_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Tag.ToString() == "empty")
            {
                btn.BackColor = Color.Red;
                btn.Tag = "full";
            }
            else
            {
                btn.BackColor = Color.Green;
                btn.Tag = "empty";
            }
        }
    }
}
