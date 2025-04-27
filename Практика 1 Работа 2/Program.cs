namespace Практика_1_Работа_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа 1. Проект 2.";
            Console.WindowWidth = 60; //Задаёт длину окна консоли
            Console.WindowHeight = 13; //Задаёт ширину окна консоли
            Console.BackgroundColor = ConsoleColor.Blue; //Задаёт фон окна консоле (синий)
            Console.Clear(); //Красит фон в заданный цвет
            Console.SetCursorPosition(15, 6); //Задаёт точку, в которой будет печататься следующий текст
            Console.Write("Введите своё имя: ");
            string Имя = Console.ReadLine();
            //Console.Write("Привет, " + Имя + "!");
            Console.Write("Привет, {0}!", Имя);
            Console.Write("\nДля завершения нажмите любую клавишу…");
            Console.ReadKey();
        }
    }
}
