Console.WriteLine("Enter the number of array elements: ");
int arrSize = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the range of the interval [a; b]: ");
Console.WriteLine("Number a: ");
int rangeA = int.Parse(Console.ReadLine());
Console.WriteLine("Number b: ");
int rangeB = int.Parse(Console.ReadLine());

int[] arr = new int[arrSize];
Random random = new Random();

Console.WriteLine("Generated array:");
for (int i = 0; i < arrSize; i++)
{
    arr[i] = random.Next(rangeA, rangeB);
    Console.Write(arr[i] + " ");
}

int negativeSum = 0;
int minElement = 0;
int indexMaxElement = 0;


for (int i = 0; i < arrSize; i++)
{
    if (arr[i] < 0)
    {
        negativeSum += arr[i];
    }

    
    if (arr[i] < minElement)
    {
        minElement = arr[i];
    }

    if (arr[i] > arr[indexMaxElement])
    {
        indexMaxElement = i;
    }
}

