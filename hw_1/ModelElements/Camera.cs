using hw_1.Stuff;

namespace hw_1.ModelElements
{
    public class Camera
    {
        public Point3D Location;
        public Angle3D Angle;

        public Camera() {
            Location = new Point3D ();
            Angle = new Angle3D ();
        }

        public Camera(Point3D point, Angle3D angle)
        {
            Location = point;
            Angle = angle;
        }

        public void Rotate(Angle3D angle) { }
        public void Move(Point3D point) { }
    }
}