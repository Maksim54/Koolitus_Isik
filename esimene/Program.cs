using esimene;

//koer koer = new koer(koer.toug.pudel, "Sharik", "Krasnij", Koduloom.sugu.isane, 15.5, 7, true);
//koer.print_Info();
//koer.print_golos();
//koer veelkoer = new koer(koer);
//veelkoer.muudaNimi("Aleksei");
//veelkoer.print_Info();


Tootaja tootaja = new Tootaja("Polütehnikum", "Õpetaja", 1600, "Mikhail", 1989, Isik.sugu.mees, 500, 1600);
Opilane Opilane = new Opilane("Tallinna Humanitaargümnaasium", 9, "pöhikool", "Elena", 2002, Isik.sugu.naine, 0, 0);
Kutsekooliopilane Kutsekooliopilane = new Kutsekooliopilane("THK", "Pirita", 460, 3, 4.2, "Tarkvaraarendaja", 2, 60, "TARpv20", "Tarkvaraarendaja", "Maksim", 2005, Isik.sugu.mees, 0,0);
tootaja.printInfo();
Kutsekooliopilane.printInfo();
Opilane.printInfo();
Console.WriteLine(" ");


List<Isik> people = new List<Isik>();

people.Add(tootaja);
people.Add(Opilane);
people.Add(Kutsekooliopilane);
StreamWriter to_file = new StreamWriter(@"..\..\..\file.txt", false);
foreach (Isik p in people)
{
    p.printInfo();
    to_file.WriteLine(p.nimi +", " + p.arvutaVanus() + ", " + p.InimSugu); 
}
to_file.Close();

StreamReader sr = new StreamReader(@"..\..\..\file.txt");
List<string> Lines = new List<string>();
int n = sr.ReadToEnd().Split(new char[] { '\n' }).Length;


//var file = File.ReadAllText(@"..\..\..\file.txt").Split(", ");
//foreach (var item in file)
//{
//    Console.Write(item + ", ");
//}

