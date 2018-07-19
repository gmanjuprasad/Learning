namespace LearnProperties
{
    public class Customer
    {
        public Customer()
        {
                
        }

        private int _id;
        private string _firstname;
        private string _lastname;

        public int ID
        {
            get { return this._id; }
            set { this._id = value;  }
        }

        public string FirstName
        {
            get { return this._firstname; }
            set { this._firstname = value; }
        }

        public string LastName
        {
            get { return _lastname; }
            set { this._lastname = value; }
        }

        public string FullName
        {
            get { return this._firstname + " " + this._lastname; }
        }
    }
}
