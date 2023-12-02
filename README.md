# C# .NET Console Applications

Repository storing C# Console Application code examples mainly for syntax review and Tasks with it's execution code.

## TASKS LIST

### 2023-11-27 Class Task

Sukurti klase ShopItem su laukais Name, Description, Price, Expiration ir Tag. Sukurti klasė Tag. Klasėje ShopItem Tag turi būti List<Tag> tipo. Sukurti metodą išvedantį ShopItem objekto visus parametrus į ekraną.


### 2023-11-28 Class Task (Continues from 2023-11-27)

1. Sukurkite programą, kuri priimtų tekstą (eilėraštis arba dainos žodžiai). Tada užklaustų vartotojo kokį žodį norėtų pakeisti į kitą vartotojo paduotą žodį. Atnaujintą tekstą turėtų išvesti į ekraną.
2. Sukurkite programą, kuri priima vartotojo įvestą žodį ir patikrina, ar jis yra "labas". Jei taip, atspausdinkite žodį atbulai naudodami metodą Reverse(). Jei žodis nesutampa su "labas", atspausdinkite žodį taip, kaip jis buvo įvestas.
3. Sukurkite metodą kuris patikrina ar atsiųstas tekstas yra skaičius ir gražina skaičių (kaip int) ir atsakyma ar teisinga (is esmes sukurkite savo int.TryParse metoda) NEGALIMA NAUDOTI TRYPARSE

###2023-11-28 Evening Homework - Using Interfaces and Services

1. Sukurti objektą su šitais laukeliais:
 - Name
 - Description.
 - Tags . (for example: food, sweets, unhealthy)
 - Price
Įdėti, bent du objektus į sąrašą/
Atspausdinti šiuos du objektus į failą naudojant ToString metodą.
 2. Sukurti metodą, kuris viduje esančius tag palygina. Ir išveda naują sąrašą tik tų tagų kurie sutampa, per visus objektus
 3.Įsiaiškinti, kas yra konstruktorius ir padaryti objekto parametrų priskyrimą per jį.
 4. Sukurti Tag, kaip nauja objektą (Tag klasę/tipą) ir atlikti ankščiau įvardytus veiksmus su juo, Tag turi turėti du parametrus ID ir Name.
 5****Extra hard for bonus points. Sukurti servicą ir jį panaudoti veiksmams su objektu/tagais.

Butinai sukurkite du servicus ir Shopitem ir Failu apdorojimui (skaitymas/rasymas ir t.t) Butinai su interface.
 
 
turi buti igyvendinti sitie metodai servicuose.
 
Item service turi buti listas, kuris egzistuoja visos programos metu ir ji turi buti privatus
 
Programai baigus darba jis isvedamas i faila.
 
programai pradejus darba uzkraunamas is failo
 
1. "Add <itemname> <price>"
2. "Remove <Itemname>" (shop items)
3. "Show balance" -> displays your balance (initial balance is 20 euros)
4. "Topup <money>" -> topup your balance;
5. "Buy <itemname>" -> buys an item if the buyer has enough money.
6.. "Display items" -> displays all items that you have bought.
 
Turi visos klaidos buti pagautos.
 
The information should be saved into a file. 
That means when you restart the information does not dissappear.
 
Console messages should be logical

Atkreipkitė dėmesį, kad Remove, atliktų tokį veiksmą:
Command 'remove <itemName>' -> would remove the item.
If item does not exist, display '<itemName> not found';
If Item quantity is more than 1, just reduce the quantity.
 
Jeigu kas baigs ankščiau, norėčiau, kad sukurtumėte naują service, įrašymui ir nuskaitymui iš JSON vietoje Txt failo

### 2023-11-29 Class Work
Parašykite metodą, kuris paduotame dvimačiame masyve rastų visus pasikartojančius skaičius

### 2023-11-30 Class Task
Sukurkite klasę ProgressBar kuri turėtų int lauką progress. Jūsų programėles main metodas turėtų sukurti ProgressBar tipo objektą ir vykdyti ciklą, kuris didintų progress lauko reikšmę vienetu kas sekundę, tol, kol reikšmė pasiekia 100. Sukurkite kitą giją, kuri kas 3 sekundes į konsolę išvestų ProgressBar objekto, progress lauko reikšmę, tol, kol programa veikia.

### 2023-11-30 Home Work

####Delegates:

Sukurkite klasę Person su string name ir int age
Main metode sukurkite sąrašą žmonių skirtingais vardais ir amžiaus
Sukurkite delegatą Filter, kuris grąžins bool o per parametrą pasiims Person objektą.
Sukurkite tris metodus kurie grąžins bool reikšmes ir priiminės Person per parametrą, vienas metodas tikrins ar žmogus yra vaikas < 18 metų, kitas tikrins ar suaugęs >= 18 metų ir trečias tikrins ar senjoras >= 65 metai.
Sukurkite metodą DisplayPeople, su parametrais title, List<Person> ir delegatu Filter. Metodo esmė bus eiti ciklu per asmenys ir paleisdinėti perduotą per parametrus filtrą patikrinti ar žmogus pvz. yra vaikas.
 
Metodo kvietimas atrodys maždaug taip: DisplayPeople("Children:", people, IsChild);
 
Metodai gali būti anoniminiai
 
####Linq:
 
Sukurkite Person klasę su vardu ir sąrašu gyvūnų(irgi nauja klasė, gyvūnai turi tik vardą). Sukurkite sąrašą su Person objektais ir viduje esančiais gyvūnų sąrašais.
Su LINQ Select ir SelectMany sukurkite sąrašą kurį sudarys visi gyvūnai iš sąrašo.
Kitas sąrašas, kurį sudarys tik gyvūnai, kurių vardai prasideda iš A raidės.
Pridėkite prie Pet klasės amžių int Age, sudarykite kitą sąrašą iš gyvūnų, kurių vardai prasideda iš A raidės ir jų amžius yra virš 5 metų.
Parašykite metodą, kuris priima vieną string parametrą. Parašykite LINQ funkcionalumą, kad grąžintų žodžius kurie yra vien iš didžiųjų raidžių.

#### Asinchroninis programavimas:

Sukurkite bent 10 failų su tekstų, teksto turėtų būti, bent 100+ žodžių (kuo daugiau failų ir teksto tuo daugiau). Tuomet asynchroniškai skaitykite visus failus vienu metu (jeigu pritrūkote resursų, galite skaityti po 4 ar 8 failus vienu metu. Susikurkite sąrašą ieškomų žodžių. Tuo pačiu metu, kai baigiate skaityti failą (vienu metu išvedinėjame kelis failus) išveskite naują rezultatų failą (atskiras failas kiekvienam skaitomui failui, pvz MyFile1_Results.txt... MyFile2_Results.txt) Kuriame bus sąrašas žodžių iš jūsų ieškomų žodžių sąrašo kuriuose radote ir kiek kartų juos radote pvz (Herojus:15,Kompiuteris:4). Failų formatas gali būti keičiamas jūsų nuožiūra, galima naudoti json.