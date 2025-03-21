



namespace MathGame
{
    class GameQuestion
    {

        static private int from = 0;
        static private int to = 0;

        static private char _Operation = '\0';


        static public void SetRangeOfNumber(int _from, int _to)
        {

            from = _from;
            to = _to;

        }

        static public void SetOperationOfGame(char operation)
        {

            _Operation = operation;

        }

        static private int GenerateRandomIntNumber(int _from, int _to)
        {

            Random rnd = new Random();
            return rnd.Next(_from, _to);

        }


    }

}
