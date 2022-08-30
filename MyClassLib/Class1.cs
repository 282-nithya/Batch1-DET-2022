namespace MyClassLib
{
    internal interface ICar
    {
        int Getprice(string Name);
    }

    class BMW : ICar
    {
        public int Getprice(string Name)
        {
            if (Name == "M3")
                return 1300000;
            else if (Name == "x7")
                return 9600000;
            else
                return 1000000;
        }
    }
    class Hyundai : ICar
    {
        public int Getprice(string Name)
        {
            if (Name == "kona")
                return 2400000;
            else if (Name == "alcazar")
                return 1500000;
            else
                return 700000;
        }
    }
}