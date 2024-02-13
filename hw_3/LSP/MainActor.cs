namespace hw_3.LSP
{
    internal class MainActor : IActor, IRole
    {
        private string Name;
        private string Role;

        public MainActor(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public string getName()
        {
            return Name;
        }

        public string getPosition()
        {
            return "Главная роль";
        }

        public string getRole()
        {
            return Role;
        }
    }
}