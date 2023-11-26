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
            Console.WriteLine(" Witaj w grze Quiz");
            Console.WriteLine(" Spróbuj odpowiedzieć na 7 pytań");
            Console.WriteLine(" Powodzenia !!!");
            Console.WriteLine();
            Console.Write(" Naciśnij ENTER, aby rozpocząć grę ...");
            Console.ReadLine();
        }

        public static void DisplayQuestion(Question question)
        {
            Console.Clear();
            Console.WriteLine(" Pytanie za " + question.Category + " pkt.");
            Console.WriteLine();
            Console.WriteLine(" " + question.Content);
            Console.WriteLine();

        }

    }
}
