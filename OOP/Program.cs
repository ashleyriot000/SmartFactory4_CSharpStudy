using System.Net.Sockets;

namespace OOP
{
    internal class Program
    {
        public struct Student
        {
            //학생 번호
            public int id;
            //학생 이름
            public string name;
            //학생 학년
            public int grade;
            //학생 성적
            public double avg;

            //생성자
            public Student(int id, string name, int grade, double avg)
            {
                this.id = id;
                this.name = name;
                this.grade = grade;
                this.avg = avg;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"저는 {grade}학년 {id}번 {name}입니다.");
            }
        }

        public class StudentClass
        {
            //학생 번호
            public int id;
            //학생 이름
            public string name;
            //학생 학년
            public int grade;
            //학생 성적
            public double avg;

            //생성자
            public StudentClass(int id, string name, int grade, double avg)
            {
                this.id = id;
                this.name = name;
                this.grade = grade;
                this.avg = avg;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"저는 {grade}학년 {id}번 {name}입니다.");
            }
        }

         static void Main(string[] args)
        {
            //int a = 100;
            //int b = 200;

            //Console.WriteLine($"1. a의 값은 {a}이고, b의 값은 {b}");
            //Swap(a, b);
            //Console.WriteLine($"2. a의 값은 {a}이고, b의 값은 {b}");
            //SwapReference(ref a, ref b);
            //Console.WriteLine($"3. a의 값은 {a}이고, b의 값은 {b}");


            ////bool isTrue = Method("안녕하세요", a, ref b, out float ggg);
            ////Method2(a, new string[] { "잘가세요.", "반가웠습니다." });
            ////Method2(b, "잘가세요.",  "반가웠습니다.");

            //string text = "안녕하세요";

            //Student std0 = new Student();
            //Student std1 = new Student(1, "Ashley", 3, 55.5);
            //std0.id = 100;
            //std0.name = "Barry";
            //std0.grade = 2;
            //std0.avg = 99.0;

            //Student[] studunts = new Student[10]
            //{
            //    new Student(0, "철수", 1, 70),
            //    new Student(0, "영희", 1, 70),
            //    new Student(0, "규남", 1, 70),
            //    new Student(0, "윤희", 1, 70),
            //    new Student(0, "득수", 1, 70),
            //    new Student(0, "철수", 1, 70),
            //    new Student(0, "철수", 1, 70),
            //    new Student(0, "철수", 1, 70),
            //    new Student(0, "철수", 1, 70),
            //    new Student(0, "철수", 1, 70)
            //};

            //studunts[3].id = 100;
            //int id = studunts[3].id;

            //foreach(var std in studunts)
            //{
            //    std.PrintInfo();
            //}




            ////Stack VS. Heap
            //StudentClass[] studentClassList = new StudentClass[10]
            //{
            //    new StudentClass(0, "철수", 1, 70),
            //    new StudentClass(0, "영희", 1, 70),
            //    new StudentClass(0, "규남", 1, 70),
            //    new StudentClass(0, "윤희", 1, 70),
            //    new StudentClass(0, "득수", 1, 70),
            //    new StudentClass(0, "철수", 1, 70),
            //    new StudentClass(0, "철수", 1, 70),
            //    new StudentClass(0, "철수", 1, 70),
            //    new StudentClass(0, "철수", 1, 70),
            //    new StudentClass(0, "철수", 1, 70)
            //};

            //studunts[0] = studunts[1];
            //studunts[1].id = 100000;
            //studunts[0].PrintInfo();
            //studunts[1].PrintInfo();

            //studentClassList[0] = studentClassList[1];
            //studentClassList[1].id = 100000;
            //studentClassList[0].PrintInfo();
            //studentClassList[1].PrintInfo();

            Console.Write("삼신할매입니다. 몇명을 태어나게 할까요?");
            int count = int.Parse(Console.ReadLine());
            Person[] peoples = new Person[count];
            Random rnd = new Random();
            for(int i = 0; i < count; i++)
            {
                PersonType type = (PersonType)rnd.Next(1, 4);
                switch (type)
                {
                    case PersonType.Asian:
                        peoples[i] = new Asian((i+ 1).ToString());
                        break;
                    case PersonType.Eskimo:
                        peoples[i] = new Eskimo((i + 1).ToString());
                        break;
                    case PersonType.Indian:
                        peoples[i] = new Indian((i + 1).ToString());
                        break;
                    default:
                        break;
                };
            }
            Console.WriteLine("================================");
            for(int i = 0; i < peoples.Length; ++i)
            {
                peoples[i].Run();
            }
            Console.WriteLine("================================");
            for (int i = 0; i < peoples.Length; ++i)
            {
                IFlyable? flyable = peoples[i] as IFlyable;
                if (flyable == null)
                    continue;
                
                flyable.Fly();
            }
        }

        static bool Method(string text, int point, ref int point2, out float avg)
        {
            point = 100;
            point2 = 200;
            avg = 0;
            Console.WriteLine($"Call {text}");
            return true;
        }

        static void Method2(int point, params string[] texts)
        {
            foreach(string t  in texts)
            {
                Console.WriteLine(t);
            }
        }

        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void SwapReference(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
