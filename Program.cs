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
            List<OtherAssets> otherassets = new List<OtherAssets>();


            //NY DATABASKONCEPT FOR RESURSLOGGEN
            AssetsContext _db = new AssetsContext();



            Console.WriteLine("RESURSLOGGEN");


            while (true)
            {
                Console.WriteLine("Skriv in en resurskategori med Enter, avbryt inmatningen med 'q'\nRedan existerande kategorier  ar 'computer' och 'cellphone'.\n----------------------------------------\n");
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

                        Assets deprecated = new Assets();

                        bool IsDeprecated = deprecated.CheckDeprecated(PurchaseTime);

                        Offices office = new Offices();

                        //om dator
                        /*
                        switch (TypeOfAsset == "computer")
                        {
                            default:
                        }
                        */

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

                            Console.WriteLine("Skriv in en resurstyp: ");
                            string AssetClass = Console.ReadLine();
                            Console.WriteLine("Skriv in ett marke: ");
                            string Brand = Console.ReadLine();
                            Console.WriteLine("Skriv in kontornamnet: ");
                            string OfficeN = Console.ReadLine();


                            //lagg till resurserna i listan
                            OtherAssets newAsset = new OtherAssets(AssetClass, Brand, PurchaseTime);
                            otherassets.Add(newAsset);



                            office.Name = OfficeN;
                            office.OtherAssets = otherassets;
                            _db.Offices.Add(office);
                            _db.SaveChanges();



                        }
                        else
                        {
                            Console.WriteLine("<>FEL DATUMO");
                        }


                        //HERE!!!!!!!!!!!!!






                    }
                    //
                    //_db.SaveChanges();

                }
                catch (FormatException WrongDateFormat)
                {
                    Console.WriteLine($"Datum ska vara i formatet YYYY-MM-DD: {WrongDateFormat}");
                }

                //_db.SaveChanges();




            }





            //  _db.SaveChanges();







            /////GENRATE METHOD AFTERWRDS
            /// //visa produkterna


            try
            {

                Console.WriteLine("RESURSERNA SOM FINNS I DATABASEN");

                Console.WriteLine($"Resurskategori".PadRight(25) + "Resurstyp".PadRight(25) + "Marke".PadRight(25) + "Inkopsdatum".PadRight(25) + "Kontor");




                //sortering per kategori sen inkopsdatum

                List<Offices> comps = _db.Offices.Where(comp => comp.Name.Contains("Lavi")).Include(comp => comp.Computers).ToList();


                //Name.ToString().ToList();

                //ToString().ToList());
                /*
                    office.OrderBy(office => office.GetType().Name)
                        .ThenBy(Assets => Assets.GetType().Name.ToString().ToList());
                    //Purchased.ToString());
                    //.ToList();
                */
                Console.WriteLine(" ");


                foreach (Offices asset in comps)
                {

                    Console.WriteLine(comps.GetType().Name.ToString());



                    /*
                    if (asset is Computers && (asset as Computers).IsDeprecated == true)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine((asset as Computers).ResourceType.PadRight(25) + " " + (asset as Computers).Brand.PadRight(25)
                       + " " + (asset as Computers).Model.PadRight(25) + (asset as Computers).Purchased.ToShortDateString() 
                       , Console.ForegroundColor);
                        Console.ResetColor();

                    }
                    else if (asset is Computers && (asset as Computers).IsDeprecated == false)
                    {

                        Console.WriteLine((asset as Computers).ResourceType.PadRight(25) + " " + (asset as Computers).Brand.PadRight(25)
                       + " " + (asset as Computers).Model.PadRight(25) + (asset as Computers).Purchased.ToShortDateString()
                       );
                    }
                    //Check if asset object is a cellphone object
                    else if (asset is CellPhones && (asset as CellPhones).IsDeprecated == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine((asset as CellPhones).ResourceType.PadRight(25) + " " + (asset as CellPhones).Brand.PadRight(25)
                                + " " + (asset as CellPhones).Model.PadRight(25) + (asset as CellPhones).Purchased.ToShortDateString()
                                , Console.ForegroundColor);
                        Console.ResetColor();
                    }
                    else if (asset is CellPhones && (asset as CellPhones).IsDeprecated == false)
                    {
                        Console.WriteLine((asset as CellPhones).ResourceType.PadRight(25) + " " + (asset as CellPhones).Brand.PadRight(25)
                              + " " + (asset as CellPhones).Model.PadRight(25) + (asset as CellPhones).Purchased.ToShortDateString()
                              );
                    }

                    //Check if asset object is a new asset object
                    else if (asset is OtherAssets && (asset as OtherAssets).IsDeprecated == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine((asset as OtherAssets).ResourceType.PadRight(25) + " " + (asset as OtherAssets).Brand.PadRight(25)
                                + " " + (asset as OtherAssets).Model.PadRight(25)
                             + (asset as OtherAssets).Purchased.ToShortDateString(), Console.ForegroundColor);
                        Console.ResetColor();

                    }
                    else if (asset is OtherAssets && (asset as OtherAssets).IsDeprecated == false)
                    {

                        Console.WriteLine((asset as OtherAssets).ResourceType.PadRight(25) + " " + (asset as OtherAssets).Brand.PadRight(25)
                                + " " + (asset as OtherAssets).Model.PadRight(25)
                             + (asset as OtherAssets).Purchased.ToShortDateString());
                    }
                    */

                    Console.WriteLine("asset");


                    //Use Include for child objects


                }


            }
            catch (Exception exc)
            {
                Console.WriteLine($"FEL: {exc}");
            }





        }






    }
}
