namespace newspaper_delivery_system
{
    partial class message
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
            this.dataList = new System.Windows.Forms.ListBox();
            this.datalist2 = new System.Windows.Forms.ListBox();
            this.option1 = new System.Windows.Forms.Button();
            this.subOption = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.option4 = new System.Windows.Forms.Button();
            this.option5 = new System.Windows.Forms.Button();
            this.option6 = new System.Windows.Forms.Button();
            this.option7 = new System.Windows.Forms.Button();
            this.option8 = new System.Windows.Forms.Button();
            this.carrierSubOption = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.householdSubOption = new System.Windows.Forms.Button();
            this.option12 = new System.Windows.Forms.Button();
            this.option11 = new System.Windows.Forms.Button();
            this.option10 = new System.Windows.Forms.Button();
            this.option9 = new System.Windows.Forms.Button();
            this.billingButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.moneyTextbox = new System.Windows.Forms.TextBox();
            this.paymentButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Publications",
            "Carriers",
            "Household Info",
            "Billing",
            "Summary Printout"});
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
            // dataList
            // 
            this.dataList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataList.FormattingEnabled = true;
            this.dataList.Location = new System.Drawing.Point(12, 178);
            this.dataList.Name = "dataList";
            this.dataList.Size = new System.Drawing.Size(969, 225);
            this.dataList.TabIndex = 4;
            this.dataList.Visible = false;
            this.dataList.SelectedIndexChanged += new System.EventHandler(this.dataList_SelectedIndexChanged);
            // 
            // datalist2
            // 
            this.datalist2.FormattingEnabled = true;
            this.datalist2.Location = new System.Drawing.Point(12, 511);
            this.datalist2.Name = "datalist2";
            this.datalist2.Size = new System.Drawing.Size(969, 186);
            this.datalist2.TabIndex = 5;
            this.datalist2.Visible = false;
            this.datalist2.SelectedIndexChanged += new System.EventHandler(this.datalist2_SelectedIndexChanged);
            // 
            // option1
            // 
            this.option1.Location = new System.Drawing.Point(1040, 210);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(149, 52);
            this.option1.TabIndex = 6;
            this.option1.Text = "Add New Subscription";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.Visible = false;
            this.option1.Click += new System.EventHandler(this.option1_Click);
            // 
            // subOption
            // 
            this.subOption.Location = new System.Drawing.Point(435, 430);
            this.subOption.Name = "subOption";
            this.subOption.Size = new System.Drawing.Size(153, 50);
            this.subOption.TabIndex = 7;
            this.subOption.UseVisualStyleBackColor = true;
            this.subOption.Visible = false;
            this.subOption.Click += new System.EventHandler(this.addSub_Click);
            // 
            // option2
            // 
            this.option2.Location = new System.Drawing.Point(1040, 645);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(149, 52);
            this.option2.TabIndex = 8;
            this.option2.Text = "Display House\' Sub List";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.Visible = false;
            this.option2.Click += new System.EventHandler(this.option2_Click);
            // 
            // option3
            // 
            this.option3.Location = new System.Drawing.Point(1040, 355);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(149, 52);
            this.option3.TabIndex = 9;
            this.option3.Text = "Remove a Subscription";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.Visible = false;
            this.option3.Click += new System.EventHandler(this.option3_Click);
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.Location = new System.Drawing.Point(-1, 15);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(780, 23);
            this.messageBox.TabIndex = 10;
            this.messageBox.Text = "label1";
            this.messageBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.messageBox);
            this.panel1.Location = new System.Drawing.Point(252, 772);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 55);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // option4
            // 
            this.option4.Location = new System.Drawing.Point(1040, 500);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(149, 52);
            this.option4.TabIndex = 12;
            this.option4.Text = "Has Subscription";
            this.option4.UseVisualStyleBackColor = true;
            this.option4.Visible = false;
            this.option4.Click += new System.EventHandler(this.option4_Click);
            // 
            // option5
            // 
            this.option5.Location = new System.Drawing.Point(874, 210);
            this.option5.Name = "option5";
            this.option5.Size = new System.Drawing.Size(149, 52);
            this.option5.TabIndex = 13;
            this.option5.Text = "Carrier Routes";
            this.option5.UseVisualStyleBackColor = true;
            this.option5.Visible = false;
            this.option5.Click += new System.EventHandler(this.option5_Click);
            // 
            // option6
            // 
            this.option6.Location = new System.Drawing.Point(874, 355);
            this.option6.Name = "option6";
            this.option6.Size = new System.Drawing.Size(149, 52);
            this.option6.TabIndex = 14;
            this.option6.Text = "Add Carrier";
            this.option6.UseVisualStyleBackColor = true;
            this.option6.Visible = false;
            this.option6.Click += new System.EventHandler(this.option6_Click);
            // 
            // option7
            // 
            this.option7.Location = new System.Drawing.Point(874, 500);
            this.option7.Name = "option7";
            this.option7.Size = new System.Drawing.Size(149, 52);
            this.option7.TabIndex = 15;
            this.option7.Text = "Remove Carrier";
            this.option7.UseVisualStyleBackColor = true;
            this.option7.Visible = false;
            this.option7.Click += new System.EventHandler(this.option7_Click);
            // 
            // option8
            // 
            this.option8.Location = new System.Drawing.Point(874, 645);
            this.option8.Name = "option8";
            this.option8.Size = new System.Drawing.Size(149, 52);
            this.option8.TabIndex = 16;
            this.option8.Text = "Modify Existing Info";
            this.option8.UseVisualStyleBackColor = true;
            this.option8.Visible = false;
            this.option8.Click += new System.EventHandler(this.option8_Click);
            // 
            // carrierSubOption
            // 
            this.carrierSubOption.Location = new System.Drawing.Point(613, 430);
            this.carrierSubOption.Name = "carrierSubOption";
            this.carrierSubOption.Size = new System.Drawing.Size(153, 50);
            this.carrierSubOption.TabIndex = 17;
            this.carrierSubOption.UseVisualStyleBackColor = true;
            this.carrierSubOption.Visible = false;
            this.carrierSubOption.Click += new System.EventHandler(this.carrierSubOption_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 573);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 20);
            this.textBox1.TabIndex = 18;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 599);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 20);
            this.textBox2.TabIndex = 19;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(315, 625);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(273, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(148, 573);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(140, 23);
            this.nameLabel.TabIndex = 21;
            this.nameLabel.Text = "Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nameLabel.Visible = false;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(148, 599);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(140, 23);
            this.phoneLabel.TabIndex = 22;
            this.phoneLabel.Text = "Phone Number:";
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.phoneLabel.Visible = false;
            this.phoneLabel.Click += new System.EventHandler(this.phoneLabel_Click);
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(148, 625);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(140, 23);
            this.addressLabel.TabIndex = 23;
            this.addressLabel.Text = "Address:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addressLabel.Visible = false;
            this.addressLabel.Click += new System.EventHandler(this.addressLabel_Click);
            // 
            // householdSubOption
            // 
            this.householdSubOption.Location = new System.Drawing.Point(261, 430);
            this.householdSubOption.Name = "householdSubOption";
            this.householdSubOption.Size = new System.Drawing.Size(153, 50);
            this.householdSubOption.TabIndex = 24;
            this.householdSubOption.UseVisualStyleBackColor = true;
            this.householdSubOption.Visible = false;
            // 
            // option12
            // 
            this.option12.Location = new System.Drawing.Point(1123, 645);
            this.option12.Name = "option12";
            this.option12.Size = new System.Drawing.Size(149, 52);
            this.option12.TabIndex = 25;
            this.option12.Text = "Suspend/Unsuspend Household";
            this.option12.UseVisualStyleBackColor = true;
            this.option12.Visible = false;
            // 
            // option11
            // 
            this.option11.Location = new System.Drawing.Point(1123, 500);
            this.option11.Name = "option11";
            this.option11.Size = new System.Drawing.Size(149, 52);
            this.option11.TabIndex = 26;
            this.option11.Text = "Modify Household Info";
            this.option11.UseVisualStyleBackColor = true;
            this.option11.Visible = false;
            // 
            // option10
            // 
            this.option10.Location = new System.Drawing.Point(1123, 355);
            this.option10.Name = "option10";
            this.option10.Size = new System.Drawing.Size(149, 52);
            this.option10.TabIndex = 27;
            this.option10.Text = "Delete Household";
            this.option10.UseVisualStyleBackColor = true;
            this.option10.Visible = false;
            // 
            // option9
            // 
            this.option9.Location = new System.Drawing.Point(1123, 210);
            this.option9.Name = "option9";
            this.option9.Size = new System.Drawing.Size(149, 52);
            this.option9.TabIndex = 28;
            this.option9.Text = "Add Household";
            this.option9.UseVisualStyleBackColor = true;
            this.option9.Visible = false;
            // 
            // billingButton
            // 
            this.billingButton.Location = new System.Drawing.Point(88, 430);
            this.billingButton.Name = "billingButton";
            this.billingButton.Size = new System.Drawing.Size(153, 50);
            this.billingButton.TabIndex = 29;
            this.billingButton.UseVisualStyleBackColor = true;
            this.billingButton.Visible = false;
            // 
            // moneyLabel
            // 
            this.moneyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.moneyLabel.Location = new System.Drawing.Point(870, 446);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(187, 23);
            this.moneyLabel.TabIndex = 30;
            this.moneyLabel.Text = "Input Amount Paid:";
            this.moneyLabel.Visible = false;
            // 
            // moneyTextbox
            // 
            this.moneyTextbox.Location = new System.Drawing.Point(1066, 446);
            this.moneyTextbox.Name = "moneyTextbox";
            this.moneyTextbox.Size = new System.Drawing.Size(206, 20);
            this.moneyTextbox.TabIndex = 31;
            this.moneyTextbox.Visible = false;
            // 
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.paymentButton.Location = new System.Drawing.Point(1000, 483);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(125, 35);
            this.paymentButton.TabIndex = 32;
            this.paymentButton.Text = "Update Bill";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Visible = false;
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(345, 430);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(153, 50);
            this.summaryButton.TabIndex = 33;
            this.summaryButton.Text = "View Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Visible = false;
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 865);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.moneyTextbox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.billingButton);
            this.Controls.Add(this.option9);
            this.Controls.Add(this.option10);
            this.Controls.Add(this.option11);
            this.Controls.Add(this.option12);
            this.Controls.Add(this.householdSubOption);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.carrierSubOption);
            this.Controls.Add(this.option8);
            this.Controls.Add(this.option7);
            this.Controls.Add(this.option6);
            this.Controls.Add(this.option5);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.subOption);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.datalist2);
            this.Controls.Add(this.dataList);
            this.Controls.Add(this.welcomelabel2);
            this.Controls.Add(this.Welcomelabel);
            this.Controls.Add(this.comboBox1);
            this.Name = "message";
            this.Text = "Name:";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Label welcomelabel2;
        private System.Windows.Forms.ListBox dataList;
        private System.Windows.Forms.ListBox datalist2;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button subOption;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
        private System.Windows.Forms.Label messageBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button option4;
        private System.Windows.Forms.Button option5;
        private System.Windows.Forms.Button option6;
        private System.Windows.Forms.Button option7;
        private System.Windows.Forms.Button option8;
        private System.Windows.Forms.Button carrierSubOption;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button householdSubOption;
        private System.Windows.Forms.Button option12;
        private System.Windows.Forms.Button option11;
        private System.Windows.Forms.Button option10;
        private System.Windows.Forms.Button option9;
        private System.Windows.Forms.Button billingButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox moneyTextbox;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Button summaryButton;
    }
}

