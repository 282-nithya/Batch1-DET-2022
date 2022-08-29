//// See https://aka.ms/new-console-template for more information
using Batch1_DET_2022;

class MyClass
{
    //enum Grade { Pass = 60, Distinction = 85 };
    ///// <summary>
    ///// method that returns Grade based on the mark
    ///// </summary>
    ///// <param name="mark">mark as the input</param>
    ///// <returns></returns>
    //public static string GetGrade(int mark);//IN parameter
    ////{
    ////    if (mark >= (int)Grade.Distinction)
    ////        return "Distinction";
    ////    else if (mark >= (int)Grade.Pass)
    ////       return "PASS"; 
    ////    else
    ////        return "FAIL";
    ////}
    public static void Main()
    {


        //#region "containment"
        //CompanyManager m = new CompanyManager { Name = "nithya", Surname = "S", Phone = "987557767" };
        //Company company = new Company { Name = "SSL", Address = "global city", Manager = m, Phone = "87876865", website = "sonata-software.com" };
        //Console.WriteLine(company.Print());


        //try
        //{
        //    Employe m = new Manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor
        //                                                                                           // Console.WriteLine(m.Print());

        //    Employe m1 = new Manager(2345, "Jeeva", new  DateOnly(2010, 1, 14), "PEMS", 450);
        //    // Console.WriteLine(m1.Print());  //base class ref can point to derived object

        //    Employe e1 = new Employe(1, "Jiyana", new DateOnly(2020, 1, 5));
        //    //Console.WriteLine(e1.Print());

        //    Console.WriteLine("enter empid b.w 1001 - 25000");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    if (id < 1001 || id > 25000)
        //        throw new InvalidEmployeidException("Entered empid is not in the range...");

        //    Console.WriteLine("enter emp name");
        //    string name = Console.ReadLine();

        //    Console.WriteLine("enter doj");
        //    DateOnly doj = DateOnly.Parse(Console.ReadLine());

        //    Employe e2 = new(id, name, doj);


        //    List<Employe> list = new List<Employe>();
        //    list.Add(m);
        //    list.Add(m1);
        //    list.Add(e1);
        //    foreach (Employe x in list)
        //        Console.WriteLine(x.Print());
        //}
        //catch (InvalidEmployeidException e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //catch (Exception e)
        //{ }






        //try
        //{
        //    Console.WriteLine("enter age btw 0- 100");
        //    int age = Convert.ToInt32(Console.ReadLine());
        //    if (age > 120)
        //        throw new InvaildAge.("age is invalid");
        //}
        //catch (InvaildAge.e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //catch (Exception e)
        //{


        //}

        //#endregion

        List<Animal> animal = new List<Animal>();
        animal.Add(new Dog());
        animal.Add(new cat());

        foreach (Animal a in animal)
            Console.WriteLine(a.MakeSounds());
    }
}