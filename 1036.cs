// 1036
using System; 

public class Program {

  public static void Main(string[] args) {


    double D, X1, X2;
    Console.WriteLine("digite a");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("digite b");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("digite c");
    double c = double.Parse(Console.ReadLine());

    D = (b * b) - 4 * a * c;
    X1 = ((-b) + Math.Sqrt(D)) / (2 * a);
    X2 = ((-b) - Math.Sqrt(D)) / (2 * a);

    Console.WriteLine($"R1 = {X1:0.00000}");
    Console.WriteLine($"R2 = {X2:0.00000}");
  }
}
