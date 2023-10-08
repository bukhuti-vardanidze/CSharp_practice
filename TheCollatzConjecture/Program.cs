namespace TheCollatzConjecture;

 class Program{
    static void Main(string[] args)
    {
        int num = Numb(10);
        Console.WriteLine(num);
    }

    static int Numb(int n)
    {
        int stepCounter=0;

        if (n <= 0)
        {
            throw new ArgumentException("Input must be a positive integer.");
        }

        
        while (n != 1) 
        { 
            if(n % 2 == 0)
            {
                n /= 2;
                Console.WriteLine($"step {stepCounter} - {n}");
            }
            else
            {
                n = n * 3 + 1;
                Console.WriteLine($"step {stepCounter} - {n}");
            }
            stepCounter++;
        }

        return stepCounter;
    }
}
