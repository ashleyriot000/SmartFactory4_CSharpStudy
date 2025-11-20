namespace VariableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //콘솔창에 "Inch -> mm 변환툴" 이라고 출력
            //숫자를 입력받음
            //변환과정(1inch = 25.4mm)
            //콘솔창에 "입력하신 {인치값}은 {결과값}mm입니다."출력

            Console.WriteLine("Inch -> mm 변환툴");
            Console.Write("변환하고 싶은 Inch 값을 입력해주세요 : ");
            string input = Console.ReadLine();

            
            double inch = double.Parse(input);
            double mm = inch * 25.4d;

            Console.Write("변환중");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.WriteLine(".");
            Console.WriteLine($"입력하신 {inch}inch값은 {mm}mm입니다");
        }
    }
}
