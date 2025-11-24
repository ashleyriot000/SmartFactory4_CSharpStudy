using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Indian : Person, IFlyable
    {
        public Indian(string name) : base()
        {
            this.name = name;
        }
        public void ChangeName(string changed)
        {
            name = changed;
        }

        protected override void Birth()
        {
            type = PersonType.Indian;
            //base.Birth();
            Console.WriteLine($"나는 인디인데 {age}살이고 이름은 {name}이야. 아우우우우우!!!");
        }

        public override void Die()
        {
            //base.Die();
            Console.WriteLine($"나는 인디인데 {age}살이고 이름은 {name}이야. 장렬히 전사했어");
        }

        public override void Run()
        {
            Console.WriteLine($"나는 인디인데 {age}살이고 이름은 {name}이야. 나 달린다");
            AGE++;
        }

        public void Fly()
        {
            Console.WriteLine($"나는 인디인데 {age}살이고 이름은 {name}이야.  나 지금 날고 있어");
        }
    }
}
