using System;

namespace _10in1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*1.*/ CheckN(8);


            //2

            int a = 70;
            int b = 880;
            int rez = EvenSum(a, b);
            Console.WriteLine("Sum of the even numbers : " + rez);

            //3

            int j = 70;
            int i = 880;
            int cons = OddNumbersSum(j, i);
            Console.WriteLine("Count of the random numbers : " + cons);


            //4

            int n = 68;
            int m = 775;
            int netice = OddNumbersSum(n, m);
            Console.WriteLine("Sum is :" + netice);


            //5

            int[] array = { 45, 8, 17, 99, 3, 18, 5, 11 };
            int sol = SumOfEven(array);
            Console.WriteLine(sol);

            //6

            int[] arrays = { 45, 8, 17, 99, 3, 18, 5, 11 };
            int res = SumOfEven(arrays);
            Console.WriteLine(res);


            //7

            int reqem = 24041045;
            string solution = PrimeOrComposite(reqem);
            Console.WriteLine(solution);

            //8

            int eded = 8;
            int answer = (eded);
            Console.WriteLine("Find whether eded equals the answer when 2 is raised to any power."+ answer);

            //9

            int[] arr = { 45, 8, 17, 99, 3, 18, 5, 11 };
            int arrResult = OnetoTwentyMultiple(arr);
            Console.WriteLine("The multiplication array of between one and twenty is  : " + arrResult);

            //10

            int[] numbers = { 8, 44, 1, 72, 67, 522, 120, 48, 193 };
            int result = SquareSumEven(numbers);
            Console.WriteLine("The square of the even numbers of sum is : " + result);

        }



        //Task 1 Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

        public static void CheckN(int n)
        {
            if (IsDivisible(n))
            {
                Console.WriteLine("Divisible by 3 and 7");

            }
            else
            {
                Console.WriteLine("Not divisible by 3 and 7");

            }
        }

        public static bool IsDivisible(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            {
                return true;
            }
            return false;
        }

        //Task 2 n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.


        public static int EvenSum(int n, int m )
        {
            int sum = 0;
            if (n % 2 == 0 && m % 2 == 0)
            {
                sum = n + m;
            }
            else
            {
                Console.WriteLine("Opps.. Something went wrong");
            }
            return sum;

        }

        //Task 3 Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.
        public static int OddNumbers(int n, int m)
        {
            int count = 0;
            if (n < 1 && m < 1)
            {
                Console.WriteLine("You have to enter valid number");

            }
            else
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        //Task 4 Verilmis n ve m(n<m) ededleri arasindaki tek ededlerin cemini tapin.


        public static int OddNumbersSum(int n, int m)
        {
            int sum = 0;
            if (n < 1 && m < 1)
            {
                Console.WriteLine("Opps.. Something went wrong");

            }
            else
            {
                for (int i = n; i < m; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;

        }


        //Task 5 Verilmish arrayin icindeki cut ededlerin cemini tapin.
        public static int SumOfEven(int[] array)
        {
            int sumEven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumEven += array[i];
                }

            }
            return sumEven;
        }




        //Task 6 Verilmish arrayin icindeki cut ededlerin sayini tapin.

        public static int CountOfEven(int[] array)
        {
            int countEven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    countEven ++;
                }

            }
            return countEven;
   
        }



        //Task 7 Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
        public static string PrimeOrComposite(int reqem)
        {
            int j = 1;
            if (reqem <= 1)
            {
                return "Opps..You have to enter valid number";
            }
            else
            {
                for (int i = 2; i < reqem; i++)
                {
                    if (reqem % i == 0)
                    {
                        j = 0;
                        break;
                    }
                }
                if (j == 1)
                {
                    return "The Number is Prime.";
                }
                else
                {
                    return "The Number is Composite.";

                }
            }


        }



        //Task 8 n ededi gelir. 2-ni hansisa quvvete yukseltdikde n-in alinan cavaba beraber olub-olmamasını tapın.

        public static string İsExponential(int eded)
        {
            if (eded <= 1)
            {
                return "Opps.. Something went wrong";
            }
            else
            {
                int i = 2;
                while (i < eded)
                {
                    i *= 2;
                }
                if (eded == i)
                {
                    return "Eded is equal to any exponential of 2.";
                }
                else
                {
                    return "Opps... We are sorry for this answer is NOT exponential of 2";
                }
            }
        }


        //Task 9 Verilmish arrayin-in elementlerinin icinden 1-20 arasinda olanlarinin hasilini tapmaq.Mes ([1,3,55,6,33], cavab : 18).

        public static int OnetoTwentyMultiple(int[] arr)
        {
            int multiple = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if ( 1 <= arr[i] && arr[i] <= 20)
                {
                    multiple *= arr[i];

                }
            }
            return multiple;

        }


        //Task 10 Verilmish arrayin elementlerininden cut olanlarinin ceminin kvadratini tapmaq.

        public static int SquareSumEven(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    sum += nums[i];
                }
            }
            int square = sum * sum;
            return square;
        }

    }



}

