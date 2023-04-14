using Exceptions;
using System.Diagnostics;

string? nome, cognome, dataDiNascita,password;
bool esito=false;
Console.WriteLine(nameof(dataDiNascita));


while (!esito)
{
    Console.Write("Inserisci il tuo nome: ");
    nome= Console.ReadLine();
    Console.Write("Inserisci il tuo cognome: ");
     cognome = Console.ReadLine();
    Console.Write("Inserisci la tua data di nascita: ");
     dataDiNascita = Console.ReadLine();
    Console.Write("Inserisci la tua password: ");
    password = Console.ReadLine();

    if (nome != null && cognome != null && dataDiNascita != null && password != null) 
    {
        try
        {
            Persona p = new Persona(nome, cognome, dataDiNascita, password);
            Console.WriteLine("persona creata correttamente");
            esito= true;
        }      

        catch (FormatException ex)
        {
            Console.WriteLine("non è stato possibile creare la persona a causa di un errore di formato");
            Debug.WriteLine(ex.Message);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("non è stato possibile creare la persona a causa di un dato nullo");
            Debug.WriteLine(ex.Message);
        }
        catch (PasswordNotValidException ex)
        {
            Console.WriteLine("non è stato possibile creare la persona perché la password non è valida");
            Console.WriteLine(ex.getErrors());
            Debug.WriteLine(ex.getErrors());
        }
        catch (Exception ex)        //tutto quello che non sono riuscito ad intercettare prima
        {
            Console.WriteLine("non è stato possibile creare la persona");
            Debug.WriteLine(ex.Message);
        }
        
        finally
        {
            Console.WriteLine("----------------");
        }

    }
}

 

