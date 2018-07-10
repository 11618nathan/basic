using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBaseball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("------------Math Baseball----------");
            Console.WriteLine("");
            Console.WriteLine("랜덤으로 세 자릿수 하나 선택");
            Console.WriteLine("각 자리 수는 0 ~ 9 중 하나로 중복X");
            Console.WriteLine("모든 숫자와 위치를 맞히면 승리");
            Console.WriteLine("자리와 숫자 모두 -> 스트라이크");
            Console.WriteLine("숫자만 -> 볼");
            Console.WriteLine("숫자 X -> 아웃");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("");

            Random random = new Random();

            int[] ComputerNum = new int[3];
            int index = 0;
            while (index < 3)
            {
                ComputerNum[index] = random.Next(0, 10);

                bool isSameNumer = false;
                for (int j = 0; j < index; j++)
                {
                    if (ComputerNum[index] == ComputerNum[j])
                    {
                        isSameNumer = true;
                        break;
                    }
                }

                if (!isSameNumer)
                {
                    index++;
                }
            }


            int[] UserNum = new int[3];
            string[] message = { "백의 자리 숫자 입력: ", "십의 자리 숫자 입력: ", "일의 자리 숫자 입력: " };
             
            int strikeCount = 0;
            int ballCount = 0;

            while (true)
            {
                Console.WriteLine("-> 공격수");  
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(message[i]);
                    UserNum[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < 3; i++)
                { 
                    Console.WriteLine(UserNum[i]);
                }

                if (UserNum[0] == UserNum[1] || UserNum[1] == UserNum[2] || UserNum[1] == UserNum[2])
                {
                    Console.WriteLine("같은 숫자 입력X");
                    continue;
                }

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (ComputerNum[i] == UserNum[j])
                        {
                            if (i == j)
                            {
                                strikeCount++;
                            }
                            else
                            {
                                ballCount++;
                            }
                        }
                    }
                }

                Console.Write("스트라이크: ");
                Console.WriteLine(strikeCount);
                Console.Write("볼: ");
                Console.WriteLine(ballCount);
                Console.Write("아웃: ");
                Console.WriteLine(3 - strikeCount - ballCount);

                if (strikeCount == 3)
                {
                    Console.WriteLine("정답");
                    break;
                }
            }
        }
    }
}
