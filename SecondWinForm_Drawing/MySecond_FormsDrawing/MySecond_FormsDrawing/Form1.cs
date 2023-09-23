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
            Brush blackBrush = new SolidBrush(Color.Black);

            Pen penOne = new Pen(Brushes.Black);
            Pen whitePen = new Pen(Brushes.White);
            Pen newPen = new Pen(Color.OrangeRed);
           

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
            graphics.FillRectangle(blackBrush, windowRect);

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
            Pen grayPen = new Pen(Color.Gray);
            Brush grayBrush = new SolidBrush(Color.DarkCyan);
            //TextureBrush grayBrush = new TextureBrush(Image.FromFile(""));

            #region middle
            Rectangle multipleShapesOne = new Rectangle((screenWisth / 2) - 160, 150, 300, 100);

            graphics.DrawRectangle(penOne, multipleShapesOne);
            graphics.DrawEllipse(grayPen, multipleShapesOne);
            graphics.FillEllipse(grayBrush, multipleShapesOne);

            graphics.DrawArc(yellowPen, multipleShapesOne, 60, 165);
            graphics.DrawPie(yellowPen, multipleShapesOne, 60, 105);
            graphics.FillPie(redBrush, multipleShapesOne, 60, 105);

            graphics.DrawArc(yellowPen, multipleShapesOne, 240, 165);
            graphics.DrawPie(yellowPen, multipleShapesOne, 240, 104);
            graphics.FillPie(redBrush, multipleShapesOne, 240, 104);




            Rectangle radarSquareA = new Rectangle(400, 170, 10, 10);
            Rectangle radarSquareB = new Rectangle(400, 235, 10, 10);
            Rectangle radarSquareC = new Rectangle(350, 220, 10, 10);
            graphics.DrawRectangle(newPen, radarSquareA);
            graphics.DrawRectangle(newPen, radarSquareB);
            graphics.DrawRectangle(newPen, radarSquareC);

            //graphics.DrawPie(otherPen, multipleShapesOne, 165, 75);
            #endregion

            #region left shape
            Rectangle leftShape = new Rectangle(50, 100, 100, 250);

            
            //graphics.DrawRectangle(yellowPen, leftShape);

            Point[] lineOne = new Point[6];
            Point[] lineOneB = new Point[6];

            lineOne[0] = new Point(150, 100);
            lineOne[1] = new Point(75, 290);
            lineOne[2] = new Point(60, 350);

            lineOne[3] = new Point(100, 300);
            lineOne[4] = new Point(130, 330);
            lineOne[5] = new Point(150, 100);

            //A shifted version, +5
            lineOneB[0] = new Point(155, 95);
            lineOneB[1] = new Point(80, 285);
            lineOneB[2] = new Point(65, 345);

            lineOneB[3] = new Point(105, 295);
            lineOneB[4] = new Point(135, 325);
            lineOneB[5] = new Point(155, 95);

            graphics.DrawLines(newPen, lineOne);
            graphics.FillPolygon(redBrush, lineOne);

            graphics.DrawLines(newPen, lineOneB);
            graphics.FillPolygon(orangeBrush, lineOneB);
            #endregion

            #region right shape
            Rectangle rightShape = new Rectangle(655, 100, 100, 250);


            //graphics.DrawRectangle(yellowPen, rightShape);

            Point[] lineTwo = new Point[6];
            Point[] lineTwoB = new Point[6];

            lineTwo[0] = new Point(655, 100);
            lineTwo[1] = new Point(730, 290);
            lineTwo[2] = new Point(745, 350);

            lineTwo[3] = new Point(705, 300);
            lineTwo[4] = new Point(675, 330);
            lineTwo[5] = new Point(655, 100);

            //A shifted verison, -5
            lineTwoB[0] = new Point(650, 95);
            lineTwoB[1] = new Point(725, 285);
            lineTwoB[2] = new Point(740, 345);

            lineTwoB[3] = new Point(700, 295);
            lineTwoB[4] = new Point(670, 325);
            lineTwoB[5] = new Point(650, 95);



            graphics.DrawLines(newPen, lineTwo);
            graphics.FillPolygon(redBrush, lineTwo);

            graphics.DrawLines(newPen, lineTwoB);
            graphics.FillPolygon(orangeBrush, lineTwoB);

            #endregion

            Rectangle newRect = new Rectangle(200,200, 10,10);
            Rectangle newRectB = new Rectangle(590, 200, 10, 10);

            Point[] hexLeft = new Point[7];
            Point[] hexRight = new Point[5];
            //graphics.DrawRectangle(whitePen, newRect);
             graphics.DrawRectangle(whitePen, newRectB);

            //hexLeft[0] = new Point(200,200);
            //hexLeft[1] = new Point(195,205);
            //hexLeft[2] = new Point(200, 210);
            //hexLeft[3] = new Point(205,210);
            //hexLeft[4] = new Point(210, 205);
            //hexLeft[5] = new Point(205, 200);
            //hexLeft[6] = new Point(200,200);

            hexLeft[0] = new Point(200, 200);
            hexLeft[1] = new Point(195, 205);
            hexLeft[2] = new Point(200, 210);
            hexLeft[3] = new Point(205, 210);
            hexLeft[4] = new Point(210, 205);
            hexLeft[5] = new Point(205, 200);
            hexLeft[6] = new Point(200, 200);

            graphics.DrawLines(whitePen, hexLeft);


            #region shapes needed
            ///Rectangle -----DONE
            ///Ellipses  -----DONE
            ///Square    -----DONE
            ///Circle
            ///Pie       -----DONE
            ///Arc       -----DONE
            ///Triangle
            ///Hexagon
            ///Text      -----DONE
            ///Pen and Brush--DONE
            #endregion
        }
    }
}