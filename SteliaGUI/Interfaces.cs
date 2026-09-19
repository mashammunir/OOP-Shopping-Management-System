namespace SteliaGUI
{

    // INTERFACE used for dashboard forms to ensure they implement required methods
    public interface IDashboard
    {
       
     void LoadData();
     void HandleLogout();
   
    }
    // POLYMORPHISM used for different types of input validation
    public abstract class BaseValidator
    {
        public abstract bool ValidateInput(string input);
    }

 public class UsernameValidator : BaseValidator
    {
  public override bool ValidateInput(string input)
        {
            return !string.IsNullOrWhiteSpace(input) &&
                input.Length >= 6 &&
                   input.Length <= 15 &&
                 !input.Contains(",");
        }
    }

  public class EmailValidator : BaseValidator
    {
        public override bool ValidateInput(string input)
        {
            int atCount = 0, dotCount = 0;
   foreach (char c in input)
            {
                if (c == '@') atCount++;
                if (c == '.') dotCount++;
            }
      return atCount == 1 && dotCount >= 1 && input.Length >= 5;
        }
    }

    public class PasswordValidator : BaseValidator
    {
        public override bool ValidateInput(string input)
        {
            int numbers = 0, capitals = 0, specials = 0;
            foreach (char c in input)
            {
                if (char.IsDigit(c)) numbers++;
             else if (char.IsUpper(c)) capitals++;
                else if (!char.IsWhiteSpace(c) && !char.IsLetter(c)) specials++;
            }
          return input.Length >= 6 &&
             numbers >= 1 &&
             capitals >= 1 &&
           specials >= 1;
        }
    }
}