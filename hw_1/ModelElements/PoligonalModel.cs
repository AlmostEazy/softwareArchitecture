using hw_1.Stuff;

namespace hw_1.ModelElements
{
    public class PoligonalModel
    {
        public List<Poligon> Poligons;
        public List<Texture> Textures;

        public PoligonalModel(List<Texture> textures)
        {
            Textures = textures;
            Poligons = [];
            Poligon poligon = new Poligon();
            Poligons.Add(poligon);
        }

        public PoligonalModel(List<Texture> textures, Point3D point)
        {
            Textures = textures;
            Poligons = [new Poligon(point)];
        }
    }
}