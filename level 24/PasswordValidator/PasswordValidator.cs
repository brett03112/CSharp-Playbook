namespace Level24;

public class PasswordValidator
{
    public bool Validate(string password)
    {
        int lower_letters = 0;
        int upper_letters = 0;
        int numbers = 0;
        foreach (char c in password)
        {
            if (char.IsLower(c)) lower_letters++;
            if (char.IsUpper(c)) upper_letters++;
            if (char.IsDigit(c)) numbers++;
            if(c == 'T' || c == '&')
            {
                WriteLine("Password cannot contain 'T' or '&'.");
                return false;
            }
        }
         if (lower_letters > 0 && upper_letters > 0 && numbers > 0)
            {
                WriteLine("Password is valid.");
                return true;
            }
        else
        {
            WriteLine("Password is invalid.");
            return false;
        }
        
    }
}


