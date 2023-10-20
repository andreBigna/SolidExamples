namespace SolidExamples.OCP
{
    public class ShapesDrawer
    {
        public void DrawShapes(IEnumerable<IShape> shapes)
        {
            IOrderedEnumerable<IShape> orderedShapes = shapes.Order(new ShapeComparer());
            foreach (IShape shape in orderedShapes)
            {
                shape.Draw();
            }
        }
    }

    

}
