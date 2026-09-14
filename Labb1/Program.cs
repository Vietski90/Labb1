using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv något här: ");
        string text = Console.ReadLine();

        HittaDelsträngar(text);
    }

    static void HittaDelsträngar(string text)
    {
        for (int start = 0; start < text.Length; start++)
        {
            if (!char.IsDigit(text[start]))
            {
                continue;
            }

            string siffror = "";

            for (int slut = start; slut < text.Length; slut++)
            {
                if (!char.IsDigit(text[slut]))
                {
                    break;
                }

                siffror += text[slut];
            }

            if (siffror.Length > 0)
            {
                Console.WriteLine(siffror);

                start += siffror.Length - 1;
            }
        }
    }
}