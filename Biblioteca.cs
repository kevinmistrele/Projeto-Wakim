using System;
using System.Data;
using MySql.Data.MySqlClient;

public class Biblioteca
{
  public Biblioteca(){}

  public void ShowMenu(String key)
  {
    switch(key)
    {
    case "1":
      {
        Livro l = new Livro();
                Console.WriteLine("+------------------------- LIVRO  --------------+    ");
                Console.WriteLine("¦                                               ¦    ");
                Console.WriteLine("        Forneca os dados do Livro:              ¦    ");
                Console.WriteLine("¦                                               ¦    ");
                Console.WriteLine("+-----------------------------------------------+    ");


        Console.WriteLine("ISBN: ");		
        l.SetISBN(Console.ReadLine().ToString());

        Console.WriteLine("Titulo: ");
        l.SetTitulo(Console.ReadLine().ToString());

        Console.WriteLine("Autor: ");		
        l.SetAutor(Console.ReadLine().ToString());

        Console.WriteLine("Ano: ");		
        l.SetAno(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Genero: ");		
        l.SetGenero(Console.ReadLine().ToString());

        Console.WriteLine("Edicao: ");		
        l.SetEdicao(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Quantidade: ");		
        l.SetQuantidade(Convert.ToInt32(Console.ReadLine()));

                string sql = $"INSERT INTO LIVRO (ISBN, Titulo, Autor, Ano, Genero, Edicao, Quantidade) VALUES ('{l.GetISBN()}', '{l.GetTitulo()}', '{l.GetAutor()}', {l.GetAno()}, '{l.GetGenero()}', {l.GetEdicao()}, {l.GetQuantidade()});";

                executeScript(sql);			

                break;
        
      }
    case "2":{
      Livro l = new Livro();
      Console.WriteLine("+------------------------- LIVRO  --------------+    ");
      Console.WriteLine("¦                                               ¦    ");
      Console.WriteLine("    Forneca os dados atualizados do Livro:      ¦    ");
      Console.WriteLine("¦                                               ¦    ");
      Console.WriteLine("+-----------------------------------------------+    ");


      Console.WriteLine("ISBN: ");
      l.SetISBN(Console.ReadLine().ToString());

      Console.WriteLine("Titulo: ");
      l.SetTitulo(Console.ReadLine().ToString());

      Console.WriteLine("Autor: ");
      l.SetAutor(Console.ReadLine().ToString());

      Console.WriteLine("Ano: ");
      l.SetAno(Convert.ToInt32(Console.ReadLine()));

      Console.WriteLine("Genero: ");
      l.SetGenero(Console.ReadLine().ToString());

      Console.WriteLine("Edicao: ");
      l.SetEdicao(Convert.ToInt32(Console.ReadLine()));

      Console.WriteLine("Quantidade: ");
      l.SetQuantidade(Convert.ToInt32(Console.ReadLine()));

      string sql = $"UPDATE LIVRO SET titulo = '{l.GetTitulo()}', autor = '{l.GetAutor()}', ano = {l.GetAno()}, genero = '{l.GetGenero()}', edicao = {l.GetEdicao()}, quantidade = {l.GetQuantidade()} WHERE isbn =  '{l.GetISBN()}' ";

      executeScript(sql);

      break;
    }
    case "3": {
      Livro l = new Livro();
      Console.WriteLine("+------------------------- LIVRO  --------------+    ");
      Console.WriteLine("¦                                               ¦    ");
      Console.WriteLine("¦    Forneca o titulo do Livro para remover:    ¦    ");
      Console.WriteLine("¦                                               ¦    ");
      Console.WriteLine("+-----------------------------------------------+    ");

      Console.WriteLine("Titulo: ");
      l.SetTitulo(Console.ReadLine().ToString());

      string sql = $"DELETE FROM LIVRO WHERE Titulo = '{l.GetTitulo()}'";

      executeScript(sql);

      break;
    }
    case "4": {
      Livro l = new Livro();
        Console.WriteLine("+------------------------- LIVRO  --------------+    ");
        Console.WriteLine("¦                                               ¦    ");
        Console.WriteLine("¦   Forneca o titulo do Livro para consultar:   ¦    ");
        Console.WriteLine("¦                                               ¦    ");
        Console.WriteLine("+-----------------------------------------------+    ");

        Console.WriteLine("Titulo: ");
        l.SetTitulo(Console.ReadLine().ToString());

        string sql = $"SELECT * FROM LIVRO WHERE Titulo = '{l.GetTitulo()}'";

      using MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_kevin;uid=freedb_kevinmistrele;pwd=$QSNfS53YNrEUtw");
      con.Open();

      using MySqlCommand cmd = new MySqlCommand(sql, con);

      using MySqlDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read()){
         // Console.WriteLine("Id: " + dataReader["Id"].ToString());
          Console.WriteLine("ISBN: " + dataReader["ISBN"].ToString());
          Console.WriteLine("Titulo: " + dataReader["Titulo"].ToString());
          Console.WriteLine("Autor: " + dataReader["Autor"].ToString());
          Console.WriteLine("Ano: " + dataReader["Ano"].ToString());
          Console.WriteLine("Genero: " + dataReader["Genero"].ToString());
          Console.WriteLine("Edicao: " + dataReader["Edicao"].ToString());
          Console.WriteLine("Quantidade: " + dataReader["Quantidade"].ToString());
        }

        executeScript(sql);

        break;
    }
     }
   }
  public static void executeScript(string sql)
  {
        MySqlConnection con;
        con = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_kevin;uid=freedb_kevinmistrele;pwd=$QSNfS53YNrEUtw");
        try
        {
            con.Open();
            Console.WriteLine($"MySQL version : {con.ServerVersion}");
        }
        catch (System.Exception e)
        {
            //Console.WriteLine (e.Message.ToString());
            //MessageBox.Show(e.Message.ToString());
        }
        //verifica se a conexão esta aberta
        if (con.State == ConnectionState.Open)
        {
            Console.WriteLine("connection Open!");
            using var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }
 }