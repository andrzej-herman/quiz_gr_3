using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.backend
{
    public class Game
    {
        public List<Question> Questions { get; set; }
        public Question CurrentQuestion { get; set; }
        public int CurrentCategory { get; set; } = 100;

        public void CreateQuestions()
        {
            // utworzyć prawdziwe pytania
            Questions = new List<Question>();

            var q1 = new Question();
            q1.Category = 100;
            q1.Content = "Jak miał na imię Einstein?";

            var a1 = new Answer();
            a1.Id = 1;
            a1.Content = "Albert";
            a1.IsCorrect = true;
            q1.Answers.Add(a1);

            var a2 = new Answer();
            a2.Id = 2;
            a2.Content = "Adam";
            q1.Answers.Add(a2);

            var a3 = new Answer();
            a3.Id = 3;
            a3.Content = "John";
            q1.Answers.Add(a3);

            var a4 = new Answer();
            a4.Id = 4;
            a4.Content = "Tom";
            q1.Answers.Add(a4);

            Questions.Add(q1);
        }

        public void DrawQuestion()
        {
            // naprawdę losować
            CurrentQuestion = Questions[0];
        }

        public bool CheckUserAnswer(int number)
        {
            var userAnswer = CurrentQuestion.Answers.FirstOrDefault(x => x.Id == number);
            return userAnswer.IsCorrect;
        }

    }
}
