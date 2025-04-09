using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Net.Sockets;

namespace modul7_kelompok6
{
    class TeamMembers103022300072
    {
        public List<Member> members { get; set; }

        public class Member
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public string nim { get; set; }
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_2_103022300072.json";
            string jsonString = File.ReadAllText(filePath);

            var data = JsonSerializer.Deserialize<TeamMembers103022300072>(jsonString);

            Console.Write("Team Member List: "); 
            Console.WriteLine();
            foreach (var member in data.members)
            {
                Console.WriteLine(member.nim + " " + member.firstName + " " + member.lastName + " (" + member.age + " " + member.gender + ") ");
            }
        }
    }
}
