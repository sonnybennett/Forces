﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);

        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);

                double Fx = force * cos(Angle);
                double Fy = force * sin(Angle);

                label1.Text = "Fx = " + Fx;
                label2.Text = "Fy = " + Fy;

                //run the code between these brackets
                //jump to catch if an error occurs
            }
            catch
            {
                MessageBox.Show("Cant do tha ye muppet");
            }






            {

            }
        }
    }
}