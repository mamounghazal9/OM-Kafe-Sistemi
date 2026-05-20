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
        bool isClearing = false;

        public OrderForm()
        {
            InitializeComponent();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            espressocheck.Tag = 60;
            lattecheck.Tag = 110;
            doublecheck.Tag = 85;
            turkishcheck.Tag = 65;
            frozencheck.Tag = 150;
            limonatacheck.Tag = 130;
        }

        private void Product_CheckedChanged(object sender, EventArgs e)
        {
            if (isClearing) return;

            CheckBox chk = (CheckBox)sender;

            int price = Convert.ToInt32(chk.Tag);
            string item = chk.Text + " - " + price + " TL";

            if (chk.Checked)
            {
                orderlist.Items.Add(item);
                total += price;
            }
            else
            {
                orderlist.Items.Remove(item);
                total -= price;
            }

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
            orders = "";

            toplamlabel.Text = "0 TL";

            espressocheck.Checked = false;
            lattecheck.Checked = false;
            doublecheck.Checked = false;
            turkishcheck.Checked = false;
            frozencheck.Checked = false;
            limonatacheck.Checked = false;
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            if (orderlist.Items.Count == 0)
            {
                MessageBox.Show("No order to pay");
                return;
            }

            string receipt = "";

            foreach (var item in orderlist.Items)
            {
                receipt += item.ToString() + "\n";
            }

            DailyReportForm.dailyOrders.Add(receipt);
            DailyReportForm.dailyOrders.Add("Total = " + total + " TL");
            DailyReportForm.dailyOrders.Add("----------------");

            isClearing = true;

            espressocheck.Checked = false;
            lattecheck.Checked = false;
            doublecheck.Checked = false;
            turkishcheck.Checked = false;
            frozencheck.Checked = false;
            limonatacheck.Checked = false;

            isClearing = false;

            orderlist.Items.Clear();
            orders = "";
            total = 0;

            toplamlabel.Text = "0 TL";
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            DailyReportForm dailyForm = new DailyReportForm();
            dailyForm.Show();
        }
    }
}
