namespace Feature_average;

public class FeatureMax
{
    public static int FindMaxValue(int[] tab)
    {
        if (tab == null || tab.Length == 0)
        {
            throw new ArgumentException("Tablica jest pusta lub niezainicjowana.");
        }

<<<<<<< HEAD
        int max = tab[0];
        foreach (int liczba in tab)
        {
            if (liczba > max)
            {
                max = liczba;
=======
        int maximum = array[0];
        foreach (int num in array)
        {
            if (num > maximum)
            {
                maximum = num;
>>>>>>> feature-new
            }
        }

        return maximum;
    }
    
    
}