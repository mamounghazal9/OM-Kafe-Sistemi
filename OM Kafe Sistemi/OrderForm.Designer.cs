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
            orderlist = new ListBox();
            removebtn = new Button();
            deletebtn = new Button();
            paybtn = new Button();
            toplamlabel = new Label();
            label1 = new Label();
            espressocheck = new CheckBox();
            doublecheck = new CheckBox();
            turkishcheck = new CheckBox();
            frozencheck = new CheckBox();
            lattecheck = new CheckBox();
            limonatacheck = new CheckBox();
            viewbtn = new Button();
            SuspendLayout();
            // 
            // orderlist
            // 
            orderlist.Anchor = AnchorStyles.None;
            orderlist.BackColor = Color.White;
            orderlist.FormattingEnabled = true;
            orderlist.Location = new Point(1011, 66);
            orderlist.Name = "orderlist";
            orderlist.Size = new Size(452, 260);
            orderlist.TabIndex = 6;
            // 
            // removebtn
            // 
            removebtn.Anchor = AnchorStyles.None;
            removebtn.BackColor = Color.FromArgb(150, 78, 72);
            removebtn.Location = new Point(1034, 470);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(141, 77);
            removebtn.TabIndex = 7;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = false;
            removebtn.Click += removebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.Anchor = AnchorStyles.None;
            deletebtn.BackColor = Color.FromArgb(150, 78, 72);
            deletebtn.Location = new Point(1285, 470);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(135, 77);
            deletebtn.TabIndex = 8;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // paybtn
            // 
            paybtn.Anchor = AnchorStyles.None;
            paybtn.BackColor = Color.FromArgb(128, 135, 94);
            paybtn.Location = new Point(1060, 597);
            paybtn.Name = "paybtn";
            paybtn.Size = new Size(330, 61);
            paybtn.TabIndex = 9;
            paybtn.Text = "Pay";
            paybtn.UseVisualStyleBackColor = false;
            paybtn.Click += paybtn_Click;
            // 
            // toplamlabel
            // 
            toplamlabel.Anchor = AnchorStyles.None;
            toplamlabel.AutoSize = true;
            toplamlabel.Location = new Point(1216, 371);
            toplamlabel.Name = "toplamlabel";
            toplamlabel.Size = new Size(58, 32);
            toplamlabel.TabIndex = 11;
            toplamlabel.Text = "0 TL";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(1095, 371);
            label1.Name = "label1";
            label1.Size = new Size(97, 32);
            label1.TabIndex = 12;
            label1.Text = "Toplam:";
            // 
            // espressocheck
            // 
            espressocheck.AutoSize = true;
            espressocheck.Location = new Point(503, 82);
            espressocheck.Margin = new Padding(5);
            espressocheck.Name = "espressocheck";
            espressocheck.Size = new Size(137, 36);
            espressocheck.TabIndex = 13;
            espressocheck.Text = "Espresso";
            espressocheck.UseVisualStyleBackColor = true;
            espressocheck.CheckedChanged += Product_CheckedChanged;
            // 
            // doublecheck
            // 
            doublecheck.AutoSize = true;
            doublecheck.Location = new Point(731, 82);
            doublecheck.Margin = new Padding(5);
            doublecheck.Name = "doublecheck";
            doublecheck.Size = new Size(220, 36);
            doublecheck.TabIndex = 14;
            doublecheck.Text = "double espresso";
            doublecheck.UseVisualStyleBackColor = true;
            doublecheck.CheckedChanged += Product_CheckedChanged;
            // 
            // turkishcheck
            // 
            turkishcheck.AutoSize = true;
            turkishcheck.Location = new Point(503, 184);
            turkishcheck.Margin = new Padding(5);
            turkishcheck.Name = "turkishcheck";
            turkishcheck.Size = new Size(170, 36);
            turkishcheck.TabIndex = 15;
            turkishcheck.Text = "turkish kafe";
            turkishcheck.UseVisualStyleBackColor = true;
            turkishcheck.CheckedChanged += Product_CheckedChanged;
            // 
            // frozencheck
            // 
            frozencheck.AutoSize = true;
            frozencheck.Location = new Point(731, 184);
            frozencheck.Margin = new Padding(5);
            frozencheck.Name = "frozencheck";
            frozencheck.Size = new Size(114, 36);
            frozencheck.TabIndex = 16;
            frozencheck.Text = "frozen";
            frozencheck.UseVisualStyleBackColor = true;
            frozencheck.CheckedChanged += Product_CheckedChanged;
            // 
            // lattecheck
            // 
            lattecheck.AutoSize = true;
            lattecheck.Location = new Point(503, 308);
            lattecheck.Margin = new Padding(5);
            lattecheck.Name = "lattecheck";
            lattecheck.Size = new Size(93, 36);
            lattecheck.TabIndex = 17;
            lattecheck.Text = "latte";
            lattecheck.UseVisualStyleBackColor = true;
            lattecheck.CheckedChanged += Product_CheckedChanged;
            // 
            // limonatacheck
            // 
            limonatacheck.AutoSize = true;
            limonatacheck.Location = new Point(731, 308);
            limonatacheck.Margin = new Padding(5);
            limonatacheck.Name = "limonatacheck";
            limonatacheck.Size = new Size(139, 36);
            limonatacheck.TabIndex = 18;
            limonatacheck.Text = "limonata";
            limonatacheck.UseVisualStyleBackColor = true;
            limonatacheck.CheckedChanged += Product_CheckedChanged;
            // 
            // viewbtn
            // 
            viewbtn.BackColor = Color.Gold;
            viewbtn.Location = new Point(621, 470);
            viewbtn.Name = "viewbtn";
            viewbtn.Size = new Size(249, 77);
            viewbtn.TabIndex = 19;
            viewbtn.Text = "View list";
            viewbtn.UseVisualStyleBackColor = false;
            viewbtn.Click += viewbtn_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1537, 738);
            Controls.Add(viewbtn);
            Controls.Add(limonatacheck);
            Controls.Add(lattecheck);
            Controls.Add(frozencheck);
            Controls.Add(turkishcheck);
            Controls.Add(doublecheck);
            Controls.Add(espressocheck);
            Controls.Add(label1);
            Controls.Add(toplamlabel);
            Controls.Add(paybtn);
            Controls.Add(deletebtn);
            Controls.Add(removebtn);
            Controls.Add(orderlist);
            Margin = new Padding(2);
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
        private CheckBox espressocheck;
        private CheckBox doublecheck;
        private CheckBox turkishcheck;
        private CheckBox frozencheck;
        private CheckBox lattecheck;
        private CheckBox limonatacheck;
        private ComboBox comboBox1;
        private Button viewbtn;
    }
}