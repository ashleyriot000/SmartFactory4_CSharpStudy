using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum PersonType
    {
        None,
        Asian,
        Eskimo,
        Indian,
        Max
    }
    internal abstract class Person
    {

        public static int TotalPerson = 0;
        protected PersonType type;
        protected string name = "아무개";
        protected int age = 1;

        public string Name 
        { 
            get 
            { 
                return name; 
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                    return;

                if (value.Length < 3)
                    return;

                name = value;
            }
        }
        public int AGE
        {
            get
            {
                return age;
            }

            protected set
            {
                if (value < 1)
                    return;

                if (value == age)
                    return;

                age = value;
                Console.WriteLine($"나 {age}살이 되었어");
            }
        }
        //public int AGE1 { get => age; private set => age = value;}

        
        public Person()
        {
            TotalPerson++;
            Birth();
        }

        public Person(string name) : base()
        {
            this.name = name;
        }

        ~Person()
        {
            Die();
        }

        public void Speak(string talk)
        {
            Console.WriteLine(talk);
        }

        protected virtual void Birth()
        {
            Console.WriteLine("응애!!");
        }

        public virtual void Die()
        {
            Console.WriteLine("으악!!");
            TotalPerson--;
        }

        public abstract void Run();

        public void Introduce()
        {
            Console.WriteLine($"내 이름은 {name}이고, {age}살 입니다.");
        }

        public static void PrintPersonCount()
        {
            Console.WriteLine($"현재 인구수는 {TotalPerson}명입니다.");
        }
    }
}
