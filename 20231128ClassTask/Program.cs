using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Noriu eilerascio");
String eilerastis = Console.ReadLine();
Console.WriteLine("koki zodi pakeisti?");
String zodis = Console.ReadLine();
Console.WriteLine("i ka pakeisti?");
String pakeistukas = Console.ReadLine();

//String Change(String text, String word, String repalace)
//{
//    String[] split = Regex.Split(text, " ");
//    foreach (String s in split)
//    {
//        if s == word{
//            s = repalace;
//        }
//    }

//    foreach (String s in split)
//    {
//        text += s;
//    }
//    return text;
//}

//Console.WriteLine(Change(eilerastis, zodis, pakeistukas));

Console.WriteLine(eilerastis.Replace(zodis, pakeistukas));

// priimti zodi, tikrinti ar jis "labas", -> true -> apsukti atbulai, if false -> zodis. 

Console.WriteLine("ivesti zodi");
String word=Console.ReadLine();
Reverse(word);
void Reverse(String word)
{
    if (word == "labas")
    {
       Console.WriteLine("sabal");
    }
    else
    {
        Console.WriteLine(word);
    }
}

Console.Write("give me number");
String number = Console.ReadLine();

void showNUmber(String number)
{
    try
    {
        Console.Write(int.Parse(number));
    }
    catch (Exception e)
    {
        Console.Write("klaida " + e);
    }
}

showNUmber(number);