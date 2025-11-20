namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("변수란");
            //변수 선언
            int iA;
            //변수 정의
            int iB = 10;
            //변수 대입
            iA = iB;

            int iC = Sum(iA, iB);

            short sA = (short)iA;
            long lA = iA;
            float fA = lA;

            float fB = 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f;
            if(fB == 1f)
            {
                Console.WriteLine("fB는 1과 같습니다.");
            }
            else
            {
                Console.WriteLine("fB는 1과 다릅니다.");
            }
        }

        static int Sum(int l, int r)
        {
            return l + r;
        }
    }


    
}
