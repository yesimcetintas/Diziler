// See https://aka.ms/new-console-template for more information

// dizi tanımlama

string[] renkler = new string[5];

string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Maymun"};

int[] dizi;
dizi = new int[4];

// Dizilere değer atama ve erişim

renkler[0] = "Mavi";
dizi[3] = 10;

Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);
Console.WriteLine(hayvanlar[1]);

// döngülerle dizi kullanımı

// klavyeden girilen n tane sayının ortalamasını alan program

Console.Write("Lütfen dizinin eleman sayısını giriniz:");
int arrayLength = int.Parse(Console.ReadLine());

int[] numberArray = new int[arrayLength];

for (int i = 0; i < arrayLength; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz: ",i+1);
    numberArray[i] = int.Parse(Console.ReadLine());
}

int total = 0;

foreach (var number in numberArray)
{
    total += number;
}

Console.WriteLine("Ortalama:" + total/arrayLength);
