
public class Program1
{
    public static void Main()
    {
        byte edad;
        
        Console.WriteLine("Introduce su edad");

        edad=74;

        Console.WriteLine("No aparentas",edad);
    }
}
public class Program2
{
	public static void Main()
	{
		byte n1, n2, m1;
		Console.WriteLine("Ingrese 2 numeros de 2 crifas:");
		n1 = Convert.ToByte(Console.ReadLine());
		n2 = Convert.ToByte(Console.ReadLine());
		m1 = (byte)(n1 * n2);
		ushort b3 = m1;
		Console.WriteLine(b3);
	}
}

public class Program3
{
    public static void Main()
    {
        long n1 = 444245;
        long n2 = 342423;
        long suma, resta, multiplicacion;
        Console.WriteLine("Los datos son {0}, {1}");
        suma = n1 + n2;
        resta = n1 - n2;
        multiplicacion = n1 * n2;
        Console.WriteLine(suma);
        Console.WriteLine(resta);
        Console.WriteLine(multiplicacion);
        Console.WriteLine(Console.ReadLine());
    }
}
