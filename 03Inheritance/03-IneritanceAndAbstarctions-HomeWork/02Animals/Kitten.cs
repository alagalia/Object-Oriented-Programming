using System;

namespace Animals
{
    public class Kitten : Cat
    {
        private Gender gender;

        public Kitten(string name, int age, Gender gender) : base(name, age)
        {
            this.Gender = gender;
        }

        public Gender Gender
        {
            get { return this.gender; }
            set
            {
                this.gender = Gender.Female;
            }
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + ", gender: {0}", this.Gender);
        }
    }
}
