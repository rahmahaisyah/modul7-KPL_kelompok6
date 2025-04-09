using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul7_kelompok6
{
    class TeamMembers103022300071
    {
        public class member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public class listMember
        {
            public List<member> members { get; set; }
        }

        public static void ReadJSON()
        {
            try
            {
                string filePath = "jurnal7_2_103022300071.json";
                string jsonContent = File.ReadAllText(filePath);

                var data = JsonConvert.DeserializeObject<listMember>(jsonContent);

                Console.WriteLine("Daftar anggota kelompok:");
                int i = 1;
                foreach (member m in data.members)
                {
                    Console.WriteLine("Nama : " + m.firstName + " " + m.lastName);
                    Console.WriteLine("Jenis Kelamin : " + m.gender);
                    Console.WriteLine("Umur : " + m.age);
                    Console.WriteLine("NIM : " + m.nim);
                    i++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi kesalahan saat membaca file JSON: " + e.Message);
            }
        }
    }
}
