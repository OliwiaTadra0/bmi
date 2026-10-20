Console.WriteLine("Obliczmy Twoje BMI!");
Console.Write("Podaj swoją wagę (kg): ");
double waga = double.Parse(Console.ReadLine());
Console.Write("Podaj swój wzrost (m): ");
double wzrost = double.Parse(Console.ReadLine());
double bmi = waga / (wzrost * wzrost);
Console.WriteLine($"Twoje BMI wynosi: {bmi:F2}");
if (bmi < 18.5)
{
    Console.WriteLine("Masz niedowagę.");
}
else if (bmi >= 18.5 && bmi < 24.9)
{
    Console.WriteLine("Masz prawidłową wagę.");
}
else if (bmi >= 25 && bmi < 29.9)
{
    Console.WriteLine("Masz nadwagę.");
}
else
{
    Console.WriteLine("Masz otyłość.");
}



