namespace SolidExamples.OCP
{
    public class ShapeComparer : IComparer<IShape>
    {
        private static readonly Dictionary<Type, int> orderingTable = new()
        {
            { typeof(Circle), 1 },
            { typeof(Square), 2 }
        };

        private int GetOrder(IShape shape)
        {
            if (shape == null) return 0;
            return orderingTable.ContainsKey(shape.GetType()) ? orderingTable[shape.GetType()] : 0;
            
        }

        public int Compare(IShape? x, IShape? y)
        {
            var xOrder = GetOrder(x);
            var yOrder = GetOrder(y);
            return xOrder.CompareTo(yOrder);
        }
    }
}
