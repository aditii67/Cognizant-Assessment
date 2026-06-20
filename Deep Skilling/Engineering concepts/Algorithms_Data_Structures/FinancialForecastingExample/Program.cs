using FinancialForecastingExample.Models;
using FinancialForecastingExample.Services;

namespace FinancialForecastingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine(" FINANCIAL FORECASTING SYSTEM ");
            Console.WriteLine("=================================");

            Console.Write("Enter Initial Value: ");
            double initialValue =
                Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Annual Growth Rate (%): ");
            double growthRate =
                Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Number of Years: ");
            int years =
                Convert.ToInt32(Console.ReadLine());

            ForecastData forecast =
                new ForecastData(
                    initialValue,
                    growthRate,
                    years);

            double futureValue =
                ForecastService.PredictFutureValue(
                    forecast.InitialValue,
                    forecast.GrowthRate,
                    forecast.Years);

            Console.WriteLine("\nForecast Result");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Present Value : {forecast.InitialValue}");
            Console.WriteLine($"Growth Rate   : {forecast.GrowthRate}%");
            Console.WriteLine($"Years         : {forecast.Years}");
            Console.WriteLine($"Future Value  : {futureValue:F2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}