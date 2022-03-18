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