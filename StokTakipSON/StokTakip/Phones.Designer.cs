namespace StokTakip
{
    partial class Phones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phones));
            this.btnDeletePhone = new System.Windows.Forms.Button();
            this.btnCreatePhone = new System.Windows.Forms.Button();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.cbxBrands = new System.Windows.Forms.ComboBox();
            this.grid_phones = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_phones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletePhone
            // 
            resources.ApplyResources(this.btnDeletePhone, "btnDeletePhone");
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.UseVisualStyleBackColor = true;
            this.btnDeletePhone.Click += new System.EventHandler(this.btnDeletePhone_Click);
            // 
            // btnCreatePhone
            // 
            resources.ApplyResources(this.btnCreatePhone, "btnCreatePhone");
            this.btnCreatePhone.Name = "btnCreatePhone";
            this.btnCreatePhone.UseVisualStyleBackColor = true;
            this.btnCreatePhone.Click += new System.EventHandler(this.btnCreatePhone_Click);
            // 
            // txtModel
            // 
            resources.ApplyResources(this.txtModel, "txtModel");
            this.txtModel.Name = "txtModel";
            // 
            // cbxBrands
            // 
            resources.ApplyResources(this.cbxBrands, "cbxBrands");
            this.cbxBrands.FormattingEnabled = true;
            this.cbxBrands.Name = "cbxBrands";
            // 
            // grid_phones
            // 
            resources.ApplyResources(this.grid_phones, "grid_phones");
            this.grid_phones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_phones.Name = "grid_phones";
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            resources.ApplyResources(this.btn_Search, "btn_Search");
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // Phones
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDeletePhone);
            this.Controls.Add(this.btnCreatePhone);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.cbxBrands);
            this.Controls.Add(this.grid_phones);
            this.Name = "Phones";
            this.Load += new System.EventHandler(this.Phones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_phones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletePhone;
        private System.Windows.Forms.Button btnCreatePhone;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.ComboBox cbxBrands;
        private System.Windows.Forms.DataGridView grid_phones;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn_Search;
    }
}