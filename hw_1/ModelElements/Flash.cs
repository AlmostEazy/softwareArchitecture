using hw_1.Stuff;
using System.Drawing;

namespace hw_1.ModelElements
{
    public class Flash
    {
        public Point3D Location;
        public Angle3D Angle;
        public Color Color;
        public float Power;

        public Flash() {
            Location = new Point3D();
            Angle = new Angle3D();
            Color = new Color();
        }

        public Flash(Point3D point, Angle3D angle, Color color, float power)
        {
            Location = point;
            Angle = angle;
            Color = color;
            Power = power;
        }

        public void Rotate(Angle3D angle) { }
        public void Move(Point3D point) { }

    }
}