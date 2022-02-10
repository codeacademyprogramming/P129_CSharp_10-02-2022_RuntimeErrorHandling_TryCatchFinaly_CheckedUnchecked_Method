using System;

namespace P129RuntimeTryCatchCheckedUncheckedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Runtime Error Handling, Try Catch Finaly, Checked Unchecked
            //int[] arr = { 2, 4, 7 };
            //Console.WriteLine("Indexi daxil");
            //string selected = Console.ReadLine();
            //Console.WriteLine("Ededleri Daxil Et:");
            //Console.WriteLine("A:");
            //string stra = Console.ReadLine();
            //Console.WriteLine("B:");
            //string strb = Console.ReadLine();

            //try
            //{
            //    int index = int.Parse(selected);

            //    Console.WriteLine(arr[index]);

            //    int a = int.Parse(stra);
            //    int b = int.Parse(strb);

            //    Console.WriteLine(a / b);
            //}
            //catch (IndexOutOfRangeException a)
            //{
            //    Console.WriteLine(a.Message);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Duzgun Deyer Et");
            //}
            //catch (OverflowException ex)
            //{
            //    //throw ex;
            //    Console.WriteLine(ex.Message);
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("Daxil Edilen Heddi Asir");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Ededi 0-a Bolmek Mumkun Deyil");
            //}
            //finally
            //{
            //    Console.WriteLine("Finaly Isledi");
            //}

            //Console.WriteLine("Hello World");

            //int number = 0;

            //try
            //{
            //    checked
            //    {
            //        int maxvalue = 2147483647;
            //        number = maxvalue + 100;
            //    }
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Hedini Asir");
            //}

            //try
            //{
            //    unchecked
            //    {
            //        int maxvalue = 2147483647;
            //        number = maxvalue + 100;
            //    }
            //}
            //catch (OverflowException)
            //{

            //    Console.WriteLine("Hedini Asir");
            //}

            //Console.WriteLine(number);//-2,147,483,548
            #endregion

            //Console.WriteLine("Daxil Et");
            //string selected = Console.ReadLine();

            //int result = SumEvenNumber(selected);

            //CheckDevideByFive(result);

            //int[] arr = { 1, 3, 6, 8, 21, 30 };
            //int a = 35;
            //int b = 40;
            //int result = SumEvenNumArray(a,5,7,8,15,20,30,b);
            //Console.WriteLine(result);
        }

        static int SumEvenNumber(string str)
        {
            int number = int.Parse(str);
            int evenSum = 0;

            for (int i = 0; i <= number; i++)
            {
                if (Check(i))
                {
                    evenSum += i;
                }
            }

            return evenSum;
        }

        static void CheckDevideByFive(int num)
        {
            if (Check(num, 5))
            {
                Console.WriteLine("5-e Bolunur");
            }
            else
            {
                Console.WriteLine("5-e Bolunmur");

            }
        }

        static bool Check(int num1, int num2 = 2)
        {
            //bool result = true;
            //if (num1 % num2 == 0)
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}

            //return result;

            //if (num1 % num2 == 0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            //if (num1 % num2 == 0)
            //{
            //    return true;
            //}
            //return false;

            //if (num1 % num2 == 0)
            //    return true;
            //return false;

            return num1 % num2 == 0 ? true : false;
        }

        static int SumEvenNumArray(params int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Check(arr[i]))
                    result += arr[i];
            }
            return result;
        }

        //Method Signature - Methodun Imzasi Eyni Classin Daxilinde Eyni Method Yaratmaq Ucun
        //1. Methodun Parametrlernin Sayi Ferqli Olmalidi
        //2. Methodun Parametrlernin Tipi Ferqli Olmalidi
        //3. Methodun Parametrlernin Sirasi Ferqli Olmalidi
        //Bu 3 sertden Biri Odendiyi Halda Method Overloadin Mentiqi Isdiyir
        static void Sum(int a, byte b)
        {
            Console.WriteLine(a+b);
        }

        static void Sum(int a, byte b, int c)
        {
            Console.WriteLine(a + b);
        }
        static void Sum(byte a, int b, int c)
        {
            Console.WriteLine(a + b);
        }
    }
}
