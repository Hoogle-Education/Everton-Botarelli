# Construtores

São criações personalizadas de novos objetos, para manter uma boa consistência pelo código.

Exemplo: Uma pessoa já deve ser instaciada com um nome e um idade, porém seu telefone pode ser opcional;

Primeiro jeito (que a gente não faz muito)
```c#
class Pessoa {

  public string Nome;

  public Pessoa(String NomeEntrada){
    Nome = NomeEntrada;
  }

}
```

Deste jeito é mais interessante em casos futuros:
```c#
class Pessoa {

  public string Nome;

  public Pessoa(String Nome){
    this.Nome = Nome;
  }

}
```

## Keyword `this`

Faz uma autoreferência ao objeto que invocou o construtor ou método.

## Sobrecarga (*Overload*)

*Overload* é o processo de sobrecarregar ou sobrepor os construtores de uma classe, isto é, tornar opicional e seguro a criação de novos objetos daquele tipo.

Por exemplo, uma pessoa **deve** ter nome e idade na criação, mas uma pessoa **pode** ter um telefone.

```c#
class Pessoa {

  public string Nome;
  public int Idade;

  public Pessoa(string Nome){
    this.Nome = Nome;
  }

  public Pessoa(string Nome, int Idade){
    this.Nome = Nome;
    this.Idade = Idade;
  }

}
```

# Getters and Setters 

Controlando o acesso **durante** o uso dos atributos e mantendo a flexibilidade/segurança do código.

# Properties e autoProperties

Aprofundaremos nesses tópicos mais a frente, porém seu uso é para diminuir a verbosidade dos getters and setters.

## Propertie 

Usado quando queremos personalizar o get ou o set:

```c#
public long Number {
    get { return _number; }
    set { 
        if(value > 0) _number = value;
        else Console.WriteLine($"O valor = {value} é inválido!");
    }
}
```

## Auto properties

Atalho: *"prop"* + `tab` + `tab`

```c#
public string Name { get; private set; }
public int Age { get; private set; }
private long _number;
```

