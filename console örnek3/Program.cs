Console.Write("Bölünecek sayıyı giriniz. : ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Bölen sayıyı giriniz : ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

for (int i = sayi2; i <= sayi1;)
{
    sayi1 = sayi1 - i;
}

Console.WriteLine(sayi1);


//Sadece Toplama ve Çıkarma kullanılarak Bölme İşlemi