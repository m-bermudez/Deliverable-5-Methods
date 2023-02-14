using System;

namespace Deliverable_5___Methods;
class Program
{
    static int[] random_array(int array_len)
    {
        //Randomly populate an array with integers numbers between 10 and 50. The array length is a parameter for the method.
        Random random = new Random();
        int[] RNGArray = new int[array_len];
        for (int i = 0; i < array_len; i++)
        {
            RNGArray[i] = random.Next(10, 50);
        }
        return RNGArray;
    }
    static int sum(int[] array)
    {
        int sum = 0;
        foreach (int item in array)
        {
            sum = sum + item;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        try
        {
            //Return the summation of all the elements of an array (the array is the parameter for this method).
            Console.WriteLine("Enter an integer between 5 and 15");
            int input = int.Parse(Console.ReadLine());
            if (input < 15 && input > 5)
            {
                int[] sampleArray = random_array(input);

                Console.WriteLine("The random elements in the array are: ");
                foreach (int element in sampleArray)
                {
                    Console.WriteLine(element + " ");
                }

                Console.WriteLine(" ");
                Console.WriteLine("The sum is: " + sum(sampleArray));
            }
            else
            {
                Console.WriteLine("Please enter an integer between 5 and 15");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter an integer");
        }
    }
}