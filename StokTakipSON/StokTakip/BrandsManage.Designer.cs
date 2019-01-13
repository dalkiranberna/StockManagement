namespace StokTakip
{
    partial class BrandsManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandsManage));
            this.lst_Brands = new System.Windows.Forms.ListBox();
            this.tb_Brand = new System.Windows.Forms.TextBox();
            this.btn_InsertBrand = new System.Windows.Forms.Button();
            this.btnDeleteBrand = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_Brands
            // 
            resources.ApplyResources(this.lst_Brands, "lst_Brands");
            this.lst_Brands.FormattingEnabled = true;
            this.lst_Brands.Name = "lst_Brands";
            // 
            // tb_Brand
            // 
            resources.ApplyResources(this.tb_Brand, "tb_Brand");
            this.tb_Brand.Name = "tb_Brand";
            // 
            // btn_InsertBrand
            // 
            resources.ApplyResources(this.btn_InsertBrand, "btn_InsertBrand");
            this.btn_InsertBrand.Name = "btn_InsertBrand";
            this.btn_InsertBrand.UseVisualStyleBackColor = true;
            this.btn_InsertBrand.Click += new System.EventHandler(this.btn_InsertBrand_Click);
            // 
            // btnDeleteBrand
            // 
            resources.ApplyResources(this.btnDeleteBrand, "btnDeleteBrand");
            this.btnDeleteBrand.Name = "btnDeleteBrand";
            this.btnDeleteBrand.UseVisualStyleBackColor = true;
            this.btnDeleteBrand.Click += new System.EventHandler(this.btnDeleteBrand_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.tb_Brand);
            this.groupBox1.Controls.Add(this.btn_InsertBrand);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BrandsManage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteBrand);
            this.Controls.Add(this.lst_Brands);
            this.Name = "BrandsManage";
            this.Load += new System.EventHandler(this.BrandsManage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Brands;
        private System.Windows.Forms.TextBox tb_Brand;
        private System.Windows.Forms.Button btn_InsertBrand;
        private System.Windows.Forms.Button btnDeleteBrand;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}