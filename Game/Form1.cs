using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        bool down = false;
        const int canvasSize = 30;
        PictureBox[,] canvas = new PictureBox[canvasSize, canvasSize];
        PictureBox[] colors = new PictureBox[10];
        Image selectedImage = Properties.Resources._0;

        //PictureBox[] pic1 = new PictureBox[10];
        public Form1()
        {
            InitializeComponent();

            int size = 7;
            for (int i = 0; i < canvasSize; i++)
            {
                for (int j = 0; j < canvasSize; j++)
                {
                    canvas[i, j] = new PictureBox();
                    canvas[i, j].Parent = canvasPanel;
                    canvas[i, j].Image = selectedImage;
                    canvas[i, j].Size = new Size(size, size);
                    canvas[i, j].Location = new Point(i * size, j * size);
                    canvas[i, j].MouseMove += CanvasClick;
                    canvas[i, j].Click += FormMouseDown;
                    //canvas[i, j].MouseUp += FormMouseUp;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                colors[i] = new PictureBox();
                colors[i].Parent = colorPannel;
                colors[i].Size = new Size(20, 20);
                colors[i].Location = new Point(i * 20, 0);
                colors[i].Click += ColorsClick;
                switch (i)
                {
                    case 0:
                        colors[i].Image = Properties.Resources._0;
                        break;
                    case 1:
                        colors[i].Image = Properties.Resources._1;
                        break;
                    case 2:
                        colors[i].Image = Properties.Resources._2;
                        break;
                    case 3:
                        colors[i].Image = Properties.Resources._3;
                        break;
                    case 4:
                        colors[i].Image = Properties.Resources._4;
                        break;
                    case 5:
                        colors[i].Image = Properties.Resources._5;
                        break;
                    case 6:
                        colors[i].Image = Properties.Resources._6;
                        break;
                    case 7:
                        colors[i].Image = Properties.Resources._7;
                        break;
                    case 8:
                        colors[i].Image = Properties.Resources._8;
                        break;
                    case 9:
                        colors[i].Image = Properties.Resources._9;
                        break;
                }
            }
        }
        public void FormMouseDown(Object sender, EventArgs e)
        {
            down ^= true;
        }
        public void FormMouseUp(Object sender, EventArgs e)
        {
            down = false;
        }
        public void CanvasClick(Object sender, EventArgs e)
        {
            if (down)
            {
                PictureBox pixel = sender as PictureBox;
                pixel.Image = selectedImage;
            }
        }
        public void ColorsClick(Object sender, EventArgs e)
        {
            PictureBox color = sender as PictureBox;
            selectedImage = color.Image;
        }
    }
}
