# Tratamento de Excessões

## Vantagens

- Código mais resistente a erros
- Protocolo a ser realizado em casos de erro
- Permite que o código continue apesar de uma falha em um teste especifico.

## Exemplos

```c#

  public static double divide(double a, double b) throws DividedByZeroException {
    return a/b;
  }

 public static void Main(String[] Args) {

   double a, b;

   try {
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());

    if(b > 200) throw new OverflowException("Overflow the limit");

     Console.WriteLine(a/b);
   } catch(DividedByZeroException) {
     Console.WriteLine("You cannot divide by zero!");
   } catch (FormatException )

 }
```