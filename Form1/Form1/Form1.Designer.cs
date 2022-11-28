namespace Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.gridGiangVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnThongTinGiangVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khoa:";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(105, 41);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(121, 24);
            this.cbbKhoa.TabIndex = 1;
            this.cbbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbbKhoa_SelectedIndexChanged);
            // 
            // gridGiangVien
            // 
            this.gridGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGiangVien.Location = new System.Drawing.Point(12, 95);
            this.gridGiangVien.Name = "gridGiangVien";
            this.gridGiangVien.RowHeadersWidth = 51;
            this.gridGiangVien.RowTemplate.Height = 24;
            this.gridGiangVien.Size = new System.Drawing.Size(795, 343);
            this.gridGiangVien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách giảng viên:";
            // 
            // btnThongTinGiangVien
            // 
            this.btnThongTinGiangVien.Location = new System.Drawing.Point(404, 44);
            this.btnThongTinGiangVien.Name = "btnThongTinGiangVien";
            this.btnThongTinGiangVien.Size = new System.Drawing.Size(190, 23);
            this.btnThongTinGiangVien.TabIndex = 4;
            this.btnThongTinGiangVien.Text = "Thông Tin Giảng Viên";
            this.btnThongTinGiangVien.UseVisualStyleBackColor = true;
            this.btnThongTinGiangVien.Click += new System.EventHandler(this.btnThongTinGiangVien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.btnThongTinGiangVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridGiangVien);
            this.Controls.Add(this.cbbKhoa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.DataGridView gridGiangVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.Button btnThongTinGiangVien;
    }
}

