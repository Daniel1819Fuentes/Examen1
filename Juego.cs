namespace Examen1;

class Juego: Program{
    public int dinero {set; get;}
    public Juego(int dinero){
        this.dinero = dinero;
    }
    public void MostrarSaldo() {
        Console.WriteLine(dinero.ToString());
    }
    public void ValidarSaldo() {
        if (this.dinero<=0)
        {
            
        }else
        {
            
        }
    }
    public void ValidarApuesta() {
        int valor;
        string? n;
        bool esNumero;
        bool rangoAceptado = true;
        do
        {
            do {
                Console.Clear();
                Console.WriteLine("Ingrese una apuesta en multiplos de 10");
                n = Console.ReadLine(); 
                esNumero= int.TryParse(n, out valor);
            } while (!esNumero);
            if(valor > 0 && valor < 36) {
                rangoAceptado = false;
            }
        } while (rangoAceptado);
    }
}