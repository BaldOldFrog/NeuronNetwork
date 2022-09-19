namespace NeuronNetwork
{
    class Neuron
    {
        public List<double> Weights { get; }
        public NeyronType NeyronType { get; }
        public double Output { get; private set; }

        public Neuron(int inputCount, NeyronType type = NeyronType.Normal)
        {
            NeyronType = type;
            Weights = new List<double>();

            for(int i = 0; i < inputCount; i++)
            {
                Weights.Add(1);
            }
        }

        public double FeedForward(List<double> inputs)
        {
            var sum = 0.0;
            for(int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weights[i];
            }

            Output = Sigmoid(sum);
            return Output;
        }

        private double Sigmoid(double x)
        {
            var result = 1.0 / (1.0 + Math.Exp(-x));
            return result;
        }

        public override string ToString()
        {
            return Output.ToString();
        }
    }
}
