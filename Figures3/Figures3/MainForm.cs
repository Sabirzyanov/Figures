/* 
    Insaf Sabirzyanov 220P,
    Task "Figures 4"
    30.05.22
*/


using System.Drawing.Drawing2D;
using System;
using System.Drawing;
using System.Reflection;

namespace Figures3
{
    public partial class MainForm : Form
    {
        private bool canDraw;
        string figureType;
        Figures figures = new Figures();
        Figure currentFigure = new Figure(0, 0); 
        Point startPoint;

        public MainForm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance |
                BindingFlags.NonPublic,
                null, mainPanel, new object[] { true });
        }

        private Figure createFigure(string figureType)
        {
            Figure fig;

            switch (figureType)
            {
                case "Triangle":
                    fig = new Triangle(new Point(0, 0), new Point(0, 0), new Point(0, 0));
                    break;
                case "Rectangle":
                    fig = new Rectangle(new Point(0, 0), 0, 0);
                    break;
                case "Circle":
                    fig = new Circle(new Point(0, 0), 0);
                    break;
                case "Line":
                    fig = new Line(new Point(0, 0), new Point(0, 0));
                    break;
                default:
                    fig = new Line(new Point(0, 0), new Point(0, 0));
                    break;
            }
            return fig;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            WinFormsDrawer drawer = new WinFormsDrawer(e.Graphics);

            if (figures.GetCount() != 0)
                figures.Draw(drawer);
            if (drawer is not null)
                currentFigure?.Draw(drawer);
        }

        private void figuresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string data = figuresList.Text;
            if (data != "")
            {
                canDraw = true;
                figureType = data;
                figureListLabel.Text = $"Figure: {data}";
            }
            else
            {
                canDraw = false;
                figureListLabel.Text = $"Figure: None";
            }
        }

        private void colorSelectBtn_Click(object sender, EventArgs e)
        {
            colorDialogWindow.ShowDialog();
            selectedColor.Text = $"Selected color: {colorDialogWindow.Color.Name}";
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (canDraw)
            {                
                if (e.Button == MouseButtons.Left) 
                {
                    if (currentFigure is not null)
                    {
                        figures.Add(currentFigure);
                        mainPanel.Refresh();
                    }
                }
            }
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left && canDraw && currentFigure != null) 
            {
                currentFigure = createFigure(figureType);

                currentFigure.basePoint = startPoint;
                currentFigure.endPoint.X = e.X;
                currentFigure.endPoint.Y = e.Y;
                currentFigure.color = colorDialogWindow.Color;


                float penWidth = 0;

                if (!float.TryParse(penWidthInput.Text, out penWidth))
                    penWidth = 2f;

                currentFigure.strokeWidth = (int) penWidth;
                debugLabel.Text = $"Figures count: {figures.GetCount()}";
                mainPanel.Refresh();
            }
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (canDraw)
            {
                if (e.Button == MouseButtons.Left)
                {
                    startPoint = new Point(e.X, e.Y);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveFileDialogWindow.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialogWindow.FileNames[0];
                figures.Save(savePath);
                MessageBox.Show("Saved");
            };
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            currentFigure = new Figure();
            if (openFileDialogWindow.ShowDialog() == DialogResult.OK)
            {
                canDraw = false;
                figures.Load(openFileDialogWindow.FileName);
                mainPanel.Refresh();
                canDraw = true;
            };
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            figures = new Figures();
            currentFigure = new Figure();
            debugLabel.Text = $"Figures count: {figures.GetCount()}";
            mainPanel.Refresh();

        }
    }
}