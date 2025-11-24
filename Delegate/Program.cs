namespace Delegate
{
    internal class Program
    {
        //델리게이트 선언
        delegate void OnBirth(string message);

        static void Main(string[] args)
        {
            //델리게이트 정의 및 메소드 할당
            OnBirth onBirth = new OnBirth(Speak);
            //델리게이트 호출
            onBirth?.Invoke("응애응애");
            //if(onBirth != null)
            //{
            //    onBirth.Invoke("응애응애");
            //}

            //반환값이 없고, <>안에 매개변수 타입이 동일한 메소드 등록가능
            Action<string> action = Speak;
            //반환값이 있고, 맨앞이 반환값의 타입, 그다음부터 매개변수 타입.
            Func<string, string> func = Speak2;

            //무명함수를 델리게이트에 넣는 방법
            action += (message) => Console.WriteLine(message);
            //
            Func<string> func2 = () => "Speak";
        }

        static void Speak(string talkMessage)
        {
            Console.WriteLine("Speak1 : " +  talkMessage);
        }
        static string Speak2(string talkMessage)
        {
            Console.WriteLine("Speak2 : " + talkMessage);
            return talkMessage;
        }
    }
}
