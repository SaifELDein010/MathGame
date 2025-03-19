
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

        }

        static private GameQuestion gameQuestion;

        static private void HeaderSreen()
        {

            Console.Write("\n\t\t\t\t\tM a t h  -  game  -  Q u e s t i o n\n\n");

        }

        static private void ReadAnswer()
        {

            gameQuestion.userAnswer = Read_Int_Input.ReadNumber("\t\t\t\t\tYour aanswer: ", "Not A number, Enter a vaild number: ");

        }

        static private void IsrigthAnswer()
        {

            gameQuestion.correctAnswer = 0;

            if(gameQuestion.correctAnswer == gameQuestion.userAnswer)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Wronge {gameQuestion.correctAnswer}");
            }


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



    }

}
