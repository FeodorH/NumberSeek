using System;
using System.IO;
using System.Windows.Forms;

namespace _32._1_Holkin_NumberSeek.NeuroNet
{
    abstract class Layer
    {
        protected string name; //имя слоя
        private string pathDirWaights; //путь с файлам с весами
        private string pathFileWaidhts;
        protected int numOfNeurons; //кол-во пред нейронов
        protected int numOfPrevNeurons; //аналогично для предыдущего
        protected const double LEARNING_RATE = 0.05;
        protected const double MOMENTUM = 0.5;
        protected double[,] lastDeltaWaights; //хранятся веса перехода для каждого нейрона из предыдущего нейрона
        protected Neuron[] neurons; //сами нейроны

        public double[] Data //хранит полученные на выходе значения из нейронов 
        {
            set
            {
                for (int i = 0; i < numOfNeurons; i++)
                {
                    neurons[i].Activator(value);
                }
            }
        }

        protected Layer(int non, int nopn, NeuronType nt, string name)
        {
            numOfNeurons = non;
            numOfPrevNeurons = nopn;
            neurons = new Neuron[non];
            this.name = name;
            pathDirWaights = AppDomain.CurrentDomain.BaseDirectory + "memory\\";
            pathFileWaidhts = pathDirWaights + name + "_memory.csv";

            lastDeltaWaights = new double[non, nopn + 1];
            double[,] Weights;

            if (File.Exists(pathFileWaidhts)){
                Weights = WaightsInitialize(MemoryMode.Get, pathFileWaidhts);
            }
            else
            {
                Directory.CreateDirectory(pathFileWaidhts);
                Weights = WaightsInitialize(MemoryMode.Init, pathFileWaidhts);
            }

            for (int i = 0; i < non; i++)
            {
                double[] t = new double[nopn+1];
                for(int j = 0; j < nopn + 1; j++)
                {
                    t[j] = Weights[i, j];
                }
                neurons[i] = new Neuron(t, nt);
            }
        }

        protected double[,] WaightsInitialize(MemoryMode mm, string path) //Передача/получение весов в зависимости от режима
        {
            char[] spliterator = new char[] { ' ', ';' };
            string tmpStr;
            string[] tmpStrWeights;
            double[,] weights = new double[numOfNeurons, numOfPrevNeurons + 1];

            switch (mm)
            {
                case MemoryMode.Get:
                    tmpStrWeights = File.ReadAllLines(path);
                    string[] memory_element;
                    for(int i = 0; i < numOfNeurons; i++)
                    {
                        memory_element = tmpStrWeights[i].Split(spliterator);
                        for(int j = 0; j < numOfPrevNeurons; j++)
                        {
                            weights[i, j] = double.Parse(memory_element[j].Replace(',', '.'),
                                System.Globalization.CultureInfo.InvariantCulture);
                        }
                    }
                    break;

                case MemoryMode.Set:
                    tmpStrWeights = new string[numOfNeurons];

                    if (!File.Exists(path))
                    {
                        MessageBox.Show("WARNING!!! File " + name + "_memory.csv is not exists! For create this, tap \"OK\"",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    for(int i = 0; i < numOfNeurons; i++)
                    {
                        tmpStr = neurons[i].Weights[0].ToString();
                        for(int j = 0; j < numOfPrevNeurons + 1; j++)
                        {
                            tmpStr += spliterator[0] + neurons[i].Weights[j].ToString();
                        }
                    }
                    File.WriteAllLines(path, tmpStrWeights);
                    break;

                case MemoryMode.Init:
                    MessageBox.Show("WARNING!!! NeuroNet break down to basic settings!!!, tap \"OK\"",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    Random random = new Random();

                    double targetStd = Math.Sqrt(2.0 / (numOfPrevNeurons + numOfNeurons)); // нужное отклонение

                    tmpStrWeights = new string[numOfNeurons];
                    double[] tmpArr = new double[numOfPrevNeurons + 1];

                    for (int i = 0; i < numOfNeurons; i++)
                    {
                        double sum = 0.0;

                        for(int j = 0;j < numOfPrevNeurons + 1; j++)
                        {
                            tmpArr[j] = random.NextDouble();
                            sum += tmpArr[j];
                        }

                        double mean = sum / (numOfPrevNeurons + 1);
                        for (int j = 0; j < numOfPrevNeurons + 1; j++)
                        {
                            tmpArr[j] -= mean;
                        }

                        double sqSum = 0.0;
                        for (int j = 0; j < numOfPrevNeurons + 1; j++)
                        {
                            sqSum += tmpArr[j] * tmpArr[j];
                        }

                        double currentStd = Math.Sqrt(sqSum / numOfPrevNeurons + 1);

                        // масштабирование к целевому отклонению
                        double scale = currentStd > 1e-12 ? targetStd / currentStd : 1.0;

                        for (int j = 0; j < numOfPrevNeurons + 1; j++)
                        {
                            weights[i, j] = tmpArr[j] * scale;
                        }

                        string[] parts = new string[numOfPrevNeurons + 1]; 
                        for (int j = 0; j < numOfPrevNeurons + 1; j++)
                        {
                            parts[j] = weights[i, j].ToString(
                                "G17",
                                System.Globalization.CultureInfo.InvariantCulture);
                        }
                        tmpStrWeights[i] = string.Join(";", parts);
                    }

                    File.WriteAllLines(path, tmpStrWeights);

                    break;

                default:
                    break;
            }

            return weights;
        }

        abstract public void Recognize(Network network, Layer nextLayer); // для прямых проходов

        abstract public double[] BackwardPass(double[] stuff); // для обратного прозхода
    }
}
