using System;
using System.Data;
using MySql.Data.MySqlClient;


public class Aluno
{
    private string Nome;
    private string Rgm;
    private string DataNascimento;
    private string Curso;
    private int Bolsista;
    private string Rg;
    private string Genero;

    public Aluno(string _nome, string _rgm, string _dataNascimento, string _curso, int _bolsista, string _rg, string _genero)
    {
        Nome = _nome;
        Rgm = _rgm;
        DataNascimento = _dataNascimento;
        Curso = _curso;
        Bolsista = _bolsista;
        Rg = _rg;
        Genero = _genero;
    }

    public Aluno()
    {
        Nome = "";
        Rgm = "";
        DataNascimento = "";
        Curso = "";
        Bolsista = 0;
        Rg = "";
        Genero = "";
    }

    public string GetNome()
    {
        return Nome;
    }

    public void SetNome(string valor)
    {
        Nome = valor;
    }

    public string GetRgm()
    {
        return Rgm;
    }

    public void SetRgm(string valor)
    {
        Rgm = valor;
    }

    public string GetDataNascimento()
    {
        return DataNascimento;
    }

    public void SetDataNascimento(string valor)
    {
        DataNascimento = valor;
    }

    public string GetCurso()
    {
        return Curso;
    }

    public void SetCurso(string valor)
    {
        Curso = valor;
    }

    public int GetBolsista()
    {
        return Bolsista;
    }

    public void SetBolsista(int valor)
    {
        Bolsista = valor;
    }

    public string GetRg()
    {
        return Rg;
    }

    public void SetRg(string valor)
    {
        Rg = valor;
    }

    public string GetGenero()
    {
        return Genero;
    }

    public void SetGenero(string valor)
    {
        Genero = valor;
    }
}

public class Livro
{
    private string isbn;
    private string titulo;
    private string autor;
    private int ano;
    private string genero;
    private int edicao;
    private int quantidade;

    public Livro(string _titulo, string _autor, int _ano, string _genero, int _edicao, int _quantidade, string _isbn)
    {
        isbn = _isbn;
        titulo = _titulo;
        autor = _autor;
        ano = _ano;
        genero = _genero;
        edicao = _edicao;
        quantidade = _quantidade;
    }

    public Livro()
    {
        titulo = "";
        autor = "";
        ano = 0;
        genero = "";
        edicao = 0;
        quantidade = 0;
        isbn = "";
    }

    public string GetISBN()
    {
        return isbn;
    }

    public void SetISBN(string valor)
    {
        isbn = valor;
    }

    public string GetTitulo()
    {
        return titulo;
    }

    public void SetTitulo(string valor)
    {
        titulo = valor;
    }

    public string GetAutor()
    {
        return autor;
    }

    public void SetAutor(string valor)
    {
        autor = valor;
    }

    public int GetAno()
    {
        return ano;
    }

    public void SetAno(int valor)
    {
        ano = valor;
    }

    public string GetGenero()
    {
        return genero;
    }

    public void SetGenero(string valor)
    {
        genero = valor;
    }

    public int GetEdicao()
    {
        return edicao;
    }

    public void SetEdicao(int valor)
    {
        edicao = valor;
    }

    public int GetQuantidade()
    {
        return quantidade;
    }

    public void SetQuantidade(int valor)
    {
        quantidade = valor;
    }
}