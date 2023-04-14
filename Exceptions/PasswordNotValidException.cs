using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class PasswordNotValidException: Exception
    {
        List<string> errors=new List<string>();
        public PasswordNotValidException() { }

        public PasswordNotValidException(string message) : base(message) { }

        public void addError(string message) { errors.Add(message);}

        public string getErrors()
        {
            string err = string.Empty;
            foreach (string error in errors) 
            {
                err += error + Environment.NewLine;
            }
            return err;
        }

        public int getErrorsCount() 
        { return errors.Count;}
    }
}
