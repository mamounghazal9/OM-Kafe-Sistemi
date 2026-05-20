using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OM_Kafe_Sistemi
{
    public partial class DailyReportForm : Form
    {
        public static List<string> dailyOrders = new List<string>();
        public DailyReportForm()
        {
            InitializeComponent();
        }

        private void DailyReportForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string item in dailyOrders)
            {
                listBox1.Items.Add(item);
            }
        }
        private void silbtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void toplabtn_Click(object sender, EventArgs e)
        {
            int totalIncome = 0;

            foreach (string item in listBox1.Items)
            {
                if (item.Contains("Total ="))
                {
                    string number = item
                        .Replace("Total =", "")
                        .Replace("TL", "")
                        .Trim();

                    totalIncome += Convert.ToInt32(number);
                }
            }

            MessageBox.Show(
                "Toplam Gelir = " + totalIncome + " TL",
                "Daily Income",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
