//Atividade 1
/*
mostrartitulo();
mostrarbrevedescricao();
mostrarobjetivo();
Console.WriteLine("Qual é o seu nome?");
String nome = Console.ReadLine();
Console.WriteLine("Muito bem, " + nome + ", sua jornada começa aqui, explore esse mundo e obtenha todos os elementos");



void mostrartitulo()
{
    Console.WriteLine("=========" + "\nElementra" + "\n=========");
}
void mostrarbrevedescricao()
{
    Console.WriteLine("esse mundo tem varios elementos, olha que legal :3");
}
void mostrarobjetivo()
{
    Console.WriteLine("Seu objetivo é obter todos os elementos");
} */

/*
//Atividade 2
mostrardialogo2 ("Luna", "ANDY");
mostrardialogo2 ("Andy", "Oque foi?");
mostrardialogo2 ("Luna", "Oque você tá fazendo aqui!?");
mostrardialogo2 ("Andy", "Eu não avisei que iria te visitar?");

void mostrardialogo2(string personagem, string texto)
{
    Console.WriteLine(personagem + ": " + texto);
}  */

/*
//Atividade 3
mostrarstatus("Raphael", "Guerreiro", 100, 30, 10, 2000);
void mostrarstatus(string nome, string classe, int vida, int energia, int forca, int moedas)
{
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine("Classe: " + classe);
    Console.WriteLine("Vida: " + vida);
    Console.WriteLine("Energia: " + energia);
    Console.WriteLine("Forca: " + forca);
    Console.WriteLine("Moedas: " + moedas);
} */

/*
//Atividade 4
int dano = CalcularDano(20, 5);
Console.WriteLine("Dano causado: " + dano);
int CalcularDano(int ataque, int defesa)
{
    int danoFinal = ataque - defesa;
    return danoFinal;
} */

/*
//Atividade 5
int vidafinal = CalcularCura(50, 100);
if ( vidafinal > 100)
{
    vidafinal = 100;
}
else
{

}
Console.WriteLine("Vida atual: " + vidafinal);
int CalcularCura(int vida, int cura)
{
    return vida + cura;
} */

//Atividade 6
int abrirbau = 1;
Console.WriteLine("Você tenta abrir o báu");
VerificarBau(20, 10, 30);
abrirbau2(true);
void VerificarBau(int energia, int nivel, int vida)
{
    if (energia >= 20 && nivel >= 10 && vida >= 30)
    {
        Console.WriteLine("Você conseguiu abrir o báu!");
        
    }
    else
    {
        
    }
}
void abrirbau2(bool consegue)
{
  if (consegue = true)
    {
        Console.WriteLine("Você conseguiu abrir o báu!");
    }
  else if (abrirbau == 0 && consegue == false )
    {
        Console.WriteLine("Você não conseguiu abrir o báu");
    }
  else
    {

    }
}