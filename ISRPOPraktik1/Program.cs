using ISRPOPraktik1;

try
{
    Console.Write("Введите количество строк n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    double[,] matr = new double[n, m];

    Console.WriteLine("Выберите команду: 1 - рандомные значения;" +
        " 2 - ручной ввод.");
    int value = Convert.ToInt32(Console.ReadLine());
    double[] b;
    switch (value)
    {
        case 1:
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = rnd.Next(-10, 10);
                    Console.Write("{0,5}", matr[i, j] + " ");
                }
                Console.WriteLine();
            }
            b = Proizvedenie.FormVector(matr);
            Console.WriteLine();

            Console.WriteLine("Вектор b (произведение элементов строк):");
            for (int i = 0; i < b.Length; i++)
                Console.Write("{0,5}", b[i]);
            Console.WriteLine();

            b = AvgStolbik.FormVector(matr);
            Console.WriteLine();

            Console.WriteLine("Вектор b (среднее арифметическое столбцов):");
            for (int j = 0; j < b.Length; j++)
                Console.Write("{0,5}", b[j]);
            Console.WriteLine();

            b = RaznMinMax.FormVector(matr);
            Console.WriteLine();

            Console.WriteLine("Вектор b (разность max и min по строкам):");
            for (int i = 0; i < b.Length; i++)
                Console.Write("{0,5}", b[i]);
            Console.WriteLine();

            b = OneOtricat.FormVector(matr);
            Console.WriteLine();

            Console.WriteLine("Вектор b (первый отрицательный в столбце):");
            for (int j = 0; j < b.Length; j++)
                Console.Write("{0,5}", b[j]);
            Console.WriteLine();
            break;

        case 2:
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ввод строки" + i);
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Ввод значения " + (j + 1) + " столбца - ");
                    matr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            Console.WriteLine("Исходный массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0,5}", matr[i, j]);
                }
                Console.WriteLine("");
            }
            b = Proizvedenie.FormVector(matr);
            Console.WriteLine();

            Console.WriteLine("Вектор b (произведение элементов строк):");
            for (int i = 0; i < b.Length; i++)
                Console.Write("{0,5}", b[i]);
            Console.WriteLine();

            b = AvgStolbik.FormVector(matr);
            Console.WriteLine();

            Console.WriteLine("Вектор b (среднее арифметическое столбцов):");
            for (int j = 0; j < b.Length; j++)
                Console.Write("{0,5}", b[j]);
            Console.WriteLine();

            b = RaznMinMax.FormVector(matr);
            Console.WriteLine();

            Console.WriteLine("Вектор b (разность max и min по строкам):");
            for (int i = 0; i < b.Length; i++)
                Console.Write("{0,5}", b[i]);
            Console.WriteLine();

            b = OneOtricat.FormVector(matr);
            Console.WriteLine();

            Console.WriteLine("Вектор b (первый отрицательный в столбце):");
            for (int j = 0; j < b.Length; j++)
                Console.Write("{0,5}", b[j]);
            Console.WriteLine();
            break;
        default:
            Console.WriteLine("Неизвестная команда!");
            break;
    }
}
catch (Exception)
{
    Console.WriteLine("Ну давай братик потом придёшь!");
}