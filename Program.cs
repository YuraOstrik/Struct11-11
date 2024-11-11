namespace Struct.Home11._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Drob d1 = new Drob(1,2);
            Drob d2 = new Drob(2, 5);

            Drob sum = d1 + d2;
            Console.WriteLine(sum);
        }

        struct Drob
        {
            public int x { get; set; }
            public int y { get; set; }

            public Drob( int x, int y)
            {
                if(y == 0)
                {
                    throw new Exception(" 0 0 0 ");
                }
                this.x = x;
                this.y = y;

            }

            public static Drob operator +(Drob d1, Drob d2)
            {
                int num = d1.x * d1.y + d2.x * d2.y;
                int pum = d1.y * d2.y;
                return new Drob(num, pum);
            }
            public static Drob operator -(Drob d1, Drob d2)
            {
                int num = d1.x * d1.y - d2.x * d2.y;
                int pum = d1.y * d2.y;
                return new Drob(num, pum);
            }
            public static Drob operator *(Drob d1, Drob d2)
            {
                int num = d1.x * d2.x ;
                int pum = d1.y * d2.y;
                return new Drob(num, pum);
            }
            public static Drob operator /(Drob d1, Drob d2)
            {
                int num = d1.x / d2.x;
                int pum = d1.y * d2.y;
                return new Drob(num, pum);
            }

            public override string ToString()
            {
                return $"{x} / {y}";
            }
        }
    }
}
