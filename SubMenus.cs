namespace Examen1;

class SubMenus {
    Ruleta ruleta = new Ruleta();
    public void MenuApuestas() {
        bool selec = true;
        while (selec) {
            Console.Clear();
            Console.WriteLine("Modo de apuesta");
            Console.WriteLine("1.-Seleccion de numero");
            Console.WriteLine("2.-seleccion de color");
            Console.WriteLine("3.-Es par o impar");
            Console.WriteLine("4.-regresar");
            Console.Write("Opcion: ");
            switch (Console.ReadLine()) {
                case "1":
                    int n = ruleta.Verificarnum();
                    ruleta.ApuestaPorNum(n);
                    break;
                case "2":
                    MenuColores();
                    break;
                case "3":
                    MenuParInpares();
                    break;
                case "4":
                    selec = false;
                    break;
                default: 
                    selec = true;
                    break;
            }
        }
    }
    public void MenuColores() {
        bool selec = true;
        while(selec) {
            Console.Clear();
            Console.WriteLine("Qué Color quieres");
            Console.WriteLine("1.-Rojo");
            Console.WriteLine("2.-Negro");
            Console.WriteLine("3.-regrsar");
            Console.Write("Opcion: ");
            switch (Console.ReadLine()) {
                case "1":
                    ruleta.ApuestaRoja();
                    Console.WriteLine("preciona enter para continuar");
                    Console.ReadLine();
                    break;
                case "2":
                    ruleta.ApuestaNeg();
                    Console.WriteLine("preciona enter para continuar");
                    Console.ReadLine();
                    break;

                case "3":
                    selec = false;
                    break;
                default:
                    break;
            }
        }
    }
    public void MenuParInpares() {
        bool selec = true;
        while(selec) {
            Console.Clear();
            Console.WriteLine("selecciona pares o inpares");
            Console.WriteLine("1.-Par");
            Console.WriteLine("2.-Inpar");
            Console.WriteLine("3.-regrsar");
            Console.Write("Opcion: ");
            switch (Console.ReadLine()) {
                case "1":
                    int n =ruleta.ParEinpar(ruleta.Aleatorio36());
                    if(n == 0) {
                        Console.WriteLine("es par, has ganado");
                        Console.WriteLine("Precione enter para continuar");
                        Console.ReadLine();
                    } else
                    {
                        Console.WriteLine("es inpar, has perdido");
                        Console.WriteLine("Precione enter para continuar");
                        Console.ReadLine();
                    }
                    break;
                case "2":
                    int c =ruleta.ParEinpar(ruleta.Aleatorio36());
                    if(c != 0) {
                        Console.WriteLine("es inpar, has ganado");
                        Console.WriteLine("Precione enter para continuar");
                        Console.ReadLine();
                    } else
                    {
                        Console.WriteLine("es par, has perdido");
                        Console.WriteLine("Precione enter para continuar");
                        Console.ReadLine();
                    }
                    break;

                case "3":
                    selec = false;
                    break;
                default:
                    break;
            }
        }
    }
    public void MenuEstadisticas() {
        bool selec = true;
        while (selec) {
            Console.Clear();
            Console.WriteLine("Que deceas ver: ");
            Console.WriteLine("1.-Balance");
            Console.WriteLine("2.-Cantidad de jugadas");
            Console.WriteLine("3.-Numero con más y menos suerte");
            Console.WriteLine("4.-Color con más y menos suerte");
            Console.WriteLine("5.-Pares o impares Cuales tienen mayor suerte");
            Console.WriteLine("6.-Regresar");
            Console.Write("Opcion: ");
            switch (Console.ReadLine()) {
                case "1":
                    Console.WriteLine("Balance");
                    Console.ReadLine();
                    selec = true;
                    break;
                case "2":
                    Console.WriteLine("Historial de jugadas");
                    Console.ReadLine();
                    selec = true;
                    break;
                case "3":
                    Console.WriteLine("Numero con suerte");
                    Console.ReadLine();
                    selec = true;
                    break;
                case "4":
                    Console.WriteLine("colores con suerte");
                    Console.ReadLine();
                    selec = true;
                    break;
                case "5":
                    Console.WriteLine("pares o impares");
                    Console.ReadLine();
                    selec = true;
                    break;
                case "6":
                    Console.WriteLine("Hasta pronto");
                    Console.ReadLine();
                    selec = false;
                    break;
                default: 
                    selec = true;
                    break;
            }
        }
    }
}