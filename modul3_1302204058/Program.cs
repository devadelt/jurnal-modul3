// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        KodeBuah table_Kodebuah = new KodeBuah();
        Console.WriteLine("========= GET KODE BUAH APEL =========");
        table_Kodebuah.getKodebuah("Apel");
        Console.WriteLine("==== GET ALL KODE BUAH ====");
        table_Kodebuah.getAllkodebuah();
        /////////////////////////////////////
    }

}


