using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWLesson9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomBtn_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            //            int a = Convert.ToInt32(fromNumbertxtBox.Text);
            //            int b = Convert.ToInt32(toNumbertxtBox.Text);

            int a, b;

            bool successA = Int32.TryParse(fromNumbertxtBox.Text, out a);
            bool successB = Int32.TryParse(toNumbertxtBox.Text, out b);

            if (successA && successB || a >= b)
            {
                Debug.WriteLine($"Generate a random number between {a} and {b}");

                int number = randomGenerator.Next(a, b) + 1;

                ResultLbl.Text = $"The random number is: {number}";
                Debug.WriteLine($"The random number is: {number}");
            }
            else
            {
                ResultLbl.Text = "Invalid Input";
            }
        }

        private void zerofyBtn_Click(object sender, EventArgs e)
        {
            Random randomGenerator = new Random();
            int a = 0;
            int b = 0;
            fromNumbertxtBox.Text = $"{a}";
            toNumbertxtBox.Text = $"{b}";
            int number = randomGenerator.Next(a, b);

            ResultLbl.Text = $"The random number is: {number}";
        }
    }
}
