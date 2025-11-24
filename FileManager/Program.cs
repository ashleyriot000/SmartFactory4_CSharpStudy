namespace FileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "File.txt");
            if(!File.Exists(path))
            {
                File.WriteAllLines(path, new string[0]);
            }
            else
            {
                string[] text = File.ReadAllLines(path);
                foreach (string line in text)
                {
                    string[] datas = line.Split(',');
                    string lastName = datas[0];
                    string firstName = datas[1];
                    int age = int.Parse(datas[2]);
                    int point = int.Parse(datas[3]);
                    studentList.Add(new Student(lastName, firstName, age, point));
                }
            }  
            Thread.Sleep(1000);

            foreach(Student student in studentList)
            {
                student.PrintInfo();
            }
            Thread.Sleep(1000);


            Console.Write("몇명의 학생을 추가하시겠습니까? : ");
            int count = int.Parse(Console.ReadLine());
            for(int i = 0; i < count; i++)
            {
                Console.Write("성을 입력해주세요. : ");
                string lastName = Console.ReadLine();

                Console.Write("이름을 입력해주세요. : ");
                string firstName = Console.ReadLine();
                    
                int age = 0;
                while(true)
                {
                    Console.Write("나이를 입력해 주세요 : ");
                    if(int.TryParse(Console.ReadLine(), out age))
                        break;

                    Console.Write("잘못 입력하셨습니다. 다시 ");
                }

                int point = 0;
                while (true)
                {
                    Console.Write("점수를 입력해 주세요 : ");
                    if (int.TryParse(Console.ReadLine(), out point))
                        break;

                    Console.Write("잘못 입력하셨습니다. 다시 ");
                }

                studentList.Add(new Student(lastName, firstName, age, point));
            }

            Console.Clear();
            foreach(var s in studentList)
            {
                s.PrintInfo();
            }

            Console.Write("저장하시겠습니까? : ");
            ConsoleKeyInfo info = Console.ReadKey();
            if(info.Key == ConsoleKey.Y)
            {
                List<string> stdList = new List<string>();
                foreach (var s in studentList)
                {
                    stdList.Add(s.ToString());
                }
                //파일로 저장
                File.WriteAllLines(path, stdList);
            }

            //바로 종료
        }
    }
}
