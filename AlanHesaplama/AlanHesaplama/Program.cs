using System;
//Geometrik Şekil sınıfı (temel sınıf)
public abstract class GeometrikSekil
{
    public abstract double AlanHesapla();
    public abstract double CevreHesapla();
    public abstract double HacimHesapla(double yukseklik);

}
// Daire sınıfı
public class Daire : GeometrikSekil
{
    private double yaricap;
    public Daire(double yaricap)
    {
        this.yaricap = yaricap;
    }
    public override double AlanHesapla()
    {
        return yaricap*Math.PI*yaricap;
    }
    public override double CevreHesapla()
    {
        return 2*Math.PI*yaricap;
    }
    public override double HacimHesapla(double yukseklik)
    {
        return 0;//Daire 2D bir şekildir hacmi yoktur

    }

}
//Ucgen sınıfı
public class Ucgen :GeometrikSekil
{
    private double a;
    private double b;
    private double c;
    public Ucgen(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    public override double AlanHesapla()
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
    public override double CevreHesapla()
    {
        return a+ b + c;
    }
    public override double HacimHesapla(double yukseklik)
    {
        return (AlanHesapla() * yukseklik) / 3; // Üçgenin hacmi, (Taban Alanı * Yükseklik) / 3 şeklinde hesaplanır.
    }
}
//Kare Sınıfı
public class Kare:GeometrikSekil
{
    private double kenarUzunlugu;
    public Kare(double kenarUzunlugu)
    {
        this.kenarUzunlugu = kenarUzunlugu;
    }
    public override double AlanHesapla()
    {
        return kenarUzunlugu * kenarUzunlugu;
    }
    public override double CevreHesapla()
    {
        return 4 * kenarUzunlugu;
    }
    public override double HacimHesapla(double yukseklik)
    {
        return kenarUzunlugu*kenarUzunlugu*yukseklik;
    }
}
//Konsol uygulaması
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Geometrik Şekil Hesaplamaları");
        Console.Write("Lutfen geometrik şekli girin =>Daire,Ucgen,Kare");
        string sekilAdi = Console.ReadLine();
        GeometrikSekil sekil = null;
        switch (sekilAdi.ToLower())
        {
            case "daire":
                Console.Write("Dairenin yarıçapını giriniz");
                double daireYariCap = double.Parse(Console.ReadLine());
                sekil = new Daire(daireYariCap);
                break;
            case "ucgen":
                Console.Write("Üçgenin a kenarını girin: ");
                double ucgenA = double.Parse(Console.ReadLine());
                Console.Write("Üçgenin b kenarını girin: ");
                double ucgenB = double.Parse(Console.ReadLine());
                Console.Write("Üçgenin c kenarını girin: ");
                double ucgenC = double.Parse(Console.ReadLine());
                sekil = new Ucgen(ucgenA, ucgenB, ucgenC);
                break;
            case "kare":
                Console.Write("Karenin kenar uzunluğunu girin: ");
                double kareKenarUzunlugu = double.Parse(Console.ReadLine());
                sekil = new Kare(kareKenarUzunlugu);
                break;

            default:
                Console.WriteLine("Geçersiz bir geometrik şekil girdiniz.");
                return;
        }
        Console.Write("Hesaplanmak istenen boyutu seçin (Alan, Cevre, Hacim)");
        string boyut = Console.ReadLine();

        switch (boyut.ToLower())
        {
            case "alan":
                Console.WriteLine($"{sekilAdi} alanı: {sekil.AlanHesapla()}");
                break;

            case "cevre":
                Console.WriteLine($"{sekilAdi} çevresi: {sekil.CevreHesapla()}");
                break;

            case "hacim":
                Console.Write("Yüksekliği girin: ");
                double yukseklik = double.Parse(Console.ReadLine());
                Console.WriteLine($"{sekilAdi} hacmi: {sekil.HacimHesapla(yukseklik)}");
                break;

            default:
                Console.WriteLine("Geçersiz bir boyut seçtiniz.");
                break;
        }
    }
}

    



