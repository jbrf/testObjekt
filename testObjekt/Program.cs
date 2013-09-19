using System;


class Program
{
    public static string TillRovarSprak(string text)
    {
        char[] chars = text.ToCharArray();
        string result = "";
        string consonants = "bcdfghjklmnpqrstvxz";
        consonants += consonants.ToUpper();

        foreach (char achar in chars)
        {
           
            if (consonants.IndexOf(achar) >= 0)
            {
                // Är konsonant

                result += achar + "o" + achar; /*(char.ToLower(achar));*/

            }
            else
            {
                // Är inte konsonant så lägg till i result
                //result += achar;
                result = result + achar;
            }
        }
        return result;
    }

    public static string FranRovarSprakTillSvenska(string text)
    {



        return result;
    }
    
  
    static void Main()
    {

        Console.WriteLine(TillRovarSprak("Hej, jag heter Johan"));
        Console.WriteLine(FranRovarSprakTillSvenska("Hohejoj, jojagog hohetoteror Jojohohanon"));

       
       
        
    }
}

