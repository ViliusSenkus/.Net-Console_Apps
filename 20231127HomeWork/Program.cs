using _20231127HomeWork;

ShopItem shopItem1 = new ShopItem();
ShopItem shopItem2 = new ShopItem();

shopItem1.Name = "Candies";
shopItem1.Description = "very sweet";
shopItem1.Tag.Add("unhealhy");
shopItem1.Tag.Add("food");
shopItem1.Price = 2.22;

shopItem2.Name = "Soda";
shopItem2.Price = 2.22;
shopItem2.Description = "very sweet";
shopItem2.Tag.Add("food");
shopItem2.Tag.Add("beverage");

List <ShopItem> shopItemsList = new List<ShopItem>();
shopItemsList.Add(shopItem1);
shopItemsList.Add(shopItem2);


foreach (ShopItem item in shopItemsList)
{
    File.AppendAllText(@"C:/Users/v.senkus/Desktop/ShopItems.txt", item.ToString());
}


