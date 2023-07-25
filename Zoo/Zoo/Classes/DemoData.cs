using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Zoo.Enums;

namespace Zoo
{
    public class DemoData
    {
     
        public static Zoo FillZoo()
        {
            Zoo zoo = new Zoo();
            zoo.ZooName = "Priecigie Titari";
            zoo.Address = "Riga, Valnu iela 4";
            zoo.Tigers = GetTigers();
            zoo.Shark = GetShark();
            zoo.Eagles = GetEagles();
            return zoo;
        }
        #region Generate Tigers
        private static List<Tiger> GetTigers()
        {
            Helper help = new Helper();
            List<Tiger> lsTigers = new List<Tiger>();
            Tiger tiger = new Tiger();
            int crateSize = help.GetRndNumber(250, 750);
            for (int x = 0; x < help.GetRndNumber(1, 8); x++)
            {
                lsTigers.Add(GenTiger(crateSize));
            }
            return lsTigers;
        }
        private static List<Tiger> GetTigers(int count)
        {
            Helper help = new Helper();
            List<Tiger> lsTigers = new List<Tiger>();
            Tiger tiger = new Tiger();
            int crateSize = help.GetRndNumber(250, 750);
            for (int x = 0; x < count; x++)
            {
                lsTigers.Add(GenTiger(crateSize));
            }
            return lsTigers;
        }
        private static Tiger GenTiger(int crateSize)
        {
            Random rnd  =  new Random();
            Helper help = new Helper();
            Tiger tiger = new Tiger();
            tiger.Weight = help.GetRndNumber(100, 300);
            tiger.Striper = help.GetRndNumber(50, 150);
            tiger.Age = help.GetRndNumber(1, 15);
            tiger.NailLength = help.GetRndDouble(1, 8);
            tiger.CrateSize = crateSize;
            tiger.AnimalType = AnimalType.Mammal;
            tiger.Enhabitat = Enhabitat.Land;
            tiger.Name = GetRndName();
            tiger.Sex = help.GetRndBool() == true ? Sex.Male : Sex.Female;
            tiger.Speed = help.GetRndDouble(49, 65);
            tiger.Color = Enum.GetValues(typeof(AnimalColor))
                .Cast<AnimalColor>()
                .OrderBy(x => rnd.Next())
                .FirstOrDefault();
            return tiger;
        }
        #endregion
        #region Generate Sharks
        private static Shark GetShark() 
        {
            Helper help = new Helper();
            Shark shark = new Shark();
            //shark.ShrkBreed = GetRndBreed(breedArray[GetRndNumber(0, 2)]);
            shark.Age = help.GetRndNumber(1, 30);
            shark.Weight = help.GetRndNumber(1, 1100);
            shark.Length = help.GetRndDouble(1, 5);
            shark.AnimalType = AnimalType.Fish;
            shark.Dept = help.GetRndNumber(1, 2000);
            shark.Enhabitat = Enhabitat.Water;
            shark.Name = GetRndName();
            shark.KillCount = help.GetRndNumber(1, 100);
            shark.Speed = help.GetRndNumber(1, 19);
            shark.Sex = help.GetRndBool() == true ? Sex.Male : Sex.Female;
            return shark;
        }
        #endregion
        #region
        private static List<Eagle> GetEagles()
        {
            Helper help = new Helper();
            List<Eagle> lsEagles = new List<Eagle>();
            int crateSize = help.GetRndNumber(250, 750);
            for (int y = 0; y < help.GetRndNumber(1, 6); y++)
            {
                lsEagles.Add(GenEagle(crateSize));
            }
            return lsEagles;
        }
        private static Eagle GenEagle(int crateSize)
        {
            Helper help  = new Helper();
            Eagle eagle = new Eagle();
            eagle.Weight = help.GetRndNumber(3, 10);
            eagle.EggWeight = help.GetRndNumber(100, 200);
            eagle.Altitude = help.GetRndNumber(1, 9);
            eagle.Age = help.GetRndNumber(1, 45);
            eagle.AnimalType = AnimalType.Bird;
            eagle.CrateSize = crateSize;
            eagle.Enhabitat = Enhabitat.Air;
            eagle.Name = GetRndName();
            eagle.Sex = help.GetRndBool() == true ? Sex.Male : Sex.Female;
            eagle.WndSpan = help.GetRndDouble(1, 3);
            return eagle;
        }
        #endregion
        private static string GetRndName()
        {
            Thread.Sleep(250);
            Helper help = new Helper();
            List<string> lsNames = new List<string> { "Hitlers", "Muris", "Charlie", "Cookie", "Tony", "Fluffy", "Simba", "Aluminijs", "Zumba", "Skippy", "Uldis", "Nemo" };
            return lsNames[help.GetRndNumber(0, lsNames.Count() - 1)];
        }
        private static string GetRndName(int number)
        {
            List<string> lsNames = new List<string> { "Hitlers", "Muris", "Charlie", "Cookie", "Tony", "Fluffy", "Simba", "Aluminijs", "Zumba", "Skippy", "Uldis", "Nemo" };
            return lsNames[number];
        }
        public static List<int> GetDummyNumberList()
        {
            Helper help = new Helper();
            List<int> numbers = new List<int>();
            for (int x = 0; x < help.GetRndNumber(5, 20); x++)
            {
                numbers.Add(help.GetRndNumber(1, 100));
            }
            return numbers;
        }
    }
}
