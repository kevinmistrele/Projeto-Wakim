using System;
using System.Data;
using MySql.Data.MySqlClient;

public class Secretaria
{
  public Secretaria(){}

  public void ShowMenu(String key)
  {
    switch(key)
    {
    case "1":
      {
        Aluno a = new Aluno();
        Console.WriteLine("+------------------------- ALUNO  --------------+");
        Console.WriteLine("¦                                               ¦");
        Console.WriteLine("¦        Forneca os dados do Aluno:             ¦");
        Console.WriteLine("¦                                               ¦");
        Console.WriteLine("+-----------------------------------------------+");
        Console.WriteLine("¦          GGGGG   GGGGG   K    K   PPPP        ¦");
        Console.WriteLine("¦         G    G  G    G  K  K     P   P        ¦");
        Console.WriteLine("¦         G       G       KK       P   P        ¦");
        Console.WriteLine("¦         G   GGG G   GGG K  K     PPPP         ¦");
        Console.WriteLine("¦         G    G  G    G  K   K    P            ¦");
        Console.WriteLine("¦          GGGGG   GGGGG   K    K   P           ¦");
        Console.WriteLine("+-----------------------------------------------+");


        Console.WriteLine("Nome: ");		
        a.SetNome(Console.ReadLine().ToString());

        Console.WriteLine("Rgm: ");
        a.SetRgm(Console.ReadLine().ToString());

        Console.WriteLine("DataNascimento: ");		
        a.SetDataNascimento(Console.ReadLine().ToString());

        Console.WriteLine("Curso: ");		
        a.SetCurso(Console.ReadLine().ToString());

        Console.WriteLine("Bolsista: ");		
        a.SetBolsista(Convert.ToInt32(Console.ReadLine()));

        Console.WriteLine("Rg: ");		
        a.SetRg(Console.ReadLine().ToString());

        Console.WriteLine("Genero: ");		
        a.SetGenero(Console.ReadLine().ToString());

                string sql = $"INSERT INTO ALUNO (Nome, Rgm, DataNascimento, Curso, Bolsista, Rg, Genero) VALUES ('{a.GetNome()}', '{a.GetRgm()}', '{a.GetDataNascimento()}', '{a.GetCurso()}', {a.GetBolsista()}, '{a.GetRg()}', '{a.GetGenero()}');";

                executeScript(sql);

        break;

        
      }
    case "2":{
      Aluno a = new Aluno();
      Console.WriteLine("+------------------------- ALUNO  --------------+");
      Console.WriteLine("¦                                               ¦");
      Console.WriteLine("¦     Forneca os dados atualizados do Aluno:    ¦");
      Console.WriteLine("¦                                               ¦");
      Console.WriteLine("+-----------------------------------------------+");
      Console.WriteLine("¦          GGGGG   GGGGG   K    K   PPPP        ¦");
      Console.WriteLine("¦         G    G  G    G  K  K     P   P        ¦");
      Console.WriteLine("¦         G       G       KK       P   P        ¦");
      Console.WriteLine("¦         G   GGG G   GGG K  K     PPPP         ¦");
      Console.WriteLine("¦         G    G  G    G  K   K    P            ¦");
      Console.WriteLine("¦          GGGGG   GGGGG   K    K   P           ¦");
      Console.WriteLine("+-----------------------------------------------+");


      Console.WriteLine("Nome: ");		
      a.SetNome(Console.ReadLine().ToString());

      Console.WriteLine("Rgm: ");
      a.SetRgm(Console.ReadLine().ToString());

      Console.WriteLine("DataNascimento: ");		
      a.SetDataNascimento(Console.ReadLine().ToString());

      Console.WriteLine("Curso: ");		
      a.SetCurso(Console.ReadLine().ToString());

      Console.WriteLine("Bolsista: ");		
      a.SetBolsista(Convert.ToInt32(Console.ReadLine()));

      Console.WriteLine("Rg: ");		
      a.SetRg(Console.ReadLine().ToString());

      Console.WriteLine("Genero: ");		
      a.SetGenero(Console.ReadLine().ToString());

      string sql = $"UPDATE ALUNO SET Rgm = '{a.GetRgm()}', DataNascimento = '{a.GetDataNascimento()}', Curso = '{a.GetCurso()}', Bolsista = {a.GetBolsista()}, Rg = '{a.GetRg()}', Genero = '{a.GetGenero()}' WHERE Nome =  '{a.GetNome()}' ";

              executeScript(sql);

      break;
    }
    case "3":{
      Aluno a = new Aluno();
        Console.WriteLine("+------------------------- ALUNO  --------------+");
        Console.WriteLine("¦                                               ¦");
        Console.WriteLine("¦    Forneca o nome do Aluno para remover:      ¦");
        Console.WriteLine("¦                                               ¦");
        Console.WriteLine("+-----------------------------------------------+");
        Console.WriteLine("¦          GGGGG   GGGGG   K    K   PPPP        ¦");
        Console.WriteLine("¦         G    G  G    G  K  K     P   P        ¦");
        Console.WriteLine("¦         G       G       KK       P   P        ¦");
        Console.WriteLine("¦         G   GGG G   GGG K  K     PPPP         ¦");
        Console.WriteLine("¦         G    G  G    G  K   K    P            ¦");
        Console.WriteLine("¦          GGGGG   GGGGG   K    K   P           ¦");
        Console.WriteLine("+-----------------------------------------------+");

      Console.WriteLine("Nome: ");
      a.SetNome(Console.ReadLine().ToString());

      string sql = $"DELETE FROM ALUNO WHERE Nome = '{a.GetNome()}'";

      executeScript(sql);

      break;
    }
    case "4":{
      Aluno a = new Aluno();
        Console.WriteLine("+------------------------- ALUNO  --------------+");
        Console.WriteLine("¦                                               ¦");
        Console.WriteLine("¦   Forneca o nome do Aluno para consultar:     ¦");
        Console.WriteLine("¦                                               ¦");
        Console.WriteLine("+-----------------------------------------------+");
        Console.WriteLine("¦          GGGGG   GGGGG   K    K   PPPP        ¦");
        Console.WriteLine("¦         G    G  G    G  K  K     P   P        ¦");
        Console.WriteLine("¦         G       G       KK       P   P        ¦");
        Console.WriteLine("¦         G   GGG G   GGG K  K     PPPP         ¦");
        Console.WriteLine("¦         G    G  G    G  K   K    P            ¦");
        Console.WriteLine("¦          GGGGG   GGGGG   K    K   P           ¦");
        Console.WriteLine("+-----------------------------------------------+");

        Console.WriteLine("Nome: ");
        a.SetNome(Console.ReadLine().ToString());

        string sql = $"SELECT * FROM ALUNO WHERE Nome = '{a.GetNome()}'";

      using MySqlConnection con = new MySqlConnection("Persist Security Info=False;server=sql.freedb.tech;database=freedb_umc_dp_kevin;uid=freedb_kevinmistrele;pwd=$QSNfS53YNrEUtw");
      con.Open();

      using MySqlCommand cmd = new MySqlCommand(sql, con);

      using MySqlDataReader dataReader = cmd.ExecuteReader();

        while (dataReader.Read()){
          Console.WriteLine("Nome: " + dataReader["Nome"].ToString());
          Console.WriteLine("Rgm: " + dataReader["Rgm"].ToString());
          Console.WriteLine("Data de Nascimento (Ano-Mes-Dia): " + dataReader["DataNascimento"].ToString());
          Console.WriteLine("Curso: " + dataReader["Curso"].ToString());
          Console.WriteLine("Bolsista: " + dataReader["Bolsista"].ToString());
          Console.WriteLine("Rg: " + dataReader["Rg"].ToString());
          Console.WriteLine("Genero: " + dataReader["Genero"].ToString());
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