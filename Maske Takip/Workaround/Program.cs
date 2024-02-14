
using Business.Concrete;
using Entities.Concrete;
using System;
Person person1=new Person();
person1.FirstName = "Emrah";
person1.LastName = "Akan";
person1.DateOfBirthYear = 1999;
person1.NationalIdentitiy = 123;
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

/*----default parametre
static void SelamVer(string isim = "noname") {//default paramaetre fonksiyon çağırılmaz ise yerine noname değeri gelecek.
    Console.WriteLine($"Merhaba {isim}");
}
SelamVer("Emrah");
SelamVer();//default parametre gönderdik 
*/


//------
//static int /*Dönecek Olan değerin tipi*/Topla(int sayi1,int sayi2)/*gelen parametrelerin tipi*/ {
//    int toplam = sayi1 + sayi2;// local değişken tanımladık sadece bu fonksiyonda geçerli toplam değişkeni
//    return toplam;
//}

//Topla(3, 5);


/*
------list
List<string> yeniSehirler = new List<string>() { "Gümüşhane","Adıyaman","Düzce"};
yeniSehirler.Add("Tekirdağ");
*/
/*
Referans Tipler
string[] ogrenciler = new string[3];
ogrenciler[0] = "Emrah";
ogrenciler[1] = "Ayşe";
ogrenciler[2] = "Emay";
ogrenciler=new string[4]; //burada new string tanımladığımız anda heap kısmında tutulan yeni 4 alanlı bir yer açılır 
//ve bu kısımlar boştur 4. kısmına ise ayem eklenir yani ekrana yazdırdığımızda bize sadece Ayem gelmektedir.
ogrenciler[3] = "Ayem";

string[] sehirler1 = new[] {"Ankara","Kocaeli","İstanbul"};
string[] sehirler2 = new[] { "Hakkari", "Şırnak", "Van" };
sehirler1 = sehirler2;//dersek eğer stack kısmında tutulan sehirler 1 referans olarak sehirler 2 nin 
//heap kısmında ayrılan alanlarını alır ve orayı işaret eder
sehirler1[0] = "Çanakkale";//Dediğimizde sehirler 2 nin hakkari yazan elemanı öanakkale olur 
//çünkü artık sehirler 1 de referans olarak sehirler 2 yi almakta
 
 */

/*
 Değer Tipler
sayi1=10;
sayi2=20;
sayi2=sayi1;
sayi1=30;
sayi2=??--->10 değerini alır
burada ise değer veri tipler üzerinde çalıştığımızdan hepsi stack kısmında tutulur ve referans almazlar.
olaylar değer seviyesinde olur .
 */