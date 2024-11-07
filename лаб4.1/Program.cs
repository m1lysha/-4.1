class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Введите размер массива: ");
        int n = Convert.ToInt32(Console.ReadLine());

        
        int[] arr = new int[n];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        double average = sum / n;

       
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > average)
            {
                count++;
            }
        }

       
        double percentage = ((double)count / n) * 100;

     
        Console.WriteLine($"Процент элементов, превышающих среднеарифметическое: {percentage:F2}%");
    }
}
