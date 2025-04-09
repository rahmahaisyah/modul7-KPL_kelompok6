using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok6
{
    public class Memeber
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public long age { get; set; }
        public string nim { get; set; }
    }

    public class MemberList
    {
        public List<Memeber> members { get; set; }
    }
    class TeamMembers103022300014
    {
        public static void ReadJSON()
        {
            //path file json
            string filePath = "jurnal7_2_103022300014.json";

            //baca isi file
            string jsonString = File.ReadAllText(filePath);

            //deserialisasi ke object mahasiswa
            MemberList data = JsonSerializer.Deserialize<MemberList>(jsonString);

            //cetak format
            Console.WriteLine("Team member list:");
            foreach (var member in data.members)
            {
                Console.WriteLine($"NIM: {member.nim} - {member.firstName} {member.lastName}" +
                    $" dengan umur: {member.age}");
            }
        }
    }
}
