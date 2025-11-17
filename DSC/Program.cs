namespace DSC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //double R = double.Parse(Console.ReadLine());
            //double p = 3.141592653;
            //double area = p * R * R;
            //Console.WriteLine(area.ToString("F9"));
            #endregion
            #region q2
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x} + {y} = {x + y}");
            //Console.WriteLine($"{x} * {y} = {x * y}");
            //Console.WriteLine($"{x} - {y} = {x - y}");
            #endregion
            #region q3
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());

            //if (A % B == 0 || B % A == 0)
            //{
            //    Console.WriteLine("Multiples");
            //}
            //else
            //{
            //    Console.WriteLine("No Multiples");
            //}
            #endregion
            #region q4
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if(a>b && a > c)
            //{
            //    Console.WriteLine("max="+a);
            //}
            //else if(b>a&& b > c)
            //{
            //    Console.WriteLine("max=" + b);
            //}
            //else
            //{
            //    Console.WriteLine("max=" + c);
            //}
            //if (a < b && a < c)
            //{
            //    Console.WriteLine("min=" + a);
            //}
            //else if (b < a && b < c)
            //{
            //    Console.WriteLine("min=" + b);
            //}
            //else
            //{
            //    Console.WriteLine("min=" + c);
            //}
            #endregion
            #region q5
            //char X = char.Parse(Console.ReadLine());

            //if (char.IsDigit(X))
            //{
            //    Console.WriteLine("IS DIGIT");
            //}
            //else
            //{
            //    Console.WriteLine("ALPHA");

            //    if (char.IsUpper(X))
            //    {
            //        Console.WriteLine("IS CAPITAL");
            //    }
            //    else
            //    {
            //        Console.WriteLine("IS SMALL");
            //    }
            //}
            #endregion
            #region q6
            //int A = int.Parse(Console.ReadLine());
            //char S =char.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //char Q = char.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());

            //int result;

            //switch (S)
            //{
            //    case '+':
            //        result = A+B;
            //        break;

            //    case '-':
            //        result = A-B;
            //        break;

            //    case '*':
            //        result = A*B;
            //        break;
            //}

            //if (result == C)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion
            #region q7
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //int D = int.Parse(Console.ReadLine());

            //int product = A * B * C * D;

            //int lastTwo = product % 100;

            //Console.WriteLine(lastTwo.ToString("D2"));
            #endregion
            #region q8
            //double a = double.Parse(Console.ReadLine());
            //double b = double.Parse(Console.ReadLine());
            //double c = double.Parse(Console.ReadLine());
            //double d = double.Parse(Console.ReadLine());

            //double power1 = Math.Pow(a, b);
            //double power2 = Math.Pow(c, d);

            //if (power1 > power2)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            #endregion
            #region q9
            //int x;
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine(x);
            #endregion

            #region q10
            //string input = Console.ReadLine();

            //string digits = "";

            //foreach (char c in input)
            //{
            //    if (char.IsDigit(c))  
            //    {
            //        digits += c;        
            //    }
            //}

            //int number = int.Parse(digits);
            //Console.WriteLine(number);

            #endregion




            #region q11
            //Console.Write("Enter the string: ");
            //string text = Console.ReadLine();

            //Console.Write("Enter start index: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Enter length: ");
            //int length = int.Parse(Console.ReadLine());

            //string result = text.Substring(start, length);

            //Console.WriteLine("Extracted substring: " + result);

            #endregion
            #region q13
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string onevar = x + y;
            //Console.WriteLine(onevar);
            #endregion
            #region q14
            //Console.Write("Enter principal amount: ");
            //double principal = double.Parse(Console.ReadLine());

            //Console.Write("Enter rate of interest: ");
            //double rate = double.Parse(Console.ReadLine());

            //Console.Write("Enter time: ");
            //double time = double.Parse(Console.ReadLine());

            //double interest = (principal * rate * time) / 100;

            //Console.WriteLine("Simple Interest = " + interest);
            #endregion
            #region q14
            //Console.Write("Enter temperature: ");
            //int temp = int.Parse(Console.ReadLine());
            //string result;
            //if (temp < 10)
            //{
            //    result = "jusr cold";
            //    Console.WriteLine( result);
            //}
            //else if (temp > 30)
            //{
            //    result = "jusr hot";
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    result = "just good";
            //    Console.WriteLine(result);
            //}
            #endregion
            #region q15
            //int num = int.Parse(Console.ReadLine());

            //if (num % 3 == 0 && num % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}  
            #endregion
            #region q16
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}
            #endregion
            #region q17
            //char ch = char.Parse(Console.ReadLine().ToLower());

            //switch (ch)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("Vowel");
            //        break;

            //    default:
            //        Console.WriteLine("Consonant");
            //        break;
            //}
            #endregion
        }
    }
}
