using System;


class Program
{
    public string TillRovarSprak(string text)
    {
        char[] chars = text.ToCharArray();
        string result = "";

        foreach (char achar in chars)
        {
            if ("bcdfghjklmnpqrstvxz".IndexOf(achar) >= 0)
            {
                // Är konsonant
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
    
  
    static void Main()
    {
        string text = "Hej";
        

       
       
        
    }
}

