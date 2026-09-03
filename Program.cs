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

string GetPasswordInput()
{
    // skriv koden her :)
    return "";
}

bool IsLongEnough(string password)
{
    // skriv koden her :)
    return false;
}

// check what chars password contains methods:
bool HasUppercase(string password)
{
    // skriv koden her :)
    return false;
}
bool HasLowercase(string password)
{
    // skriv koden her :)
    return false;
}
bool HasDigit(string password)
{
    // skriv koden her :)
    return false;
}
bool HasSpecialCharacter(string password)
{
    // skriv koden her :)
    return false;
}

int CalculatePasswordScore(string password)
{
    return 0;
}

void GetMissingRequirements(string password)
{
    // code to check requirments, and then display to user.
}