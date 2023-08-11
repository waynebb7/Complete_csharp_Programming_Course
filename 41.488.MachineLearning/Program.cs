using System.Diagnostics;
using Microsoft.ML;
using Microsoft.ML.Data;


namespace _41._488.MachineLearning
{
    public class ComputerData
    {
        public float RAM { get; set; }
        public float Price { get; set; }
    }

    public class Prediction
    {
        [ColumnName("Score")]
        public float Price { get; set; }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MLContext mlContext = new MLContext();
            ComputerData[] computerData =
            {
                new ComputerData() {RAM=8, Price=800},
                new ComputerData() {RAM=16, Price=1000},
                new ComputerData() {RAM=32, Price=1500},
                new ComputerData() {RAM=64, Price=2500}
            };

            IDataView trainingData = mlContext.Data.LoadFromEnumerable(computerData);

            var pipeline = mlContext.Transforms.Concatenate("Features",
                new[] { "RAM" }).Append(mlContext.Regression.Trainers.Sdca(labelColumnName: "Price", maximumNumberOfIterations: 100));

            var model = pipeline.Fit(trainingData);

            ComputerData randomeAccessMemory = new ComputerData() { RAM = 100 };

            Prediction price = mlContext.Model.CreatePredictionEngine<ComputerData, Prediction>(model).Predict(randomeAccessMemory);

            Debug.WriteLine($"Predicted price for RAM: {randomeAccessMemory.RAM} price = {price.Price:C}");
        }
    }
}