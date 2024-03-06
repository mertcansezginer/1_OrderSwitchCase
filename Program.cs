
Console.WriteLine("Lutfen siparis numaranizi giriniz: ");
int siparisNumarasi = Convert.ToInt32(Console.ReadLine());

switch (siparisNumarasi)
{
    case 100:
        Console.WriteLine("Siparis edilen urun : Ayran 1L");
        break;
    case 101:
        Console.WriteLine("Siparis edilen urun : Ezine Peyniri 1KG");
        break;
    case 102:
        Console.WriteLine("Siparis edilen urun : Kasar Peyniri 1KG");
        break;
    case 103:
        Console.WriteLine("Siparis edilen urun : Gemlik Zeytin 0.5KG");
        break;
    default:
        Console.WriteLine("Gecersiz bir siparis numarasi girdiniz");
        break;


}
 


