using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Persona
    {
        private string nome;
        private string cognome;
        private DateOnly dataDiNascita;
        private string password;

        public Persona(string nome, string cognome, string dataDiNascita, string password)
        { 
          
            if (nome!=string.Empty)
                this.nome = nome;
            else
                throw new ArgumentNullException(nameof(nome));
            if (cognome!=string.Empty)
                this.cognome = cognome;
            else
                throw new ArgumentNullException(nameof(cognome));
            DateOnly data;
            if (DateOnly.TryParseExact(dataDiNascita, "d", out data))
                this.dataDiNascita = DateOnly.ParseExact(dataDiNascita,"d");
            else
            {
                //sollevo un'eccezione
                throw new FormatException("Data di nascita non valida");
            }

            PasswordNotValidException passEx=new PasswordNotValidException();
            if (password.Length < 6)
                passEx.addError("La lunghezza deve essere almeno 6");
            if (password.ToUpper()==password)
                passEx.addError("La lunghezza deve contenere almeno una minuscola");
            if (password.ToLower() == password)
                passEx.addError("La password deve contenere almeno una maiuscola");

            if (passEx.getErrorsCount() > 0)
                throw passEx;
            else
                this.password = password;

        }

    }
}
