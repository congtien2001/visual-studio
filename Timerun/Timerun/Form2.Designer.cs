namespace Timerun
{
    partial class SettingForm
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
            this.numSoPhut = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhut)).BeginInit();
            this.SuspendLayout();
            // 
            // numSoPhut
            // 
            this.numSoPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoPhut.Location = new System.Drawing.Point(238, 99);
            this.numSoPhut.Name = "numSoPhut";
            this.numSoPhut.Size = new System.Drawing.Size(226, 38);
            this.numSoPhut.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian(phút)";
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(238, 210);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(104, 45);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "ok";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.Location = new System.Drawing.Point(360, 210);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(104, 45);
            this.btnBoQua.TabIndex = 3;
            this.btnBoQua.Text = "bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(543, 312);
            this.ControlBox = false;
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numSoPhut);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoPhut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSoPhut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}