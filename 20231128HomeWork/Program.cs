using _20231128HomeWork.Models;
using _20231128HomeWork.Services;
using System;
using System.IO;

Console.WriteLine(File.ReadAllText(@"C:/Users/v.senkus/Desktop/Shop.txt"));

ShopItemService shopItemService = new ShopItemService();
FileService fileService = new FileService();

shopItemService.MakeShoppingItemsList();

shopItemService.DisplayItems();

Console.WriteLine("Iveskite komanda:");
String input = Console.ReadLine();


//try
//{
//    StreamReader sr = new StreamReader();
//    String line = sr.ReadLine();

//    while (line != null)
//    {
//        Console.WriteLine(line);
//        line = sr.ReadLine();
//    }
//    sr.Close();
//}
//catch (Exception e)
//{
//    Console.WriteLine("Exception: " + e.Message);
//}
//finally
//{
//    Console.WriteLine("Executing finally block.");
//}