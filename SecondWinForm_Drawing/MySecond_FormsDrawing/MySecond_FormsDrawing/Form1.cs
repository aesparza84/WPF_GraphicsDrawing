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

            Brush cyanBrush = new SolidBrush(Color.Cyan);
            Brush tealBrush = new SolidBrush(Color.Teal);
            Brush orangeBrush = new SolidBrush(Color.DarkOrange);
            Brush redBrush = new SolidBrush(Color.DarkRed);
            Brush brownBrush = new SolidBrush(Color.Brown);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush darkBlueBrush = new SolidBrush(Color.DarkBlue);
            Brush greenBrush = new SolidBrush(Color.DarkGreen);

            Brush crystalA = new SolidBrush(Color.Green);
            Brush crystalB = new SolidBrush(Color.GreenYellow);

            Pen grayPen = new Pen(Color.Gray);
            Brush grayBrush = new SolidBrush(Color.Gray);

            Pen penOne = new Pen(Brushes.Black);

            Pen whitePen = new Pen(Brushes.White);
            whitePen.Width = 2;

            Pen newPen = new Pen(Color.OrangeRed);
            Pen thickRed = new Pen(Color.Red);
            thickRed.Width = 3;
           

            Pen penTwo = new Pen(Brushes.OrangeRed);
            penTwo.Width = 25;


            Pen thickColoredPen = new Pen(Brushes.DarkOrange);
            thickColoredPen.Width = 25;

            int screenWisth = this.Width;
            int screenHeight = this.Height;

            Point centerPoint = new Point(screenWisth / 2, screenHeight / 2);

            string menuTitle = "  Anomoly Hunters";
            Font titleFont = new Font("Cambria Math", 35);

            Font fontTwo = new Font("Courier New",15);
            string[] menuOptions = new string[3];
            menuOptions[0] = "Start";
            menuOptions[1] = "Options";
            menuOptions[2] = "Exit";

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
            graphics.DrawString(menuTitle, titleFont, tealBrush, new Rectangle((screenWisth / 4), 30, width, 150));

            Pen yellowPen = new Pen(Color.Yellow);
            yellowPen.Width = 3;

            Pen otherPen = new Pen(Color.Black);
            otherPen.Width = 3;

            //graphics.DrawRectangle(penOne, new Rectangle((screenWisth / 2) - 100, 150, 250, 100));
            
            //TextureBrush grayBrush = new TextureBrush(Image.FromFile(""));

            #region middle
            Rectangle multipleShapesOne = new Rectangle((screenWisth / 2) - 160, 150, 300, 100);

            graphics.DrawRectangle(penOne, multipleShapesOne);
            graphics.DrawEllipse(grayPen, multipleShapesOne);
            graphics.FillEllipse(tealBrush, multipleShapesOne);

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
            Rectangle rectUnderMid = new Rectangle(screenWisth/2 - 70, screenHeight/2+30, 125, 150);

            graphics.DrawRectangle(whitePen, rectUnderMid);
           

            Point[] hexLeft = new Point[7];

            Point[] underMidA = new Point[3];
            Point[] underMidB = new Point[3];
            //graphics.DrawRectangle(whitePen, newRect);


            underMidA[0] = new Point(rectUnderMid.X+50, rectUnderMid.Y);
            underMidA[1] = new Point(rectUnderMid.X, rectUnderMid.Y+34);
            underMidA[2] = new Point(rectUnderMid.X, rectUnderMid.Y);

            underMidB[0] = new Point(rectUnderMid.X + 80, rectUnderMid.Y+150);
            underMidB[1] = new Point(rectUnderMid.X+125, rectUnderMid.Y+110);
            underMidB[2] = new Point(rectUnderMid.X+125, rectUnderMid.Y+150);

            graphics.DrawLines(whitePen, underMidA);
            graphics.FillPolygon(grayBrush, underMidA);
            graphics.DrawLines(whitePen, underMidB);
            graphics.FillPolygon(redBrush, underMidB);

            Point menuPointA = new Point(rectUnderMid.X+30, rectUnderMid.Y+30);
            Point menuPointB = new Point(rectUnderMid.X + 15, rectUnderMid.Y + 60);
            Point menuPointC = new Point(rectUnderMid.X + 35, rectUnderMid.Y + 90);

            graphics.DrawString(menuOptions[0], fontTwo, cyanBrush, menuPointA);
            graphics.DrawString(menuOptions[1], fontTwo, grayBrush, menuPointB);
            graphics.DrawString(menuOptions[2], fontTwo, grayBrush, menuPointC);


            //graphics.DrawRectangle(whitePen, newRectB);

            //hexLeft[0] = new Point(200,200);
            //hexLeft[1] = new Point(195,205);
            //hexLeft[2] = new Point(200, 210);
            //hexLeft[3] = new Point(205,210);
            //hexLeft[4] = new Point(210, 205);
            //hexLeft[5] = new Point(205, 200);
            //hexLeft[6] = new Point(200,200);

            hexLeft[0] = new Point(200, 200);
            hexLeft[1] = new Point(175, 205);
            hexLeft[2] = new Point(200, 210);
            hexLeft[3] = new Point(205, 210);
            hexLeft[4] = new Point(210, 205);
            hexLeft[5] = new Point(205, 200);
            hexLeft[6] = new Point(200, 200);
            graphics.DrawLines(whitePen, hexLeft);


            Rectangle planetRectA = new Rectangle(10, 30, 60, 60);
            Rectangle planetRectB = new Rectangle(150, 310, 60, 60);

            //graphics.DrawRectangle(whitePen, planetRect);
            // graphics.DrawEllipse(whitePen, planetRect);
            // graphics.DrawPie(yellowPen, planetRect, 276, 130);

            graphics.FillEllipse(darkBlueBrush, planetRectA);
            graphics.FillPie(greenBrush, planetRectA, 276, 130);

            graphics.FillEllipse(grayBrush, planetRectB);
            graphics.FillPie(redBrush, planetRectB, 290, 45);

            Point[] laser = new Point[2];
            laser[0] = new Point(planetRectB.X+50, planetRectB.Y+10);
            laser[1] = new Point(planetRectB.X+100, planetRectB.Y-40);

            graphics.DrawLines(thickRed, laser);
            graphics.DrawLine(thickRed, laser[0], new Point(planetRectB.X+60, planetRectB.Y-30));
            graphics.DrawLine(thickRed, laser[0], new Point(planetRectB.X + 90, planetRectB.Y + 10));
            graphics.DrawLine(thickRed, laser[0], new Point(planetRectB.X + 70, planetRectB.Y));

            // graphics.FillClosedCurve(redBrush, planetDivide);

            Point[] Diamond = new Point[14];
            Diamond[0] = new Point(580, 300);
            Diamond[1] = new Point(550, 300);
            Diamond[2] = new Point(520, 330);
            Diamond[3] = new Point(567, 400);
            Diamond[4] = new Point(610, 330);
            Diamond[5] = new Point(580, 300);
            Diamond[6] = new Point(565, 340);
            Diamond[7] = Diamond[1];
            Diamond[8] = Diamond[6];
            Diamond[9] = Diamond[2];
            Diamond[10] = Diamond[6];
            Diamond[11] = Diamond[3];
            Diamond[12] = Diamond[6];
            Diamond[13] = Diamond[4];

            Point[] triA = new Point[3];
            triA[0] = Diamond[1];
            triA[1] = Diamond[6];
            triA[2] = Diamond[2];

            Point[] triB = new Point[3];
            triB[0] = Diamond[2];
            triB[1] = Diamond[6];
            triB[2] = Diamond[3];

            Point[] triC = new Point[3];
            triC[0] = Diamond[3];
            triC[1] = Diamond[6];
            triC[2] = Diamond[4];

            Point[] triD = new Point[3];
            triD[0] = Diamond[4];
            triD[1] = Diamond[6];
            triD[2] = Diamond[5];

            Point[] triE = new Point[3];
            triE[0] = Diamond[5];
            triE[1] = Diamond[6];
            triE[2] = Diamond[6];

            Point[] triF = new Point[3];
            triE[0] = Diamond[0];
            triE[1] = Diamond[6];
            triE[2] = Diamond[1];

            graphics.FillPolygon(crystalA, triA);
            graphics.FillPolygon(crystalA, triB);
            graphics.FillPolygon(crystalB, triC);
            graphics.FillPolygon(crystalB, triD);
            graphics.FillPolygon(crystalB, triE);
            graphics.FillPolygon(crystalB, triF);

            Pen thickBlackPen = new Pen(Color.Black);
            thickBlackPen.Width = 6;
            graphics.DrawLines(thickBlackPen, Diamond);



            Point[] Hex = new Point[7];
            Hex[0] = new Point(Diamond[3].X, Diamond[3].Y-80); //567, 400
            Hex[1] = new Point(550, 330);
            Hex[2] = new Point(550, 345);
            Hex[3] = new Point(567, 355);
            Hex[4] = new Point(585, 345);
            Hex[5] = new Point(585, 330);
            Hex[6] = new Point(Diamond[3].X, Diamond[3].Y - 80);

            Point[] HexDivide= new Point[5];
            HexDivide[0] = Hex[0];
            HexDivide[1] = Hex[3];
            HexDivide[2] = Hex[2];
            HexDivide[3] = Hex[1];
            HexDivide[4] = Hex[0];

            //graphics.DrawLines(yellowPen, Hex);
            //graphics.DrawLines(whitePen, HexDivide);

            graphics.FillPolygon(crystalA, Hex);
            graphics.FillPolygon(crystalB, HexDivide);

            #region shapes needed
            ///Rectangle -----DONE
            ///Ellipses  -----DONE
            ///Square    -----DONE
            ///Circle    -----DONE
            ///Pie       -----DONE
            ///Arc       -----DONE
            ///Triangle  -----DONE
            ///Hexagon   -----DONE
            ///Text      -----DONE
            ///Pen and Brush--DONE
            #endregion
        }
    }
}