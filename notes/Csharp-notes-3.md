# Listas e pesquisas

Ainda veremos listas com mais detalhes, e como seus métodos foram implementados.

## Introdução Tipos Genéricos (`<T>`)

Veremos apenas para ler melhor as documentações por enquanto, e são indicativos de que dado um primeiro elemento do tipo `T` criado, todos os elementos referentes a esse tipo `T` genérico serão da mesma classe. 

Não funciona criar do tipo `Object` pois traria muitas falhas e possíveis inseguranças ao longo do código.

## Principais métodos das Listas

| `methods` | Evento |
|:---:| :---: |
|`.add(T Item)`| Adiciona no final |
|`.remove(T Item)`| Remove um item na lista |
|`.findIndex()`| Retorna verdadeiro se contém o item |
|...| veja mais na referência |

O interessante desses tópicos é apenas facilitas pesquisas e aplicações em projetos atuais.

# Static keyword

Variáveis ou métodos estáticas são imutáveis(*estáticas*) em relação a sua classe e por isso também não precisam de instância para serem mencionadas.

puramente estática:
```c#
public class Circle{

  public static const double PI = 3.14159265;

  public static double CalculateArea(double radius){
    return radius*radius*PI;
  }

}
```

uso:
```c#
  double resposta = Circle.CalculaArea(4.0);
```

mesclando estático com não-estático:
```c#
public class Circle{

  public static const double PI = 3.14159265;

  public double Radius {get; set;}

  public Circle(double radius){
    Radius = radius;
  }

  public static double CalculateArea(double radius){
    return radius*radius*PI;
  }

  public double Area(){
    return Radius*Radius*PI;
  }

}
```

# Tipo Nullable

Nullable é um tipo quando não desejamos que nossas atributos comecem zerados ou com valores estranhos. Por exemplo um saldo deve começar `null` e não zerado.

Jeito inicial:
```c#
 Nullable<int> a;
```

Como fazemos hoje em dia:
```c#
  double? a = null;
```

## Operador `?`

Indica variável do tipo nulo.

## Atributo `.HasValue`

```c#
 int? a = null;
 int? b = 2;

 if(a.HasValue) Console.WriteLine("A");
 else if if(b.HasValue) Console.WriteLine("B");
 else Console.WriteLine("NULL");
```

saída:
```
B
```

## Colescência nula `??`

> [Referência microsoft](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator)

Objetivo: Testar se é nulo e se não for escolher a variável.

# Modelo de entrada `params`

Permite que sejam recebidos diversos parametros, bem como passar um vetor como parametro, porém está *keyword* melhora a sintaxe de chamada.

```c#
public static void sum(params int[] vetor){
  int resultado=0;

  foreach(int x in vetor) sum += x;

  return resultado;
}
```

```c#
  Test.sum(1, 2, 3, 4, 6); // saída = 16
```

# Entradas por Referência

Quando desejamos que um parâmetro de função **realmente** seja alterado pelo parâmetro de entrada, precisamos que seja passada uma referência a raiz dessa variável e não apenas uma cópia dela.

Função para trocar dois números:
```c#
 public class Test{

   public static void swap(int a, int b){
     int temp = a;
     a = b;
     b = temp;
   }

 }
```

Nossa aplicação:
```c#
 public class Program{
   public static void main(string[] args){
    int x = 2;
    int y = 3;

    Test.swap(x,y);  
   }
 }
```

⚠️ **Problema:** Os valores não são trocados pois é passado para a `swap` apenas uma cópia dos valores de `x` e `y`, sendo assim a troca pertence ao escopo local. Para que realmente sejam alterados, trabalharemos com uma **referência ao endereço de memória** destes dados.

## 1. Keyword `ref`

Usamos a ref no parametro e na passagem da variável, para que o próprio programa entenda que deve ser pasado e usado uma referência na captura do parâmetro.

Alterando a Swap:
```c#
   public static void swap(ref int a, ref int b){
     int temp = a;
     a = b;
     b = temp;
   }
```

Alterando a chamada da swap:
```c#
 Test.swap(ref x, ref y);
```

e agora efetivamente trocaremos os dados de x e y.

## 2. Keyword `out`

Similar ao `ref`, faz o parâmetro ser uma referência para a variável, porém ele não exige que a variável seja anteriormente criada. É similar a uma quebra no escopo da função, pois existe a exportação de uma variável por referência sem necessidade de usar `return`.

```c#
 public class Calculator{
   public static void Multiply(int value, int multiplier, out int result){
     result = value*multiplier;
   }
 }
```

```c#
  public class Program{
    public static void main(string[] args){
      int value = 5;
      int multiplier = 6;
      int result = Calculator.Multiply(value, multiplier, out result);
    }
  }
```


## 3. `ref` *versus* `out`
 
Ambos são muito parecidos, e essencialmente iguais por baixo dos panos.

 |`ref`| `out`|
 |:---:|:---:|
 |variável parâmetro **DEVE** ter sido iniciada|variável parâmetro **não precisa**|

 > **Code Smells:** Ambos são considerados designs ruins de códigos, a partir do paradigma da orientação a objetos, esses usos devem ser evitados.