namespace hw_3.ISP
{
    public class Operator : IOperator
    {
        private string Name;
        private bool Main;
        
        public Operator(string name, bool isMain)
        {
            Name = name;
            this.Main = Main;
        }

        public string getMovieRole()
        {
            return "оператор";
        }

        public string getName()
        {
            return Name;
        }

        public bool isMain()
        {
            return Main;
        }
    }
}