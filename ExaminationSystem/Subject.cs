using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    //internal class Subject
    //{
    //    public int SubjectId { get; set; }
    //    public string SubjectName { get; set; }
    //    public Exam ExamOfSubject { get; set; }

    //    public Subject(int subjectId, string subjectName)
    //    {
    //        SubjectId = subjectId;
    //        SubjectName = subjectName;
    //    }

    //    public void CreateExam()
    //    {
    //        //  الصفحة الأولى إعدادات الامتحان 
    //        int typeChoice;
    //        do
    //        {
    //            Console.WriteLine("Enter the type of exam (1 for Practical, 2 for Final):");
    //        } while (!int.TryParse(Console.ReadLine(), out typeChoice) || (typeChoice != 1 && typeChoice != 2));

    //        int time;
    //        do
    //        {
    //            Console.WriteLine("Please enter the time for the exam (30 to 180 minutes):");
    //        } while (!int.TryParse(Console.ReadLine(), out time) || time < 30 || time > 180);

    //        int numOfQuestions;
    //        do
    //        {
    //            Console.WriteLine("Please enter the number of questions:");
    //        } while (!int.TryParse(Console.ReadLine(), out numOfQuestions) || numOfQuestions <= 0);

    //        //  هدخل صفحة جديده علشان  ابدأ اكتب الاسألة
    //        Console.Clear();

    //        // إنشاء الامتحان حسب النوع
    //        if (typeChoice == 1) // لو اختار Practical
    //        {
    //            ExamOfSubject = new PracticalExam(time, numOfQuestions);
    //        }
    //        else
    //        {
    //            ExamOfSubject = new FinalExam(time, numOfQuestions);
    //        }

    //        ExamOfSubject.Questions = new Question[numOfQuestions];

            
    //        for (int i = 0; i < numOfQuestions; i++)
    //        {
    //            int qType = 2; // لو اختار Final
    //            if (typeChoice == 2) // لو الامتحان فاينل هسأله عن نوع السؤال
    //            {
    //                do
    //                {
    //                    Console.WriteLine($"Please enter the type of question {i + 1} (1 for True/False, 2 for MCQ):");
    //                } while (!int.TryParse(Console.ReadLine(), out qType) || (qType != 1 && qType != 2));
    //                Console.Clear();
    //            }

    //            if (qType == 1) // True / False 
    //            {
    //                Console.WriteLine("Please enter the question body:");
    //                string body = Console.ReadLine();

    //                int mark;
    //                do
    //                {
    //                    Console.WriteLine("Please enter the question mark:");
    //                } while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0);

    //                int rightChoiceId;
    //                do
    //                {
    //                    Console.WriteLine("Please enter the ID of the correct answer (1 for True, 2 for False):");
    //                } while (!int.TryParse(Console.ReadLine(), out rightChoiceId) || (rightChoiceId != 1 && rightChoiceId != 2));

    //                TrueOrFalseQuestion tf = new TrueOrFalseQuestion("True or False Question", body, mark);
    //                tf.RightAnswer = tf.AnswerList[rightChoiceId - 1];
    //                ExamOfSubject.Questions[i] = tf;
    //            }
    //            else // MCQ 
    //            {
    //                Console.WriteLine("Please enter the question body:");
    //                string body = Console.ReadLine();

    //                int mark;
    //                do
    //                {
    //                    Console.WriteLine("Please enter the question mark:");
    //                } while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0);

    //                Console.WriteLine("Choices of Question:");
    //                int choicesCount = 4;
    //                Answer[] answers = new Answer[choicesCount];

    //                for (int j = 0; j < choicesCount; j++)
    //                {
    //                    Console.WriteLine($"Please enter choice number {j + 1}:");
    //                    string choiceText = Console.ReadLine();
    //                    answers[j] = new Answer(j + 1, choiceText);
    //                }

    //                int rightChoiceId;
    //                do
    //                {
    //                    Console.WriteLine("Please enter the ID of the correct answer (1 to 4):");
    //                } while (!int.TryParse(Console.ReadLine(), out rightChoiceId) || rightChoiceId < 1 || rightChoiceId > choicesCount);

    //                MCQQuestion mcq = new MCQQuestion("MCQ Question", body, mark, choicesCount);
    //                mcq.AnswerList = answers;
    //                mcq.RightAnswer = answers[rightChoiceId - 1];

    //                ExamOfSubject.Questions[i] = mcq;
    //            }

    //            // مسح الشاشة لفتح صفحة جديدة للسؤال التالي
    //            Console.Clear();
    //        }
    //    }
    //}
}
        
    
