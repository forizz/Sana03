Console.WriteLine("Enter the number of array elements: ");
int arrSize = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the range of the interval [a; b]: ");
Console.WriteLine("Number a: ");
int rangeA = int.Parse(Console.ReadLine());
Console.WriteLine("Number b: ");
int rangeB = int.Parse(Console.ReadLine());

double[] arr = new double[arrSize];
Random random = new Random();

Console.WriteLine("Generated array:");
for (int i = 0; i < arrSize; i++)
{
    arr[i] =  Math.Round(random.NextDouble() * (rangeA - rangeB) + rangeB, 2);
    Console.Write($"{arr[i]} | ");
}
    Console.WriteLine("\n");

double negativeSum = 0;
double minElement = 0;
int indexMaxElement = 0;
double maxAbsElement = 0;
double sumPositiveIndex = 0;
int countIntegerNums = 0;


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

    double absNum = Math.Abs(arr[i]);
    if(absNum > maxAbsElement)
    {
        maxAbsElement = absNum;
    }

    if (arr[i] > 0)
    {
        sumPositiveIndex += i;
    }

    if (arr[i] % 1 == 0)
    {
        countIntegerNums++;
    }

}
    Console.WriteLine($"Sum of negative elements: {negativeSum}");
    Console.WriteLine($"Minimum element: {minElement}");
    Console.WriteLine($"Index of the maximum element: {indexMaxElement}");
    Console.WriteLine($"Maximum absolute element: {maxAbsElement}");
    Console.WriteLine($"Sum of indexes of positive elements: {sumPositiveIndex}");
    Console.WriteLine($"Count of integers in the array: {countIntegerNums}");

