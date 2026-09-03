/*
Oppgave, uke 1

Lag et rent CLI-program i C# som sjekker hvor sterkt et passord er.

Programmet skal sjekke passordet steg for steg og holde hver oppgave i en egen metode, slik at koden blir enkel å lese, teste og bygge videre på.
*/

/*
Programflyt, rett etter dotnet run:
1. Hils på bruker
2. Vent på input X
3. Sjekk input, sjekk lengde på passord (hvis langt nok return true, ellers return false)
4. Sjekk hva det innholder, uppercase, lowercase, digit, osv... (flere funksjoner som return boolean)
5. Sjekk hvor sterkt det er (score, integer 0-x)
6. Vis hva mangler ?
7. Foreslå forbedring til bruker hvis passord ikke sterkt nok.
*/

namespace BackendSeptUke1;


class Program
{
    static void Main(string[] args)
    {
        

        Console.Clear();
        Console.WriteLine("Welcome to the password strengh checking app. Please enter a password and hit enter key.");
        
        while (true)
        {
            int passwordScore = 0; 

            string? password =  Console.ReadLine();
            passwordScore = CalculatePasswordScore(password);

            Console.WriteLine($"password score: {passwordScore}");
        }

    }

    static bool IsLongEnough(string password)
    {
        if (password.Length >= 8) return true;
        return false;
    }

    // check what chars password contains methods:
    static bool HasUppercase(string password)
    {
        foreach (char character in password)
        {
            if (char.IsUpper(character)) return true;
        }
        return false;
    }
    static bool HasLowercase(string password)
    {
        foreach (char character in password)
        {
            if (char.IsLower(character)) return true;
        }
        return false;
    }
    static bool HasDigit(string password)
    {
        foreach (char character in password)
        {
            if (char.IsDigit(character)) return true;
        }
        return false;
    }
    static bool HasSpecialCharacter(string password)
    {
        foreach (char character in password)
        {
            if (char.IsSymbol(character) || char.IsPunctuation(character)) return true;
        }
        return false;
    }

    static int CalculatePasswordScore(string password)
    {
        int scoreCalculation = 0;
        if (IsLongEnough(password)) scoreCalculation++;
        if (HasLowercase(password)) scoreCalculation++;
        if (HasUppercase(password)) scoreCalculation++;
        if (HasDigit(password)) scoreCalculation++;
        if (HasSpecialCharacter(password)) scoreCalculation++;

        return scoreCalculation;
    }

    static void ShowMissingRequirements(string password)
    {
        // code to check requirments, and then display to user.
    }
}
