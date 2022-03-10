# Introdução a POO

## Conceito de Class e Objeto

> Classe é similar a um molde

> Objetos são frutos do molde

Podemos definir de maneira razoável, que tudo *é* ou *faz* algo.

Desta forma uma classe(molde) qualquer possui:

```
  Classe:
    | - Atributos (o que ela é)
    | - métodos (o que ela faz)
```

## Pilares da POO

1. Flexibilidade
2. Reuso

## Usando Atributos

```c#
public class Pessoa {

    public string Nome;
    public int Idade;
    public char Sexo;
    public long Telefone;

}
```

Criamos um molde de pessoa com todos os atributos listados.

## Usando nosso modelo

```C#
  Pessoa joao = new Pessoa();
```

## Métodos 

O que a classe pode fazer.

```c#
public class Pessoa{

  // ...

  public void Birthday(){
    Idade++;
  }

}
```

Estrutura genérica de um método

```html
  <privacidade> <retorno> <nome da função> ( <parametros> ){
    <sequencia de passos>
    <retorno se tiver retorno>
  }
```

