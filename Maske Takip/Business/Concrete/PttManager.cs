using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager:ISupplierService
{
    private IApplicantService _applicantService;//fieldlar classın içerisinde alt çizgi ile yazılır.
    public PttManager(IApplicantService applicantService) { //constructor
        _applicantService = applicantService;//classlarda fieldların _ile başlamasının sebebi constructorlarda set etmemizdir.
    }
    public void GiveMask(Person person)
    {

        //PersonManager personManager = new PersonManager();//Bir iş sınıfı başka bir iş sınıfını kullanırken newliyor ise ileriye dönük değişiklik talebinde bu uygulama direnç gösterir
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine($"{person.FirstName} için maskesi verildi");
        }
        else {
            Console.WriteLine($"{person.FirstName} için maskesi verilemedi");
        }

    }
}
