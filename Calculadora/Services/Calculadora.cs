namespace Calculadora.Services;

public class Calculadora {
    private List<string> historico;
    private string Data;

    public Calculadora(string data) {
        historico = new List<string>();
        Data = data;
    }

    public int Somar(int x, int y) { 
        historico.Insert(0, $"Result: {x + y} | Data: {Data}");
        return x + y; 
    }
    public int Subtrair(int x, int y) { 
        historico.Insert(0, $"Result: {x - y} | Data: {Data}");
        return x - y; 
    }
    public int Multiplicar(int x, int y) { 
        historico.Insert(0, $"Result: {x * y} | Data: {Data}");
        return x * y; 
    }
    public int Dividir(int x, int y) { 
        historico.Insert(0, $"Result: {x / y} | Data: {Data}");
        return x / y; 
    }
    public List<string> Historico() {
        historico.RemoveRange(3, historico.Count - 3);
        return historico;
    }

    public int Fatorial(int x) {
        if (x == 1) {
            return x;
        } else {
            return x * Fatorial(x - 1);
        }
    }

    public int Potencia(int x, int y) {
        if (y == 1) {
            return x;
        } else {
            return x * Potencia(x, y - 1);
        }
    }

    public int Fibonacci(int x) {
        if (x < 2) {
            return x;
        } else {
            return Fibonacci(x - 1) + Fibonacci(x - 2);
        }
    }

    public bool RestoDivisao(int x) {
        return x % 2 == 0;
    }
}