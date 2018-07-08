using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_programing
{
    class Program
    {
        static void Main(string[] args)
        {
            // 기본 출력
            Console.Write("Enter X");
            Console.WriteLine("Enter 포함");

            // ", ", \ 출력
            Console.WriteLine("\"");
            Console.WriteLine("\"");
            Console.WriteLine("\\");

            // 상수
            Console.WriteLine(2);
            Console.WriteLine(-2);

            // 실수
            Console.WriteLine(1.1618);

            // 문자열
            Console.WriteLine("문자열 출력");

            // 변수 지정 -> 왼쪽만 지정 가능
            int number = 11618;
            Console.WriteLine(number);
            string line = "Nathan";
            Console.WriteLine(line);


            // 숫자 연산자 +, -, *, /, %
            Console.WriteLine(1 + 0);
            Console.WriteLine(2 - 1);
            Console.WriteLine(2 * 3);
            Console.WriteLine(8 / 8);
            Console.WriteLine(30 % 11);

            // 문자열 연산자 +
            Console.WriteLine("문자" + "열");

            // 디버깅 / 디버그

            // 사용자 입력 받기
            Console.Write("입력: ");
            String Input = Console.ReadLine();
            Console.Write("출력: ");
            Console.WriteLine(Input);

            // 문자열 변환
            String InputNum = Console.ReadLine();
            int ParseNum = int.Parse(InputNum);
            Console.Write("출력: ");
            Console.WriteLine(ParseNum);

            // 비교 연산자
            // >
            int num_left = 3;
            int num_right = 7;
            Console.WriteLine(num_left > num_right);

            // <
            Console.WriteLine(num_left < num_right);

            // <=
            Console.WriteLine(num_left <= num_right);

            // >=
            Console.WriteLine(num_left >= num_right);

            // ==
            Console.WriteLine(num_left == num_right);

            // !=
            Console.WriteLine(num_left != num_right);

            // 조건문 136p
            int num_if = 17;
            if (num_if < 3)
            {
                Console.WriteLine("출력");
            }

            if (num_if < 4)
            {

            }
            else if (num_if < 14)
            {

            }
            else
            {

            }

            // 논리 연산자
            // && 논리곱연산자
            Console.WriteLine(num_left < 33 && num_right < 2);

            // || 논리합연산자
            Console.WriteLine(num_left < 33 || num_right < 2);

            // ! 논리부정연산자
            Console.WriteLine(!(num_left < 33 && num_right < 2));

            // 배열
            int[] numb = { 1, 1, 6, 1, 8 };

            // 배열 요소 접근 - 인덱스 0부터
            Console.WriteLine(numb[0]);

            // 다양한 종류 배열 생성
            Console.WriteLine("학생 숫자 입력: ");
            int studentNum = int.Parse(Console.ReadLine());

            int[] age = new int[studentNum];
            string[] names = new string[studentNum];
            double[] weight = new double[studentNum];


            // while()
            int num_while = 1;
            while (num_while < 10)
            {
                num_while = num_while + 1;
            }

            // break
            while (num_while != 0)
            {
                break;
            }

            // for문
            for(int index = 0; index < 3; index++)
            {
                Console.WriteLine(index);
            }

            // 이중 for문
            for(int i = 2; i <=9; i++)
            {
                for(int j=1; j<=9; j++)
                {
                    Console.Write(i);
                    Console.Write("*");
                    Console.Write(j);
                    Console.Write("=");
                    Console.Write(i*j);
                    Console.WriteLine("");
                }
            }

            // random
            Random random = new Random();
            int size = 3;
            int[] num_random = new int[size];
            for (int i = 0; i < 3; i++)
            {
                num_random[i] = random.Next(0, 10);
                Console.WriteLine(num_random[0]);
            }
        }
    }
}
