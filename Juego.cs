namespace Examen1;

class Juego: Program{
    Ruleta ruleta = new Ruleta();
    public int dinero = 300;
    public int dineroapostado = 0;
    public void MostrarSaldo() {
        Console.WriteLine(dinero);
    }
    public void RealizarApuesta() {
        bool a = true;
        if (dinero > 0)
        {
            do
            {
                int n = ruleta.Dinero();
                if (n > 0 && n%10==0 && n <= dinero)
                {
                    Console.WriteLine("se realizo la apuesta");
                    dineroapostado = n;
                    a = false;
                }


            } while (a);
        } else
        {
            Console.WriteLine("No cuenta con el dinero suficiente");
        }
    }
    public void Premio(bool b, int n) {
        bool a = b;
        switch (n)
        {
            case 1:
            if (a.Equals(true))
            {
                dinero = dinero + dineroapostado*10;
                Console.WriteLine("has ganado: +" + (dineroapostado * 10));
                Console.WriteLine(dinero);
                Console.ReadLine();
            } else
            {
                dinero = dinero - dineroapostado*10;
                Console.WriteLine("has perdido: -" + (dineroapostado * 10));
                Console.WriteLine( dinero);
                Console.ReadLine();
            }
            break;
            default:
            break;
        }
    }
}