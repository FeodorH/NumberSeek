using static System.Math;

namespace _32._1_Holkin_NumberSeek.NeuroNet
{
    class Neuron
    {
        private NeuronType type;
        private double[] weights;
        private double[] inputs;
        private double output;
        private double derivative;

        // константы для фун активации

        // св-ва
        public double[] Weights { get => weights; set => weights = value; }
        public double[] Inputs { get => inputs; set => inputs = value; }
        public double Output { get => output; }
        public double Derivative { get => derivative; }

        public Neuron(double[] memoryWeights, NeuronType neuronType)
        {
            weights = memoryWeights;
            type = neuronType;
        }

        public void Activator(double[] input)
        {
            inputs = input;

            double sum = weights[0];

            for (int i = 0; i < inputs.Length; i++)
            {
                sum += weights[i + 1] * inputs[i];
            }

            switch (type)
            {
                case NeuronType.Hidden:
                    output = tgh(sum);
                    derivative = derTgh(sum);
                    break;
                case NeuronType.Output:
                    output = Exp(sum);
                    derivative = Exp(sum);
                    break;
            }
        }

        private double tgh(double v)
        {
            return (Exp(v) - Exp(-v)) / (Exp(v) + Exp(-v));
        }

        private double derTgh(double v)
        {
            double t = tgh(v);
            return 1.0 - t * t;
        }
    }
}
