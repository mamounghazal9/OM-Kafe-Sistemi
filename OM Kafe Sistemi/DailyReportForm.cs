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
    }
}
