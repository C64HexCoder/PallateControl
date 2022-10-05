using System;
using System.Drawing;
using System.Reflection;


namespace Pallate_Control
{
    public partial class Pallate : UserControl
    {

        public int _NumOfColors = 4;
        public Color[] Colors = new Color[256];
        // 0 1 2 3 4  5  6  7
        byte[] Yarray = { 1, 2, 2, 4, 4, 8, 8, 16, 16 };
        byte[] Xarray = { 1, 1, 2, 2, 4, 4, 8, 8, 16 };
        public Color _SelectedColor;
        public int SelectedColorARGB;
        int[] ColorDialogCustomColors;
        public bool _SelectedColorBox;
        int NumOfCellsX;
        int NumOfCellsY;

        public event EventHandler<SelectedColorEventArgs> ColorSelected;

        public class SelectedColorEventArgs : EventArgs
        {
            public Color Color;
            public int colorIndex;
        }

        protected virtual void OnColorSelected (SelectedColorEventArgs e)
        {
            EventHandler<SelectedColorEventArgs> eventHandler = ColorSelected;

            if (eventHandler != null)
            {
                eventHandler (this, e);
            }
        }


        byte _Red, _Green, _Blue;
        public bool RGBVisible
        {
            set
            {
                redNum.Visible = value;
                greenNum.Visible = value;
                blueNum.Visible = value;
                RedLbl.Visible = value;
                GreenLbl.Visible = value;
                BlueLbl.Visible = value;
            }
            get { return redNum.Visible; }
        }

        byte Red => _Red;
        byte Green => _Green;
        byte Blue => _Blue;


        public Color SelectedColor
        {
            get { return _SelectedColor; }
            set {
                _SelectedColor = value;
                SelectedColorARGB = value.ToArgb();
            }
        }

        public int NumOfColors
        {
            get { return _NumOfColors; }
            set {
                _NumOfColors = value;
                colorPanel.Controls.Clear();
                colorPanel.Refresh();
            }
        }

        public bool SelectedColorBox {
            set
            {
                selectedColorPb.Visible = value;
                _SelectedColorBox = value;
            }
            get
            {
                return selectedColorPb.Enabled;
            }
        }

        public Pallate()
        {
            InitializeComponent();
            Random rnd = new Random();

            
          

            for (int i = 0; i < NumOfColors; i++)
            {
                    Colors[i] = Color.FromArgb(rnd.Next (255),rnd.Next(255), rnd.Next(255));
            }

        }

        private void colorPanel_Resize(object sender, EventArgs e)
        {
            Panel panel = ((Panel)sender);
            foreach (PictureBox c in panel.Controls)
            {
                c.Width = panel.Width/NumOfCellsX;
                c.Height = panel.Height/NumOfCellsY;
            }
            panel.Invalidate();
        }

        private void colorPanel_Paint(object sender, PaintEventArgs e)
        {
            //int RawAndClomn = (int)Math.Sqrt(NumOfColors);
            int index = (int)(Math.Log(NumOfColors) / Math.Log(2));
            NumOfCellsX = Xarray[index];
            NumOfCellsY = Yarray[index];

            for (int y = 0; y < NumOfCellsY; y++)
            {
                for (int x = 0; x < NumOfCellsX; x++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(colorPanel.Width / NumOfCellsX, colorPanel.Height / NumOfCellsY);
                    pictureBox.BackColor = Colors[y * (NumOfCellsX) + x];
                    pictureBox.MouseClick += ColorMouseClick;
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.Tag = y * NumOfCellsX + x;
                    pictureBox.Location = new Point(colorPanel.Width / NumOfCellsX * x, colorPanel.Height / NumOfCellsY * y);

                    ControlPaint.DrawBorder(e.Graphics, pictureBox.ClientRectangle, Color.Blue, ButtonBorderStyle.Solid);
                    ((Panel)sender).Controls.Add(pictureBox);
                }
            }
        }

        private void ColorMouseClick(object? sender, MouseEventArgs e)
        {
            PictureBox pickedColor = (PictureBox)sender;
            int index = int.Parse(pickedColor.Tag.ToString());

            if (e.Button == MouseButtons.Right && !(pickedColor.Tag.ToString() == "0"))
            {
                ColorDialog colorDialog = new ColorDialog();

                if (ColorDialogCustomColors != null)
                    colorDialog.CustomColors = ColorDialogCustomColors;

                colorDialog.Color = pickedColor.BackColor;
                colorDialog.FullOpen = true;
                colorDialog.AnyColor = true;
                colorDialog.SolidColorOnly = false;
                colorDialog.ShowDialog();
                ColorDialogCustomColors = colorDialog.CustomColors;
                // Color3P.BackColor = colorDialog.Color;
                pickedColor.BackColor = colorDialog.Color;

                Colors[int.Parse(pickedColor.Tag.ToString())] = pickedColor.BackColor;
                //Colors[int.Parse((pictureBox.Tag.ToString()))] = pictureBox.BackColor;

            }

            SelectedColor = Colors[index];

            selectedColorPb.BackColor = SelectedColor;

            redNum.Value = SelectedColor.R;
            greenNum.Value = SelectedColor.G;
            blueNum.Value = SelectedColor.B;


            SelectedColorEventArgs args = new SelectedColorEventArgs();
            args.Color = SelectedColor;
            args.colorIndex = index;

            OnColorSelected(args);
        }
    }
}