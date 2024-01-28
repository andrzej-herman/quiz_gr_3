using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Game
    {
        public Game()
        {
            Random = new Random();
            CreateQuestions();
            AllCategories = Questions.Select(x => x.Category)
                .Distinct().OrderBy(x => x).ToList();

            CurrentCategory = AllCategories[CurrentCategoryIndex];
        }


        public List<Question> Questions { get; set; }
        public Question CurrentQuestion { get; set; }
        public int CurrentCategory { get; set; }
        public Random Random { get; set; }
        public int PlayerPoints { get; set; }
        public List<int> AllCategories { get; set; }
        public int CurrentCategoryIndex { get; set; }

        public void CreateQuestions()
        {
            Questions = DataCreator.GetQuestions();
        }

        public void DrawQuestion()
        {
            var qOfCurrentCat = Questions.Where(x => x.Category == CurrentCategory).ToList();
            var number = Random.Next(0, qOfCurrentCat.Count);
            var question = qOfCurrentCat[number];
            question.Answers = question.Answers.OrderBy(x => Random.Next()).ToList();

            var n = 1;
            foreach (var answer in question.Answers)
            {
                answer.DisplayOrder = n++;
            }


            CurrentQuestion = question;
        }

        public bool CheckUserAnswer(int number)
        {
            var userAnswer = CurrentQuestion.Answers.FirstOrDefault(x => x.DisplayOrder == number);
            var isCorrect = userAnswer.IsCorrect;
            if (isCorrect)
            {
                PlayerPoints += CurrentQuestion.Category;
            }

            return isCorrect;
        }

        public bool IsLastQuestion()
        {
            if (CurrentCategoryIndex >= AllCategories.Count - 1)
            {
                return true;
            }
            else
            {
                CurrentCategoryIndex++;
                CurrentCategory = AllCategories[CurrentCategoryIndex];
                return false;
            }

        }
    }
}
