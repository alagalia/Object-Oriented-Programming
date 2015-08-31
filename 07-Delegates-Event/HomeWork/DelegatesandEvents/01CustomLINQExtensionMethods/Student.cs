namespace _01CustomLINQExtensionMethods
{
    class Student
    {
        public string Name { get; set; }
        public double Grade { get; set; }

        public Student(string name, double grade)
        {
            this.Name = name;
            this.Grade = grade;
        }
    }
}
