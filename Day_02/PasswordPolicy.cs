
namespace Day_02
{
    public class PasswordPolicy
    {
        private int _lowest;
        public int Lowest
        {
            get { return _lowest; }
            set { _lowest = value; }
        }

        private int _highest;
        public int Highest
        {
            get { return _highest; }
            set { _highest = value; }
        }

        private string _contains;
        public string Contains
        {
            get { return _contains; }
            set { _contains = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private int _containsCount;
        public int ContainsCount
        {
            get { return _containsCount; }
            set { _containsCount = value; }
        }

        private bool _p1IsValid;
        public bool P1IsValid
        {
            get { return _p1IsValid; }
            set { _p1IsValid = value; }
        }

        private bool _p2IsValid;

        public bool P2IsValid
        {
            get { return _p2IsValid; }
            set { _p2IsValid = value; }
        }



    }
}
