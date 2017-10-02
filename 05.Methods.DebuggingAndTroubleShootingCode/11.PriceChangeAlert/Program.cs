using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double limit = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = percent(lastPrice, currentPrice);
            bool IfSignificantIsDifferent = IsDifferent(difference, limit);
            string message = Get(currentPrice, lastPrice, difference, IfSignificantIsDifferent);

            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    private static string Get(double c, double lastPrice, double difference, bool isTrue)
    {
        string resultText = "";
        if (difference == 0)
        {
            resultText = string.Format("NO CHANGE: {0}", c);
        }
        else if (!isTrue)
        {
            resultText = string.Format("MINOR CHANGE: {0} resultText {1} ({2:F2}%)", lastPrice, c, difference);
        }
        else if (isTrue && (difference > 0))
        {
            resultText = string.Format("PRICE UP: {0} resultText {1} ({2:F2}%)", lastPrice, c, difference);
        }
        else if (isTrue && (difference < 0))
            resultText = string.Format("PRICE DOWN: {0} resultText {1} ({2:F2}%)", lastPrice, c, difference);
        return resultText;
    }

    private static bool IsDifferent(double limit, double isDiff)
    {
        if (Math.Abs(limit) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double percent(double l, double price)
    {
        double sum   = (price - l) / l;
        return sum;
    }
}
