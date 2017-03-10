namespace Example03
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.product1Button = new System.Windows.Forms.Button();
            this.product2Button = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.orderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.payButton = new System.Windows.Forms.Button();
            this.tablecomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // product1Button
            // 
            this.product1Button.Location = new System.Drawing.Point(236, 14);
            this.product1Button.Name = "product1Button";
            this.product1Button.Size = new System.Drawing.Size(164, 92);
            this.product1Button.TabIndex = 0;
            this.product1Button.Text = "button1";
            this.product1Button.UseVisualStyleBackColor = true;
            this.product1Button.Click += new System.EventHandler(this.product1Button_Click);
            // 
            // product2Button
            // 
            this.product2Button.Location = new System.Drawing.Point(406, 14);
            this.product2Button.Name = "product2Button";
            this.product2Button.Size = new System.Drawing.Size(157, 92);
            this.product2Button.TabIndex = 1;
            this.product2Button.Text = "button2";
            this.product2Button.UseVisualStyleBackColor = true;
            this.product2Button.Click += new System.EventHandler(this.product2Button_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(60, 88);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(50, 18);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "label1";
            // 
            // orderRichTextBox
            // 
            this.orderRichTextBox.Location = new System.Drawing.Point(50, 253);
            this.orderRichTextBox.Name = "orderRichTextBox";
            this.orderRichTextBox.Size = new System.Drawing.Size(520, 192);
            this.orderRichTextBox.TabIndex = 3;
            this.orderRichTextBox.Text = "";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(50, 141);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(171, 92);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "button1";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // payButton
            // 
            this.payButton.Location = new System.Drawing.Point(236, 141);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(164, 92);
            this.payButton.TabIndex = 5;
            this.payButton.Text = "button1";
            this.payButton.UseVisualStyleBackColor = true;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // tablecomboBox
            // 
            this.tablecomboBox.FormattingEnabled = true;
            this.tablecomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.tablecomboBox.Location = new System.Drawing.Point(50, 24);
            this.tablecomboBox.Name = "tablecomboBox";
            this.tablecomboBox.Size = new System.Drawing.Size(142, 26);
            this.tablecomboBox.TabIndex = 6;
            this.tablecomboBox.SelectedIndexChanged += new System.EventHandler(this.tablecomboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 468);
            this.Controls.Add(this.tablecomboBox);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.orderRichTextBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.product2Button);
            this.Controls.Add(this.product1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button product1Button;
        private System.Windows.Forms.Button product2Button;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.RichTextBox orderRichTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button payButton;
        private System.Windows.Forms.ComboBox tablecomboBox;
    }
}

