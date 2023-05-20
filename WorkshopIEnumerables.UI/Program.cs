using WorkshopIEnumerables.Logic;

int option = 0;

do
{
    option = Menu();
    switch (option)
    {
        case 1: MultiplyMatrices(); break;
        case 2: HourglassOfAmatrix(); break;
        case 3: DecompositionOfNumbersIntoFactors(); break;
        case 4: ReapAHarvestWithTheChessKnight(); break;
        case 5: HorsesInConflict(); break;

        default: break;
    }
}
while (option != 0);


#region Methods
void MultiplyMatrices()
{
    Console.WriteLine("Please enter m:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter n:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter p:");
    int p = Convert.ToInt32(Console.ReadLine());

    var matrixA = new Matrix();
    var matrixB = new Matrix(); 
    var matrixC = new Matrix();

    matrixA = new Matrix(matrixA.CreateArraysA(m, n)); 
    matrixB = new Matrix(matrixB.CreateArraysB(n, p));    
    matrixC = new Matrix(matrixC.MatrixMultiplier(matrixA.CreateArraysA(m, n), matrixB.CreateArraysB(n, p), m, n, p));


    Console.WriteLine($"*** A *** \n " +
                      $"{matrixA.ToString()}");
    Console.WriteLine($"*** B *** \n" +
                      $"{matrixB.ToString()}");
    Console.WriteLine($"*** C *** \n" +
                      $"{matrixC.ToString()}");

} //Listo

void HourglassOfAmatrix()
{
    var matrix = new Matrix();
    var matrixHourglass = new Matrix();

    Console.WriteLine("Please enter order matriz:");
    int order = Convert.ToInt32(Console.ReadLine());

    
    Console.Write(matrix.ToString());
    Console.WriteLine("******************");
    Console.Write(matrixHourglass.ToStringHourglass(matrix.FillMatrix2x2(order)));
    Console.Write(matrixHourglass.ToStringMatrixInverse(matrixHourglass.ToStringHourglassReves(matrix.FillMatrix2x2(order))));

} //Listo Casi que no 

void DecompositionOfNumbersIntoFactors()
{
    Console.WriteLine("Please enter a whole number:");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The factors of the number {number} are:");
    Factoring(number);

    void Factoring(int number)
    {
        int divisor = 2;
        string output = string.Empty;

        while (number >= 1)
        {
            if (number % divisor == 0)
            {
                if (number == 1)
                {
                    output += $"{number} | \n";
                }
                else
                {
                    output += $"{number} | {divisor} \n";
                }
                number /= divisor;


            }
            else
            {
                divisor++;
            }
        }
        
        Console.WriteLine(output);
    }
} //Listo


void ReapAHarvestWithTheChessKnight()
{
    throw new NotImplementedException();
} //Falta

void HorsesInConflict()
{
    throw new NotImplementedException();
} //Falta

int Menu()
{
    Console.WriteLine("¿What do you want to do? \n" +
                      "1. multiply matrices \n" +
                      "2. Hourglass of a matrix \n" +
                      "3. Decomposition of numbers into factors \n" +
                      "4. Reap a harvest with the chess knight \n" +
                      "5. Horses in conflict \n" +
                      "0. Exit");
    Console.WriteLine("Enter your option: ");
    var option = Console.ReadLine();

    return Convert.ToInt32(option);
}
#endregion