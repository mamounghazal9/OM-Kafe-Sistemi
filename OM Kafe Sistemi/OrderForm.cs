using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OM_Kafe_Sistemi
{
    public partial class OrderForm : Form
    {
        public static int total = 0;
        public static string orders = "";

        public OrderForm()
        {
            InitializeComponent();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            espressobtn.Tag = 60;
            lattebtn.Tag = 110;
            Desspbtn.Tag = 85;
            turkishbtn.Tag = 65;
            frozenbtn.Tag = 150;
            limonatabtn.Tag = 130;
        }

        private void Price_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            int price = Convert.ToInt32(btn.Tag);

            orderlist.Items.Add(btn.Text + " - " + price + " TL");

            orders += btn.Text + " - " + price + " TL\n";
            total += price;

            toplamlabel.Text = total + " TL";
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (orderlist.SelectedItem != null)
            {
                string item = orderlist.SelectedItem.ToString();

                string[] parts = item.Split('-');

                int price = Convert.ToInt32(
                    parts[1].Replace("TL", "").Trim()
                );

                total -= price;

                toplamlabel.Text = total + " TL";

                orderlist.Items.Remove(orderlist.SelectedItem);
            }

            else
            {
                MessageBox.Show("Select an Item", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            orderlist.Items.Clear();

            total = 0;

            toplamlabel.Text = "0 TL";
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show
                ("Yes = Cash\nNo = Kard",
                "Cash?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
