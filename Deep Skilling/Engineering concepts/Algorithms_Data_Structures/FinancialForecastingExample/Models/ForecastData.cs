namespace FinancialForecastingExample.Models
{
    public class ForecastData
    {
        public double InitialValue { get; set; }

        public double GrowthRate { get; set; }

        public int Years { get; set; }

        public ForecastData(double initialValue,
                            double growthRate,
                            int years)
        {
            InitialValue = initialValue;
            GrowthRate = growthRate;
            Years = years;
        }
    }
}