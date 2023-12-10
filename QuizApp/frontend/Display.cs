using QuizApp.backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.frontend
{
    public static class Display
    {
        public static void DisplayWelcome()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Witaj w grze Quiz");
            Console.WriteLine(" Spróbuj odpowiedzieć na 7 pytań");
            Console.WriteLine(" Powodzenia !!!");
            Console.WriteLine();
            Console.Write(" Naciśnij ENTER, aby rozpocząć grę ...");
            Console.ReadLine();
        }

        public static int DisplayQuestion(Question question)
        {
            Console.Clear();
            Console.WriteLine($" Pytanie za {question.Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(" " + question.Content);
            Console.WriteLine();
            // zabronić wpisania czegokolwiek innego
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($" {answer.Id}. {answer.Content}");
            }
            Console.WriteLine();
            Console.Write(" Naciśnij 1, 2, 3 lub 4 => ");
            return int.Parse(Console.ReadLine());
        }

        public static void DisplayGameOver()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Niestety, to nie jest dobra odpowiedź ...");
            Console.WriteLine();
            Console.WriteLine(" KONIEC GRY");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void DiplayAnswerOk()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Brawo, to jest dobra odpowiedź. Gratulacje !!! ...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
