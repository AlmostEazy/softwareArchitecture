namespace hw_3.LSP
{
    internal class CrowdActor : IActor
    {
        public string Name { get; }
        
        public CrowdActor(string name)
        {
            Name = name;
        }

        public string getName()
        {
            return Name;
        }

        public string getPosition()
        {
            return "Актер второго плана";
        }
    }
}