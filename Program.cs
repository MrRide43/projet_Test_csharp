// script qui demande le prénom est retourne "bonjour + prenom"

//Console.WriteLine("Saisir votre prnom :");

//var prenom = Console.ReadLine();

//Console.WriteLine("Bonjour " + prenom);


//script qui demande l'age et le prénom de l'utilisateur pour retourner une phrase avec ces informations

//Console.WriteLine("Saisir votre prenom :");
//var prenom = Console.ReadLine();
//string prenomChaine = prenom.ToString();
//Console.WriteLine("Saisir votre age :");
//var age = Console.ReadLine();
//int ageEntier = int.Parse(age);

//string bonjour = $"bonjour {prenom} vous avez {ageEntier} !";
//string bonjour2 = "bonjour " + prenom + " vous avez" + ageEntier + " !";

//Console.WriteLine(bonjour);

// script qui dit à l'utilisateur si il est majeur ou mineur 

//Console.WriteLine("Saisir votre prenom :");
//var prenom = Console.ReadLine();
//Console.WriteLine("Saisir votre age :");
//int age = int.Parse(Console.ReadLine());

//int ageLegal = 18;

//Console.WriteLine($"bonjour {prenom} vous avez {age} ans");

//if (age < ageLegal)
//{
//    Console.WriteLine("vous êtes mineur");
//} 
//else
//{
//    Console.WriteLine("vous êtes majeur"); 
//}

//script pour remplir un tableau est les retourne dans des phrases

//string[] valeur = new string[3];

//for (int i = 0;i < 3; i++)
//{
//    Console.WriteLine("Saisir votre valeur n°" + (i + 1));
//    valeur[i] = Console.ReadLine();
//}

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"la valeur {(i + 1)} est {valeur[i]}");
//}


Random rnd = new Random();

int chiffreAleatoire = rnd.Next(0, 100);
bool gagne = false;

List <int> chiffreRentrer = [];
string indication = "";

 while (gagne == false)
{
    Console.Clear();
    
        Console.WriteLine("vos Tentative précédente :");
        foreach (var item in chiffreRentrer)
        {
            Console.WriteLine($"{item}");
        }
        Console.WriteLine();

        if (!string.IsNullOrEmpty(indication))
        {
            Console.WriteLine(indication);
        }

    Console.WriteLine("Saisir un nombre :");
    string chiffre = Console.ReadLine();


    // gestion utilisateur qui rentre un champ vide 
    if (string.IsNullOrEmpty(chiffre))
    {
        Console.WriteLine("Renato il faut rentrer un chiffre !");
        continue;
    }
    // gestion utilisateur qui rentre un string
    if (!int.TryParse(chiffre, out int chiffreInt))
    {
        Console.WriteLine("Renato saisie un nombre !");
        continue;
    }
    // Gestion utilisateur qui n'est plus dans la plage du nombre mystère
    if (chiffreInt > 100 || chiffreInt < 0)
    {
        Console.WriteLine("ne faite pas comme Renato");
        continue;
    }

    chiffreRentrer.Add(int.Parse(chiffre));


        //partie condition pour guider l'utilisateur
        if (chiffreInt > chiffreAleatoire)
        {
            indication = "c'est moins";
        }
        else if (chiffreInt < chiffreAleatoire)
        {
            indication = "c'est plus";
        }
        else
        {
            indication = "trouvé !";
            gagne = true;
        }
}

Console.WriteLine("test git hub");
Console.WriteLine("Test 2 github mofication sur la branche 2");
Console.WriteLine("Test commit et push avec identifiant à mon nom 2");
Console.WriteLine("Test commit et push avec identifiant à mon nom");

// Exemple de fonction en c#
//int result = GetResultNumber(2, 3);
//Console.WriteLine(result);

//static int GetResultNumber(int a, int b)
//{
//    return a + b;
//}
