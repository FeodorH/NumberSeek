using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _32._1_Holkin_NumberSeek
{
    public partial class FormMain : Form
    {
        private double[] inputMatrix; // Собственно, полученные пиксели
        private string learnFilePath;
        private string testFilePath;

        public FormMain()
        {
            InitializeComponent();

            inputMatrix = new double[15];
            learnFilePath = AppDomain.CurrentDomain.BaseDirectory + "learn.txt";
            testFilePath = AppDomain.CurrentDomain.BaseDirectory + "test.txt";
        }

        private void changeStatePixelButton(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.White)
            {
                ((Button)sender).BackColor = Color.Black;
                inputMatrix[((Button)sender).TabIndex] = 1d;
            }
            else
            {
                ((Button)sender).BackColor = Color.White;
                inputMatrix[((Button)sender).TabIndex] = 0d;
            }
        }

        private void recognizeClickButton(object sender, EventArgs e)
        {
            
        }

        private void numericUpDownTarget_ValueChanged(object sender, EventArgs e)
        {

        }

        private void onSaveLearn(object sender, EventArgs e)
        {
            string tmp = targetNumericUpDown.Value.ToString() + " ";

            for (int i = 0;i < inputMatrix.Length; i++)
            {
                tmp += inputMatrix[i];
            }
            tmp += "\n";

            File.AppendAllText(learnFilePath, tmp);
        }

        private void onSaveTest(object sender, EventArgs e)
        {
            string tmp = targetNumericUpDown.Value.ToString() + " ";

            for (int i = 0; i < inputMatrix.Length; i++)
            {
                tmp += inputMatrix[i];
            }
            tmp += "\n";

            File.AppendAllText(testFilePath, tmp);
        }
    }
}
