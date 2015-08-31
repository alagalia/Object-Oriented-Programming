using System;

namespace _04StudentClass
{
    //правим си собствени аргументи към собствения делегат
    public class ChangePropertyEventArgs : EventArgs
    {
        public string PropertyName{ get; set; }
        public string OldName { get; set; }
        public string NewName { get; set; }
        public int OldAge { get; set; }
        public int NewAge { get; set; }

        public ChangePropertyEventArgs(string propertyName, string oldName, string newName, int oldAge, int newAge)
        {
            this.PropertyName = propertyName;
            this.OldName = oldName;
            this.NewName = newName;
            this.OldAge = oldAge;
            this.NewAge = newAge;
        }
    }

    //правим си собствен делегат EventHandler
    public delegate void OnChangeProperyEventHandler(Student student, ChangePropertyEventArgs eventArgs);

    public class Student
    {
        public event OnChangeProperyEventHandler onChangeProperty;
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Name cannot take null value");
                }
                if (this.onChangeProperty != null)
                {
                    onChangeProperty(this, new ChangePropertyEventArgs("Name",this.name,value,this.age,this.age));
                }
                
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <1)
                {
                    throw new NullReferenceException("Age cannot take negative ot zero value");
                }
                if (this.onChangeProperty != null)
                {
                    onChangeProperty(this, new ChangePropertyEventArgs("Age",
                        this.name, this.name, this.age,value));
                }
                this.age = value;
            }
        }
    }
}
