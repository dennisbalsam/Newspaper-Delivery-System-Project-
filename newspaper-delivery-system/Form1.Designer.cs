namespace newspaper_delivery_system
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.welcomelabel2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataList = new System.Windows.Forms.ListBox();
            this.datalist2 = new System.Windows.Forms.ListBox();
            this.option1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Household Info",
            "Carriers",
            "Publications"});
            this.comboBox1.Location = new System.Drawing.Point(261, 107);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(762, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelabel.Location = new System.Drawing.Point(401, 24);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(483, 23);
            this.Welcomelabel.TabIndex = 1;
            this.Welcomelabel.Text = "Welcome to the Newspaper Delivery System";
            this.Welcomelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Welcomelabel.Click += new System.EventHandler(this.Welcomelabel_Click);
            // 
            // welcomelabel2
            // 
            this.welcomelabel2.AutoSize = true;
            this.welcomelabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel2.Location = new System.Drawing.Point(544, 57);
            this.welcomelabel2.Name = "welcomelabel2";
            this.welcomelabel2.Size = new System.Drawing.Size(196, 20);
            this.welcomelabel2.TabIndex = 2;
            this.welcomelabel2.Text = "Please select an option";
            this.welcomelabel2.Click += new System.EventHandler(this.welcomelabel2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataList
            // 
            this.dataList.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.dataList.FormattingEnabled = true;
            this.dataList.Location = new System.Drawing.Point(69, 234);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(671, 173);
            this.dataList.TabIndex = 4;
            this.dataList.Visible = false;
            this.dataList.SelectedIndexChanged += new System.EventHandler(this.dataList_SelectedIndexChanged);
            // 
            // datalist2
            // 
            this.datalist2.FormattingEnabled = true;
            this.datalist2.Location = new System.Drawing.Point(69, 446);
            this.datalist2.Name = "datalist2";
            this.datalist2.Size = new System.Drawing.Size(671, 173);
            this.datalist2.TabIndex = 5;
            this.datalist2.Visible = false;
            this.datalist2.SelectedIndexChanged += new System.EventHandler(this.datalist2_SelectedIndexChanged);
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(915, 234);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(149, 52);
            this.option1.TabIndex = 6;
            this.option1.Text = "button2";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Visible = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 669);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.datalist2);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.welcomelabel2);
            this.Controls.Add(this.Welcomelabel);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Label welcomelabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.ListBox datalist2;
        private System.Windows.Forms.Button option1;
    }
}

