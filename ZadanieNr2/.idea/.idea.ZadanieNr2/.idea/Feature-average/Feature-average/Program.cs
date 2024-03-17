namespace Feature_average;

public static class FeatureAverage
{
    public static double Average(int[] zbior)
    {
        if (zbior == null || zbior.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub niezainicjowana.");
        }

        int sum = 0;
        foreach (int num in zbior)
        {
            sum += num;
        }

        return (double)sum / zbior.Length;
    }
}