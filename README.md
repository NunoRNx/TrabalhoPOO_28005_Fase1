TrabalhoPOO_28005_Fase1
Descrição do Projeto
Este projeto foi desenvolvido como parte do trabalho da disciplina de Programação Orientada a Objetos (POO). Ele consiste em um RPG estruturado com base nos conceitos fundamentais de POO, incluindo herança, encapsulamento, polimorfismo e abstração.

O objetivo principal é fornecer uma implementação modular e extensível para um sistema de combate, classes de personagens e outras funcionalidades comuns em jogos de RPG.

Funcionalidades
Criação de classes de personagens:
Warrior, Paladin, Swordsman, Assassin, Archer, Mage.
Gerenciamento de recursos específicos para cada classe, como:
Rage, Holy, Focus, Stealth, Arrows, e Mana.
Sistema de combate utilizando habilidades personalizadas para cada classe.
Gerenciamento de equipes através da classe BattleTeams.
Sistema de autenticação simples com a classe User.
Estrutura do Projeto
A estrutura do projeto é organizada da seguinte forma:

scss
Copy code
TrabalhoPOO_28005_Fase1/
│
├── RPG/
│   ├── Classes/
│   │   ├── Character.cs
│   │   ├── Warrior.cs
│   │   ├── Paladin.cs
│   │   └── ... (outras classes específicas)
│   │
│   ├── Teams/
│   │   └── BattleTeams.cs
│   │
│   ├── Users/
│   │   └── User.cs
│   │
│   └── Program.cs
│
├── db_backup/
│   └── ... (arquivos relacionados a backups de dados)
│
├── .gitignore
├── README.md
└── TrabalhoPOO.sln
Tecnologias Utilizadas
Linguagem: C# (.NET Framework)
IDE: Visual Studio
Controle de versão: Git e GitHub
Como Executar o Projeto
Clone o repositório:
bash
Copy code
git clone https://github.com/NunoRNx/TrabalhoPOO_28005_Fase1.git
Abra o projeto na IDE (Visual Studio).
Compile o projeto utilizando o botão Start.
Teste as funcionalidades através do método Main() definido no arquivo Program.cs.
Observações
Importante: Certifique-se de não incluir pastas de build, como bin/ e obj/, nem arquivos compilados (.exe) ao compartilhar ou entregar o projeto.
As pastas e arquivos ignorados já estão configurados no arquivo .gitignore.
Contribuição
Sinta-se à vontade para contribuir para o projeto! Caso encontre algum problema ou tenha uma sugestão, abra uma Issue ou envie um Pull Request.

Autor
Nome: NunoRNx
Disciplina: Programação Orientada a Objetos (POO)
