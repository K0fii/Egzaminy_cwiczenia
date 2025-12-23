using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    public class PasswordManagers
    {
        public bool czyHasloJestSilne(string haslo)
        {
            try 
            {
                if (haslo == null)
                    throw new ArgumentNullException();

                if(haslo.Length < 8)
                    return false;

                bool duzaLitera = haslo.Any(char.IsUpper);
                bool cyfra = haslo.Any(char.IsNumber);
                bool znakSpycjalny = haslo.Any(c => !char.IsLetterOrDigit(c));

                if(duzaLitera && cyfra && znakSpycjalny)
                    return true;
                else
                    return false;
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
