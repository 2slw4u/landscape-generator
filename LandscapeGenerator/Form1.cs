using System.ComponentModel;
using System.Windows.Forms;

namespace LandscapeGenerator
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int width = 800;
        private int height = 800;
        public int resolution = 1;
        private int cellsAmount = 1;
        private LandscapeMap map;
        public Form1()
        {
            InitializeComponent();
            cellsAmount = (int)resolutionContainer.Value;
            resolution = width / cellsAmount;
            landscapeBox.Width = width;
            landscapeBox.Height = height;
            landscapeBox.Image = new Bitmap(width, height);
            graphics = Graphics.FromImage(landscapeBox.Image);
        }

        private void ColorMap()
        {
            for (int i = 0; i < cellsAmount; i++)
            {
                for (int j = 0; j < cellsAmount; j++)
                {
                    Cell currentCell = map.Field[i, j];
                    currentCell.updateColor();
                    graphics.FillRectangle(new SolidBrush(currentCell.Color), currentCell.X, currentCell.Y, resolution, resolution);
                }
            }
            landscapeBox.Refresh();
        }
        private void InitilazeMap()
        {
            map = new LandscapeMap(cellsAmount, cellsAmount, this);
            for (int i = 0; i < cellsAmount; ++i)
            {
                for (int j = 0; j < cellsAmount; ++j)
                {
                    map.Field[i, j] = new Cell(i * resolution, j * resolution);
                }
            }
            MapGenerator generator = new DiamondSquareGenerator();
            map.Field = generator.generateHeightMap(map.Field);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            CellTypes.TypesContainer.initialize();
            InitilazeMap();
            landscapeBox.Image = new Bitmap(width, height);
            graphics = Graphics.FromImage(landscapeBox.Image);
            ColorMap();
            globalTimer.Enabled = true;
        }

        private void resolutionContainer_ValueChanged(object sender, EventArgs e)
        {
            cellsAmount = (int)resolutionContainer.Value;
            resolution = width / cellsAmount;
            landscapeBox.Image = new Bitmap(width * resolution, height * resolution);
            graphics = Graphics.FromImage(landscapeBox.Image);
            globalTimer.Enabled = false;
            //InitilazeMap();
            //ColorMap();
        }

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            map.MapUpdater.updateNextTick();
            ColorMap();
        }

        public void changeText(string text)
        {
            consoleBox.Text += text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}