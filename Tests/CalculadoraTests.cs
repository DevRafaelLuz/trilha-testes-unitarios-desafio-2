namespace Tests;

public class CalculadoraTests {
    public Calculadora.Services.Calculadora ConstruirClasse() {
        string Data = "17/10/2024";
        Calculadora.Services.Calculadora calculadora = new Calculadora.Services.Calculadora(Data);
        return calculadora;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TesteSomar(int x, int y, int z) {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();

        int resultado = calculadora.Somar(x, y);

        Assert.Equal(z, resultado);
    }

    [Theory]    
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void TesteMultiplicar(int x, int y, int z) {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();

        int resultado = calculadora.Multiplicar(x, y);

        Assert.Equal(z, resultado);
    }

    [Theory]    
    [InlineData(6, 2, 3)]
    [InlineData(9, 3, 3)]
    public void TesteDividir(int x, int y, int z) {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();

        int resultado = calculadora.Dividir(x, y);

        Assert.Equal(z, resultado);
    }

    [Theory]    
    [InlineData(6, 2, 4)]
    [InlineData(9, 5, 4)]
    public void TesteSubtrair(int x, int y, int z) {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();

        int resultado = calculadora.Subtrair(x, y);

        Assert.Equal(z, resultado);
    }

    [Fact]
    public void TesteDivisaoPorZero() {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();
        Assert.Throws<DivideByZeroException> (() => calculadora.Dividir(3, 0));
    }

    [Fact]
    public void TesteHistorico() {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();
        calculadora.Somar(1, 2);
        calculadora.Somar(3, 4);
        calculadora.Somar(5, 6);
        calculadora.Somar(7, 8);

        var lista = calculadora.Historico();

        Assert.NotEmpty(calculadora.Historico());
        Assert.Equal(3, lista.Count);
    }

    [Fact]
    public void TesteFatorial() {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();
    
        int resultado = calculadora.Fatorial(5);
    
        Assert.Equal(120, resultado);
    }

    [Fact]
    public void TestePotencia() {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();

        int resultado = calculadora.Potencia(5, 3);

        Assert.Equal(125, resultado);
    }

    [Fact]
    public void TesteFibonacci() {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();

        int resultado = calculadora.Fibonacci(6);

        Assert.Equal(8, resultado);
    }

    [Fact]
    public void TesteRestoDivisao() {
        Calculadora.Services.Calculadora calculadora = ConstruirClasse();

        Assert.True(calculadora.RestoDivisao(10));
    }
}