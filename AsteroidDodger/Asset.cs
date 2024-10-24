namespace AsteroidDodger
{
    public abstract class Asset
    {
        public Point Center { get; set; }
        public Rectangle Collision { get; set; }

        public int MoveX { get; set; }
        public int MoveY { get; set; }

        public abstract void Draw(PaintEventArgs e);

        public virtual void Move(int x1, int x2, int y1, int y2)
        {
            int newX = Center.X + MoveX;
            if (newX < x1) newX = x2;
            else if (newX > x2) newX = x1;

            int newY = Center.Y + MoveY;
            if (newY < y1) newY = y2;
            else if (newY > y2) newY = y1;

            Center = new Point(newX, newY);
        }
    }
}
