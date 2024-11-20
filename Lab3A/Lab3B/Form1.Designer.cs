namespace Lab3B
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hairDressersList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.servicesList = new System.Windows.Forms.ListBox();
            this.serviceBtn = new System.Windows.Forms.Button();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.chargedList = new System.Windows.Forms.ListBox();
            this.totalPriceList = new System.Windows.Forms.ListBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hairDressersList);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hair Dresser";
            // 
            // hairDressersList
            // 
            this.hairDressersList.FormattingEnabled = true;
            this.hairDressersList.Location = new System.Drawing.Point(3, 16);
            this.hairDressersList.Name = "hairDressersList";
            this.hairDressersList.Size = new System.Drawing.Size(260, 21);
            this.hairDressersList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.servicesList);
            this.groupBox2.Location = new System.Drawing.Point(315, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service";
            // 
            // servicesList
            // 
            this.servicesList.FormattingEnabled = true;
            this.servicesList.Location = new System.Drawing.Point(3, 16);
            this.servicesList.Name = "servicesList";
            this.servicesList.Size = new System.Drawing.Size(260, 238);
            this.servicesList.TabIndex = 0;
            this.servicesList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // serviceBtn
            // 
            this.serviceBtn.Enabled = false;
            this.serviceBtn.Location = new System.Drawing.Point(10, 330);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Size = new System.Drawing.Size(160, 25);
            this.serviceBtn.TabIndex = 2;
            this.serviceBtn.Text = "Add a service";
            this.serviceBtn.UseVisualStyleBackColor = true;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Enabled = false;
            this.calculateBtn.Location = new System.Drawing.Point(180, 329);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(160, 25);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate Total Price";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(350, 330);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(160, 25);
            this.resetBtn.TabIndex = 4;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(520, 330);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(160, 25);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // chargedList
            // 
            this.chargedList.FormattingEnabled = true;
            this.chargedList.Location = new System.Drawing.Point(10, 410);
            this.chargedList.Name = "chargedList";
            this.chargedList.Size = new System.Drawing.Size(300, 290);
            this.chargedList.TabIndex = 6;
            // 
            // totalPriceList
            // 
            this.totalPriceList.FormattingEnabled = true;
            this.totalPriceList.Location = new System.Drawing.Point(315, 410);
            this.totalPriceList.Name = "totalPriceList";
            this.totalPriceList.Size = new System.Drawing.Size(300, 290);
            this.totalPriceList.TabIndex = 7;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.Location = new System.Drawing.Point(625, 410);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(200, 25);
            this.totalPriceLabel.TabIndex = 8;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 749);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPriceList);
            this.Controls.Add(this.chargedList);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.serviceBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Hair Perfect Cut Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox hairDressersList;
        private System.Windows.Forms.ListBox servicesList;
        private System.Windows.Forms.Button serviceBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ListBox chargedList;
        private System.Windows.Forms.ListBox totalPriceList;
        private System.Windows.Forms.Label totalPriceLabel;
    }
}

