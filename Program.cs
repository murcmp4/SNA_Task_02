using System;

namespace SNA_Task_02
{
    class Program
    {
        static void Main()
        {
            string question;

            Random rand = new Random();
            int fate;

            bool isContinue = true;
            string continueAnswer;

            while (isContinue)
            {
                Console.Write("Шар предсказаний: ");
                question = Console.ReadLine();

                fate = rand.Next(0, 10);

                switch (fate)
                {
                    case 0:
                        Console.Write("Это правдеподобно\n");
                        break;
                    case 1:
                        Console.Write("Может быть\n");
                        break;
                    case 2:
                        Console.Write("Не уверен\n");
                        break;
                    case 3:
                        Console.Write("Скорее нет, чем да\n");
                        break;
                    case 4:
                        Console.Write("Уверен, что нет\n");
                        break;

                    case 5:
                        Console.Write("Мне подсказали, что нет\n");
                        break;
                    case 6:
                        Console.Write("Я бы не рассчитывал\n");
                        break;
                    case 7:
                        Console.Write("ДА! ДА! ДА!\n");
                        break;
                    case 8:
                        Console.Write("Есть одно но\n");
                        break;
                    case 9:
                        Console.Write("Еще раз спроси\n");
                        break;

                    case 10:
                        Console.Write("Попробуй позже\n");
                        break;
                }

                Console.Write("Продолжить? ? [Y / Exit]\n");
                continueAnswer = Console.ReadLine();

                //Выход если
                if (continueAnswer == "Exit" || continueAnswer == "exit")
                {
                    isContinue = false;
                }
            }
        }
    }
}