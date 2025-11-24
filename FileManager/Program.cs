namespace FileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "File.txt");

            //File.WriteAllText(path, "안녕하세요");
            string[] text = File.ReadAllLines(path);
            List<Student> studentList = new List<Student>();
            foreach(string line in text)
            {
                string[] datas = line.Split(',');
                string lastName = datas[0];
                string firstName = datas[1];
                int age = int.Parse(datas[2]);
                int point = int.Parse(datas[3]);
                studentList.Add(new Student(lastName, firstName, age, point));
            }

            foreach(Student student in studentList)
            {
                student.PrintInfo();
            }
            //File.ReadAllText(path);
        }
    }
}
