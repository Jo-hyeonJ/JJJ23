using System.Reflection;

namespace JJJ23
{

    internal class Program
    {
        public static int[] ExtractLength(string[] strs)
        {
            return strs.Select(s => s.Length).ToArray();

            int[] result = new int[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                result[i] = strs[i].Length;
            }

            return result;
        }
        public static int ContainsString(string strA, string strB)
        {
            return strA.Contains(strB) ? 1 : 2;

            var c = strA.Contains(strB);

            if (c)
                return 1;
            else
                return 2;



        }

        public class Box
        {
            public int x;
            public int y;
            public Box(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            // string.Join을 쓰기 위해 tostring을 정의해준다.
            public override string ToString()
            {
                return $"x : {x}, y : {y}";
            }
        }

        class Person
        {
            public string name;
            public int age;
            public float height;
        }

        public static string IsEven(int num)
        {
            return num % 2 == 0 ? "Even" :"Odd";   
        }
        public static string[] UpLower(string[] strings)
        {
            // IEnumerable<T>.Select()
            // = Func<T,T> selector = T를 매개변수로 받고 TR를 반환
            // = Func<T,index(int)> selector = T와 인덱스를 매개변수로 받고 TR(result)을 반환하는 함수
            // 아래에서 s는 문자열 배열 속성 중 하나, i는 index가 몇번째인지
            strings.Select((s, i) => (i % 2 == 0) ? s.ToLower() : s.ToUpper()).ToArray();

            string[] result = new string[strings.Length];
            for (int i = 0; i < strings.Length; i++)
            {
                if (i % 2 == 0)
                    result[i] = strings[i].ToUpper();
                else
                    result[i] = strings[i].ToLower();
            }


            return result;
        }
        public static string Enigma(string word, int code)
        {
            return string.Concat(word.Where((w, i) => ((i + 1) % code == 0)));
        }

        public static int CombineBigNum(int a, int b)
        {
            string ab = string.Concat(a.ToString(),b.ToString());
            string ba = string.Concat(b.ToString(), a.ToString());

            if(int.Parse(ab) >= int.Parse(ba))
            {
                return int.Parse(ab);
            }
            else
            {
                return int.Parse(ba);
            }
        }

        public static int[] RepeatNum(int[] nums)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int e = nums[i];
                for (int j = 0; j < e; j++)
                {
                    result.Add(e);
                }
            }

            return result.ToArray();
        }
        static void Main(string[] args)
        {
            //1교시
            /*
            // Q. 문자열 배열의 각 요소의 길이를 int형 배열로 반환

            string[] BBB = { "black", "cow", "dude" };

            Console.WriteLine(string.Join(",", ExtractLength(BBB)));

            // Q. 문자열 A와 B가 주어졌을 때 B가 A에 포함되면 1, 아니면 2를 반환

            Console.WriteLine(ContainsString("ABC", "A"));
            Console.WriteLine(ContainsString("ABC", "D"));


            // Select는 선택이며 변환의 역할을 겸할 수 있다.
            Box[] boxs = new Box[] { new Box(1, 1), new Box(1, 1), new Box(1, 1), new Box(1, 1) };
            Console.WriteLine(string.Join(",", boxs.Select(b => b.x).ToArray()));
            Console.WriteLine(string.Join(",", boxs.Where(b => b.x % 2 != 0)));

            // 무명 클래스
            // 선언과 동시에 값을 집어넣는 형식
            var player = new { name = "유저A", Level = "30" };
            // 값을 대입 할 수는 없다.

            // 지정 연산자를 사용하여 생성자 없는 클래스에 값을 넣을 수 있다.
            Person person = new Person() { name = "이름", age = 30, height = 160f };

            Person[] persons = new Person[] {
            new Person() { name = "이름", age = 20, height = 160f },
            new Person() { name = "이름", age = 20, height = 160f },
            new Person() { name = "이름", age = 20, height = 160f },
            new Person() { name = "이름", age = 20, height = 160f },
            };

            // 무명 클래스를 사용하여 클래스의 일부만을 수용하는 클래스를 쉽게 만들 수 있다.
            // 웹에선 클래스가 없기에 자주 사용하는 방식이다.

            // persons에서 키가 150이 넘는 객체의 이름과 나이+키를 2로 나눈 값을 배열로 만듬
            var find = persons.Where(p => p.height >= 150f).Select(p =>
            new { name = p.name, order = (p.age + p.height) / 2f }).ToArray();

            foreach(var v in find)
            {
                Console.WriteLine(v.name + v.order);
            }
            */
            //2,3교시
            /*
            // 정수 num이 짝수일 경우 even을 반환, 홀수인 경우 odd를 반환하는 함수

            Console.WriteLine("30은 " + IsEven(30));
            Console.WriteLine("29는 " + IsEven(29));

            Console.WriteLine();
            
            // 홀수번째 인덱스는 대문자로, 짝수는 소문자로 배열 만들어 뱉기
            string[] ULs = { "AAA", "BBB", "CCC", "DDD", "EEE" };

            ULs = UpLower( ULs );
            ULs.ToWriteLine();
            Console.WriteLine();

            // 암호문 해독하기

            string ww = "ashasoasmase";

            Console.WriteLine(Enigma(ww,3));
            */

            // Q. a와 b를 결합했을 때 더 큰 조합을 리턴하라
            // 5와 15가 결합 됐을 때 155가 아닌 515가 나와야함

            Console.WriteLine(CombineBigNum(125, 15));


            // Q. 배열의 원소만큼 추가하기(int[])
            // 1은 배열에 '1' 하나, 6은 배열에 '6' 6개

            int[] nums = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(string.Concat(RepeatNum(nums)));
        }
    }
    public static class Method
    {
        public static void ToWriteLine<T>(this T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}