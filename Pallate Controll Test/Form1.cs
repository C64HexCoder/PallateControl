namespace Pallate_Controll_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pallate1_ColorSelected(object sender, Pallate_Control.Pallate.SelectedColorEventArgs e)
        {
            selectedColorPb.BackColor = e.Color;
        }
    }
}