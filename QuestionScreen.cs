
using Generic_Libraries;

namespace MathGame
{
    class QuestionScreen
    {
        struct GameQuestionVariables
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

        static private GameQuestionVariables gameQuestion;

      
        static private void ReadAnswer()
        {

            gameQuestion.userAnswer = Read_Int_Input.ReadNumber("\t\t\t\t\t\t   Your aanswer: ", "\t\t\t\t\t\t   Not A number, Enter a vaild number: ");

        }

        static private void ReadNumberInQuestion()
        {

            gameQuestion.Number1 = GameQuestion.GenerateRandomIntNumber();
            gameQuestion.Number2 = GameQuestion.GenerateRandomIntNumber();

        }

        static private void ReadOperatoreInQuestion()
        {

            gameQuestion._operator = GameQuestion.GetOperation();

        }

        static private void IsrigthAnswer()
        {

            gameQuestion.correctAnswer = 15;

            if(gameQuestion.correctAnswer == gameQuestion.userAnswer)
            {
                Console.WriteLine("\n\t\t\t\t\t\t    Correct!");
                gameQuestion.numberOfCorrectAnswer++;
            }
            else
            {
                Console.WriteLine($"\n\t\t\t\t\t    Wronge, Rigth Answer is: {gameQuestion.correctAnswer}");
                gameQuestion.numberOfWrongeAnswer++;
            }


        }


        static private void HeaderSreen()
        {

            Console.Write("\n\t\t\t\t\tM a t h  -  game  -  Q u e s t i o n\n\n");

        }

        static private void QuestionDesign()
        {

            Console.WriteLine("\t\t\t\t\t  _-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_\n");

            Console.WriteLine($"\t\t\t\t\t    Question [{gameQuestion.questionNumber}]:\n");

            Console.WriteLine($"\t\t\t\t\t\t    {gameQuestion.Number1}");
            Console.Write($"\t\t\t\t\t\t    {gameQuestion.Number2}");
            Console.WriteLine($"       {gameQuestion._operator}");
            Console.WriteLine("\t\t\t\t\t           _____________\n");

            ReadAnswer();
            IsrigthAnswer();

            Console.WriteLine("\n\t\t\t\t\t  -_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-\n\n");

        }

        static private void PrintQuestions()
        {

            gameQuestion.questionNumber = 0;

            for (int i = 0; i < 5; i++)
            {

                HeaderSreen();

                gameQuestion.questionNumber++;

                ReadNumberInQuestion();
                ReadOperatoreInQuestion();

                QuestionDesign();

                Console.Write("\t\t\t\t\tPress any key to go next question...");
                Console.ReadKey();
                Console.Clear();

            }

        }

        
        static public void QuestionsScreen()
        {

            Console.Clear();

            PrintQuestions();

        }

    }

}
