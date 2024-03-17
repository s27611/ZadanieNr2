namespace Feature_average;

public static class FeatureAverage
{
    public static double Average(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub niezainicjowana.");
        }

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}