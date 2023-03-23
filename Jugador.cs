namespace Examen1;

class Jugador {
    Juego juego = new Juego();
    SubMenus subMenus = new SubMenus();
    public bool MostrarMenu() {
        Console.Clear();
        Console.WriteLine("Bienbenido");
        Console.WriteLine("1.-Mostrar mi saldo");
        Console.WriteLine("2.-Jugar");
        Console.WriteLine("3.-Estadisticass");
        Console.WriteLine("4.-Salir");
        Console.Write("Opcion: ");

        switch(Console.ReadLine()) {
            case "1":
            juego.MostrarSaldo();
            Console.Write("precione enter para continuar");
            Console.ReadLine();
            return true;
            case "2":
            subMenus.MenuApuestas();
            return true;
            case "3":
            subMenus.MenuEstadisticas();
            return true;
            case "4":
            return false;
            default:
            return true;

        }
    }
}