namespace MySecond_FormsDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MyPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;


            Brush tealBrush = new SolidBrush(Color.Teal);
            Brush orangeBrush = new SolidBrush(Color.DarkOrange);
            Brush redBrush = new SolidBrush(Color.DarkRed);
            Brush brownBrush = new SolidBrush(Color.Brown);

            Pen penOne = new Pen(Brushes.Black);

            Pen penTwo = new Pen(Brushes.OrangeRed);
            penTwo.Width = 25;


            Pen thickColoredPen = new Pen(Brushes.DarkOrange);
            thickColoredPen.Width = 25;

            int screenWisth = this.Width;
            int screenHeight = this.Height;

            Point centerPoint = new Point(screenWisth / 2, screenHeight / 2);

            string menuTitle = "    Super Omega \n      Placholder";
            Font titleFont = new Font("Arial", 35);

            Rectangle windowRect = new Rectangle(0, 0, screenWisth, screenHeight);
            graphics.FillRectangle(tealBrush, windowRect);

            //graphics.DrawRectangle(penFour, new Rectangle(centerPoint.X, centerPoint.Y, 1, 1));

            //graphics.DrawEllipse(penFour, new Rectangle(screenWisth / 2, screenHeight / 2, 50, 50));
            //graphics.DrawEllipse(thickColoredPen, new Rectangle(screenWisth / 2, screenHeight / 2, 50, 50));


            //graphics.DrawEllipse(penOne, new Rectangle(screenWisth / 2, 20, 20, 20));
            //graphics.FillEllipse(redBrush, new Rectangle(screenWisth / 2, 20, 20, 20));
            //graphics.DrawArc(thickPen, new Rectangle(screenWisth/2, 20, 10, 10), 50f, 100f);

            //graphics.DrawEllipse(penOne, new Rectangle(screenWisth / 4, screenHeight/4, 20, 20));
            //graphics.DrawEllipse(penOne, new Rectangle((screenWisth / 4)+(screenWisth/2), screenHeight / 4, 20, 20));
            // graphics.DrawEllipse(penOne, new Rectangle((screenWisth / 4) + (screenWisth / 2), (screenHeight / 4) - (screenHeight / 4), 20, 20));
            //graphics.DrawEllipse(penOne, new Rectangle((screenWisth / 4), (screenHeight / 4) - (screenHeight / 4), 20, 20));

            Point o = new Point((screenWisth / 4) + (screenWisth / 2), 0);
            Point p = new Point((screenWisth / 4), (screenHeight / 4));
            int width = o.X - p.X;

            int titleRectSize = 83;
            graphics.DrawRectangle(penTwo, new Rectangle((screenWisth / 4), 10, width, titleRectSize));
            graphics.FillRectangle(orangeBrush, new Rectangle((screenWisth / 4), 10, width, titleRectSize));
            graphics.DrawString(menuTitle, titleFont, brownBrush, new Rectangle((screenWisth / 4), 10, width, 150));

            Pen yellowPen = new Pen(Color.Yellow);
            yellowPen.Width = 3;

            Pen otherPen = new Pen(Color.Black);
            otherPen.Width = 3;

            //graphics.DrawRectangle(penOne, new Rectangle((screenWisth / 2) - 100, 150, 250, 100));

            #region middle
            Rectangle multipleShapesOne = new Rectangle((screenWisth / 2) - 160, 150, 300, 100);

            graphics.DrawRectangle(penOne, multipleShapesOne);

            graphics.DrawArc(yellowPen, multipleShapesOne, 60, 165);
            graphics.DrawPie(yellowPen, multipleShapesOne, 60, 105);
            graphics.FillPie(redBrush, multipleShapesOne, 60, 105);

            graphics.DrawArc(yellowPen, multipleShapesOne, 240, 165);
            graphics.DrawPie(yellowPen, multipleShapesOne, 240, 104);
            graphics.FillPie(redBrush, multipleShapesOne, 240, 104);

            //graphics.DrawPie(otherPen, multipleShapesOne, 165, 75);
            #endregion

            #region left shape
            Rectangle leftShape = new Rectangle(50, 100, 100, 250);

            
            graphics.DrawRectangle(yellowPen, leftShape);

            Point[] lineOne = new Point[6];
            lineOne[0] = new Point(150, 100);
            lineOne[1] = new Point(75, 290);
            lineOne[2] = new Point(60, 350);

            lineOne[3] = new Point(100, 300);
            lineOne[4] = new Point(130, 330);
            lineOne[5] = new Point(150, 100);

            graphics.DrawLines(otherPen, lineOne);
            graphics.FillPolygon(redBrush, lineOne);
            #endregion

            #region right shape
            Rectangle rightShape = new Rectangle(650, 100, 100, 250);


            graphics.DrawRectangle(yellowPen, rightShape);

            Point[] lineTwo = new Point[6];
            Point[] lineTwoB = new Point[6];

            lineTwo[0] = new Point(650, 100);
            lineTwo[1] = new Point(725, 290);
            lineTwo[2] = new Point(740, 350);

            lineTwo[3] = new Point(700, 300);
            lineTwo[4] = new Point(670, 330);
            lineTwo[5] = new Point(650, 100);

            //A shifted verison, -5
            lineTwoB[0] = new Point(645, 95);
            lineTwoB[1] = new Point(720, 285);
            lineTwoB[2] = new Point(735, 345);

            lineTwoB[3] = new Point(695, 295);
            lineTwoB[4] = new Point(665, 325);
            lineTwoB[5] = new Point(645, 95);



            graphics.DrawLines(otherPen, lineTwo);
            graphics.FillPolygon(redBrush, lineTwo);

            graphics.DrawLines(otherPen, lineTwoB);
            graphics.FillPolygon(orangeBrush, lineTwoB);

            #endregion
        }
    }
}