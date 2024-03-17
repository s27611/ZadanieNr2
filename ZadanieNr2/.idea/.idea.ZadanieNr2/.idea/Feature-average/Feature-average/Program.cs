namespace Feature_average;

public static class FeatureAverage
{
    public static double Average(int[] tab)
    {
        if (tab == null || tab.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub niezainicjowana.");
        }

        int sum = 0;
        foreach (int num in tab)
        {
            sum += num;
        }

        return (double)sum / tab.Length;
    }
}