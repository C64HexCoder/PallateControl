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
            this.selectedColorPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColorPb)).BeginInit();
            this.SuspendLayout();
            // 
            // pallate1
            // 
            this.pallate1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pallate1.Location = new System.Drawing.Point(88, 87);
            this.pallate1.Name = "pallate1";
            this.pallate1.NumOfColors = 4;
            this.pallate1.RGBVisible = false;
            this.pallate1.SelectedColor = System.Drawing.Color.Empty;
            this.pallate1.SelectedColorBox = true;
            this.pallate1.Size = new System.Drawing.Size(346, 510);
            this.pallate1.TabIndex = 0;
            this.pallate1.ColorSelected += new System.EventHandler<Pallate_Control.Pallate.SelectedColorEventArgs>(this.pallate1_ColorSelected);
            // 
            // selectedColorPb
            // 
            this.selectedColorPb.Location = new System.Drawing.Point(88, 641);
            this.selectedColorPb.Name = "selectedColorPb";
            this.selectedColorPb.Size = new System.Drawing.Size(346, 60);
            this.selectedColorPb.TabIndex = 1;
            this.selectedColorPb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 802);
            this.Controls.Add(this.selectedColorPb);
            this.Controls.Add(this.pallate1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.selectedColorPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Pallate_Control.Pallate pallate1;
        private PictureBox selectedColorPb;
    }
}