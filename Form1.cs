namespace GameOfLife
{
    public partial class Form1 : Form
    {
        readonly int cellSize = 5;
        readonly int mapSize = 100;
        private readonly Bitmap bitmap = new(500, 500);
        private GameMap bigMap;
        private readonly PatternMaker patternMaker;

        public Form1()
        {
            
            InitializeComponent();
            patternMaker = new(mapSize);
           
        }

        private void LoadAnimation()
        {
            var drawMap = bigMap.ReturnMap();
            for (int i = 0; i < mapSize; i++)
            {
                for (int z = 0; z < mapSize; z++)
                {
                    DrawRectangle(i,z,drawMap[i,z].IsAlive);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void DrawRectangle(int i, int z, bool color)
        {
            for (int q = 0; q < cellSize; q++)
            {
                for (int y = 0; y < cellSize; y++)
                {
                    if (color)
                    {
                        bitmap.SetPixel((i*cellSize)+q, (z*cellSize)+y, Color.Black);
                    }
                    else
                    {
                        bitmap.SetPixel((i * cellSize) + q, (z * cellSize) + y, Color.White);
                    }
                }
            }
        }
        private void handlePatternButtons(GameMap gameMap)
        {
            bigMap = gameMap;
            LoadAnimation();
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bigMap.CheckAlive();
            LoadAnimation();
            button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GameMap gameMap = new GameMap(patternMaker.Random(), mapSize);
            handlePatternButtons(gameMap);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameMap gameMap = new(patternMaker.Glider(), mapSize);
            handlePatternButtons(gameMap);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GameMap gameMap = new(patternMaker.LightWeightSpaceShip(), mapSize);
            handlePatternButtons(gameMap);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GameMap gameMap = new(patternMaker.MiddleWeightSpaceShip(), mapSize);
            handlePatternButtons(gameMap);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GameMap gameMap = new(patternMaker.HeavyWeightSpaceShip(), mapSize);
            handlePatternButtons(gameMap);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GameMap gameMap = new(patternMaker.Pulsar(), mapSize);
            handlePatternButtons(gameMap);
        }

    }
}