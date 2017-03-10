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
            this.SuspendLayout();
            // 
            // product1Button
            // 
            this.product1Button.Location = new System.Drawing.Point(50, 143);
            this.product1Button.Name = "product1Button";
            this.product1Button.Size = new System.Drawing.Size(194, 92);
            this.product1Button.TabIndex = 0;
            this.product1Button.Text = "button1";
            this.product1Button.UseVisualStyleBackColor = true;
            // 
            // product2Button
            // 
            this.product2Button.Location = new System.Drawing.Point(250, 143);
            this.product2Button.Name = "product2Button";
            this.product2Button.Size = new System.Drawing.Size(191, 92);
            this.product2Button.TabIndex = 1;
            this.product2Button.Text = "button2";
            this.product2Button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 468);
            this.Controls.Add(this.product2Button);
            this.Controls.Add(this.product1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button product1Button;
        private System.Windows.Forms.Button product2Button;
    }
}

