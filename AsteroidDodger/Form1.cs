namespace AsteroidDodger
{
    public partial class Form1 : Form
    {
        Ship player = new Ship(new Point(550, 350));
        int score;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            score = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameLoop.Interval = 24;
            GameLoop.Start();

            this.Size = new Size(1200, 900);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.BackColor = Color.Black;

            this.Paint += new PaintEventHandler(PaintObjects);
        }

        protected void PaintObjects(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(100, 100, 1000, 700);

            e.Graphics.DrawRectangle(Pens.White, rectangle);
            Region clippingRegion = new Region(rectangle);
            e.Graphics.Clip = clippingRegion;

            player.Draw(e);

            e.Graphics.ResetClip();
            e.Graphics.DrawString("Score: " + score.ToString(), new Font("Verdana", 30, FontStyle.Regular), Brushes.Gold, new Point(10, 10));
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Left) player.MoveX = -5;
            if (e.KeyCode == Keys.Right) player.MoveX = 5;
            if (e.KeyCode == Keys.Up) player.MoveY = -5;
            if (e.KeyCode == Keys.Down) player.MoveY = 5;
        }

        private void GameLoop_Tick(object sender, EventArgs e)
        {
            player.Move(100, 1100, 100, 800);
            this.Refresh();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            player.MoveX = 0;
            player.MoveY = 0;
        }
    }
}
