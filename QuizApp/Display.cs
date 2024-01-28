using Quiz;

namespace QuizApp
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
            ShowQuestion(question);
            var userInput = Console.ReadLine();
            var correctKey = IsCorrectKey(userInput);
            while (!correctKey)
            {
                ShowQuestion(question);
                userInput = Console.ReadLine();
                correctKey = IsCorrectKey(userInput);
            }

            return int.Parse(userInput);
        }

        public static void DisplaySuccess(int points)
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Brawo, ukończyłeś/aś cały Quiz. Gratulacje !!! ...");
            Console.WriteLine();
            Console.WriteLine($" Łącznie zdobyłeś/aś {points} pkt. KONIEC GRY");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
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
            Console.ReadLine();
        }

        public static void DiplayAnswerOk()
        {
            Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Brawo, to jest dobra odpowiedź. Gratulacje !!! ...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" Naciśnij ENTER, aby zobaczyć następne pytanie ...");
            Console.ReadLine();
        }

        private static bool IsCorrectKey(string input)
        {
            var acceptedKeys = new List<string>() { "1", "2", "3", "4" };
            return acceptedKeys.Contains(input);
        }

        private static void ShowQuestion(Question question)
        {
            Console.Clear();
            Console.WriteLine($" Pytanie za {question.Category} pkt.");
            Console.WriteLine();
            Console.WriteLine(" " + question.Content);
            Console.WriteLine();
            foreach (var answer in question.Answers)
            {
                Console.WriteLine($" {answer.DisplayOrder}. {answer.Content}");
            }
            Console.WriteLine();
            Console.Write(" Naciśnij 1, 2, 3 lub 4 => ");
        }

    }
}
