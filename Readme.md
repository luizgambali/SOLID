Projetos de Exemplo dos Princípios do SOLID
Este repositório contém uma série de projetos desenvolvidos para exemplificar os princípios do SOLID. Cada projeto possui duas pastas: "wrong" e "correct". Na pasta "wrong", estão as implementações que não seguem corretamente os princípios do SOLID, enquanto na pasta "correct", estão as versões corrigidas que seguem as boas práticas desses princípios.

Princípios do SOLID
Os princípios do SOLID são um conjunto de diretrizes que auxiliam no desenvolvimento de software de alta qualidade, facilitando a manutenção, extensibilidade e testabilidade. Eles foram propostos por Robert C. Martin e se baseiam em cinco conceitos fundamentais:

S - SRP - Single Responsibility Principle: Uma classe deve ter apenas uma razão para mudar, ou seja, deve ter apenas uma responsabilidade. Isso promove a coesão e evita que as classes se tornem grandes e complexas.

O - OCP - Open-Closed Principle - OCP: Uma entidade de software deve ser aberta para extensão, mas fechada para modificação. Isso significa que você pode estender o comportamento de uma classe sem modificar seu código-fonte.

L - LSP - Liskov Substitution Principle: As instâncias de uma classe derivada devem poder ser substituídas pelas instâncias da classe base sem afetar a integridade do sistema. Em outras palavras, uma classe derivada deve ser substituível por sua classe base sem que isso cause problemas.

I - ISP - Interface Segregation Principle: Uma classe não deve ser forçada a depender de interfaces que não utiliza. Em vez disso, é melhor criar interfaces específicas para cada cliente.

D - DIP - Dependency Inversion Principle - DIP: Módulos de alto nível não devem depender de módulos de baixo nível; ambos devem depender de abstrações. Além disso, abstrações não devem depender de detalhes; detalhes devem depender de abstrações.

Projetos
A seguir, estão os projetos presentes neste repositório, cada um enfocando um dos princípios do SOLID:

1. Projeto Solid.SRP (Princípio da Responsabilidade Única)
Este projeto demonstra a importância de manter as classes com apenas uma responsabilidade. A pasta "wrong" conterá um exemplo em que uma classe possui múltiplas responsabilidades, tornando-a difícil de manter e modificar. Já na pasta "correct", a classe foi refatorada para cumprir o SRP.

2. Projeto Solid.OCP (Princípio Aberto-Fechado)
Neste projeto, veremos como o princípio OCP pode ser aplicado. Na pasta "wrong", haverá um exemplo em que uma alteração no comportamento de uma classe requer a modificação do código-fonte. Na pasta "correct", mostraremos como estender a funcionalidade sem modificar o código original.

3. Projeto Solid.LSP (Princípio da Substituição de Liskov)
Aqui, discutiremos a importância de garantir a substituibilidade correta de classes derivadas. O exemplo na pasta "wrong" revelará um cenário em que a substituição de uma classe derivada causa problemas inesperados. Já na pasta "correct", ajustaremos a implementação para seguir o LSP corretamente.

4. Projeto Solid.ISP (Princípio da Segregação de Interfaces)
O projeto Solid.ISP destacará como é essencial criar interfaces específicas para cada cliente. Na pasta "wrong", encontraremos uma interface com muitos métodos desnecessários para algumas classes que a implementam. Na pasta "correct", reorganizaremos as interfaces para que cada classe tenha sua própria interface com apenas os métodos necessários.

5. Projeto Solid.DIP (Princípio da Inversão de Dependência)
Por fim, o projeto Solid.DIP mostrará como reduzir o acoplamento entre classes e melhorar a flexibilidade e testabilidade. Na pasta "wrong", identificaremos um exemplo em que as classes de alto nível dependem das classes de baixo nível. Na pasta "correct", aplicaremos a inversão de dependência para tornar as classes mais independentes.

Referencias

https://medium.com/desenvolvendo-com-paixao/o-que-%C3%A9-solid-o-guia-completo-para-voc%C3%AA-entender-os-5-princ%C3%ADpios-da-poo-2b937b3fc530

http://butunclebob.com/ArticleS.UncleBob.PrinciplesOfOod



Happy coding! 🚀