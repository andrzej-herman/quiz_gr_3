using QuizApp.backend;
using QuizApp.frontend;

var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
game.DrawQuestion();
var number = Display.DisplayQuestion(game.CurrentQuestion);
var isOk = game.CheckUserAnswer(number);
if (isOk)
{
    Display.DiplayAnswerOk();
}
else
{
    Display.DisplayGameOver();
}















Console.ReadLine();