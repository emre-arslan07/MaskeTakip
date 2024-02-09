using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
	public class Program
	{
		static void Main(string[] args)
		{
			Person person=new Person();
            Console.WriteLine("Adınızı Giriniz:");
			string name=Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
			string surName=Console.ReadLine();
            Console.WriteLine("Doğum Yılınız Giriniz:");
			int birthdate=int.Parse(Console.ReadLine());
            Console.WriteLine("Kimlik Numaranızı Giriniz");
			long nationalId=long.Parse(Console.ReadLine());
			person.FirstName = name;
			person.LastName = surName;
			person.DateofBirthYear = birthdate;
			person.NationalIdentity = nationalId;

			PttManager pttManager = new PttManager(new PersonManager());
			pttManager.GiveMask(person);
			Console.ReadLine();
		}
	}
}
