using System.Globalization;
public class Program
{
  static void Main()
  {
    List<Triangulo> listaT = new List<Triangulo>();
    while (true)
    {
      Console.WriteLine("Deseja adicionar um novo triângulo? s/n");
      string e = Console.ReadLine();
      if (e != "s") break;

      Triangulo t = new Triangulo();

      Console.WriteLine("Entre com o nome e as medidas do triângulo: ");
      t.Nome = Console.ReadLine();
      t.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      t.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      t.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      listaT.Add(t);
    }
    Triangulo maiorT = null!;
    double maiorArea = 0;
    foreach(var t in listaT)
    {
      double areaTAtual = t.AreaT();
      Console.WriteLine($"Área de {t.Nome} = {areaTAtual:F4}");
      if (areaTAtual > maiorArea)
      {
        maiorArea = areaTAtual;
        maiorT = t;
      }
    }
    Console.WriteLine($"Maior área = {maiorT.Nome}");
  }
}