namespace sort;
class Program
{
    static void Main(string[] args)
    {
        var rand = new Random(250);
        int[] numbers = new int[8];
        for (int i = 0; i < 8; i++)
        {
            numbers[i] = (int)(rand.NextDouble() * 100);
        }

        Console.WriteLine("Unsorted Array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        SelectionSort(numbers);

        Console.WriteLine("Sorted Array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    public static void SelectionSort(int[] nums)
    {
        var count = nums.Length;
        for (int i = 0; i < count - 1; i++)
        {
            var minIndex = i;
            for (int j = i + 1; j < count; j++) // Use j as the loop variable
            {
                if (nums[j] < nums[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the elements after finding the minimum
            var temp = nums[minIndex];
            nums[minIndex] = nums[i];
            nums[i] = temp;
        }
    }
}