namespace SmallExercise
{
    public class RayOfLight
    {
        private readonly LineSegment _verticalSegment;
        private readonly LineSegment _horizontalSegment;

        public RayOfLight(int m, int n)
        {
            _verticalSegment = new LineSegment(m);
            _horizontalSegment = new LineSegment(n);
        }

        public Position CurrentPosition
        {
            get
            {
                return new Position(
                    _verticalSegment.RayPoint,
                    _horizontalSegment.RayPoint);
            }
            set
            {
                _verticalSegment.RayPoint = value.X;
                _horizontalSegment.RayPoint = value.Y;
            }
        }

        public Direction VerticalDirection
        {
            get { return _verticalSegment.Direction; }
            set { _verticalSegment.Direction = value; }
        }

        public Direction HorizontalDirection
        {
            get { return _horizontalSegment.Direction; }
            set { _horizontalSegment.Direction = value; }
        }

        public bool HasReachedACorner
        {
            get
            {
                return _verticalSegment.RayHasReachedAnEndPoint &&
                       _horizontalSegment.RayHasReachedAnEndPoint;
            }
        }
        public void TravelOnePosition()
        {
            _verticalSegment.RayTravelOnePoint();
            _horizontalSegment.RayTravelOnePoint();
        }

        private class LineSegment
        {
            public int Size { get; private set; }

            public Direction Direction { get; set; }

            public int RayPoint { get; set; }

            public bool RayHasReachedAnEndPoint
            {
                get { return RayPoint == FirstPoint || RayPoint == LastPoint; }
            }

            public LineSegment(int size)
            {
                Size = size;
                RayPoint = FirstPoint;
                Direction = Direction.Null;
            }

            public void RayTravelOnePoint()
            {
                Direction = ReverseTheDirectionIfReflectionOccurs();
                RayPoint = Direction.NextPoint(RayPoint);
            }

            private Direction ReverseTheDirectionIfReflectionOccurs()
            {
                if (RayPoint == FirstPoint && Direction == Direction.Backward)
                    return Direction.Forward;

                if (RayPoint == LastPoint && Direction == Direction.Forward)
                    return Direction.Backward;

                return Direction;
            }

            private int FirstPoint
            {
                get { return 0; }
            }

            private int LastPoint
            {
                get { return Size; }
            }
        }
    }
}
