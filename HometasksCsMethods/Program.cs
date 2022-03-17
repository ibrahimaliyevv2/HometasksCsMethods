using System;
//17.03.2022
namespace HometasksCsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hometask-1 Addition
            //string str = "samir";
            //char ch = 'm';
            //int index = IndexOfChar(str, ch);
            //Console.WriteLine(index);
            #endregion

            #region Hometask-2 Addition
            //int number = 50;
            //int result = NearestSquareRoot(number);
            //Console.WriteLine(result);
            #endregion

            #region Hometask-3 Addition
            //int result = SumOfDigits(152);
            //Console.WriteLine(result);
            #endregion

            #region Hometask-4 Addition
            //int[] numArray = { 12, 22, 423, 242, 353, 12311 };
            //int result = MaxInteger(numArray);
            //Console.WriteLine(result);
            #endregion

            #region Hometask-5 Addition
            //int[] numArray = { 13, 23, -77, 56, 45, -102 };
            //AllNumbersPositive(numArray);
            #endregion
        }

        //Hometask-1 Verilmis string deyerinde char-in hansi index deyerinde yerlesdiyini tapib qaytaran metod

        static int IndexOfChar(string str, char ch)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                {
                    return i;
                }

            }
            return -1;
        }


        //Hometask-2 Verilmis ededin en yaxin asagi kokaltisini tapib qaytaran metod

        static int NearestSquareRoot(int num)
        {
            int answer = 0;
            int i = 2;
            if (num == 0 || num == 1)
            {
                return num;
            }
            else if (num > 1){
                while(i * i <= num)
                {
                    answer = i;
                    i++;
                }
                return answer;
            }
            return -1;
        }


        //Hometask-3 Verilmis ededin reqemleri cemini tapib qaytaran metod

        static int SumOfDigits(int num)
        {
            int sum = 0;
            while(num!=0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }


        //Hometask-4 Verilmis integer array-in icindeki en boyuk deyeri tapan metod

        static int MaxInteger(int[] numbers)
        {
            int max=numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }


        //Hometask-5 Verilmis integer array-in butun elementlerini musbet sekilde qaytaran metod

        static void AllNumbersPositive(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = -numbers[i];
                }
                Console.WriteLine(numbers[i]);    
            }
            return;
        }


    }
}
