# .Net_Course

## Tasks

### 2023-11-30 Class Task
Sukurkite klasę ProgressBar kuri turėtų int lauką progress. Jūsų programėles main metodas turėtų sukurti ProgressBar tipo objektą ir vykdyti ciklą, kuris didintų progress lauko reikšmę vienetu kas sekundę, tol, kol reikšmė pasiekia 100. Sukurkite kitą giją, kuri kas 3 sekundes į konsolę išvestų ProgressBar objekto, progress lauko reikšmę, tol, kol programa veikia.

### 2023-11-30 HomeWork

- Delegates:
  
Sukurkite klasę Person su string name ir int age
Main metode sukurkite sąrašą žmonių skirtingais vardais ir amžiaus
Sukurkite delegatą Filter, kuris grąžins bool o per parametrą pasiims Person objektą.
Sukurkite tris metodus kurie grąžins bool reikšmes ir priiminės Person per parametrą, vienas metodas tikrins ar žmogus yra vaikas < 18 metų, kitas tikrins ar suaugęs >= 18 metų ir trečias tikrins ar senjoras >= 65 metai.
Sukurkite metodą DisplayPeople, su parametrais title, List<Person> ir delegatu Filter. Metodo esmė bus eiti ciklu per asmenys ir paleisdinėti perduotą per parametrus filtrą patikrinti ar žmogus pvz. yra vaikas.
 
Metodo kvietimas atrodys maždaug taip: DisplayPeople("Children:", people, IsChild);
 
Metodai gali būti anoniminiai
 
- Linq:
 
Sukurkite Person klasę su vardu ir sąrašu gyvūnų(irgi nauja klasė, gyvūnai turi tik vardą). Sukurkite sąrašą su Person objektais ir viduje esančiais gyvūnų sąrašais.
Su LINQ Select ir SelectMany sukurkite sąrašą kurį sudarys visi gyvūnai iš sąrašo.
Kitas sąrašas, kurį sudarys tik gyvūnai, kurių vardai prasideda iš A raidės.
Pridėkite prie Pet klasės amžių int Age, sudarykite kitą sąrašą iš gyvūnų, kurių vardai prasideda iš A raidės ir jų amžius yra virš 5 metų.
Parašykite metodą, kuris priima vieną string parametrą. Parašykite LINQ funkcionalumą, kad grąžintų žodžius kurie yra vien iš didžiųjų raidžių.

- Asinchroninis programavimas:
  
Sukurkite bent 10 failų su tekstų, teksto turėtų būti, bent 100+ žodžių (kuo daugiau failų ir teksto tuo daugiau). Tuomet asynchroniškai skaitykite visus failus vienu metu (jeigu pritrūkote resursų, galite skaityti po 4 ar 8 failus vienu metu. Susikurkite sąrašą ieškomų žodžių. Tuo pačiu metu, kai baigiate skaityti failą (vienu metu išvedinėjame kelis failus) išveskite naują rezultatų failą (atskiras failas kiekvienam skaitomui failui, pvz MyFile1_Results.txt... MyFile2_Results.txt) Kuriame bus sąrašas žodžių iš jūsų ieškomų žodžių sąrašo kuriuose radote ir kiek kartų juos radote pvz (Herojus:15,Kompiuteris:4). Failų formatas gali būti keičiamas jūsų nuožiūra, galima naudoti json.
