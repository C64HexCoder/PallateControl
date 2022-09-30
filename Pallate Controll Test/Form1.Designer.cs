namespace Pallate_Controll_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pallate1 = new Pallate_Control.Pallate();
            this.SuspendLayout();
            // 
            // pallate1
            // 
            this.pallate1.AutoSize = true;
            this.pallate1.Location = new System.Drawing.Point(12, 12);
            this.pallate1.Name = "pallate1";
            this.pallate1.NumOfColors = 16;
            this.pallate1.RGBVisible = true;
            this.pallate1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pallate1.Size = new System.Drawing.Size(500, 649);
            this.pallate1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 661);
            this.Controls.Add(this.pallate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pallate_Control.Pallate pallate1;
    }
}