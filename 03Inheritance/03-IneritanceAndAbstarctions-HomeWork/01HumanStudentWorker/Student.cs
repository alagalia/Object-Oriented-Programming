namespace _01HumanStudentWorker
{
    using System;

    class Student :Human
    {
        private const int MinFacultyNumberLenght = 5;
        private const int MaxFacultyNumberLenght = 10;
        private int facultyNumber;

        public Student(string firstName, string lastName, int facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public int FacultyNumber 
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.ToString().Length < MinFacultyNumberLenght || value.ToString().Length > MaxFacultyNumberLenght)
                {
                    throw new ArgumentOutOfRangeException("Faculty number has to be in range [5...10] digits ");
                }

                this.facultyNumber = value;
            } 
        }
    }
}
