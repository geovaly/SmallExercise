namespace SmallExercise
{
    public class Direction
    {
        private readonly int _value;

        public static readonly Direction Forward = new Direction(1);
        public static readonly Direction Backward = new Direction(-1);
        public static readonly Direction Null = new Direction(0);

        private Direction(int value)
        {
            _value = value;
        }

        public int NextPoint(int point)
        {
            return point + _value;
        }
    }
}
