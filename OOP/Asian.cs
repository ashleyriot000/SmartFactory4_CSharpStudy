using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Asian : Person
    {

        public Asian(string name) : base()
        {
            this.name = name;
        }
        protected override void Birth()
        {
            base.Birth();
            type = PersonType.Asian;
        }
        public override void Run()
        {
            Console.WriteLine($"나는 아시아인인데 {age}살이고 이름은 {name}이야. 응애응애!!!");
        }
    }
}
