using System;
using System.Data;
using MySql.Data.MySqlClient;

class Program
{
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

        if (con.State == ConnectionState.Open)
        {
            Console.WriteLine("connection Open!");
            using var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }

    public static void executeQuery(string sql)
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

        if (con.State == ConnectionState.Open)
        {
            Console.WriteLine("connection Open!");
            using var cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
    }

    public static void Main(string[] args)
    {
        String opcao = "";
        do
        {

            opcao = Singleton.GetInstance().showMenu("MENU_PRINCIPAL");

            if (opcao == "0")
                break;

            Console.Clear();

            switch (opcao)
            {
                case "1":
                    {
                        Secretaria s = new Secretaria();
                        opcao = Singleton.GetInstance().showMenu("MENU_SECRETARIA");
                        s.ShowMenu(opcao);
                        break;

                    
                    }
                case "2":
                    {
                        Biblioteca b = new Biblioteca();
                        opcao = Singleton.GetInstance().showMenu("MENU_BIBLIOTECA");
                        b.ShowMenu(opcao);
                        break;


                    }
                case "5":
                    {
                        Livro l = new Livro();
                        Console.WriteLine("+------------------------- LIVRO  --------------+");
                        Console.WriteLine("¦                                               ¦");
                        Console.WriteLine("¦        Forneca os dados do Livro:              ¦");
                        Console.WriteLine("¦                                               ¦");
                        Console.WriteLine("+-----------------------------------------------+");
                        Console.WriteLine("¦          GGGGG   GGGGG   K    K   PPPP        ¦");
                        Console.WriteLine("¦         G    G  G    G  K  K     P   P        ¦");
                        Console.WriteLine("¦         G       G       KK       P   P        ¦");
                        Console.WriteLine("¦         G   GGG G   GGG K  K     PPPP         ¦");
                        Console.WriteLine("¦         G    G  G    G  K   K    P            ¦");
                        Console.WriteLine("¦          GGGGG   GGGGG   K    K   P           ¦");
                        Console.WriteLine("+-----------------------------------------------+");

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
                case "6":
                    {
                        Livro l = new Livro();
                        Console.WriteLine("+------------------------- LIVRO  --------------+");
                        Console.WriteLine("¦                                               ¦");
                        Console.WriteLine("¦        Forneca os dados  atualizados          ¦");
                        Console.WriteLine("¦                                               ¦");
                        Console.WriteLine("+-----------------------------------------------+");
                        Console.WriteLine("¦          GGGGG   GGGGG   K    K   PPPP        ¦");
                        Console.WriteLine("¦         G    G  G    G  K  K     P   P        ¦");
                        Console.WriteLine("¦         G       G       KK       P   P        ¦");
                        Console.WriteLine("¦         G   GGG G   GGG K  K     PPPP         ¦");
                        Console.WriteLine("¦         G    G  G    G  K   K    P            ¦");
                        Console.WriteLine("¦          GGGGG   GGGGG   K    K   P           ¦");
                        Console.WriteLine("+-----------------------------------------------+");


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
                case "7":
                    {
                        Livro l = new Livro();
                        Console.WriteLine("+------------------------- LIVRO  --------------+");
                        Console.WriteLine("¦                                               ¦");
                        Console.WriteLine("¦    Forneca os dados do Livro para remover:    ¦");
                        Console.WriteLine("¦                                               ¦");
                        Console.WriteLine("+-----------------------------------------------+");
                        Console.WriteLine("¦          GGGGG   GGGGG   K    K   PPPP        ¦");
                        Console.WriteLine("¦         G    G  G    G  K  K     P   P        ¦");
                        Console.WriteLine("¦         G       G       KK       P   P        ¦");
                        Console.WriteLine("¦         G   GGG G   GGG K  K     PPPP         ¦");
                        Console.WriteLine("¦         G    G  G    G  K   K    P            ¦");
                        Console.WriteLine("¦          GGGGG   GGGGG   K    K   P           ¦");
                        Console.WriteLine("+-----------------------------------------------+");

                        Console.WriteLine("Titulo: ");
                        l.SetTitulo(Console.ReadLine().ToString());

                        string sql = $"DELETE FROM LIVRO WHERE Titulo = '{l.GetTitulo()}'";

                        executeScript(sql);

                        break;

                    }
                default:
                    {
                        Console.WriteLine("Digitou uma opção invalida!!");
                        break;
                    }
            }

        } while (opcao != "0");


    }
}