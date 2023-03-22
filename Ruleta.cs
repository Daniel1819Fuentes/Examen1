namespace Examen1;
 class Ruleta {
    public void ApuestaPorNum(int n) {
        Console.Clear();
        int a = Aleatorio36();
        Console.WriteLine($"En la ruleta a caido: {a}");
        if (a == n) {
            Console.WriteLine("has ganado");
        } else
        {
            Console.WriteLine("has perdido");
        }   
    }
    public int Verificarnum() {
        int valor;
        string? n;
        bool esNumero;
        bool rangoAceptado = true;
        do
        {
            do {
                Console.Clear();
                Console.WriteLine("Ingrese un num 0 al 36");
                n = Console.ReadLine(); 
                esNumero= int.TryParse(n, out valor);
            } while (!esNumero);
            if(valor > 0 && valor < 36) {
                rangoAceptado = false;
            }
        } while (rangoAceptado);
        return valor; 
    }
    public int Aleatorio36() {
        Random myObject = new Random();
        int ranNum= myObject.Next(0, 36);
        return ranNum;
    }
    public void ApuestaRoja() {
        int num = Aleatorio36();
        Console.Write($"En la ruleta a caido: {num}");
        if(num%2==0 || num == 29 || num ==  31 || num == 33 || num == 35 && num != 30
        && num != 32 && num != 34 && num != 36){
            Console.WriteLine(" es rojo");
            Console.WriteLine("has ganado");
        } else {
            Console.WriteLine(" es negro");
            Console.WriteLine("has perdido");
        }
    }
    public void ApuestaNeg() {
        int num = Aleatorio36();
        Console.Write($"En la ruleta a caido: {num}");
        if(num%2!=0 || num == 30 || num ==  32 || num == 34 || num == 36 && num != 29
        && num != 31 && num != 33 && num != 35){
            Console.WriteLine(" es negro");
            Console.WriteLine("has ganado");
        } else {
            Console.WriteLine(" es rojo");
            Console.WriteLine("has perdido");
        }
    }
    public int ParEinpar(int n) {
        if(n%2==0) {
            return 0;
        } else
        {
            return 1;
        }
    }
 }