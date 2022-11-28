namespace Time
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
            this.lbDongHo = new System.Windows.Forms.Label();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCaiDat = new System.Windows.Forms.ToolStripMenuItem();
            this.tácGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDongHo
            // 
            this.lbDongHo.AutoSize = true;
            this.lbDongHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDongHo.Location = new System.Drawing.Point(221, 89);
            this.lbDongHo.Name = "lbDongHo";
            this.lbDongHo.Size = new System.Drawing.Size(135, 51);
            this.lbDongHo.TabIndex = 0;
            this.lbDongHo.Text = "00:00";
            this.lbDongHo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.Location = new System.Drawing.Point(111, 235);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(142, 59);
            this.btnDongY.TabIndex = 1;
            this.btnDongY.Text = "Start";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.Location = new System.Drawing.Point(329, 235);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(142, 59);
            this.btnBoQua.TabIndex = 2;
            this.btnBoQua.Text = "Stop";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCaiDat,
            this.tácGiảToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 52);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(127, 24);
            this.btnCaiDat.Text = "Cài Đặt";
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // tácGiảToolStripMenuItem
            // 
            this.tácGiảToolStripMenuItem.Name = "tácGiảToolStripMenuItem";
            this.tácGiảToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.tácGiảToolStripMenuItem.Text = "Tác Giả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 377);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.lbDongHo);
            this.Name = "Form1";
            this.Text = "TimeRun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDongHo;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCaiDat;
        private System.Windows.Forms.ToolStripMenuItem tácGiảToolStripMenuItem;
    }
}

