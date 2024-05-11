**Projeto Celular usando .NET 8**

Este é um projeto simples que demonstra a criação de um sistema de gerenciamento de smartphones usando a linguagem de programação C# e o framework .NET 8. O projeto consiste em três classes principais: Smartphone, Iphone e Nokia.

**Classes
Smartphone**
A classe Smartphone é uma classe abstrata que serve como a classe base para os modelos de smartphones. Possui propriedades comuns a todos os smartphones, como número, modelo, IMEI e memória. Além disso, possui métodos comuns, como ligar e receber ligação. A classe Smartphone também possui um método abstrato InstalarAplicativo, que deve ser implementado pelas subclasses.

**Iphone**
A classe Iphone é uma subclasse da classe Smartphone e representa um modelo específico de smartphone da marca Apple. Ela herda todas as propriedades e métodos da classe Smartphone e implementa o método InstalarAplicativo de acordo com as especificidades do modelo Iphone.

**Nokia**
A classe Nokia é uma subclasse da classe Smartphone e representa um modelo específico de smartphone da marca Nokia. Da mesma forma que a classe Iphone, ela herda todas as propriedades e métodos da classe Smartphone e implementa o método InstalarAplicativo de acordo com as especificidades do modelo Nokia.

**Utilização**
No arquivo Program.cs, foram criados dois objetos de teste: um Iphone e um Nokia. Os objetos foram instanciados com números, modelos, IMEIs e capacidades de memória específicos. Em seguida, foram utilizados os métodos InstalarAplicativo e Ligar para demonstrar o funcionamento básico do sistema.



using Celular.Models;

class Program
{
    static void Main(string[] args)
    {
        Iphone ip = new Iphone(("94521564"),"11 Pro Max","14527318M1",64);
        Nokia nk = new Nokia(("9846624"),"Lumia 15","145518M1",32);

        ip.InstalarAplicativo("Spotiffy");
        nk.InstalarAplicativo("Amazon Prime");
        nk.Ligar();
    }
}


**Conclusão**
Este projeto demonstra uma implementação simples de um sistema de gerenciamento de smartphones em C# utilizando .NET 8. As classes Smartphone, Iphone e Nokia ilustram conceitos básicos de herança, polimorfismo e abstração em programação orientada a objetos.

