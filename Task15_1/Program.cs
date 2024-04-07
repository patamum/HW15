namespace Task15_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            int start = 5;
            int step = 3;
            arith.setStart(start);
            arith.setStep(step);
            Console.WriteLine("Арифметическая прогресcия");
            Console.WriteLine(start);
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Сброс");
                    arith.reset();
                    Console.WriteLine(start);
                }                    
                Console.WriteLine(arith.getNext());
            }
            
            GeomProgression geom = new GeomProgression();
            geom.setStart(start);
            geom.setStep(step);
            Console.WriteLine("Геометрическая прогресcия");
            Console.WriteLine(start);
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("Сброс");
                    geom.reset();
                    Console.WriteLine(start);
                }
                Console.WriteLine(geom.getNext());
            }

        }
    }
}