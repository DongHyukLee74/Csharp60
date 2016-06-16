using System;
using System.Data;

namespace Ex0649
{
    class Program
    {
        static void Main(string[] args)
        {
            DataColumn nameCol = new DataColumn("Name", typeof(string));
            DataColumn birthCol = new DataColumn("Birth", typeof(DateTime));
            DataColumn emailCol = new DataColumn("Email", typeof(string));
            DataColumn familyCol = new DataColumn("Family", typeof(byte));
        }
    }
}
