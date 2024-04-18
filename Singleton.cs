using System;

public sealed class Singleton
{
    private Singleton() { }
    private static Singleton _instance;
    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        } 
        return _instance;
    }

    public string showMenu(string key)
    {
      String opcao = "";
      
      switch(key)
      {
      case "MENU_PRINCIPAL":
        {
          Console.WriteLine("Executando uma operacao no singleton.");

          Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
          Console.WriteLine("║ 1 SECRETARIA                                  ║    ");
          Console.WriteLine("║ 2 BIBLIOTECA                                  ║    ");
          Console.WriteLine("║═══════════════════════════════════════════════║    ");
          Console.WriteLine("║ 0 SAIR                                        ║    ");
          Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
          Console.WriteLine(" ");
          Console.Write("DIGITE UMA OPÇÃO : ");

          opcao = Console.ReadLine();

          break;

        
      }
      case "MENU_SECRETARIA":{
        Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
        Console.WriteLine("║ 1 INCLUIR - ALUNO                             ║    ");
        Console.WriteLine("║ 2 ATUALIZAR - ALUNO                           ║    ");
        Console.WriteLine("║ 3 REMOVER - ALUNO                             ║    ");
        Console.WriteLine("║ 4 CONSULTAR - ALUNO                           ║    ");
        Console.WriteLine("║═══════════════════════════════════════════════║    ");
        Console.WriteLine("║ 0 SAIR                                        ║    ");
        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
          
        Console.WriteLine(" ");
        Console.Write("DIGITE UMA OPÇÃO : ");

        opcao = Console.ReadLine();
        
        break;
      }
      case "MENU_BIBLIOTECA":{
        Console.WriteLine("╔════════════════ MENU DE OPÇÕES ═══════════════╗    ");
        Console.WriteLine("║ 1 INCLUIR - LIVRO                             ║    ");
        Console.WriteLine("║ 2 ATUALIZAR - LIVRO                           ║    ");
        Console.WriteLine("║ 3 REMOVER - LIVRO                             ║    ");
        Console.WriteLine("║ 4 CONSULTAR - LIVRO                           ║    ");
        Console.WriteLine("║═══════════════════════════════════════════════║    ");
        Console.WriteLine("║ 0 SAIR                                        ║    ");
        Console.WriteLine("╚═══════════════════════════════════════════════╝    ");
        Console.WriteLine(" ");
        Console.Write("DIGITE UMA OPÇÃO : ");

        opcao = Console.ReadLine();
        
        break;
      }

        
      }
      return opcao;
  
    }
}