using System.Net.Http.Json;

namespace modul7_kelompok6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataMahasiswa103022300071.ReadJSON();
            Console.WriteLine();    
            TeamMembers103022300071.ReadJSON();
        }
    }
}
