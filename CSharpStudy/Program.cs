namespace CSharpStudy
{
    internal class Program
    {
        //Entry Point 모든 C, C++, C#언어는 Main함수로 시작되고 종료된다.
        static void Main(string[] args)
        {
            //화면 출력하고 다음 줄로 내림
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);

            //화면 출력하고 커서 유지
            Console.Write("Welcome C# =>");
            //유저가 작성한 문자입력을 받음. 엔터칠 때까지 
            Console.WriteLine(Console.ReadLine());
            //유저가 입력한 처음 키보드 문자를 입력받기
            ConsoleKeyInfo info = Console.ReadKey();
            Console.WriteLine(info.KeyChar);
        }
    }
}
