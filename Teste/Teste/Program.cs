using System.Globalization;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            //double N1, N2, N3, N4, MEDIA;
            //string[] values = Console.ReadLine().Split(' ');
            //N1 = double.Parse(values[0]);
            //N2 = double.Parse(values[1]);
            //N3 = double.Parse(values[2]);
            //N4 = double.Parse(values[3]);

            //MEDIA = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10; ;
            //Console.WriteLine("Media: " + MEDIA.ToString("0.0"));


            //if (MEDIA >= 7)
            //{
            //    Console.WriteLine("Aluno aprovado.");
            //}
            //else if (MEDIA < 7 && MEDIA >= 5)
            //{
            //    Console.WriteLine("Aluno em exame.");
            //    double NExame = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Nota do exame: " + NExame.ToString("0.0"));
            //    MEDIA = (MEDIA + NExame) / 2;
            //}
            //if (MEDIA >= 5)
            //{
            //    Console.WriteLine("Aluno aprovado.");
            //}
            //else
            //{
            //    Console.WriteLine("Aluno reprovado.");
            //}
            //Console.WriteLine("Media final: " + MEDIA.ToString("0.0"));

            //Console.ReadKey();

            System.Threading.Thread.CurrentThread.CurrentUICulture =
        System.Globalization.CultureInfo.InvariantCulture;

            double N1, N2, N3, N4, MEDIA;
            string[] values = (Console.ReadLine().Split(' '));
            N1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            N2 = double.Parse(values[1], CultureInfo.InvariantCulture);
            N3 = double.Parse(values[2], CultureInfo.InvariantCulture);
            N4 = double.Parse(values[3], CultureInfo.InvariantCulture);

            MEDIA = (N1 * 2 + N2 * 3 + N3 * 4 + N4) / 10;
            Console.WriteLine("Media: " + MEDIA.ToString("0.0", CultureInfo.InvariantCulture));
            if (MEDIA >= 7.0)
            {   
                Console.WriteLine("Aluno aprovado.");
            }
            else if (MEDIA >= 5.0)
            {
                Console.WriteLine("Aluno em exame.");
                double NExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Nota do exame: " + NExame.ToString("0.0", CultureInfo.InvariantCulture));
                double result = (NExame + MEDIA / 2.0);
                if (result > 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                MEDIA = (NExame + MEDIA) / 2.0;
                Console.WriteLine("Media final: " + MEDIA.ToString("0.0", CultureInfo.InvariantCulture));

            }
            else
            {
                Console.WriteLine("Aluno reprovado.\n");
            }

            using System;

namespace Start
    {
        class Program
        {
            static void Main(string[] args)
            {
                double a, b, c, d, avg;
                string[] values = Console.ReadLine().Split(' ');

                a = double.Parse(values[0]) * 2;
                b = double.Parse(values[1]) * 3;
                c = double.Parse(values[2]) * 4;
                d = double.Parse(values[3]) * 1;

                avg = (a + b + c + d) / 10;
                Console.WriteLine("Media: " + avg.ToString("0.0"));

                if (avg >= 7)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else if (avg < 5)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                else if (avg <= 6.9)
                {
                    double e = double.Parse(Console.ReadLine());

                    Console.WriteLine("Aluno em exame.");
                    Console.WriteLine("Nota do exame: " + e.ToString("0.0"));
                    avg = (avg + e) / 2;

                    if (avg >= 5)
                    {
                        Console.WriteLine("Aluno aprovado.");
                    }
                    else
                    {
                        Console.WriteLine("Aluno reprovado");
                    }
                    Console.WriteLine("Media final: " + avg.ToString("0.0"));
                }
                Console.ReadKey();
            }
        }
    }














}
    }
}





