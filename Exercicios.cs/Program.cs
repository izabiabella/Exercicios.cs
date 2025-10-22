// Aula 4 - Exercícios de Fixação
using System;
using System.Collections.Generic;
using System.Linq;
/*
//Exercício 1:
Dictionary<string, List<int>> aluno = new Dictionary<string, List<int>>();
aluno.Add("Beatriz", new List<int> { 10, 8, 9 });
double soma = 0;
int i = 0;

foreach (var nota in aluno.Last().Value)
{
    soma += nota;
    i++;
}

double media = soma / i;
Console.WriteLine($"A média do aluno é: {media}");

// Ex 1: Versão usando Sum e Count:
Dictionary<string, List<int>> aluno = new Dictionary<string, List<int>>();
aluno.Add("Beatriz", new List<int> { 10, 8, 9 });

// Para utlilizar o nome 
var alunoData = aluno.Last();
string nomeAluno = alunoData.Key;

// Calcular média usando System.Linq
double media = (double)alunoData.Value.Sum() / alunoData.Value.Count();

Console.WriteLine($"A média de {nomeAluno} é: {media}");
*/



/*
// Exercício 2:
Dictionary<string, int> estoque = new Dictionary<string, int>();


void menu()
{
    Console.WriteLine("\n>>>ESTOQUE<<<");
    Console.WriteLine("Digite 1 para adicionar um produto");
    Console.WriteLine("Digite 2 para adicionar quantidade do estoque");
    Console.WriteLine("Digite 3 para reduzir quantidade do estoque");
    Console.WriteLine("Digite 4 visualizar o estoque");
    Console.Write("Digite um número para seguir com uma ação: ");
    int acaoEscolhida = int.Parse(Console.ReadLine()!);


    switch (acaoEscolhida)
    {
        case 1:
            NovaChave();
            break;

        case 2:
            AdicionarQuantidade();
            break;

        case 3:
            ReduzirQuantidade();
            break;

        case 4:
            VisualizarEstoque();
            break;
    }

};


void NovaChave()
{
    Console.Write("\nDigite o nome do produto que deseja adicionar: ");
    string nomeProduto = Console.ReadLine()!;
    estoque.Add(nomeProduto, 0);
    Console.WriteLine($"Produto {nomeProduto} adicionado com sucesso!\n");
    menu();
}

void AdicionarQuantidade()
{
    Console.Write("\nDigite o nome do produto que houve recebimento: ");
    string produtoAdicionar = Console.ReadLine()!;

    // Nota: Não usar laço for para procurar por uma chave! - Aumenta MUITO o custo de processamento
     if (estoque.ContainsKey(produtoAdicionar))
     {

        int valor = estoque[produtoAdicionar];
        Console.WriteLine($"\nAtualmente {produtoAdicionar} possui {valor} itens em estoque");
        Console.Write("Quanto deseja adicionar ao estoque? ");
        int valorAdicionado = int.Parse(Console.ReadLine()!);
        int valorTotal = valor + valorAdicionado;
        estoque[produtoAdicionar] = valorTotal;
        Console.WriteLine($"\nO produto {produtoAdicionar} agora possui {valorTotal} itens no estoque.\n");
           

      }

       else
       {
           Console.WriteLine("Esse produto ainda não existe no estoque");
       }

    menu();
}


void ReduzirQuantidade()
{
    Console.Write("\nDigite o nome do produto que foi vendido: ");
    string produtoReduzir = Console.ReadLine()!;


    if (estoque.ContainsKey(produtoReduzir))
    {

        int valor = estoque[produtoReduzir];
        Console.WriteLine($"\nAtualmente {produtoReduzir} possui {valor} itens em estoque");
        Console.Write("Quanto deseja reduzir do estoque? ");
        int valorReduzido = int.Parse(Console.ReadLine()!);
        int valorTotal = valor - valorReduzido;
        estoque[produtoReduzir] = valorTotal;
        Console.WriteLine($"\nO produto {produtoReduzir} agora possui {valorTotal} itens no estoque.\n");


    }

    else
    {
        Console.WriteLine("Esse produto ainda não existe no estoque");
    }

    menu();
}

void VisualizarEstoque()
{
    Console.Clear();
    Console.WriteLine("\nEstoque atual:\n");
    foreach (var item in estoque)
    {
        Console.WriteLine($"Produto: {item.Key}, Quantidade: {item.Value}");
    }

    Console.WriteLine("Digite qualquer tecla para voltar ao menu!");
    Console.ReadKey();
    menu();
}

menu();



// Exercício 3 - Quiz de perguntas e respostas

Dictionary<string, string> AeQ = new Dictionary<string, string>();

AeQ.Add("Qual é a maior montanha do mundo?", "Everest");
AeQ.Add("Qanto que é a raiz de 144?", "12");
AeQ.Add("Qual o ponto mais baixo da Terra?", "Mar morto");
AeQ.Add("Qual é a fórmula da Força?", "F = M.a");
AeQ.Add("Qual é o quadrado de 14?", "196");


int pontos = 0;
foreach (var pergunta in AeQ)
{
    Console.WriteLine(pergunta.Key);
    Console.Write("Digite sua resposta: ");
    string respostaUsuario = Console.ReadLine()!;

    if (respostaUsuario.Equals(pergunta.Value, StringComparison.OrdinalIgnoreCase)) // Ignorar maiúsculas/minúsculas, mas é sensível a espaços 
    {
        Console.WriteLine("Resposta correta!\n");
        pontos++;
    }
    else
    {
        Console.WriteLine($"Resposta incorreta! A resposta certa é: {pergunta.Value}\n");
    }
}

Console.WriteLine($"Quiz finalizado! Sua pontuação foi de: {pontos}/5");
*/

// Exercício 4 - Login

Dictionary<string, string> infoLogin  = new Dictionary<string, string>();


void TentativaLogin()
{
    Console.WriteLine(">>> ACESSANDO <<<");
    Console.Write("Nome de Usuário: ");
    string compUsuario = Console.ReadLine()!;

    if (infoLogin.ContainsKey(compUsuario))
    {
        Console.Write("Digite sua senha: ");
        string compSenha = Console.ReadLine()!;

        if (compSenha == infoLogin[compUsuario])
        {
            if (compSenha == "laele")
            {
                Console.WriteLine("Senha válida! Só vc tem a senha do meu coração!<3");
            }
            else
            {
                Console.WriteLine("Senha válida! Seja bem vindo!");
            }
            
        }

        else
        {
            Console.WriteLine("Senha inválida!");
            TentativaLogin();
        }
    }

    else
    {
        Console.WriteLine("Usuário inexistente!");
    }
}
void FazendoLogin()
{
    Console.Write("Digite seu nome de usuário: ");
    string usuario = Console.ReadLine()!;

    Console.Write("Digite sua senha: ");
    string senha = Console.ReadLine()!;
    infoLogin.Add(usuario, senha);

    TentativaLogin();

}



FazendoLogin();
