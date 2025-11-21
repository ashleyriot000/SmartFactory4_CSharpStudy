namespace ControlStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch();
            For();
        }

        static void Switch()
        {
            Console.WriteLine("=== 재표 물성치 데이터베이스 ===");
            Console.WriteLine("1. Steel, 2. Aluminum, 3. Titanium");
            Console.Write("재료 번호를 선택하세요 : ");

            int choice = int.Parse(Console.ReadLine());
            double modulus = 0;

            switch(choice)
            {
                case 1:
                    Console.WriteLine("선택 : Steel (강철)");
                    modulus = 200.0;
                    break;
                case 2:
                    Console.WriteLine("선택 : Aluminum(알루미늄)");
                    modulus = 69.0;
                    break;
                case 3:
                    Console.WriteLine("선택 : Titanium(티타늄)");
                    modulus = 116.0;
                    break;
                default:
                    Console.WriteLine("알 수 없는 재료입니다.");
                    return;
            }

            Console.WriteLine($"해당 재료의 영률(Young's Modulus) : {modulus} GPa");
        }
        static void For()
        {
            Random rnd = new Random();
            Console.WriteLine("=== 오차 확인 검사 ===");
            Console.Write("검사할 부품의 갯수를 입력해주세요 : ");
            int count = int.Parse(Console.ReadLine());
            double[] errors = new double[count];
            for(int i = 0; i < errors.Length; i++)
            {
                errors[i] = rnd.NextDouble() * 100d;
            }

            int product = 0;
            for (int i = 0; i < errors.Length; i++)
            {                
                if (errors[i] > 90d && errors[i] < 100d)
                {
                    product++;
                }
            }

            int errorCount = errors.Length - product;
            double errorRate = (double)errorCount / errors.Length;
            Console.WriteLine("=== 오차 확인 결과 ===");
            Console.WriteLine($"정상 부품 갯수 : {product} ");
            Console.WriteLine($"불량 부품 갯수 : {errorCount} ");
            Console.WriteLine($"불량 율 : {errorRate:P} ");
        }

        static void ForExample()
        {
            //2차원배열을 이용.            
            //2개가 한쌍인 부품을 원하는 갯수만큼 생산후, 
            //부품 공정에 필요한 탭 갯수를 확인후 서로 같은지 확인해 불량 체크
            //그게 아니면 불량. 
            //결과로 몇개의 부품을 생산했고,  정상 부품이 몇개인지 표시하고, 불량 부품의 갯수을 보여주고
            //불량율을 표시해주고 프로그램 종료.
            Random rnd = new Random();
            rnd.Next(3);
        }
    }


}
