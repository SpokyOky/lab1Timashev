﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1WinForms
{
    public partial class FormAircraftCarrier : Form
    {
        private AircraftCarrier aircraftCarrier;

        public FormAircraftCarrier()
        {
            InitializeComponent();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCarrier.Width, pictureBoxCarrier.Height);
            Graphics g = Graphics.FromImage(bmp);
            aircraftCarrier.DrawCarrier(g);
            pictureBoxCarrier.Image = bmp;
        }        private void btnCreate_Click(object sender, EventArgs e)
        {
            aircraftCarrier = new AircraftCarrier(200, 1000, Color.Gray, Color.White, true, false);
            aircraftCarrier.SetPosition(10, 10, pictureBoxCarrier.Width, pictureBoxCarrier.Height);
            Draw();
        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            string s = (sender as Button).Name;
            switch (s)
            {
                case "btnUp":
                    aircraftCarrier.MoveTransport(Direction.Up);
                    break;
                case "btnDown":
                    aircraftCarrier.MoveTransport(Direction.Down);
                    break;
                case "btnLeft":
                    aircraftCarrier.MoveTransport(Direction.Left);
                    break;
                case "btnRight":
                    aircraftCarrier.MoveTransport(Direction.Right);
                    break;
                default:
                    break;
            }
            Draw();
        }
    }
}
