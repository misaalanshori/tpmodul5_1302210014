namespace tpmodul5_1302210014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric.SapaUser<String>("Isa");
            DataGeneric<String> data = new DataGeneric<String>("1302210014");
            data.PrintData();
        }
    }
}