namespace Examen1;
class Program
{
    static void Main(string[] args)
    {
        Jugador jugador = new Jugador();
        bool IniciarMenu = true;
        while (IniciarMenu)
        {
            IniciarMenu = jugador.MostrarMenu();
        }
    }
}
