namespace ifExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //화면에 "기계 구조용 탄소강의 부피 및 무게 계산기" 출력
            //1. 재료의 치수(반지름, 높이)를 입력받기
            //탄소강의 밀도 = 7.85,
            //2. 부피 계산 : 파이 * 반지름 * 반지름 * 높이
            //3. 무게 계산 : 부피 * 밀도
            //Math.PI
            //double value = 124154.23623098d;
            //Console.WriteLine($"{value:F3}");

            // 부피가 1000이 넘으면서 무게가 1000kg이 넘는지 출력하기
            //부피와 무게를 화면에 출력해주세요.

            Console.WriteLine("기계 구조용 탄소강(S45C)의 부피 및 무게 계산기");
            Console.Write("탄소강의 둘레를 입력해주세요 : ");
            double radius = 0d;
            if(double.TryParse(Console.ReadLine(), out double result))
            {
                radius = result;
            }

            Console.Write("탄소강의 높이를 입력해주세요 : ");
            double height = 0d;
            if (double.TryParse(Console.ReadLine(), out result))
            {
                height = result;
            }

            double volume = Math.PI * radius * radius * height;
            double mass = volume * 7.85d;

            if(volume > 1000 && mass > 1000)
            {
                Console.WriteLine($"탄소강의 부피와 무게가 모두 1000이 넘습니다.");
            }
            else
            {
                Console.WriteLine($"탄소강의 부피와 무게가 1000이 안될 수 있습니다.");
            }

            Console.WriteLine($"탄소강의 부피는 {volume:F3}m^3이며 무게는 {mass:F3}kg입니다");
        }
    }
}
