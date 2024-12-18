using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_03
{
    internal class Program
    {
        #region 과제 3
        //static void Main(string[] args)
        //{
        //    int inputNum_1 = 0;
        //    int inputNum_2 = 0;
        //    int isNum = 0;
        //    bool condition = false;
        //    Console.WriteLine("두 수를 입력하여 차이에 따라 참/거짓을 반환하시오.");
        //    // Console.ReadLine();

        //    Console.WriteLine("첫번째 숫자를 입력해주세요.");
        //    inputNum_1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("두번 째 숫자를 입력해주세요.");
        //    inputNum_2 = int.Parse(Console.ReadLine());

        //    condition = SetNum(inputNum_1 , inputNum_2);
        //    isNum = inputNum_1 + inputNum_2;
        //    Console.WriteLine($"유저의 값은 {isNum}이고 반환 값은 {condition}");
        //}

        //static bool SetNum(int a , int b)
        //{
        //    int setNum = 0;

        //    bool isNum = false;

        //    setNum = a + b;

        //    if (setNum < 100)
        //    {
        //        Console.WriteLine("100 미만");
        //        isNum = true;
        //    }

        //    else if (setNum >= 100)
        //    {
        //        Console.WriteLine("100과 같거나 초과");
        //        isNum = false;
        //    }
        //    return isNum;
        //}
        #endregion

        #region 심화과제 1
        //static void Main(string[] args)
        //{
        //    int setNum = 0;
        //    int result = 0;

        //    Console.WriteLine("3,5의 배수들의 합을 구하여 정수형을 반환");
        //    Console.WriteLine("숫자 하나를 입력하시오.");
        //    setNum = int.Parse(Console.ReadLine());

        //    SumNum(setNum);

        //    result = SumNum(setNum);
        //    Console.WriteLine(result);
        //}


        //static int SumNum(int a)
        //{
        //    int three = 0;
        //    int five = 0;
        //    int setNum_1 = 0;
        //    int setNum_2 = 0;
        //    int sumNum = 0;

        //    for ( int i = 1; i < a + 1; i++)
        //    {
        //        if (i % 3 == 0)
        //        {
        //            three = three + 3;
        //            setNum_1 = setNum_1 + three;
        //        }
        //    }

        //    for (int i = 1; i < a + 1; i++)
        //    {
        //        if (i % 5 == 0)
        //        {
        //            five = five + 5;
        //            setNum_2 = setNum_2 + five;
        //        }
        //    }

        //    sumNum = setNum_1 + setNum_2;

        //    return sumNum;
        //}

        #endregion

        #region 심화과제 2
        static void Main(string[] args)
        {
            int inputNumber = 0;
            int sumInt = 0;

            //숫자를 입력받음
            inputNumber = int.Parse(Console.ReadLine());
            SumNumber(inputNumber);
            sumInt = SumNumber(inputNumber);

            Console.WriteLine($"입력한 값의 총 합은 {sumInt} 입니다.");
            Console.WriteLine($"입력한 값의 총 합은 {sumInt} 입니다.");
            Console.WriteLine($"입력한 값의 총 합은 {sumInt} 입니다.");

        }

        static int SumNumber(int inputNumber)
        {
            int sumInt = 0;

            string changeNumber = null;

            changeNumber = inputNumber.ToString();

            //변환한 스트링을 char 배열로 받음
            char[] charArr = changeNumber.ToCharArray();
            //char 배열의 길이 만큼 숫자형 배열 크기를 맞춤
            int intMaxArr = charArr.Length;

            int[] intArr = new int[intMaxArr];

            for (int i = 0; i < intMaxArr; i++)
            {
                intArr[i] = charArr[i] - 48;
                sumInt += intArr[i];
            }

            return sumInt;
        }

        #endregion

        #region 심화과제 3

        //static void Main(string[] args)
        //{
        //    long inputNumber = 0;
        //    long result = 0;

        //    inputNumber = long.Parse(Console.ReadLine());

        //    result = SetNumber(inputNumber);
        //    Console.WriteLine(result);
        //}

        //static long SetNumber(long inputNumber)
        //{
        //    long result = 0;
        //    long int_1 = 0;
        //    long int_2 = 1;

        //    long[] arrMax = new long[inputNumber];

        //    for (long i = 0; i < arrMax.Length - 1; i++)
        //    {
        //        result = int_1 + int_2;
        //        int_1 = int_2;
        //        int_2 = result;
        //    }
        //    return result;
        //}

        #endregion
     



    }
}
