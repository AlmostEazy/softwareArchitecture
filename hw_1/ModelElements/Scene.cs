using hw_1.Stuff;

namespace hw_1.ModelElements
{
    public class Scene
    {
        public int Id;
        public List<PoligonalModel> Models;
        public List<Flash> Flashes;
        public List<Camera> Cameras;

        public Scene(int id ,List<PoligonalModel> poligonalModels, List<Flash> flashes, List<Camera> cameras) {
            if (poligonalModels.Count == 0 || cameras.Count == 0)
            {
                throw new ArgumentException("Должен быть хотя бы один аргумент!");
            }
            Models = poligonalModels;
            Cameras = cameras;
            Flashes = flashes;
            Id = id;
        }

        public List<Camera> GetCamerasWithAngle(Angle3D Angle)
        {
            List<Camera> answer = [];
            for (int i = 0; i < Cameras.Count; i++)
            {
                if (Cameras[i].Angle.angle == Angle.angle)
                {
                    answer.Add(Cameras[i]);
                }
            }
            return answer;
        } 
        
        public List<Flash> GetFlashesWithPoints(double x, double y)
        {
            List<Flash> answer = [];
            for (int i = 0; i < Flashes.Count; i++)
            {
                if (Flashes[i].Location.x == x && Flashes[i].Location.y == y)
                {
                    answer.Add(Flashes[i]);
                }
            }
            return answer;
        }
    }
}