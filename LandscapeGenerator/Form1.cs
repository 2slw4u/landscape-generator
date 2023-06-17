using System.Windows.Forms;

namespace LandscapeGenerator
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int width = 800;
        private int height = 800;
        private int resolution = 1;
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
            map = new LandscapeMap(cellsAmount, cellsAmount, this);
            graphics = Graphics.FromImage(landscapeBox.Image);
        }

        private void ColorMap()
        {

            for (int i = 0; i < cellsAmount - 1; i++)
            {
                for (int j = 0; j < cellsAmount - 1; j++)
                {
                    Cell currentCell = map.Field[i, j];
                    graphics.FillRectangle(new SolidBrush(currentCell.color), currentCell.X, currentCell.Y, resolution, resolution);
                    //consoleBox.Text = resolution.ToString();
                    //consoleBox.Text += currentCell.X.ToString() + " " + currentCell.Y.ToString() + "   ";
                }
            }

            //graphics.FillRectangle(new SolidBrush(currentColor), rand.Next(0, 50), rand.Next(0, 50), rand.Next(0, 50), rand.Next(0, 50));
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
        }


        private void button1_Click(object sender, EventArgs e)
        {
            InitilazeMap();
            ColorMap();
        }

        private void resolutionContainer_ValueChanged(object sender, EventArgs e)
        {
            cellsAmount = (int)resolutionContainer.Value;
            resolution = width / cellsAmount;
            landscapeBox.Image = new Bitmap(width * resolution, height * resolution);
            graphics = Graphics.FromImage(landscapeBox.Image);
            InitilazeMap();
            ColorMap();
        }
    }
}