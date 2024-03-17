namespace Feature_average;

public class FeatureMax
{
    public static int FindMaxValue(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub niezainicjowana.");
        }

        int max = array[0];
        foreach (int liczba in array)
        {
            if (liczba > max)
            {
                max = liczba;
            }
        }

        return max;
    }
    
    
}