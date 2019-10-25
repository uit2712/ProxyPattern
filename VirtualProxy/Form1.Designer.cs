namespace VirtualProxy
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlDrawingArea = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.cbbImageName = new System.Windows.Forms.ComboBox();
            this.lblImageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.pnlDrawingArea);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblImageName);
            this.splitContainer1.Panel2.Controls.Add(this.cbbImageName);
            this.splitContainer1.Panel2.Controls.Add(this.btnDraw);
            this.splitContainer1.Size = new System.Drawing.Size(669, 488);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnlDrawingArea
            // 
            this.pnlDrawingArea.AutoScroll = true;
            this.pnlDrawingArea.BackColor = System.Drawing.Color.White;
            this.pnlDrawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDrawingArea.Location = new System.Drawing.Point(0, 0);
            this.pnlDrawingArea.Name = "pnlDrawingArea";
            this.pnlDrawingArea.Size = new System.Drawing.Size(507, 488);
            this.pnlDrawingArea.TabIndex = 1;
            this.pnlDrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDrawingArea_Paint);
            // 
            // btnDraw
            // 
            this.btnDraw.AutoSize = true;
            this.btnDraw.Location = new System.Drawing.Point(3, 68);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(152, 30);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Vẽ";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // cbbImageName
            // 
            this.cbbImageName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbImageName.FormattingEnabled = true;
            this.cbbImageName.Items.AddRange(new object[] {
            "naruto",
            "narutovssasuke",
            "narutovshinata",
            "naruto_kage_bushin_no_jutsu"});
            this.cbbImageName.Location = new System.Drawing.Point(3, 34);
            this.cbbImageName.Name = "cbbImageName";
            this.cbbImageName.Size = new System.Drawing.Size(152, 28);
            this.cbbImageName.TabIndex = 1;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(3, 9);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(70, 20);
            this.lblImageName.TabIndex = 2;
            this.lblImageName.Text = "Tên hình";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 488);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlDrawingArea;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.ComboBox cbbImageName;
        private System.Windows.Forms.Label lblImageName;
    }
}

