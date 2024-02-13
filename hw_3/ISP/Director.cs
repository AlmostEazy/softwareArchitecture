namespace hw_3.ISP
{
    public class Director : IDirector
    {
        private string Name;
        private bool isCreateScript;

        public Director(string name, bool isCreateScript)
        {
            Name = name;
            this.isCreateScript = isCreateScript;
        }

        public string CreateScript()
        {
            if (isCreateScript) { return "Написал сценарий"; };
            return "Не писал сценарий сам";
        }

        public string getMovieRole()
        {
            return "режиссер";
        }

        public string getName()
        {
            return Name;
        }
    }
}