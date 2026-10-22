using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    //internal class FinalExam : Exam
    //{
    //    public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
    //    {
    //    }

    //    //  الميثود الي بتعرض الامتحان للطالب وتخليه يجاوب وتحسب وقت الامتحان ده للفاينل

    //    public override void ShowExam()
    //    {
    //        Answer[] userAnswers = new Answer[NumberOfQuestions];// علشان فيها الاجابة الي الطالب هيختارها علشان اقرنها بالصح

    //        Stopwatch sw = new Stopwatch(); // علشان احسب بيها وقت الامتحان من اول ما الطالب يبدأ
    //        sw.Start();

    //        Console.WriteLine("Final Exam");

    //        for (int i = 0; i < Questions.Length; i++)
    //        {
    //            Console.WriteLine($"Question {i + 1}: {Questions[i].Body}");
    //            Console.WriteLine($"{Questions[i].Header}:      Mark {Questions[i].Mark}");

    //            for (int j = 0; j < Questions[i].AnswerList.Length; j++)
    //            {
    //                Console.WriteLine($"{Questions[i].AnswerList[j].AnswerId}- {Questions[i].AnswerList[j].AnswerText}");
    //            }

    //            int choice;
    //            do
    //            {
    //                Console.WriteLine("Enter your answer ID: ");
    //            } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Questions[i].AnswerList.Length);

    //            userAnswers[i] = Questions[i].AnswerList[choice - 1];
    //            Console.WriteLine("-----------------------------------");
    //        }

    //        sw.Stop();
    //        Console.Clear();

    //        Console.WriteLine("Final Exam Results:");
    //        int totalMarks = 0;
    //        int obtainedMarks = 0;

    //        for (int i = 0; i < Questions.Length; i++)
    //        {
    //            totalMarks += Questions[i].Mark;
    //            bool isCorrect = userAnswers[i].AnswerId == Questions[i].RightAnswer.AnswerId;
    //            if (isCorrect)
    //            {
    //                obtainedMarks += Questions[i].Mark;
    //            }

    //            Console.WriteLine($"Question {i + 1}: {Questions[i].Body}");
    //            Console.WriteLine($"Your Answer => {userAnswers[i].AnswerText}");
    //            Console.WriteLine($"Correct Answer => {Questions[i].RightAnswer.AnswerText}\n");
    //        }
    //  // تطبع درجة الطالب بعد الحل والوقت
    //        Console.WriteLine($"Your Grade is {obtainedMarks} from {totalMarks}");
    //        Console.WriteLine($"Time = {sw.Elapsed}");
    //        Console.WriteLine("Thank you");
    //    }
    //}
}
