namespace FinancialForecastingExample.Services
{
    public class ForecastService
    {
        public static double PredictFutureValue(
            double currentValue,
            double growthRate,
            int years)
        {
            // Base Case
            if (years == 0)
            {
                return currentValue;
            }

            return PredictFutureValue(
                currentValue * (1 + growthRate / 100),
                growthRate,
                years - 1);
        }
    }
}