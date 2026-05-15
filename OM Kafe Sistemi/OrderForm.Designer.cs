namespace OM_Kafe_Sistemi
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            lattebtn = new Button();
            turkishbtn = new Button();
            frozenbtn = new Button();
            limonatabtn = new Button();
            espressobtn = new Button();
            Desspbtn = new Button();
            orderlist = new ListBox();
            removebtn = new Button();
            deletebtn = new Button();
            paybtn = new Button();
            toplamlabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lattebtn
            // 
            lattebtn.Anchor = AnchorStyles.None;
            lattebtn.BackColor = Color.FromArgb(216, 200, 176);
            lattebtn.Location = new Point(372, 176);
            lattebtn.Margin = new Padding(2);
            lattebtn.Name = "lattebtn";
            lattebtn.Size = new Size(100, 100);
            lattebtn.TabIndex = 0;
            lattebtn.Text = "Latte";
            lattebtn.UseVisualStyleBackColor = false;
            lattebtn.Click += Price_Click;
            // 
            // turkishbtn
            // 
            turkishbtn.Anchor = AnchorStyles.None;
            turkishbtn.BackColor = Color.FromArgb(216, 200, 176);
            turkishbtn.Location = new Point(497, 176);
            turkishbtn.Margin = new Padding(2);
            turkishbtn.Name = "turkishbtn";
            turkishbtn.Size = new Size(100, 100);
            turkishbtn.TabIndex = 1;
            turkishbtn.Text = "Turkish coffee";
            turkishbtn.UseVisualStyleBackColor = false;
            turkishbtn.Click += Price_Click;
            // 
            // frozenbtn
            // 
            frozenbtn.Anchor = AnchorStyles.None;
            frozenbtn.BackColor = Color.FromArgb(216, 200, 176);
            frozenbtn.Location = new Point(372, 311);
            frozenbtn.Margin = new Padding(2);
            frozenbtn.Name = "frozenbtn";
            frozenbtn.Size = new Size(100, 100);
            frozenbtn.TabIndex = 2;
            frozenbtn.Text = "Frozen";
            frozenbtn.UseVisualStyleBackColor = false;
            frozenbtn.Click += Price_Click;
            // 
            // limonatabtn
            // 
            limonatabtn.Anchor = AnchorStyles.None;
            limonatabtn.BackColor = Color.FromArgb(216, 200, 176);
            limonatabtn.Location = new Point(497, 311);
            limonatabtn.Margin = new Padding(2);
            limonatabtn.Name = "limonatabtn";
            limonatabtn.Size = new Size(100, 100);
            limonatabtn.TabIndex = 3;
            limonatabtn.Text = "Limonata";
            limonatabtn.UseVisualStyleBackColor = false;
            limonatabtn.Click += Price_Click;
            // 
            // espressobtn
            // 
            espressobtn.Anchor = AnchorStyles.None;
            espressobtn.BackColor = Color.FromArgb(216, 200, 176);
            espressobtn.Location = new Point(372, 41);
            espressobtn.Margin = new Padding(2);
            espressobtn.Name = "espressobtn";
            espressobtn.Size = new Size(100, 100);
            espressobtn.TabIndex = 4;
            espressobtn.Text = "Espresso";
            espressobtn.UseVisualStyleBackColor = false;
            espressobtn.Click += Price_Click;
            // 
            // Desspbtn
            // 
            Desspbtn.Anchor = AnchorStyles.None;
            Desspbtn.BackColor = Color.FromArgb(216, 200, 176);
            Desspbtn.Location = new Point(497, 41);
            Desspbtn.Margin = new Padding(2);
            Desspbtn.Name = "Desspbtn";
            Desspbtn.Size = new Size(100, 100);
            Desspbtn.TabIndex = 5;
            Desspbtn.Text = "Double Espresso";
            Desspbtn.UseVisualStyleBackColor = false;
            Desspbtn.Click += Price_Click;
            // 
            // orderlist
            // 
            orderlist.Anchor = AnchorStyles.None;
            orderlist.BackColor = Color.White;
            orderlist.FormattingEnabled = true;
            orderlist.Location = new Point(622, 41);
            orderlist.Margin = new Padding(2);
            orderlist.Name = "orderlist";
            orderlist.Size = new Size(280, 164);
            orderlist.TabIndex = 6;
            // 
            // removebtn
            // 
            removebtn.Anchor = AnchorStyles.None;
            removebtn.BackColor = Color.FromArgb(150, 78, 72);
            removebtn.Location = new Point(636, 294);
            removebtn.Margin = new Padding(2);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(87, 48);
            removebtn.TabIndex = 7;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Anchor = AnchorStyles.None;
            deletebtn.BackColor = Color.FromArgb(150, 78, 72);
            deletebtn.Location = new Point(791, 294);
            deletebtn.Margin = new Padding(2);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(83, 48);
            deletebtn.TabIndex = 8;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // paybtn
            // 
            paybtn.Anchor = AnchorStyles.None;
            paybtn.BackColor = Color.FromArgb(128, 135, 94);
            paybtn.Location = new Point(652, 373);
            paybtn.Margin = new Padding(2);
            paybtn.Name = "paybtn";
            paybtn.Size = new Size(203, 38);
            paybtn.TabIndex = 9;
            paybtn.Text = "Pay";
            paybtn.UseVisualStyleBackColor = false;
            paybtn.Click += paybtn_Click;
            // 
            // toplamlabel
            // 
            toplamlabel.Anchor = AnchorStyles.None;
            toplamlabel.AutoSize = true;
            toplamlabel.Location = new Point(748, 232);
            toplamlabel.Margin = new Padding(2, 0, 2, 0);
            toplamlabel.Name = "toplamlabel";
            toplamlabel.Size = new Size(36, 20);
            toplamlabel.TabIndex = 11;
            toplamlabel.Text = "0 TL";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(674, 232);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 12;
            label1.Text = "Toplam:";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(946, 461);
            Controls.Add(label1);
            Controls.Add(toplamlabel);
            Controls.Add(paybtn);
            Controls.Add(deletebtn);
            Controls.Add(removebtn);
            Controls.Add(orderlist);
            Controls.Add(Desspbtn);
            Controls.Add(espressobtn);
            Controls.Add(limonatabtn);
            Controls.Add(frozenbtn);
            Controls.Add(turkishbtn);
            Controls.Add(lattebtn);
            Margin = new Padding(1);
            Name = "OrderForm";
            Text = "OrderForm";
            Load += OrderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lattebtn;
        private Button turkishbtn;
        private Button frozenbtn;
        private Button limonatabtn;
        private Button espressobtn;
        private Button Desspbtn;
        private ListBox orderlist;
        private Button removebtn;
        private Button deletebtn;
        private Button paybtn;
        private Label toplamlabel;
        private Label label1;
    }
}