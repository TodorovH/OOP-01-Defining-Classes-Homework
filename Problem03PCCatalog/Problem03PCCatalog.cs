using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03PCCatalog
{
    class Problem03PCCatalog
    {
        static void Main(string[] args)
        {
            Component processor1 = new Component("AMD A4 4000", (decimal)63.00, "(FM2, 3.2GHz, 1MB, 7480D)");
            Component processor2 = new Component("Intel CPU Celeron", (decimal)69.00);
            Component processor3 = new Component("Intel CPU Celeron G1850", (decimal)99.00, "(1150/2.9GHz/2Mb)");

            Component motherboard1 = new Component("MSI AM1i", (decimal)54.00, "(AM1/DDR3/Mini-iTX)");
            Component motherboard2 = new Component("Gigabyte H61M-S2PV", (decimal)75.00, "(s1155, H61, DDR3)");
            Component motherboard3 = new Component("Gigabyte H81M-S2PV", (decimal)79.00, "(1150/H81/DDR3)");

            Component graphicsCard1 = new Component("Palit GT 210", (decimal)53.00);
            Component graphicsCard2 = new Component("MSI", (decimal)54.00, "VGA PCI-Е N210-MD1GD3H/LP 1GB");
            Component graphicsCard3 = new Component("Sapphire 5450", (decimal)55.00, "1GB DDR3");

            Component ram1 = new Component("Adata", (decimal)18.00, "1GB DDR3-1333 Ram Dimm Bulk (PC3-10666, SU3U1333B1G9-B)");
            Component ram2 = new Component("TeamGroup RAM", (decimal)35.00, "DDR3 2GB DIMM 1333MHz Bulk");
            Component ram3 = new Component("Transcend", (decimal)35.00, "DDR3 2GB Dimm 1333MHz (Bulk Edition)");

            Component hdd1 = new Component("Toshiba", (decimal)84.00, "DT01ACA050 500GB HDD 3.5\" (32MB Cache, 7200RPM, Sata 6Gb/s)");
            Component hdd2 = new Component("Western Digital Caviar Blue ", (decimal)95.00, "WD5000AAKX 500GB HDD 3.5\" (16MB Cache, 7200RPM, Sata 6Gb/s)");
            Component hdd3 = new Component("Toshiba", (decimal)99.00, "DT01ACA100 1TB HDD 3.5\" (32MB Cache, 7200RPM, Sata 6Gb/s)");

            Component powerSupply1 = new Component("Turbo-X", (decimal)39.00, "400W Value Series");
            Component powerSupply2 = new Component("Turbo-X", (decimal)59.00, "450W Value Series II");
            Component powerSupply3 = new Component("Turbo-X", (decimal)79.00, "550W Value Series II");

            Component box1 = new Component("Turbo-X", (decimal)39.00, "Case A13 Piano Black - Midi");
            Component box2 = new Component("Turbo-X", (decimal)39.00, "Sphere III Midi Tower");
            Component box3 = new Component("Fazn A18", (decimal)45.00, "Piano Black - Midi (A1008)");

            Computer pc1 = new Computer("First", processor1, motherboard1, graphicsCard1, ram1, hdd1, powerSupply1, box1);
            Computer pc2 = new Computer("Second", processor2, motherboard2, graphicsCard2, ram2, hdd2, powerSupply2, box2);
            Computer pc3 = new Computer("Third", processor3, motherboard3, graphicsCard3, ram3, hdd3, powerSupply3, box3);
            Computer pc4 = new Computer("Forth", processor1, graphicsCard2, ram1, hdd3, powerSupply1, box3);
            Computer pc5 = new Computer("Fifth", processor1, motherboard2, ram1, hdd1, box2);
            Computer pc6 = new Computer("Sixth", processor2, motherboard3, graphicsCard1, powerSupply3, box1);

            List<Computer> compList = new List<Computer>();
            compList.Add(pc1);
            compList.Add(pc2);
            compList.Add(pc3);
            compList.Add(pc4);
            compList.Add(pc5);
            compList.Add(pc6);

            List<Computer> newList = new List<Computer>();

            newList = compList.OrderBy(c => c.TotalPrice).ToList();

            foreach (var c in newList)
            {
                Console.WriteLine(c.ToString());
                Console.WriteLine();
            }
        }
    }
}
