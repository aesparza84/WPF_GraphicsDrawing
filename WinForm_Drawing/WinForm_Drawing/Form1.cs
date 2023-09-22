namespace WinForm_Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
        }
    }
}