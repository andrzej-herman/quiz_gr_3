using QuizApp.backend;
using QuizApp.frontend;

var game = new Game();
Display.DisplayWelcome();

while (true)
{
    game.DrawQuestion();
    var number = Display.DisplayQuestion(game.CurrentQuestion);
    var isOk = game.CheckUserAnswer(number);
    if (isOk)
    {
        if (game.IsLastQuestion())
        {
            Display.DisplaySuccess(game.PlayerPoints);
            break;
        }
        else
        {
            Display.DiplayAnswerOk();
        }
    }
    else
    {
        Display.DisplayGameOver();
        break;
    }

}
