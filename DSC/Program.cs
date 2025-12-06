using System.ComponentModel.Design;

namespace DSC
{
    internal class Program
    {

        #region q1
        //static void printsum(int a, int b)
        //{
        //    int sum = a + b;
        //    Console.WriteLine("The sum is: " + sum);
        //}
        #endregion
        #region q2
        //static void printnumbers(int n)
        //{
        //    for (int i = 1; i <= n; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion
        #region q3
        //static void swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        #endregion
        #region q4
        //public static void min_max(int[] arr)
        //{
        //    int min = arr[0];
        //    int max = arr[0];
        //    for(int i=0; i <= arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        else if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //        Console.WriteLine("max="+max + "\n min=" + min);
        //    }
        //} 
        #endregion
        #region q5
        //static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;
        //    if (number == 2) return true;
        //    if (number % 2 == 0) return false;

        //    int sqrt = (int)Math.Sqrt(number);
        //    for (int i = 3; i <= sqrt; i += 2)
        //    {
        //        if (number % i == 0) return false;
        //    }
        //    return true;
        //}
        #endregion
        #region q6
        //public static int factorial(int number)
        //{
        //    int result = 1;

        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= i;
        //    }

        //    return result;
        //}
        #endregion
        #region q7
        //public static int sod()
        //{
        //    Console.WriteLine("Enter a number:");
        //    int num = int.Parse(Console.ReadLine());
        //    int sum = 0;

        //    while (num > 0)
        //    {
        //        sum += num % 10;
        //        num /= 10;
        //    }

        //    return sum;

        //}   
        #endregion
        #region q8
        //public static void palindrome()
        //{
        //    Console.WriteLine("Enter a number:");
        //    string inp = Console.ReadLine();
        //    inp = inp.TrimStart('0').TrimEnd('0');

        //    bool ispalindrome = true;
        //    int length = inp.Length;

        //    for (int i = 0; i < length / 2; i++)
        //    {
        //        if (inp[i] != inp[length - 1 - i])
        //        {
        //            ispalindrome = false;
        //            break;
        //        }
        //    }

        //    if (ispalindrome)
        //        Console.WriteLine("YES");
        //    else
        //        Console.WriteLine("NO");
        //}
        #endregion
        #region q9

        //public static void ShiftZerosToRight(int[] arr, int n)
        //{
        //    List<int> zeros = new List<int>();
        //    List<int> nonzeros = new List<int>();
        //    int c = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (arr[i] != 0)
        //        {
        //            nonzeros.Add(arr[i]);
        //        }
        //        else
        //        {
        //            zeros.Add(arr[i]);
        //        }
        //    }
        //    nonzeros.AddRange(zeros);
        //    foreach (int x in nonzeros)
        //    {
        //        Console.Write(x);
        //    }
        //}
        #endregion
        #region q10
        //public static void swap(int n, int x, int y ,int[,] arr )
        //{
        //    --x;
        //    --y;
        //    for (int i = 0; i < n; i++)
        //    {
        //        int temp = arr[x, i];
        //        arr[x, i] = arr[y, i];
        //        arr[y, i] = temp;

        //    }
        //    for (int i = 0; i < n; i++)
        //    {
        //        int temp = arr[i, x];
        //        arr[i, x] = arr[i, y];
        //        arr[i, y] = temp;

        //    }
        //}
        #endregion

        #region q11
        //public static void harry()
        //{
        //    Console.WriteLine("Enter the binary number:");
        //    string binary = Console.ReadLine();

        //    int number = Convert.ToInt32(binary, 2);

        //    if (number % 2 == 0)
        //    {
        //        Console.WriteLine("AvadaKedavra");
        //    }
        //    else
        //    {
        //        Console.WriteLine("ExpectoPatronum");
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region q1
            //Console.WriteLine("Enter the first number:");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //int num2 = int.Parse(Console.ReadLine());

            //printsum(num1, num2);
            #endregion
            #region q2
            //Console.WriteLine("Enter a number:");
            //int n = int.Parse(Console.ReadLine());

            //printnumbers(n);
            #endregion
            #region q3
            //int a = 5;
            //int b = 10;
            //Console.WriteLine("Before swap: a = " + a + ", b = " + b);
            //swap(ref a, ref b);
            //Console.WriteLine("After swap: a = " + a + ", b = " + b);
            #endregion
            #region q4
            //Console.WriteLine("How many numbers do you want to enter?");
            //int n = int.Parse(Console.ReadLine());

            //int[] numbers = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Enter number {i + 1}:");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //min_max(numbers);
            #endregion
            #region q5
            //Console.WriteLine("Enter a number:");
            //int num = int.Parse(Console.ReadLine());

            //if (IsPrime(num))
            //    Console.WriteLine($"{num} is prime.");
            //else
            //    Console.WriteLine($"{num} is not prime.");
            #endregion
            #region q6
            //Console.WriteLine("Enter a number:");
            //int num = int.Parse(Console.ReadLine());

            //int fact = factorial(num);

            //Console.WriteLine("Factorial = " + fact);
            #endregion
            #region q7

            //int res = sod();
            //Console.WriteLine("Sum of digits = " + res);
            #endregion
            #region q8
            //palindrome();
            #endregion

            #region q9
            //int n = int.Parse(Console.ReadLine());

            //string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = int.Parse(parts[i]);
            //}

            //ShiftZerosToRight(arr, n);
            #endregion

            #region q10

            //Console.WriteLine("Enter the size of the matrix (N):");
            //int n = int.Parse(Console.ReadLine());

            //int[,] arr = new int[n, n];

            //Console.WriteLine("Enter the matrix elements row by row (separated by spaces):");
            //for (int i = 0; i < n; i++)
            //{
            //    string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr[i, j] = int.Parse(parts[j]);
            //    }
            //}

            //Console.WriteLine("Enter the rows/columns to swap (X Y):");
            //string[] swapInput = Console.ReadLine().Split(' ');
            //int x = int.Parse(swapInput[0]);
            //int y = int.Parse(swapInput[1]);

            //swap(n, x, y, arr);

            //Console.WriteLine("Matrix after swapping:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region q11
           //harry();
            #endregion
        }

    }
}
