using hw_1.Stuff;

namespace hw_1.ModelElements
{
    public class Poligon
    {
        public Point3D Points;

        public Poligon() { 
            Points = new Point3D();
        }
        public Poligon(Point3D point) {
            Points = point;
        }
    }
}