using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MP_EF_Lavinia_Bleoca
{
    class Program
    {

        static AssetsContext _db = new AssetsContext();



        static void Main(string[] args)
        {
            //code

            List<Computers> computers = new List<Computers>();
            List<CellPhones> cellphones = new List<CellPhones>();
            //  List<OtherAssets> otherassets = new List<OtherAssets>();
            List<DiverseAssets> diverseassets = new List<DiverseAssets>();

            //NY DATABASKONCEPT FOR RESURSLOGGEN
            AssetsContext _db = new AssetsContext();



            Console.WriteLine("RESURSLOGGEN");


            while (true)
            {
                Console.WriteLine("\n**********************************************************\n" +
                    "* Skriv in en resurskategori med Enter - Redan existerande kategorier  ar 'computer' och 'cellphone'.\n\n " +
                    "* Avbryt inmatningen med 'q' - Detta listar tillgangliga resurser\n----------------------------------------\n");

                string TypeOfAsset = Console.ReadLine();

                if (TypeOfAsset.ToLower() == "q")
                {
                    break;
                }

                Console.WriteLine("Skriv in datumet da resursen koptes in (YYYY-MM-DD): ");
                string Purchased = Console.ReadLine();



                try
                {
                    bool isPurchaseTimeRight = DateTime.TryParse(Purchased, out DateTime result);

                    if (isPurchaseTimeRight)
                    {

                        DateTime PurchaseTime = Convert.ToDateTime(Purchased);

                        Offices office = new Offices();

                        //om dator


                        if (TypeOfAsset.Contains("computer"))
                        {

                            Console.WriteLine("Skriv in en resurstyp (redan existerande ar 'stationary' och 'laptop'): ");
                            // string ResourceType = "computer";
                            string ComputerType = Console.ReadLine();
                            Console.WriteLine("Skriv in ett marke: ");
                            string Brand = Console.ReadLine();
                            Console.WriteLine("Skriv in kontornamnet: ");
                            string OfficeN = Console.ReadLine();


                            //lagg till resurserna i listan
                            Computers newComputer = new Computers(ComputerType, Brand, PurchaseTime);
                            computers.Add(newComputer);


                            office.Name = OfficeN;
                            office.Computers = computers;
                            _db.Offices.Add(office);
                            _db.SaveChanges();



                        }
                        else if (TypeOfAsset.Contains("cellphone"))
                        {
                            Console.WriteLine("Skriv in en resurstyp (redan existerande ar 'smartphone' och 'oldermodel'): ");
                            string CellType = Console.ReadLine();
                            Console.WriteLine("Skriv in ett marke: ");
                            string Brand = Console.ReadLine();
                            Console.WriteLine("Skriv in kontornamnet: ");
                            string OfficeN = Console.ReadLine();

                            //lagg till resurserna i listan
                            CellPhones newCell = new CellPhones(CellType, Brand, PurchaseTime);
                            cellphones.Add(newCell);



                            office.Name = OfficeN;
                            office.CellPhones = cellphones;
                            _db.Offices.Add(office);
                            _db.SaveChanges();



                        }
                        else if (TypeOfAsset != "computer" || TypeOfAsset != "cellphone")
                        {

                            string resourceType = TypeOfAsset;
                            Console.WriteLine("Skriv in en resurstyp: ");
                            string Model = Console.ReadLine();
                            Console.WriteLine("Skriv in ett marke: ");
                            string Brand = Console.ReadLine();
                            Console.WriteLine("Skriv in kontornamnet: ");
                            string OfficeN = Console.ReadLine();


                            //lagg till resurserna i listan
                            DiverseAssets newDiverseAsset = new DiverseAssets(resourceType, Model, Brand, PurchaseTime);
                            diverseassets.Add(newDiverseAsset);



                            office.Name = OfficeN;
                            office.DiverseAssets = diverseassets;
                            _db.Offices.Add(office);
                            _db.SaveChanges();


                        }
                        else
                        {
                            Console.WriteLine("<>FEL DATUMO");
                        }


                        //  return IsDeprecated;

                    }


                }
                catch (FormatException WrongDateFormat)
                {
                    Console.WriteLine($"Datum ska vara i formatet YYYY-MM-DD: {WrongDateFormat}");
                }


            }


            /// //visa produkterna
            ReadandListAssets(_db);

        }

        private static void ReadandListAssets(AssetsContext _db)
        {
            try
            {





                List<Assets> allasets = new List<Assets>();
                List<Offices> alloffices = _db.Offices.ToList();
                List<Computers> allcomputers = _db.Computers.ToList();
                List<CellPhones> allcellphones = _db.CellPhones.ToList();
                List<DiverseAssets> alldiverseassets = _db.DiverseAssets.ToList();
                //  allasets.AddRange(alloffices);
                allasets.AddRange(allcomputers);
                allasets.AddRange(allcellphones);
                allasets.AddRange(alldiverseassets);

                //sortering per kontor, kategori sen inkopsdatum
                allasets = allasets.OrderByDescending(allasets => allasets.GetType().Name)
                    .ThenBy(allasets => allasets.ResourceType)
                    .ThenBy(allasets => allasets.Purchased)
                    .ToList();

                Console.WriteLine("RESURSER SOM FINNS I DATABASEN:\n");

                Console.WriteLine($"..............".PadRight(25) + "..............".PadRight(25) + "..............".PadRight(25)
                    + "..............".PadRight(25) + "..............".PadRight(25)
                    + "..............");

                Console.WriteLine($"Resurskategori".PadRight(25) + "Resurstyp".PadRight(25) + "Marke".PadRight(25) + "Inkopsdatum".PadRight(25) + "Kontor".PadRight(25)
                    + "KontorID");

                Console.WriteLine($"..............".PadRight(25) + "..............".PadRight(25) + "..............".PadRight(25)
                    + "..............".PadRight(25) + "..............".PadRight(25)
                    + "..............");

                foreach (Assets asset in allasets)
                {

                    Deprecated deprecated = new Deprecated();

                    bool isDeprecated = deprecated.CheckDeprecated(asset.Purchased);

                    if (asset is Computers && isDeprecated == true)
                    {
                        Computers computer = asset as Computers;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine(computer.GetType().Name.PadRight(25) + " " + computer.Brand.PadRight(25) + " "
                            + computer.Model.PadRight(25) + " "
                            + computer.Purchased.ToShortDateString().ToString().PadRight(25)
                            + " "
                            + computer.Office.Name.PadRight(25)
                            + "<" + computer.Office.Id + ">"
                                                        + " "
                            + "*"
                            , Console.ForegroundColor);
                        Console.ResetColor();
                    }
                    else if (asset is Computers && isDeprecated == false)
                    {
                        Computers computer = asset as Computers;


                        Console.WriteLine(computer.GetType().Name.PadRight(25) + " " + computer.Brand.PadRight(25) + " "
                            + computer.Model.PadRight(25) + " "
                            + computer.Purchased.ToShortDateString().ToString().PadRight(25)
                            + " "
                            + computer.Office.Name.PadRight(25)
                            + "<" + computer.Office.Id + ">");
                    }

                    else if (asset is CellPhones && isDeprecated == false)
                    {
                        CellPhones cellPhone = asset as CellPhones;

                        Console.WriteLine(cellPhone.GetType().Name.PadRight(25) + " " + cellPhone.Brand.PadRight(25) + " "
                           + cellPhone.Model.PadRight(25) + " "
                           + cellPhone.Purchased.ToShortDateString().ToString().PadRight(25)
                           + " "
                           + cellPhone.Office.Name.PadRight(25)
                           + "<" + cellPhone.Office.Id + ">");

                    }
                    else if (asset is CellPhones && isDeprecated == true)
                    {
                        CellPhones cellPhone = asset as CellPhones;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine(cellPhone.GetType().Name.PadRight(25) + " " + cellPhone.Brand.PadRight(25) + " "
                           + cellPhone.Model.PadRight(25) + " "
                           + cellPhone.Purchased.ToShortDateString().ToString().PadRight(25)
                           + " "
                           + cellPhone.Office.Name.PadRight(25)
                           + "<" + cellPhone.Office.Id + ">"
                                                       + " "
                            + "*"
                              , Console.ForegroundColor);
                        Console.ResetColor();

                    }
                    else if (asset is DiverseAssets && isDeprecated == false)
                    {
                        DiverseAssets divassets = asset as DiverseAssets;

                        Console.WriteLine(divassets.GetType().Name.PadRight(25) + " " + divassets.Brand.PadRight(25) + " "
                           + divassets.Model.PadRight(25) + " "
                           + divassets.Purchased.ToShortDateString().ToString().PadRight(25)
                           + " "
                           + divassets.Office.Name.PadRight(25)
                           + "<" + divassets.Office.Id + ">");

                    }
                    else if (asset is DiverseAssets && isDeprecated == true)
                    {
                        DiverseAssets divassets = asset as DiverseAssets;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine(divassets.GetType().Name.PadRight(25) + " " + divassets.Brand.PadRight(25) + " "
                           + divassets.Model.PadRight(25) + " "
                           + divassets.Purchased.ToShortDateString().ToString().PadRight(25)
                           + " "
                           + divassets.Office.Name.PadRight(25)
                           + "<" + divassets.Office.Id + ">"
                            + " "
                            + "*"
                           , Console.ForegroundColor);
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.WriteLine(asset.GetType().Name.PadRight(25) + " " + asset.Brand.PadRight(25) + " "
                             + asset.Model.PadRight(25) + " "
                            + asset.Purchased.ToShortDateString().ToString().PadRight(25)
                            + " "
                            + "<NA>");


                    }
                }


                Console.WriteLine("* Aldre an 33 manader");


            }
            catch (Exception exc)
            {
                Console.WriteLine($"FEL: {exc}");
            }
        }
    }
}
