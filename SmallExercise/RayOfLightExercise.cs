using System.Collections.Generic;

namespace SmallExercise
{
    public class RayOfLightExercise
    {
        private RayOfLight _ray;
        private readonly List<Position> _positionsReached = new List<Position>();

        public RayOfLightExercise ARayOfLightComesInAWindowOfSize(int m, int n)
        {
            _ray = new RayOfLight(m, n);
            return this;
        }

        public RayOfLightExercise FromTheUpperLeftCorner()
        {
            _ray.CurrentPosition = new Position(0, 0);
            return this;
        }

        public RayOfLightExercise With45AngledEdges()
        {
            _ray.HorizontalDirection = Direction.Forward;
            _ray.VerticalDirection = Direction.Forward;
            return this;
        }

        public RayOfLightExercise TravelUntilHasReachedACorner()
        {
            _positionsReached.Clear();
            _positionsReached.Add(_ray.CurrentPosition);

            do
            {
                _ray.TravelOnePosition();
                _positionsReached.Add(_ray.CurrentPosition);
            }
            while (!_ray.HasReachedACorner);

            return this;
        }

        public IReadOnlyList<Position> PositionsReached
        {
            get { return _positionsReached; }
        }
    }
}