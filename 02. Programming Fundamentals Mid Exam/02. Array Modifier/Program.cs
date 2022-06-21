using System;

using System.Linq;

class Program
{
    static void Main()
    {
        int[] intArray = Console.ReadLine()
            .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] tokens = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens[0] == "swap") SwapNumbersByIndexes(intArray, int.Parse(tokens[1]), int.Parse(tokens[2]));
            else if (tokens[0] == "multiply") MultiplyNumbers(intArray, int.Parse(tokens[1]), int.Parse(tokens[2]));
            else if (tokens[0] == "decrease") DecrementAllNumbers(intArray);
        }
        Console.WriteLine(String.Join(", ", intArray));
    }

    private static void DecrementAllNumbers(int[] intArray)
    {
        for (int i = 0; i < intArray.Length; i++)
            intArray[i]--;
    }

    private static void MultiplyNumbers(int[] intArray, int hostNum, int targetNum)
    {
        intArray[hostNum] *= intArray[targetNum];
    }

    private static void SwapNumbersByIndexes(int[] intArray, int index1, int index2)
    {
        int temp = intArray[index1];
        intArray[index1] = intArray[index2];
        intArray[index2] = temp;
    }
}