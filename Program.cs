using System;

class MainClass {
  static void Main(string[] args) {
    char[] alfabeto = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    int chave, i, posicao, novaPosicao;
    char espaco, letra;
    string mensagem, cripto, opcao;
    chave = 3;
    cripto = "";

    Console.WriteLine("Informe 'C' para criptografar, ou 'D' para descriptografar a mensagem: ");
    opcao = Console.ReadLine();

    if (opcao == "C")
    {
        Console.WriteLine("Informe a mensagem a ser criptografada e tecle ENTER:");
        mensagem = Console.ReadLine();

        // encriptar a mensagem
        for (i = 0; i < mensagem.Length; i++)
        {
            espaco = '\u0020';
            if (mensagem[i] != espaco) 
            {
                letra = mensagem[i];
                posicao = Array.IndexOf(alfabeto, letra);
                novaPosicao = (posicao + chave) % 26;
                cripto = cripto + alfabeto[novaPosicao];
            }
            else 
            {
                cripto = cripto + espaco;
            }
        }
    }
    else if(opcao == "D")
    {
        Console.WriteLine("Informe a mensagem a ser criptografada e tecle ENTER:");
        mensagem = Console.ReadLine();

        // descriptografar a mensagem
        for (i = 0; i < mensagem.Length; i++)
        {
            espaco = '\u0020';
            if (mensagem[i] != espaco) 
            {
                letra = mensagem[i];
                posicao = Array.IndexOf(alfabeto, letra);
                novaPosicao = (posicao - chave) % 26;
                cripto = cripto + alfabeto[novaPosicao];
            }
            else 
            {
                cripto = cripto + espaco;
            }
        }
    }
    
    Console.WriteLine(cripto);
  }
}