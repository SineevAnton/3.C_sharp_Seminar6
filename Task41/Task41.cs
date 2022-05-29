// User entering numbers to the console.
// Count how much of them are greater than 0.

Console.WriteLine("Write numbers, using comma with space(', ') between them");
Console.WriteLine("Example: 1, 2, 3, 4, 5");

int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int CountNumbersGreaterZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count += 1;
    }

    return count;
}

Console.WriteLine($"There are {CountNumbersGreaterZero(array)} positive numbers in your input.");