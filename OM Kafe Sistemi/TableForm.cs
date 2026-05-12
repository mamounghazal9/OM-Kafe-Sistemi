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
                Button btnTable = new Button();

                btnTable.Text = "Masa " + i;
                btnTable.Width = 170;
                btnTable.Height = 150;
                btnTable.Margin = new Padding(25);

                btnTable.BackColor = Color.FromArgb(70, 45, 25);
                btnTable.ForeColor = Color.Gold;
                btnTable.Font = new Font("Arial", 13, FontStyle.Bold);

                btnTable.FlatStyle = FlatStyle.Flat;
                btnTable.FlatAppearance.BorderSize = 2;
                btnTable.FlatAppearance.BorderColor = Color.Gold;

                btnTable.Tag = "empty";
                btnTable.Click += Table_Click;

                flowLayoutPanel1.Controls.Add(btnTable);

                btnTable.Margin = new Padding(80);

                btnTable.Tag = "empty";
                btnTable.BackColor = Color.Green;
            }
        }
        private void Table_Click(object sender, EventArgs e)
        {
            Button masa = (Button)sender;

            if (masa.Tag.ToString() == "empty")
            {
                masa.BackColor = Color.Red;
                masa.Tag = "full";

                OrderForm orderForm = new OrderForm();
                orderForm.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    OrderForm.orders + "\nTotal: " + OrderForm.total + " TL\n\nPayment completed?",
                    "Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    masa.BackColor = Color.Green;
                    masa.Tag = "empty";

                    OrderForm.orders = "";
                    OrderForm.total = 0;
                }
            }
        }
    }
}
