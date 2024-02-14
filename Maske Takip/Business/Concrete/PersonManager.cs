using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PersonManager:IApplicantService
{
    /*Encapsulation
    public void ApplyForMask(string id,string LastNamae) { 
    şeklinde kullanacaktık ancak biz bu verileri bir person classının içerissinde tuttuk
    böylelikle herhangi bir ekleme olacak ise örneğin string tcno eklenecek ise person clasına giderek ekleme yaparız 
    bu metodu kullandığımız her yerde tcno kısmını eklemek zorunda kalmayız
    }
     */
    public void ApplyForMask(Person person) { 
    
    }

    public List<Person> GetAll()//içerisinde verdiğimiz tipte(person) bir listedir.Bana bir liste ver türü person olan demek
    {
        return null;
    }
    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest
            (new TCKimlikNoDogrulaRequestBody(person.NationalIdentitiy, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
    }
}

