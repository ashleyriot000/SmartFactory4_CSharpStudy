namespace ControlStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Switch();
            //For();
            //ForExample();
            //ForExample2();
            //ContinueExample();
            //ForForExample();
            //ForeachExample();
            //WhileExample2();

            SmartFactoryTotalControlSystem();
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
            //Random rnd = new Random();
            //rnd.Next(3);

            Random rnd = new Random();
            Console.WriteLine("=== 스탭 갯수 확인 검사 ===");
            Console.Write("검사할 부품의 갯수를 입력해주세요 : ");
            int count = int.Parse(Console.ReadLine());
            int[,] errors = new int[count, 2];

            int product = 0;
            for (int i = 0; i < errors.GetLength(0); ++i)
            {
                errors[i, 0] = rnd.Next(3);
                errors[i, 1] = rnd.Next(3);
            }

            for (int i = 0; i < errors.GetLength(0); ++i)
            {
                if (errors[i, 0] == errors[i,1])
                {
                    product++;
                }
            }

            int errorCount = errors.GetLength(0) - product;
            double errorRate = (double)errorCount / errors.GetLength(0);
            Console.WriteLine("=== 스탭 갯수 확인 결과 ===");
            Console.WriteLine($"정상 부품 갯수 : {product} ");
            Console.WriteLine($"불량 부품 갯수 : {errorCount} ");
            Console.WriteLine($"불량 율 : {errorRate:P} ");
        }
        static void ForExample2()
        {
            //목표RPM 입력을 받고,
            //가속시간을 입력을 받고,
            //모터 가속을 시작. 출력
            //매 1초가 지날 때마다 현재 RPM을 표시함.
            //마지막에는 목표 RPM에 도달했습니다 출력.
            Console.Write("목표 RPM을 입력해주세요 : ");
            double targetRPM = double.Parse(Console.ReadLine());

            Console.Write("가속 시간을 입력해주세요 : ");
            int accTime = int.Parse(Console.ReadLine());

            double currentRPM = 0;
            double acc = targetRPM / accTime;
            for (int i = 0; i < accTime; ++i)
            {
                Thread.Sleep(1000);
                currentRPM += acc;
                Console.WriteLine($"{i + 1}초 경과 현재 RPM은 {currentRPM:F2}입니다");
            }

            Console.WriteLine("목표 RPM에 도달했습니다.");
        }

        static void ContinueExample()
        {
            Random rnd = new Random();
            Console.WriteLine("가위바위보 게임을 시작합니다.");
            Console.Write("게임을 몇 회 진행하시겠습니까? : ");
            int count = int.Parse(Console.ReadLine());
            int victory = 0;
            for(int i = 0; i < count; ++i)
            {
                Console.Write($"{i + 1}번째 게임. 원하는 가위바위보를 내주세요.(1:가위 2:바위 3:보) : ");
                int user = int.Parse(Console.ReadLine());
                if(user < 1 || user > 3)
                {
                    Console.WriteLine("잘못 내셨습니다. 다시 내주세요");
                    i -= 1;
                    continue;
                }
                int com = rnd.Next(1, 4);
                Thread.Sleep(500);

                if(user == com)
                {
                    Console.WriteLine("비겼습니다. 다시 내주세요");
                    i -= 1;
                    continue;
                }
                else
                {
                    switch(user)
                    {
                        case 1:
                            if(com == 2)
                            {
                                Console.WriteLine($"{i+1}번째 게임은 컴퓨터가 이겼습니다.");
                            }
                            else
                            {
                                Console.WriteLine($"{i + 1}번째 게임은 당신이 이겼습니다.");
                                victory++;
                            }

                            break;
                        case 2:
                            if (com == 3)
                            {
                                Console.WriteLine($"{i + 1}번째 게임은 컴퓨터가 이겼습니다.");
                            }
                            else
                            {
                                Console.WriteLine($"{i + 1}번째 게임은 당신이 이겼습니다.");
                                victory++;
                            }
                            break;
                        case 3:
                            if (com == 1)
                            {
                                Console.WriteLine($"{i + 1}번째 게임은 컴퓨터가 이겼습니다.");
                            }
                            else
                            {
                                Console.WriteLine($"{i + 1}번째 게임은 당신이 이겼습니다.");
                                victory++;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine($"게임이 모두 끝났습니다. 당신은 {victory}회 승리하셨습니다.");
            Console.WriteLine($"당신의 승률은 {(float)victory / count:P}입니다.");

        }
        static void ForForExample()
        {
            //학생 성적 기록부
            Console.WriteLine("학생 성적 기록");
            Console.Write("조회할 학생들의 수는 얼마인가요? : ");
            int count = int.Parse(Console.ReadLine());
            int[,] record = new int[count, 10];
            float[] avg = new float[count];
            Random rnd = new Random();
            for(int i = 0; i < record.GetLength(0); i++)
            {
                Console.Write($"[{i + 1:D2}번]학생의 성적은 [");
                int sum = 0;
                for(int j = 0; j < record.GetLength(1); j++)
                {
                    record[i, j] = rnd.Next(40,101);
                    sum += record[i, j];
                    if (j < record.GetLength(1) - 1)
                        Console.Write($"{record[i, j]},");
                    else
                        Console.WriteLine($"{record[i, j]}]입니다.");
                }

                avg[i] = (float)sum / record.GetLength(1);
                Console.WriteLine($"[{i + 1:D2}번]학생의 평균 점수는 {avg[i]}입니다. ");
            }            
        }
        static void ForeachExample()
        {
            //내가 학점관리 프로그램
            //과목 수강했는지 입력하시오.
            //과목 수만큼 점수 입력을 받고
            //평균을 내서 50점 이하이면 F, 60이하 D, 70이하 C, 80이하 B, 90이하 A, 100이하 A++
            Console.WriteLine("==== 내 학점관리 프로그램 ====");
            Console.Write("몇과목을 수강하고 있는지 입력해 주세요. : ");
            int count = int.Parse(Console.ReadLine());
            int[] points = new int[count];

            for(int i = 0; i < count; ++i)
            {
                Console.Write($"{i + 1}번째 과목의 점수를 입력해 주세요. : ");
                points[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            float avg = 0f;

            foreach(var p in points)
            {
                sum += p;
            }

            avg = (float)sum / count;
            Console.WriteLine($"당신의 평균 점수는 {avg:F2}입니다.");
            if(avg <= 50.0f)
            {
                Console.WriteLine($"당신은 F입니다.");
            }
            else if(avg <= 60.0f)
            {
                Console.WriteLine($"당신은 D입니다.");
            }
            else if(avg <= 70.0f)
            {
                Console.WriteLine($"당신은 C입니다.");
            }
            else if(avg <= 80.0f)
            {
                Console.WriteLine($"당신은 B입니다.");
            }
            else if(avg <= 90.0f)
            {
                Console.WriteLine($"당신은 A입니다.");
            }
            else
                Console.WriteLine($"당신은 A++입니다.");
        }
        static void WhileExample()
        {
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine($"X는 {x}입니다");
                x++;
            };

            //좋지 못한 While 사용법
            //bool isEnd = false;
            //while(!isEnd)
            //{
            //    Console.WriteLine($"아직 안끝났습니까?");
            //}
        }
        static void DoWhileExample()
        {
            int y = 10;
            do
            {
                Console.WriteLine($"Y는 {y}입니다.");
                y++;
            }
            while (y < 10);
        }
        static void WhileExample2()
        {
            while(true)
            {
                Console.Write("당신의 이름을 입력해주세요 : ");
                string name = Console.ReadLine();
                if (name == "End")
                    break;

                Thread.Sleep(1000);
                Console.Clear();
            }
        }


        static void SmartFactoryTotalControlSystem()
        {
            //센서데이터를 저장할 배열(최대 5개)
            double[] sensorDatas = new double[5];
            //센서 데이터의 수집 여부
            bool isDataCollected = false;
            //시스템 가동 여부
            bool systemRunning = true;

            while(systemRunning)
            {
                Console.Clear();
                Console.WriteLine("=== 스마트 팩토리 통합 제어 콘솔 ===");
                Console.WriteLine("1. 센서 데이터 수집 (Input)");
                Console.WriteLine("2. 데이터 분석 및 진단 (Analyze)");
                Console.WriteLine("3. 시스템 종료 (Exit)");
                Console.Write(">> 기능을 선택하세요: ");

                string input = Console.ReadLine();

                switch(input)
                {
                    case "1":
                        Console.WriteLine("\n[모드 1] 온도 센서 데이터 입력을 시작합니다.");

                        for (int i = 0; i < sensorDatas.Length; ++i)
                        {
                            double temperature;
                            do
                            {
                                Console.Write($"센서 #{i + 1} 온도 (0 ~ 200C): ");
                                if (!double.TryParse(Console.ReadLine(), out temperature))
                                {
                                    continue;
                                }


                                if (temperature < 0 || temperature > 200)
                                {
                                    Console.WriteLine("     >> [ERROR] 센서 오류! 허용 범위를 벗어났습니다. 다시 입력하세요 ");
                                }
                            } while (temperature < 0 || temperature > 200);

                            sensorDatas[i] = temperature;
                        }
                        isDataCollected = true;
                        Console.WriteLine("데이터 수집 완료! 엔터키를 누르세요...");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }



}
