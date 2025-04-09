using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok6
{
    class DataMahasiswa103022300071
    {
        
        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }
        public class Courses
        {
            public string code { get; set; }
            public string name { get; set; }
        }
        public class Mahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address address { get; set; }
            public List<Courses> courses { get; set; }
            
        }
        public static void ReadJSON()
        {
            string filepath = "jurnal7_1_103022300071.json";
            try
            {
                string jsonString = File.ReadAllText(filepath);
                var mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString);
                Console.WriteLine("Nama : " + mhs.firstName + " " + mhs.lastName);
                Console.WriteLine("Jenis Kelamin : " + mhs.gender);
                Console.WriteLine("Umur : " + mhs.age);
                Console.WriteLine("Alamat : " + mhs.address.streetAddress + ", " + mhs.address.city + ", " + mhs.address.state);
                Console.WriteLine("Daftar mata kuliah:");
                int i = 1;
                foreach (var course in mhs.courses)
                {
                    Console.WriteLine("MK" + i + " " + course.code + " - " + course.name);
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
