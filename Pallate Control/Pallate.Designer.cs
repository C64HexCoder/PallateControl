namespace Pallate_Control
{
    partial class Pallate
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.redNum = new System.Windows.Forms.NumericUpDown();
            this.greenNum = new System.Windows.Forms.NumericUpDown();
            this.blueNum = new System.Windows.Forms.NumericUpDown();
            this.selectedColorPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.redNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColorPb)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPanel
            // 
            this.colorPanel.AutoSize = true;
            this.colorPanel.Location = new System.Drawing.Point(0, 0);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(500, 500);
            this.colorPanel.TabIndex = 0;
            this.colorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.colorPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(74, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(219, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(379, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blue";
            // 
            // redNum
            // 
            this.redNum.Location = new System.Drawing.Point(35, 600);
            this.redNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNum.Name = "redNum";
            this.redNum.Size = new System.Drawing.Size(130, 31);
            this.redNum.TabIndex = 5;
            this.redNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // greenNum
            // 
            this.greenNum.Location = new System.Drawing.Point(190, 600);
            this.greenNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNum.Name = "greenNum";
            this.greenNum.Size = new System.Drawing.Size(130, 31);
            this.greenNum.TabIndex = 6;
            this.greenNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // blueNum
            // 
            this.blueNum.Location = new System.Drawing.Point(345, 600);
            this.blueNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNum.Name = "blueNum";
            this.blueNum.Size = new System.Drawing.Size(130, 31);
            this.blueNum.TabIndex = 7;
            this.blueNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectedColorPb
            // 
            this.selectedColorPb.Location = new System.Drawing.Point(3, 517);
            this.selectedColorPb.Name = "selectedColorPb";
            this.selectedColorPb.Size = new System.Drawing.Size(494, 52);
            this.selectedColorPb.TabIndex = 8;
            this.selectedColorPb.TabStop = false;
            // 
            // Pallate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectedColorPb);
            this.Controls.Add(this.blueNum);
            this.Controls.Add(this.greenNum);
            this.Controls.Add(this.redNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorPanel);
            this.Name = "Pallate";
            this.Size = new System.Drawing.Size(500, 664);
            this.SizeChanged += new System.EventHandler(this.Pallate_SizeChanged);
            this.Resize += new System.EventHandler(this.Pallate_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.redNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColorPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel colorPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown redNum;
        private NumericUpDown greenNum;
        private NumericUpDown blueNum;
        private PictureBox selectedColorPb;
    }
}