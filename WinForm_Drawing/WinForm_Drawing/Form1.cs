using System.Numerics;

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

            Brush tealBrush = new SolidBrush(Color.Teal);
            Brush orangeBrush = new SolidBrush(Color.DarkOrange);
            Brush redBrush = new SolidBrush(Color.DarkRed);
            Brush brownBrush = new SolidBrush(Color.Brown);

            Pen penOne = new Pen(Brushes.Black);

            Pen penTwo = new Pen(Brushes.Black);
            penTwo.Width = 25;

            Pen penThree = new Pen(Brushes.Black);
            penThree.Width = 35;

            Pen penFour = new Pen(Brushes.Black);
            penFour.Width = 45;



            Pen thickColoredPen = new Pen(Brushes.DarkOrange);
            thickColoredPen.Width = 25;

            int screenWisth = this.Width;
            int screenHeight = this.Height;

            Point centerPoint = new Point(screenWisth / 2, screenHeight / 2);

            string menuTitle = "Super Omega Ultra";

            Rectangle windowRect = new Rectangle(0, 0, screenWisth, screenHeight);
            graphics.FillRectangle(tealBrush, windowRect);

            graphics.DrawRectangle(penFour, new Rectangle(centerPoint.X, centerPoint.Y, 1, 1));

            graphics.DrawEllipse(penFour, new Rectangle(screenWisth / 2, screenHeight / 2, 50, 50));
            graphics.DrawEllipse(thickColoredPen, new Rectangle(screenWisth / 2, screenHeight / 2, 50, 50));


            graphics.DrawEllipse(penOne, new Rectangle(screenWisth / 2, 20, 20, 20));
            graphics.FillEllipse(redBrush, new Rectangle(screenWisth / 2, 20, 20, 20));
            //graphics.DrawArc(thickPen, new Rectangle(screenWisth/2, 20, 10, 10), 50f, 100f);

            //graphics.DrawEllipse(penOne, new Rectangle(screenWisth / 4, screenHeight/4, 20, 20));
            //graphics.DrawEllipse(penOne, new Rectangle((screenWisth / 4)+(screenWisth/2), screenHeight / 4, 20, 20));
            graphics.DrawEllipse(penOne, new Rectangle((screenWisth / 4) + (screenWisth / 2), (screenHeight / 4) - (screenHeight / 4), 20, 20));
            graphics.DrawEllipse(penOne, new Rectangle((screenWisth / 4), (screenHeight / 4) - (screenHeight / 4), 20, 20));

            Point o = new Point((screenWisth / 4) + (screenWisth / 2), 0);
            Point p = new Point((screenWisth / 4), (screenHeight / 4));
            int width = o.X - p.X;
            graphics.DrawRectangle(penTwo, new Rectangle((screenWisth / 4), 10, width, 150));
            string f = "fdddddd";
        }
    }
}