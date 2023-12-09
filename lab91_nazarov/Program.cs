try
{
    Console.Write("Введите первый катет: ");
    double firstLeg1 = double.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.Write("Введите второй катет: ");
    double secondLeg1 = double.Parse(Console.ReadLine());
    Console.WriteLine();

    RightTriangle triangle1 = new RightTriangle(firstLeg1, secondLeg1);
    Console.WriteLine(triangle1.GetInfo());
    Console.WriteLine();
    Console.Write($"Площадь: {triangle1.CalculateArea():F2}");
    Console.WriteLine();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

class RightTriangle
{
    private double firstLeg;
    private double secondLeg;

    public RightTriangle(double firstLeg, double secondLeg)
    {
        this.firstLeg = firstLeg;
        this.secondLeg = secondLeg;
    }

    public string GetInfo()
    {
        return $"Первый катет равен: {firstLeg}, Второй катет равен: {secondLeg}";

    }

    public double CalculateArea()
    {
        return 0.5 * firstLeg * secondLeg;
    }
}