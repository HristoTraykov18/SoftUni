using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double treshold = double.Parse(Console.ReadLine());
        double lastPrice = 0;

        for (int i = 0; i < n; i++)
        {
            double newPrice = double.Parse(Console.ReadLine());
            if (i == 0)
            {
                lastPrice = newPrice;
                continue;
            }
            double percenatageDifference = PercentageDifference(lastPrice, newPrice);
            bool isDifferent = IsDifferent(percenatageDifference, treshold);
            string message = CheckDifference(newPrice, lastPrice, percenatageDifference, isDifferent);
            Console.WriteLine(message);
            lastPrice = newPrice;
        }
    }
    private static double PercentageDifference(double lastPrice, double newPrice)
    {
        double difference = ((newPrice - lastPrice) / lastPrice) * 100;
        return difference;
    }
    private static bool IsDifferent(double percentageDifference, double treshold)
    {
        if (Math.Abs(percentageDifference) / 100 < treshold)
            return false;
        return true;
    }
    private static string CheckDifference(double newPrice, double lastPrice, double percentageDifference, bool isDifferent)
    {
        string output = "";
        if (percentageDifference == 0)
            output = string.Format("NO CHANGE: {0}", lastPrice);
        else if (!isDifferent)
            output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, newPrice, percentageDifference);
        else if (isDifferent && (percentageDifference > 0))
            output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, newPrice, percentageDifference);
        else if (isDifferent && (percentageDifference < 0))
            output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, newPrice, percentageDifference);
        return output;
    }
}