namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //+,-,*,/,%
            int iA = 5;
            int iB = 16;

            int iPlus = iA + iB;
            int iMinus = iA - iB;
            int iMultifly = iA * iB;
            int iDivide = iA / iB;
            int iRemain = iA % iB;

            //증감 연산자
            int iC = iPlus++;
            int iD = ++iPlus;
            
            //iC = iPlus;
            //iPlus = iPlus + 1;
            iPlus += 1;

            --iPlus;
            iPlus--;

            //비교연산자
            bool bSame = iPlus == iMinus;
            bool bNotSame = iPlus != iMinus;
            bool bBigger = iPlus > iMinus;
            bool bBiggerOrSame = iPlus >= iMinus;
            bool bSmaller = iPlus < iMinus;
            bool bSmallerOrSame = iPlus <= iMinus;

            //논리 연산자
            //부정 연산자
            bool isTrue = false;
            isTrue = !bSame;
            isTrue = !isTrue;

            //And 연산자
            bool and = bSame & bBigger & bSmallerOrSame;
            and = bSame && bBigger && bSmallerOrSame;


            //Or 연산자
            bool or = bSame | bBigger | bSmaller;
            or = bSame || bBigger || bSmaller;

            //XOR 연산자
            bool xor = bSame ^ bBigger;

            //삼항 연산자
            int iResult = bSame & bSmaller ? 1 : 0;


            //if문
            if(bSame)
            {
                //참이면 호출
                Console.WriteLine("bSame은 정말로 참입니다.");
            }
            else
            {
                //거짓이면 호출
                Console.WriteLine("bSame은 거짓입니다.");
            }

            if(bBigger)
            {
                //참이면 호출
                Console.WriteLine("bBigger는 참입니다.");
            }
            else if(bSame)
            {
                //참이면 호출
                Console.WriteLine("bSame은 참입니다.");

            }
            else
            {
                //모두 아니면 호출
                Console.WriteLine("bBigger도 bSame도 거짓입니다.");
            }


            Console.WriteLine("======================================");
            Console.Write("정수 하나를 입력해주세요 : ");
            string text = Console.ReadLine();
            if(int.TryParse(text, out int result))
            {
                if(result % 2 == 0)
                {
                    Console.WriteLine($"그래 {result}는 짝수가 맞아");
                    //Console.WriteLine("그래 " + result + "는 짝수가 맞아");                    
                }
                else
                {
                    Console.WriteLine($"아니야, {result}는 짝수가 아니야");
                }
            }

            Console.Write("정수 하나를 입력해주세요 : ");
            text = Console.ReadLine();
            if(int.TryParse(text, out result))
            {
                if(result < 100 && result > 0)
                {
                    Console.WriteLine($"그래, {result}는 100과 0사이의 값이야");
                }
                else
                {
                    Console.WriteLine($"아니야, {result}는 100과 0사이의 없는 값이야");
                }
            }
        }
    }
}
