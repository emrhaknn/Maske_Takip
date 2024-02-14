using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface IApplicantService //Belli metot imzalaarını barındırırlar birbirinin alternatifi olan sistemlerin farklı implementasyon yapmalarını sağlarlar
    //yani yabancı uyrukluyu farklı şekilde kontrol ederiz  tc uyrukluyu farklı şekilde kontrol edebiliriz 
    //kurallarının yazımı farklıdır 
    //tek sınıfta kontrol etmeye çalışırsak if bloklarımız artacak ve kodumuz kalitesizleşecektir
    //eğer kullanmasaydık if(person nationality!=0)ise kontrol yapıp öyle devam edecektik
{
    void ApplyForMask(Person person);


    List<Person> GetAll();//içerisinde verdiğimiz tipte(person) bir listedir.Bana bir liste ver türü person olan demek


    bool CheckPerson(Person person);

}
