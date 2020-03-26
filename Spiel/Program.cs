using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Core;


namespace Arbeitsauftrag_25._03._2020
{
    class Program
    {
        static void Main(string[] args)
        {

            Game quiz = new Game();

            Question f1 = new Question("Welcher Verein gewann in der Saison 40/41 die deutsche Bundesliga?");
            Answer a1 = new Answer("Bayern München");
            Answer b1 = new Answer("Eintracht Braunschweig");
            Answer c1 = new Answer("Rapid Wien", true);
            f1.AddAnswer(a1);
            f1.AddAnswer(b1);
            f1.AddAnswer(c1);
            quiz.AddQuestion(f1);

            Question f2 = new Question("Welcher Verein stand in der Euopaleague im Finale gegen Sevilla?");
            Answer a2 = new Answer("Middelsbrough");
            Answer b2 = new Answer("SV Casino Salzburg");
            Answer c2 = new Answer("Dnipro Dnipropetrovsk", true);
            f2.AddAnswer(a2);
            f2.AddAnswer(b2);
            f2.AddAnswer(c2);
            quiz.AddQuestion(f2);

            Question f3 = new Question("In welcher Saison stieg der jetzige Europaleague 8tel-Finalist 'Linzer ASK' in die Österreichische Erstklassigkeit auf?");
            Answer a3 = new Answer("12/13");
            Answer b3 = new Answer("01/02");
            Answer c3 = new Answer("16/17", true);
            f3.AddAnswer(a3);
            f3.AddAnswer(b3);
            f3.AddAnswer(c3);
            quiz.AddQuestion(f3);

            Question f4 = new Question("Der Verein 'VOC Rotterdam' wurde der erste Meister der Eredivise (Hollänidsche Erste Liga). In welcher Liga spielt der Verein jetzt?");
            Answer a4 = new Answer("2 Liga");
            Answer b4 = new Answer("Regionalliga");
            Answer c4 = new Answer("5 Liga", true);
            f4.AddAnswer(a4);
            f4.AddAnswer(b4);
            f4.AddAnswer(c4);
            quiz.AddQuestion(f4);


            while(quiz.Status == GameStatus.Active)
            {
                var fragen = quiz.NextQuestion;
                var antworten = fragen.Answers;
                Console.WriteLine(fragen.Text);
                int counter = 0;

                foreach(Answer f in antworten)
                {
                    Console.WriteLine("(" + counter + ")"+ antworten.Text;
                    counter++;
                }
                Console.WriteLine("Bitte geben Sie die Richtige Antwort ein: ");
                int index = Convert.ToInt32(Console.ReadLine());
                antworten[index].IsChecked = true;
                quiz.ValidateCurrentQuestion();
            }

            if(spiel.Status == GameStatus.HasFinished)
            {
                Console.WriteLine("Sie haben Gewonnen und alle Level gemeistert");
            }
            else
            {
                Console.WriteLine("Sie haben verloren, Sie haben dieses Level:"+ spiel.Level);
            }



        }
    }
}
