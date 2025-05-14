public class Triangulo 
{
    public string? Nome;
    public double A, B , C;
    public double AreaT()
    {
        double p = (A + B + C) / 2d;
        double areaT = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        return areaT;
    }
}