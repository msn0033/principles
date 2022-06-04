// See https://aka.ms/new-console-template for more information
using Open_Closed_Principle.After;

Console.WriteLine("Hello, World!");

Quiz quiz =new Quiz(new QuestionsBank().QuestionsGenerator());
quiz.Print(); 