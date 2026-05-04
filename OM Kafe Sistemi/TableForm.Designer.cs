namespace OM_Kafe_Sistemi
{
    partial class TableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableForm));
            btnTable = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnTable
            // 
            btnTable.BackgroundImageLayout = ImageLayout.None;
            btnTable.Font = new Font("Elephant", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTable.Image = (Image)resources.GetObject("btnTable.Image");
            btnTable.Location = new Point(47, 64);
            btnTable.Margin = new Padding(5);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(281, 264);
            btnTable.TabIndex = 0;
            btnTable.Text = "TABLE 1";
            btnTable.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(2049, 1091);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // TableForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 16, 8);
            ClientSize = new Size(2049, 1091);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnTable);
            Name = "TableForm";
            Text = "TableForm";
            Load += TableForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTable;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}