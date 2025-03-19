
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
            public char _operator;

        }

        static private GameQuestion gameQuestion;

        static private void HeaderSreen()
        {

            Console.Write("\n\t\t\t\t\tM a t h  -  game  -  Q u e s t i o n\n\n");

        }

        static private void QuestionDesign()
        {

            Console.WriteLine("\t\t\t\t\t    _-_-_-_-_-_-_-_-_-_-_-_-_-_\n");

            //Console.WriteLine($"\t\t\t\t\t Question [2]:");

            //Console.WriteLine($"\t\t\t\t\t Number 1");
            //Console.Write($"\t\t\t\t\t Number 2");
            //Console.WriteLine($"\t\t\t\t\t Operation");
            //Console.WriteLine("\t\t\t\t\t ----------------");

            //Get answer from user
            //Send response correct or wronge with rigth answer

            Console.WriteLine("\n\t\t\t\t\t    -_-_-_-_-_-_-_-_-_-_-_-_-_-");

        }



    }

}
