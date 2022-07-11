namespace eClerx.Question2.Kallem
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
            this.LblCustomerCity = new System.Windows.Forms.Label();
            this.LblSortBy = new System.Windows.Forms.Label();
            this.TxtCustomerCity = new System.Windows.Forms.TextBox();
            this.ComboSortBy = new System.Windows.Forms.ComboBox();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.GridCustomerInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomerInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCustomerCity
            // 
            this.LblCustomerCity.AutoSize = true;
            this.LblCustomerCity.Location = new System.Drawing.Point(181, 50);
            this.LblCustomerCity.Name = "LblCustomerCity";
            this.LblCustomerCity.Size = new System.Drawing.Size(71, 13);
            this.LblCustomerCity.TabIndex = 0;
            this.LblCustomerCity.Text = "Customer City";
            // 
            // LblSortBy
            // 
            this.LblSortBy.AutoSize = true;
            this.LblSortBy.Location = new System.Drawing.Point(181, 83);
            this.LblSortBy.Name = "LblSortBy";
            this.LblSortBy.Size = new System.Drawing.Size(41, 13);
            this.LblSortBy.TabIndex = 1;
            this.LblSortBy.Text = "Sort By";
            // 
            // TxtCustomerCity
            // 
            this.TxtCustomerCity.Location = new System.Drawing.Point(309, 50);
            this.TxtCustomerCity.Name = "TxtCustomerCity";
            this.TxtCustomerCity.Size = new System.Drawing.Size(159, 20);
            this.TxtCustomerCity.TabIndex = 2;
            // 
            // ComboSortBy
            // 
            this.ComboSortBy.FormattingEnabled = true;
            this.ComboSortBy.Location = new System.Drawing.Point(309, 80);
            this.ComboSortBy.Name = "ComboSortBy";
            this.ComboSortBy.Size = new System.Drawing.Size(159, 21);
            this.ComboSortBy.TabIndex = 3;
            // 
            // BtnGetData
            // 
            this.BtnGetData.Location = new System.Drawing.Point(564, 45);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(75, 23);
            this.BtnGetData.TabIndex = 4;
            this.BtnGetData.Text = "Get Data";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // GridCustomerInfo
            // 
            this.GridCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCustomerInfo.Location = new System.Drawing.Point(12, 126);
            this.GridCustomerInfo.Name = "GridCustomerInfo";
            this.GridCustomerInfo.Size = new System.Drawing.Size(731, 209);
            this.GridCustomerInfo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridCustomerInfo);
            this.Controls.Add(this.BtnGetData);
            this.Controls.Add(this.ComboSortBy);
            this.Controls.Add(this.TxtCustomerCity);
            this.Controls.Add(this.LblSortBy);
            this.Controls.Add(this.LblCustomerCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCustomerInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCustomerCity;
        private System.Windows.Forms.Label LblSortBy;
        private System.Windows.Forms.TextBox TxtCustomerCity;
        private System.Windows.Forms.ComboBox ComboSortBy;
        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.DataGridView GridCustomerInfo;
    }
}

