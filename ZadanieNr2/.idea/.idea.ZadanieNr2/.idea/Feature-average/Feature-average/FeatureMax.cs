namespace Feature_average;

public class FeatureMax
{
    public static int FindMaxValue(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub niezainicjowana.");
        }

        int maximum = array[0];
        foreach (int num in array)
        {
            if (num > maximum)
            {
                maximum = num;
            }
        }

        return maximum;
    }
    
    
}