﻿using QuizApp.backend;
using QuizApp.frontend;
var game = new Game();
game.CreateQuestions();
Display.DisplayWelcome();
var question = game.DrawQuestion();
Display.DisplayQuestion(question);

Console.ReadLine();