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

            //명시적 형변환
            short sA = (short)iA;
            short sB = 15;
            short sC = (short)(sA + sB);

            //암묵적 형변환
            long lA = iA;
            float fA = lA;

            //실수형의 정밀도 문제 주의
            float fB = 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f + 0.1f;            
            if(fB == 1f)
            {
                Console.WriteLine("fB는 1과 같습니다.");
            }
            else
            {
                Console.WriteLine("fB는 1과 다릅니다.");
            }

            //형이 다른 숫자 변수들끼리 연산할 경우 범위가 큰 타입으로 암묵적 형변환이 일어나고
            //결과값도 범위가 큰 타입으로 반환된다.
           float fC = lA + fA;

            //참, 거짓만 판별
            bool isTrue = true;
            isTrue = false;

            //문자 하나만 담을 수 있는 변수
            char a = 'a';
            char b = (char)(a + 1);
            //원하는 길이의 문장을 담을 수 있는 변수
            string text = "안녕하세요";
        }

        //매개변수l과 r의 더한 값을 반환하는 함수 
        static int Sum(int l, int r)
        {
            return l + r;
        }
    }
}
