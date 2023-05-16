//using WorkshopIEnumerables.Logic;

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
    throw new NotImplementedException();
}

void HourglassOfAmatrix()
{
    throw new NotImplementedException();
}

void DecompositionOfNumbersIntoFactors()
{
    Console.WriteLine("Please enter a whole number:");
    string? resp = Console.ReadLine();
    int number = int.Parse(resp);

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
                    output += $"{number} \n";
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
}



void ReapAHarvestWithTheChessKnight()
{
    throw new NotImplementedException();
}

void HorsesInConflict()
{
    throw new NotImplementedException();
}

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