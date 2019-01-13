namespace StokTakip
{
    partial class AddPhone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPhone));
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.tbPhoneName = new System.Windows.Forms.TextBox();
            this.tbModelCode = new System.Windows.Forms.TextBox();
            this.tbIMEI1 = new System.Windows.Forms.TextBox();
            this.tbIMEI2 = new System.Windows.Forms.TextBox();
            this.nupPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdPhone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxBrand
            // 
            resources.ApplyResources(this.cbxBrand, "cbxBrand");
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Name = "cbxBrand";
            // 
            // tbPhoneName
            // 
            resources.ApplyResources(this.tbPhoneName, "tbPhoneName");
            this.tbPhoneName.Name = "tbPhoneName";
            // 
            // tbModelCode
            // 
            resources.ApplyResources(this.tbModelCode, "tbModelCode");
            this.tbModelCode.Name = "tbModelCode";
            // 
            // tbIMEI1
            // 
            resources.ApplyResources(this.tbIMEI1, "tbIMEI1");
            this.tbIMEI1.Name = "tbIMEI1";
            // 
            // tbIMEI2
            // 
            resources.ApplyResources(this.tbIMEI2, "tbIMEI2");
            this.tbIMEI2.Name = "tbIMEI2";
            // 
            // nupPrice
            // 
            resources.ApplyResources(this.nupPrice, "nupPrice");
            this.nupPrice.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupPrice.Name = "nupPrice";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnClear
            // 
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAdPhone
            // 
            resources.ApplyResources(this.btnAdPhone, "btnAdPhone");
            this.btnAdPhone.Name = "btnAdPhone";
            this.btnAdPhone.UseVisualStyleBackColor = true;
            this.btnAdPhone.Click += new System.EventHandler(this.btnAdPhone_Click);
            // 
            // AddPhone
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdPhone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupPrice);
            this.Controls.Add(this.tbIMEI2);
            this.Controls.Add(this.tbIMEI1);
            this.Controls.Add(this.tbModelCode);
            this.Controls.Add(this.tbPhoneName);
            this.Controls.Add(this.cbxBrand);
            this.Name = "AddPhone";
            this.Load += new System.EventHandler(this.AddPhone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.TextBox tbPhoneName;
        private System.Windows.Forms.TextBox tbModelCode;
        private System.Windows.Forms.TextBox tbIMEI1;
        private System.Windows.Forms.TextBox tbIMEI2;
        private System.Windows.Forms.NumericUpDown nupPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdPhone;
    }
}