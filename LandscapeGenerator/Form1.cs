using LandscapeGenerator.CellTypes;
using LandscapeGenerator.Events;
using System;
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
        public int cellsAmount = 1;
        private string addedObject = "Stone";
        private string typeOfAddedObject = "Cell";
        private LandscapeMap map;
        private Initialize.Initialize initialize;

        public Form1()
        {
            InitializeComponent();
            cellsAmount = (int)resolutionContainer.Value;
            resolution = width / cellsAmount;
            landscapeBox.Width = width;
            landscapeBox.Height = height;
            landscapeBox.Image = new Bitmap(width, height);
            graphics = Graphics.FromImage(landscapeBox.Image);
            initialize = new Initialize.Initialize(this);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            TypesContainer.initialize();
            EventsContainer.initialize();
            map = initialize.InitializeMap();

            InitializeForest();
            InitializeWater();

            map.updatePrevTypes();
            landscapeBox.Image = new Bitmap(width, height);
            graphics = Graphics.FromImage(landscapeBox.Image);
            map.colorMap(graphics);
            landscapeBox.Refresh();
            globalTimer.Enabled = true;
            startStopTimer.Enabled = true;
            landscapeBox.Enabled = true;
        }

        public void InitializeForest()
        {

        }
            const double rate = 0.2;
            Random r = new Random();
            for (int i = 0; i < cellsAmount; ++i)
            {
                for (int j = 0; j < cellsAmount; ++j)
                {
                    double roll = r.NextDouble();
                    if (rate < roll)
                    {
                        map.Field[i, j].Type = TypesContainer.TypeDict[AllTypes.FOREST];
                    }
                }
            }
        }

        public void InitializeWater()
        {

        }

        private void resolutionContainer_ValueChanged(object sender, EventArgs e)
        {
            cellsAmount = (int)resolutionContainer.Value;
            resolution = width / cellsAmount;
            landscapeBox.Image = new Bitmap(width * resolution, height * resolution);
            graphics = Graphics.FromImage(landscapeBox.Image);
            globalTimer.Enabled = false;
            startStopTimer.Enabled = false;
            startStopTimer.Text = "Стоп";
            landscapeBox.Enabled = false;
        }

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            map.MapUpdater.updateNextTick();
            map.colorMap(graphics);
            landscapeBox.Refresh();
            map.updatePrevTypes();

        }

        private void startStopTimer_Click(object sender, EventArgs e)
        {
            if (globalTimer.Enabled == true)
            {
                startStopTimer.Text = "Дальше";
                globalTimer.Enabled = false;
            }
            else
            {
                startStopTimer.Text = "Стоп";
                globalTimer.Enabled = true;
            }
        }

        private void landscapeBox_Click(object sender, EventArgs e)
        {
            int CellXCoordinate = (int)Math.Floor((double)landscapeBox.PointToClient(Cursor.Position).X / resolution);
            int CellYCoordinate = (int)Math.Floor((double)landscapeBox.PointToClient(Cursor.Position).Y / resolution);
            if (typeOfAddedObject == "Cell")
            {
                map.Field[CellXCoordinate, CellYCoordinate].PrevType = TypesContainer.TypeDict[Enum.Parse<AllTypes>(addedObject, true)];
                map.Field[CellXCoordinate, CellYCoordinate].Type = TypesContainer.TypeDict[Enum.Parse<AllTypes>(addedObject, true)];
            }
            else if (typeOfAddedObject == "Event")
            {
                Event newEvent = EventsContainer.EventsDict[Enum.Parse<AllEvents>(addedObject, true)];
                int neededIndex = EventsContainer.EventsDict.Values.ToList().IndexOf(newEvent);
                newEvent = map.MapUpdater.EventGenerator.GenerateEvent(map.Height, CellXCoordinate, CellYCoordinate, neededIndex, 1);
                newEvent.happen(map.Field);
                // consoleBox.Text += neededIndex.ToString();
            }
            //consoleBox.Text += CellXCoordinate.ToString() + ";" + CellYCoordinate.ToString() + "        ";
            map.colorMap(graphics);
            landscapeBox.Refresh();
        }

        private void AddGrassButton_Click(object sender, EventArgs e)
        {
            typeOfAddedObject = "Cell";
            addedObject = "Grass";
        }

        private void AddForestButton_Click(object sender, EventArgs e)
        {
            typeOfAddedObject = "Cell";
            addedObject = "Forest";
        }

        private void AddWaterButton_Click(object sender, EventArgs e)
        {
            typeOfAddedObject = "Cell";
            addedObject = "Water";
        }

        private void AddSandButton_Click(object sender, EventArgs e)
        {
            typeOfAddedObject = "Cell";
            addedObject = "Sand";
        }

        private void AddSnowButton_Click(object sender, EventArgs e)
        {
            typeOfAddedObject = "Cell";
            addedObject = "Snow";
        }

        private void AddStoneButton_Click(object sender, EventArgs e)
        {
            typeOfAddedObject = "Cell";
            addedObject = "Stone";
        }

        private void ApplyDraughtButton_Click(object sender, EventArgs e)
        {
            typeOfAddedObject = "Event";
            addedObject = "Draught";
        }

        private void ApplyEarthquakeButton_Click(object sender, EventArgs e)
        {
            typeOfAddedObject = "Event";
            addedObject = "Earthquake";
        }

        private void ApplyVolcanoButton_Click(object sender, EventArgs e)
        {
            typeOfAddedObject = "Event";
            addedObject = "Volcano";
        }
    }
}