using System;

public class KlasaC
{
    public int Zbroj(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return sum;
    }

    public double Prosjek(int[] array)
    {
        int sum = Zbroj(array);
        double average = (double)sum / array.Length;
        return average;
    }
}

public class Program
{
    public static void Main()
    {
        KlasaC objekt = new KlasaC();
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int zbroj = objekt.Zbroj(numbers);
        double prosjek = objekt.Prosjek(numbers);

        Console.WriteLine("Sum: " + zbroj);
        Console.WriteLine("Average: " + prosjek);
    }
}
