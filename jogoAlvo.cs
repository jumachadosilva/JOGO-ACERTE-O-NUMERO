using System.Numerics;

Random random = new Random();

int alvo = 0;
int valorLimite = 100;
int palpite = 0;
int valorSorteado = 0;
int nBolas = 20;
string bolas = "* * * * * * * * * * * * * * * * * * * *";
bool venceu = false;

Console.WriteLine("Acerte o valor aleatorio");

while (valorSorteado <= valorLimite && !venceu)
{
    Console.WriteLine(bolas);
    valorSorteado += random.Next(1, 21);

    palpite = Convert.ToInt32(Console.ReadLine());
    if (valorSorteado == palpite)
    {
        Console.WriteLine("Você Ganhou!");
        venceu = true;
    }
    else
    {
        Console.WriteLine("Voce Errou, o valor era = " +  valorSorteado + "\n palpite - " + palpite);
    }
}
if (!venceu)
{
    Console.WriteLine("O valor Alvo atiginiu o Limite de 100! Voce perdeu!");
}