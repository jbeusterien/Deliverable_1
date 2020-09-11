using System;





namespace Deliverable1
{
    class program {
        private const string V = @"!";

        static void Main(string[]args) {

            Console.Write ("Enter a password:");
            string name = Console.ReadLine();
    }

    public static bool CheckPassword(string pass)
    {
        //min 7 chars, max 12 chars
        if (pass.Length < 7 || pass.Length > 12)
            return error;

        //At least 1 lower case letter
        if (!pass.Any(char.IsLower))
            return error;

        //At least 1 upper case letter
        if (!pass.Any(char.IsUpper))
            return error;

        //At least 1 special char !
        string specialCharacters = "!";
        char[] specialCharacterArray = specialCharacters.ToCharArray();
        foreach (char c in specialCharacterArray)
        {
            if (pass.Contains(c)) {
                Console.WriteLine ("Password valid and accepted");
        }
            else { 
                Console.WriteLine("Error");
            }
    }
}