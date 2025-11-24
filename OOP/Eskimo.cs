using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Eskimo : Person, IFlyable
    {
        public Eskimo(string name) : base()
        {
            this.name = name;
        }
        protected override void Birth()
        {
            base.Birth();
            type = PersonType.Eskimo;
        }
        public void Fly()
        {
            Console.WriteLine($"나는 에스키모인인데 {age}살이고 이름은 {name}이야. 날자 날아!!!");
        }

        public override void Run()
        {
            Console.WriteLine($"나는 에스키모인인데 {age}살이고 이름은 {name}이야. 달리자 달려!!!");
        }
    }
}
