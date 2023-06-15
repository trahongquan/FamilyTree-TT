namespace FamilyTree
{
    internal class Person
    {
        private string id;
        private string idFather;
        private string name;
        private string date;
        private string passDate;
        private string sex;
        private string home_place;
        private string phone;
        private string email;
        private string position;
        private string work_place;
        private string note;

        public Person() { }
        public Person(string id, string idFather, string name, string date, string passDate, string sex, string home_place, string phone, string email, string position, string work_place, string note)
        {
            this.id = id;
            this.idFather = idFather;
            this.name = name;
            this.date = date;
            this.passDate = passDate;
            this.sex = sex;
            this.home_place = home_place;
            this.phone = phone;
            this.email = email;
            this.position = position;
            this.work_place = work_place;
            this.note = note;
        }
        public string Id            { get { return id; }        set { id = value; } }
        public string IdFather      { get {  return idFather; } set { idFather = value; } }
        public string NameNode      { get { return name; }      set { name = value; } }
        public string Date          { get { return date; }      set { date = value; } }
        public string PassDate      { get { return passDate; }  set { passDate = value; } }
        public string Sex           { get { return sex; }       set { sex = value; } }
        public string Home_place    { get { return home_place; } set { home_place = value; } }
        public string Phone         { get { return phone; }     set { phone = value; } }
        public string Email         { get { return email; }     set { email = value; } }
        public string Position      { get { return position; }  set { position = value; } }
        public string Work_place    { get { return work_place; } set { work_place = value; }}
        public string Note          { get { return note; }      set { note = value; } }

    }
}
