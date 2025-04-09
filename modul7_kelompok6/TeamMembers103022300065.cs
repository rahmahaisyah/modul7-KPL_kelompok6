using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace modul7_kelompok6
{
    class TeamMembers103022300065
    {
        public class Member
        {
            public string firstName { get; set; } = string.Empty;
            public string lastName { get; set; } = string.Empty;
            public string gender { get; set; } = string.Empty;
            public int age { get; set; }
            public string nim { get; set; } = string.Empty;
        }

        public class MemberList
        {
            public List<Member> members { get; set; } = new List<Member>();
        }

        public static void ReadJSON()
        {
            string filePath = "jurnal7_2_103022300065.json";

            try
            {
                string jsonContent = File.ReadAllText(filePath);

                MemberList? memberList = JsonSerializer.Deserialize<MemberList>(jsonContent);

                if (memberList != null && memberList.members.Count > 0)
                {
                    Console.WriteLine("Data Anggota Kelompok:");
                    foreach (var member in memberList.members)
                    {
                        Console.WriteLine($"Nama: {member.firstName} {member.lastName}, Gender: {member.gender}, Umur: {member.age}, NIM: {member.nim}");
                    }
                }
                else
                {
                    Console.WriteLine("Data anggota kelompok kosong atau format JSON salah.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal membaca file JSON: " + e.Message);
            }
        }
    }
}
