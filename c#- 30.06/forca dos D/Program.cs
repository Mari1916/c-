//Pega a palavra que vai ser a forca
Console.Write("Digite uma palavra: ");
string palavraSecreta = Console.ReadLine();

// Limpa a linha anterior pro jogador não saber a palavra secreta
int linhaAtual = Console.CursorTop - 1;
Console.SetCursorPosition(0, linhaAtual);
Console.Write(new string(' ', Console.WindowWidth));
Console.SetCursorPosition(0, linhaAtual);

//Pega uma dica
Console.WriteLine("Digite uma dica");
string dica = Console.ReadLine();

//Cria dis "listas" uma com a palavra toda e uma com os caracteres para serem prenchidos
char[] progresso = new string('_', palavraSecreta.Length).ToCharArray(); //'\0', '\0', '\0', '\0', '\0', '\0'

//Cria uma nova "lista" a cada letra descoberta
List<char> letrasTentadas = new List<char>();

int tentativasRestantes = 6;
bool venceu = false;

Console.WriteLine("Bem-vindo ao Jogo Forca dos D!!");
Console.WriteLine($"Sua dica é: {dica}");

while (tentativasRestantes > 0 && !venceu)
{
    Console.WriteLine($"Palavra: {new string(progresso)}");
    Console.WriteLine($"Tentativas restantes: {tentativasRestantes}");
    Console.Write("Digite uma letra: ");

    //Dá um padrão pras letras, seja maiúscula ou minúscula ele reconhece
    char letra = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();

    //Ve se vc ja digitou a letra
    if (letrasTentadas.Contains(letra))
    {
        Console.WriteLine("Você já tentou essa letra!");
        continue;
    }

    //Adicona a letra q vc digitar a lista de letras tentadas
    letrasTentadas.Add(letra);

    //Se tiver a letra na palavra, adiciona a letra a "listinha"
    if (palavraSecreta.Contains(letra))
    {
        for (int i = 0; i < palavraSecreta.Length; i++)
        {
            if (palavraSecreta[i] == letra)
                progresso[i] = letra;
        }
    }

    //Se não tiver a letra tira um tentativa restante
    else
    {
        tentativasRestantes--;
        Console.WriteLine("Letra incorreta!");
    }

    //Se não tiver mais o -, ou seja 100% de progresso o amiguinho venceu!!
    if (!new string(progresso).Contains('_'))
        venceu = true;
}

//Resultados :)
if (venceu)
    Console.WriteLine($"Parabéns! Você acertou:) : {palavraSecreta}");
else
    Console.WriteLine($"Fim de jogo!:( A palavra era: {palavraSecreta}");