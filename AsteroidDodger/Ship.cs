namespace AsteroidDodger
{
    internal class Ship : Asset
    {
        public Ship(Point center)
        {
            Center = center;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkGray, 2);
            Graphics g = e.Graphics;


            e.Graphics.DrawEllipse(pen, Center.X - 40, Center.Y - 40, 80, 80);  // Outer
            e.Graphics.DrawEllipse(pen, Center.X - 25, Center.Y - 25, 50, 50);  // Inner

            Point[] righWingBridge = new Point[2];
            righWingBridge[0] = new Point(Center.X + 35, Center.Y + 20);
            righWingBridge[1] = new Point(Center.X + 70, Center.Y + 10);

            Point[] righWingBridge2 = new Point[2];
            righWingBridge2[0] = new Point(Center.X + 35, Center.Y - 20);
            righWingBridge2[1] = new Point(Center.X + 70, Center.Y - 10);

            Point[] righWing2 = new Point[4];
            righWing2[0] = new Point(Center.X + 60, Center.Y + 60);
            righWing2[1] = new Point(Center.X + 80, Center.Y + 20);
            righWing2[2] = new Point(Center.X + 80, Center.Y - 20);
            righWing2[3] = new Point(Center.X + 60, Center.Y - 60);


            Point[] righWingGrid3 = new Point[4];
            righWingGrid3[0] = new Point(Center.X + 60, Center.Y - 60);
            righWingGrid3[1] = new Point(Center.X + 70, Center.Y - 10);
            righWingGrid3[2] = new Point(Center.X + 70, Center.Y + 10);
            righWingGrid3[3] = new Point(Center.X + 60, Center.Y + 60);


            e.Graphics.DrawLines(pen, righWingBridge);
            e.Graphics.DrawLines(pen, righWingBridge2);
            e.Graphics.DrawLines(pen, righWing2);
            e.Graphics.DrawLines(pen, righWingGrid3);

            Point[] leftWingBridge = new Point[2];
            leftWingBridge[0] = new Point(Center.X - 35, Center.Y - 20);
            leftWingBridge[1] = new Point(Center.X - 70, Center.Y - 10);

            Point[] leftWingBridge2 = new Point[2];
            leftWingBridge2[0] = new Point(Center.X - 35, Center.Y + 20);
            leftWingBridge2[1] = new Point(Center.X - 70, Center.Y + 10);

            Point[] leftWing2 = new Point[4];
            leftWing2[0] = new Point(Center.X - 60, Center.Y - 60);
            leftWing2[1] = new Point(Center.X - 80, Center.Y - 20);
            leftWing2[2] = new Point(Center.X - 80, Center.Y + 20);
            leftWing2[3] = new Point(Center.X - 60, Center.Y + 60);


            Point[] leftWingGrid3 = new Point[4];
            leftWingGrid3[0] = new Point(Center.X - 60, Center.Y + 60);
            leftWingGrid3[1] = new Point(Center.X - 70, Center.Y + 10);
            leftWingGrid3[2] = new Point(Center.X - 70, Center.Y - 10);
            leftWingGrid3[3] = new Point(Center.X - 60, Center.Y - 60);

            e.Graphics.DrawLines(pen, leftWingBridge);
            e.Graphics.DrawLines(pen, leftWingBridge2);
            e.Graphics.DrawLines(pen, leftWing2);
            e.Graphics.DrawLines(pen, leftWingGrid3);

        }
    }
}
