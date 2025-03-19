
using Generic_Libraries;

namespace MathGame
{
    class QuestionScreen
    {
        struct GameQuestion
        {

            public int Number1;
            public int Number2;
            public int correctAnswer;
            public int userAnswer;
            public int questionNumber;
            public char _operator;

            public short numberOfCorrectAnswer;
            public short numberOfWrongeAnswer;

        }

        static private GameQuestion gameQuestion;

      
        static private void ReadAnswer()
        {

            gameQuestion.userAnswer = Read_Int_Input.ReadNumber("\t\t\t\t\tYour aanswer: ", "Not A number, Enter a vaild number: ");

        }

        static private void ReadNumberInQuestion()
        {

            gameQuestion.Number1 = 0;
            gameQuestion.Number2 = 0;

        }

        static private void ReadOperatoreInQuestion()
        {

            gameQuestion._operator = '+';

        }

        static private void IsrigthAnswer()
        {

            gameQuestion.correctAnswer = 0;

            if(gameQuestion.correctAnswer == gameQuestion.userAnswer)
            {
                Console.WriteLine("Correct!");
                gameQuestion.numberOfCorrectAnswer++;
            }
            else
            {
                Console.WriteLine($"Wronge {gameQuestion.correctAnswer}");
                gameQuestion.numberOfWrongeAnswer++;
            }


        }


        static private void HeaderSreen()
        {

            Console.Write("\n\t\t\t\t\tM a t h  -  game  -  Q u e s t i o n\n\n");

        }

        static private void QuestionDesign()
        {

            Console.WriteLine("\t\t\t\t\t    _-_-_-_-_-_-_-_-_-_-_-_-_-_\n");

            Console.WriteLine($"\t\t\t\t\t Question [{gameQuestion.questionNumber}]:");

            Console.WriteLine($"\t\t\t\t\t {gameQuestion.Number1}");
            Console.Write($"\t\t\t\t\t {gameQuestion.Number2}");
            Console.WriteLine($"\t\t\t\t\t {gameQuestion._operator}");
            Console.WriteLine("\t\t\t\t\t ----------------");

            ReadAnswer();
            IsrigthAnswer();

            Console.WriteLine("\n\t\t\t\t\t    -_-_-_-_-_-_-_-_-_-_-_-_-_-");

        }

        static private void PrintQuestions()
        {

            gameQuestion.questionNumber = 0;

            for (int i = 0; i < 5; i++)
            {

                gameQuestion.questionNumber++;

                ReadNumberInQuestion();
                ReadOperatoreInQuestion();

                QuestionDesign();

            }

        }

        
        static public void QuestionsScreen()
        {

            Console.Clear();

            HeaderSreen();
            PrintQuestions();

        }

    }

}
