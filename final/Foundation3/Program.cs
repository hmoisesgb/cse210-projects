using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("4446 Jarvis Street","Buffalo","New York","USA");
        Address a2 = new Address("1227 Timber Oak Drive","Amarillo","Texas","USA");
        Address a3 = new Address("3274 Cottrill Lane","Saint Louis","Missouri","USA");

        Lecture e1 = new Lecture("2019 Cobb Family Lecture Series","The China-Jamaica Capital Connection","February 5, 2024","5:00 PM","Lecture",a1,"Richard L Bernal",100);
        Reception e2 = new Reception("Daphne and Raphael Wedding","We invite you to the wedding of Daphne and Raphael","September 6, 2023", "2:00 PM","Reception",a2,"wedding@email.com");
        Outdoor e3 = new Outdoor("Summer Party","We invite you to our special Summer Party, there will be games and prizes", "July 24, 2023","4:00 PM","Outdoor Event", a3,"In the event of inclement weather you can follow the instructions in our website.");

        Console.WriteLine("-------Lecture Event-------");
        e1.ShowStandardDetails();
        Console.WriteLine();
        e1.ShowFullDetails();
        Console.WriteLine();
        e1.ShowShortDescription();
        Console.WriteLine();

        Console.WriteLine("-------Reception Event-------");
        e2.ShowStandardDetails();
        Console.WriteLine();
        e2.ShowFullDetails();
        Console.WriteLine();
        e2.ShowShortDescription();
        Console.WriteLine();

        Console.WriteLine("-------Outdoor Event-------");
        e3.ShowStandardDetails();
        Console.WriteLine();
        e3.ShowFullDetails();
        Console.WriteLine();
        e3.ShowShortDescription();
        Console.WriteLine();
        

    }
}