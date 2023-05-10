namespace exercicio_1;
class Program
{
    static void Main(string[] args)
    {
        Cao peter = new Cao();
        Gato crystal = new Gato();
        Homem anderson = new Homem();

        Console.WriteLine("Chamei o gato e ele: " + crystal.Fala());
        Console.WriteLine("Chamei o cao e ele: " + peter.Fala());
        Console.WriteLine("Chamei o homem e ele: " + anderson.Fala());
    }
}
