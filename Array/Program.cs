namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열 선언, 정의 방식. 생략이 가능함.
            int[] iArray;
            int[] iArray2 = new int[100];
            int[] iArray3 = new int[5]
            {
                0,1,2,3,4
            };


            //배열 요소에 접근, 대입하는 방법
            int[] iArray4 = {2,3,4,56};
            iArray4[0] = 5;
            iArray4[3] = iArray4[0];
            int temp = iArray4[0];
            iArray4[0] = iArray4[3];
            iArray4[3] = temp;

            //2차원 배열 선언 및 정의
            long[,] lArray = new long[5, 5]
            {
                { 0, 1, 2, 3, 4},
                { 0, 1, 2, 3, 4},
                { 0, 1, 2, 3, 4},
                { 0, 1, 2, 3, 4},
                { 0, 1, 2, 3, 4}
            };

            //2차원 배열의 대입
            lArray[0, 1] = 10;


            //가변배열, 지그배열의 선언, 정의 방법(잘 안쓰이는 배열)
            short[][] sArray = new short[3][];
            sArray[0] = new short[5];
            sArray[1] = new short[10];
            sArray[2] = new short[3];

            int[] sumArray = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };
            int result = sumArray[0] + sumArray[1] + sumArray[2] + sumArray[3] + sumArray[4] +
                sumArray[5] + sumArray[6] + sumArray[7] + sumArray[8] + sumArray[9];

            Console.WriteLine(result);
        }
    }
}
