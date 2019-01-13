namespace StokTakip
{
    partial class PhoneCaseManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneCaseManage));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_phoneCaseAdd = new System.Windows.Forms.Button();
            this.btn_DeleteCase = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // btn_phoneCaseAdd
            // 
            resources.ApplyResources(this.btn_phoneCaseAdd, "btn_phoneCaseAdd");
            this.btn_phoneCaseAdd.Name = "btn_phoneCaseAdd";
            this.btn_phoneCaseAdd.UseVisualStyleBackColor = true;
            this.btn_phoneCaseAdd.Click += new System.EventHandler(this.btn_phoneCaseAdd_Click);
            // 
            // btn_DeleteCase
            // 
            resources.ApplyResources(this.btn_DeleteCase, "btn_DeleteCase");
            this.btn_DeleteCase.Name = "btn_DeleteCase";
            this.btn_DeleteCase.UseVisualStyleBackColor = true;
            this.btn_DeleteCase.Click += new System.EventHandler(this.btn_DeleteCase_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneCaseManage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_DeleteCase);
            this.Controls.Add(this.btn_phoneCaseAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PhoneCaseManage";
            this.Load += new System.EventHandler(this.PhoneCaseManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_phoneCaseAdd;
        private System.Windows.Forms.Button btn_DeleteCase;
        private System.Windows.Forms.Button button1;
    }
}