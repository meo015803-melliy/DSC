namespace DSC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Console.Write("Enter a number : ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(number + " x " + i + " = " + (num * i));
            //}
            #endregion


            #region q2
            //Console.Write("Enter a number: ");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;
            //int i = 1;

            //while (i <= n)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine("The sum is: " + sum);

            #endregion



            #region q3
            //Console.Write("How many numbers will you enter? ");
            //int count = int.Parse(Console.ReadLine());

            //int[] numbers = new int[count];

            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write("Enter number " + (i + 1) + ": ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int evenCount = 0;
            //int oddCount = 0;

            //foreach (int num in numbers)
            //{
            //    if (num % 2 == 0)
            //    {
            //        evenCount++;
            //    }
            //    else
            //    {
            //        oddCount++;
            //    }
            //}

            //Console.WriteLine("Even numbers: " + evenCount);
            //Console.WriteLine("Odd numbers: " + oddCount);

            #endregion

            #region q4
            //int sum = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("Enter number " + i + ": ");
            //    int num = int.Parse(Console.ReadLine());

            //    if (num < 0)
            //    {
            //        Console.WriteLine("Negative numbers are skipped.");
            //        continue;
            //    }

            //    if (num == 999)
            //    {
            //        Console.WriteLine("Stop signal received. Ending input early.");
            //        break;
            //    }

            //    sum += num;

            //    Console.WriteLine("Sum of valid numbers: " + sum);
            //    }
            #endregion


            #region bonus1
            //Console.Write("How many numbers will you enter? ");
            //int n = int.Parse(Console.ReadLine());

            //int[] numbers = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter number " + (i + 1) + ": ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.Write("Enter the target number: ");
            //int target = int.Parse(Console.ReadLine());

            //int[] result = new int[2];
            //bool found = false;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] + numbers[j] == target)
            //        {
            //            result[0] = i;
            //            result[1] = j;
            //            found = true;
            //            break;
            //        }
            //    }
            //    if (found) break;
            //}

            //if (found)
            //{
            //    Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
            //}

            //else {
            //    Console.WriteLine("No solution found "); 
            //}


            #endregion
        }
    }
}
