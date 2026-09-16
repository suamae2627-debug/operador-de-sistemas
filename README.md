# Operador de Sistemas — Cadastro

Trabalho desenvolvido na escola para praticar a criação de interfaces gráficas em **C# com Windows Forms**.

O projeto apresenta uma tela de cadastro de dados pessoais, com imagens de Ichigo e Rukia, de *Bleach*, nos recursos visuais. Os arquivos estão disponíveis diretamente na pasta [projeto fodastico](./projeto%20fodastico/), sem precisar abrir um ZIP para consultar o código no GitHub.

## O que tem no projeto

- Campos para nome, sobrenome, idade, bairro, celular e e-mail.
- Botões de confirmação de dados individuais e completos.
- Opções de temas e controles de ativar, desativar e limpar na interface.
- Imagens, ícone e arquivos do formulário do Windows Forms.

**Estado atual:** a interface está montada, mas os eventos presentes em `Form1.cs` ainda estão vazios. A lógica dos botões, a troca de temas, a validação e o armazenamento dos dados ainda precisam ser implementados.

## Tecnologias

- C#
- Windows Forms
- .NET Framework 4.7.2
- Solução do Visual Studio 2022

## Como abrir e executar

1. Em um computador com Windows, instale o **Visual Studio 2022** com a carga de trabalho **Desenvolvimento para desktop com .NET** e o **Developer Pack do .NET Framework 4.7.2**.
2. Baixe ou clone este repositório.
3. Abra a solução [cadastro.sln](./projeto%20fodastico/cadastro/cadastro.sln) no Visual Studio.
4. Compile a solução e pressione **F5** para iniciar o aplicativo.

Para editar a tela visualmente, abra `Form1.cs` no Designer do Windows Forms.

## Organização dos arquivos

```text
operador-de-sistemas/
├── README.md
├── .gitignore
└── projeto fodastico/
    └── cadastro/
        ├── cadastro.sln
        └── cadastro/
            ├── cadastro.csproj
            ├── Program.cs
            ├── Form1.cs
            ├── Form1.Designer.cs
            ├── Form1.resx
            ├── App.config
            ├── Binassmax-Pry-Frente-Black-Special-2-Star-2.ico
            ├── Properties/
            └── Resources/
```

As pastas `.vs`, `bin` e `obj` são geradas pelo Visual Studio e ficam fora do repositório. Os arquivos de código, configuração e imagens necessários ao projeto estão incluídos.

## Registro do trabalho

<img width="900" alt="Registro do trabalho desenvolvido na escola" src="https://github.com/user-attachments/assets/f1f6257c-ee9d-4308-8eec-015be301dc1a" />
