// Definerer produkter og laver variabler til værdier som pris, antal solgte og kategori.

// Bambus Tandbørste
int produkt1Id = 1;
string produkt1Navn = "Bambus tandbørste";
string produkt1Kategori = "Bad";
double produkt1Pris = 39.0;
string produkt1Miljømærke = "Svanemærket";
int produkt1AntalSolgt = 243;
double omsætning1 = BeregnOmsætning(produkt1Pris, produkt1AntalSolgt);
string omsætning1Kategori = KategoriserOmsætning(omsætning1);
Console.WriteLine(produkt1Navn + " har en omsætning på " + omsætning1 + " kr. og bliver kategoriseret som:\n" + omsætning1Kategori + "\n");

//Genanvendelig kaffefilter
int produkt2Id = 2;
string produkt2Navn = "Genanvendelig kaffefilter";
string produkt2Kategori = "Køkken";
double produkt2Pris = 129.0;
string produkt2Miljømærke = "Ingen";
int produkt2AntalSolgt = 214;
double omsætning2 = BeregnOmsætning(produkt2Pris, produkt2AntalSolgt);
string omsætning2Kategori = KategoriserOmsætning(omsætning2);
Console.WriteLine(produkt2Navn + " har en omsætning på " + omsætning2 + " kr. og bliver kategoriseret som:\n" + omsætning2Kategori + "\n");

//Bambus sugerør
int produkt3Id = 3;
string produkt3Navn = "Bambus sugerør";
string produkt3Kategori = "Køkken";
double produkt3Pris = 19.0;
string produkt3Miljømærke = "Svanemærket";
int produkt3AntalSolgt = 947;
double omsætning3 = BeregnOmsætning(produkt3Pris, produkt3AntalSolgt);
string omsætning3Kategori = KategoriserOmsætning(omsætning3);
Console.WriteLine(produkt3Navn + " har en omsætning på " + omsætning3 + " kr. og bliver kategoriseret som:\n" + omsætning3Kategori + "\n");

//Bionedbrydelige affaldsposer
int produkt4Id = 4;
string produkt4Navn = "Bionedbrydelige affaldsposer";
string produkt4Kategori = "Have";
double produkt4Pris = 59.0;
string produkt4Miljømærke = "OK Compost";
int produkt4AntalSolgt = 416;
double omsætning4 = BeregnOmsætning(produkt4Pris, produkt4AntalSolgt);
string omsætning4Kategori = KategoriserOmsætning(omsætning4);
Console.WriteLine(produkt4Navn + " har en omsætning på " + omsætning4 + " kr. og bliver kategoriseret som:\n" + omsætning4Kategori + "\n");

//Bæredygtig parasol
int produkt5Id = 5;
string produkt5Navn = "Bæredygtig parasol";
string produkt5Kategori = "Have";
double produkt5Pris = 999.0;
string produkt5Miljømærke = "GRS (Global Recycled Standard)";
int produkt5AntalSolgt = 79;
double omsætning5 = BeregnOmsætning(produkt5Pris, produkt5AntalSolgt);
string omsætning5Kategori = KategoriserOmsætning(omsætning5);
Console.WriteLine(produkt5Navn + " har en omsætning på " + omsætning5 + " kr. og bliver kategoriseret som:\n" + omsætning5Kategori + "\n");




static double BeregnOmsætning(double pris, int antalSolgt)                      // Opretter en metode til at udrenge omsætningen for hvert produkt. Dette gøres ved at vælge 2 inputs en double og en int som vi kalder pris og antalSolgt.
{
    return pris * antalSolgt;                                                   // Her defineres metoden til at gange pris med antalsolgte og returnere denne metode i BeregnOmsætning.
}
                                                                                // Herefter kan vi kalde på metoden og indsætte prisen og antal solgte produkter for det specifikke produkt.

                                                                                // Herefter kan vi kalde på metoden og indsætte prisen og antal solgte produkter for det specifikke produkt.

                                                                                // Dette gemmes så i 5 double variabeler som vi navngiver omsætning 1 til 5.




static string KategoriserOmsætning(double omsætning)                            // Vi opretter en metode til at kategorisere produktets omsætning.
{
    {
        if (omsætning < 10000)                                                  // Dette gøres med if else statements. Der laves krav for hver if statement.
        {
            return "Lav omsætning: under 10.000,-";
        }
        else if (omsætning >= 10000 && omsætning <= 50000)                      // Hvis omsætningen er mindre end 10.000 kr. Så returneres "Lav omsætning: under 10.000,-" 
                                                                                // dette gøres for de andre krav også med omsætning mellem 10.000 og 50.000 samt over 50.000 kr.
        {
            return "Mellem omsætning: 10.000,- til 50.000,-";
        }
        else                                                                    // Hvis ikke at omsætningen er under 10.000 eller mellem 10.000 og 50.000 kr. så bruger vi else til at udskrive "Omsætning over 50.000 kr.
        {
            return "Høj omsætning: over 50.000,-";                              // Metoden gemmes med return i (KategoriserOmsætning)
        }

    }
}


int antalDage = 7;
double totalOmsætning = 0;

for (int dagNr = 1; dagNr <= antalDage; dagNr++)                                // Opretter et for loop der tæller fra dagNr = 1 til antalDage = 7 og laver en handling hver gang.

{

                                                                                // Simuler varierende dagligt salg ved hjælp af dagsnummeret og modulo

    int produkt1DagligtSalg = produkt1AntalSolgt / antalDage + (dagNr % 3);    // Bruger modulus til at give overblik over estimat for produkter solgt pr. dag. 
    int produkt2DaglitSalg = produkt2AntalSolgt / antalDage + (dagNr % 3);     // Modulus bruges til at gøre salget mere varieret.
    int produkt3DaglitSalg = produkt3AntalSolgt / antalDage + (dagNr % 3);     // Udregner produkter solgt dagligt med produktAntalSolgt / antalDage + (dagNr % 3)
    int produkt4DaglitSalg = produkt4AntalSolgt / antalDage + (dagNr % 3);
    int produkt5DaglitSalg = produkt5AntalSolgt / antalDage + (dagNr % 3);

   
    double dagsOmsætning = (produkt1DagligtSalg * produkt1Pris) + (produkt2DaglitSalg * produkt2Pris) + (produkt3DaglitSalg * produkt3Pris) +
        (produkt4DaglitSalg * produkt4Pris) + (produkt5DaglitSalg * produkt5Pris);

                                                                                // Summen af alle produkternes omsætning for dagen udregnes. Hver dag.
   
    totalOmsætning = dagsOmsætning * antalDage;
                                                                                // Den totale omsætning for antalDage bliver udregnet
   k
    Console.WriteLine("Dag nr. " + dagNr + "  er der blevet omsat for " + dagsOmsætning + " kr.");
}
                                                                                // Dagens statistik med dag nr. og dag omsætning bliver udskrevet hver dag.
Console.WriteLine();
Console.WriteLine("Totalomsætningen er " + totalOmsætning + " kr. i alt på " + antalDage + " dage");
                                                                                // Uden for loopet bliver den totale omsætning for antalDage udskrevet.
