



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

        static private void SetOperationOfGame(char operation)
        {

            _Operation = operation;

        }


    }

}
