using System;
using System.Runtime.ConstrainedExecution;

/*Scrivere una classe 'Contribuente' che abbia le seguenti proprietà: [Nome, Cognome, DataNascita, CodiceFiscale,
Sesso, ComuneResidenza, RedditoAnnuale] ; costruire uno o più costruttori (a scelta del candidato) ed un metodo che
applichi al reddito le seguenti aliquote per scaglioni e determini l'imposta da pagare:
SCAGLIONI DI REDDITO ALIQUOTA E IMPOSTA DOVUTA
1Reddito da 0 a 15.000 aliquota 23%
2Reddito da 15.001 a 28.000 3.450 + aliquota 27% sulla parte eccedente i 15.000
3Reddito da 28.001 a 55.000 6.960 + 38% sulla parte eccedente i 28.000
4Reddito da 55.001 a 75.000 17.220 + 41% sulla parte eccedente i 55.000
5Redditi oltre i 75.001 25.420 + 43% sulla parte eccedente i 75.000
Esecuzione del programma:
Il programma(console application), deve richiedere uno per volta tutte le proprietà del contribuente, che da
tastiera verranno immesse e memorizzate nell'oggetto, successivamente proponga un risultato riepilogativo simile al
seguente:
==================================================
CALCOLO DELL'IMPOSTA DA VERSARE:
Contribuente: Mario Rossi,
nato il 15/07/1961 (M),
residente in Palermo,
codice fiscale: MRORSI61LIKSNNNS
Reddito dichiarato: 17.850,00
IMPOSTA DA VERSARE: € 4.219,50 */
double RD;
string R1;
string N;
string C;
string S;
string D;
string F;
string R;


Console.WriteLine("Irpef 2023");
Console.WriteLine("Inserisci nome");
N = Console.ReadLine();

Console.WriteLine("Inserisci cognome");
C = Console.ReadLine();
Console.WriteLine("Inserisci sesso");
S = Console.ReadLine();
Console.WriteLine("Inserisci Data di Nascita");
D = Console.ReadLine();
Console.WriteLine("Inserisci Codice Fiscale");
F = Console.ReadLine();
Console.WriteLine("Inserisci Comune di residenza");
R = Console.ReadLine();
Console.WriteLine("Inserisci Reddito annuale Lordo");
R1 = Console.ReadLine();
RD = Convert.ToDouble(R1);

if (RD <= 15000)
{

    Scaglioni Irpef23 = new Scaglioni(N, C, D, R, S, F, RD);
    Console.Clear();
    Console.Write($" IRPEF 2023 Da Pagare Entro il 2024 \n Contribuente:  {N} {C} \n nato il {D} ({S}) \n residente in {R} \n codice fiscale:{F} \n IMPOSTA DA VERSARE: Euro  {Irpef23.Area1(RD)}");

}
else if (RD >= 15001 && RD <= 28000)
{
    Scaglioni Irpef23 = new Scaglioni(N, C, D, R, S, F, RD);
    Console.Clear();
    Console.Write($" IRPEF 2023 Da Pagare Entro il 2024 \n Contribuente:  {N} {C} \n nato il {D} ({S}) \n residente in {R} \n codice fiscale:{F} \n IMPOSTA DA VERSARE: Euro {Irpef23.Area2(RD)}");
}
else if (RD >= 28001 && RD <= 55000)
{
    Scaglioni Irpef23 = new Scaglioni(N, C, D, R, S, F, RD);
    Console.Clear();
    Console.Write($" IRPEF 2023 Da Pagare Entro il 2024 \n Contribuente:  {N} {C} \n nato il {D} ({S}) \n residente in {R} \n codice fiscale:{F} \n IMPOSTA DA VERSARE: Euro {Irpef23.Area3(RD)}");

}
else if (RD >= 55001 && RD <= 75000) 
{
    Scaglioni Irpef23 = new Scaglioni(N, C, D, R, S, F, RD);
    Console.Clear();
    Console.Write($" IRPEF 2023 Da Pagare Entro il 2024 \n Contribuente:  {N} {C} \n nato il {D} ({S}) \n residente in {R} \n codice fiscale:{F} \n IMPOSTA DA VERSARE: EUro {Irpef23.Area4(RD)}");

}
else   
{
    Scaglioni Irpef23 = new Scaglioni(N, C, D, R, S, F, RD);
    Console.Clear();
    Console.Write($" IRPEF 2023 Da Pagare Entro il 2024 \n Contribuente:  {N} {C} \n nato il {D} ({S}) \n residente in {R} \n codice fiscale:{F} \n IMPOSTA DA VERSARE: € {Irpef23.Area5(RD)}");

}


public class Scaglioni

{
    string _Nome;
    string _Cognome;
    string _DataNascita;
    string _Residenza;
    string _Fiscale;
    string _Sesso;
    double _RedditoD;
 


    public Scaglioni(string Nome, string Cognome, string DataNascita, string Residenza,string Sesso, string Fiscale,double RedditoD)
    {
        
        this._Nome = Nome;
        this._Cognome= Cognome;
        this._DataNascita= DataNascita;
        this._Residenza = Residenza;
        this._Sesso = Sesso;
        this._Fiscale = Fiscale;
        this._RedditoD = RedditoD;

    }
    public double Area1(double RedditoD)
    {
        double CalcoloScaglioni = RedditoD - 0 ;
        double CalcoloALiquota = CalcoloScaglioni * 23 / 100;
        double SommaIrpef = CalcoloALiquota;
        return SommaIrpef;
    }
    public double Area2(double RedditoD)
    {
        double CalcoloScaglioni = RedditoD - 15000;
        double CalcoloALiquota = CalcoloScaglioni * 27 / 100;
        double SommaIrpef = CalcoloALiquota + 3450;
        return SommaIrpef;

    }
    public double Area3(double RedditoD)
    {
        double CalcoloScaglioni = RedditoD -28000;
        double CalcoloALiquota = CalcoloScaglioni * 38 / 100;
        double SommaIrpef = CalcoloALiquota + 6960;
        return SommaIrpef;
    }
    public double Area4(double RedditoD)
    {
        double CalcoloScaglioni = RedditoD - 55000;
        double CalcoloALiquota = CalcoloScaglioni * 41 / 100;
        double SommaIrpef = CalcoloALiquota + 17220;
        return SommaIrpef;
    }
    public double Area5(double RedditoD)
    {
        double CalcoloScaglioni = RedditoD - 75000;
        double CalcoloALiquota = CalcoloScaglioni * 43 / 100;
        double SommaIrpef = CalcoloALiquota + 25420;
        return SommaIrpef;
    }

}
//per gestione settaggio data: DateTime dataNascita = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null)