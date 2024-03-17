namespace Feature_average;

public static class FeatureAverage
{
<<<<<<< HEAD
    public static double Average(int[] array)
    {
        if (array == null || array.Length == 0)
=======
    public static double Average(int[] tab)
    {
        if (tab == null || tab.Length == 0)
>>>>>>> feature-new
        {
            throw new ArgumentException("Tablica jest pusta lub niezainicjowana.");
        }

        int sum = 0;
<<<<<<< HEAD
        foreach (int num in array)
=======
        foreach (int num in tab)
>>>>>>> feature-new
        {
            sum += num;
        }

<<<<<<< HEAD
        return (double)sum / array.Length;
=======
        return (double)sum / tab.Length;
>>>>>>> feature-new
    }
}