using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGenerator
{
    static public class syllableData
    {
        static private Random rndMain = new Random();
        static public Dictionary<int, string> dictSyllAA;
        static public Dictionary<int, string> dictSyllAB;
        static public Dictionary<int, string> dictSyllBA;
        static public Dictionary<int, string> dictSyllBB;
        static public Dictionary<int, string> dictSyllFin;
        static public void Init()
        {
            dictSyllAA = new Dictionary<int, string>();
            dictSyllAB = new Dictionary<int, string>();
            dictSyllBA = new Dictionary<int, string>();
            dictSyllBB = new Dictionary<int, string>();
            dictSyllFin = new Dictionary<int, string>();
            dictSyllAA.Add(0, "ao");
            dictSyllAA.Add(1, "eo");
            dictSyllAA.Add(2, "io");
            //
            dictSyllBB.Add(0, "rt");
            dictSyllBB.Add(1, "tr");
            dictSyllBB.Add(2, "kl");
            dictSyllBB.Add(3, "vr");
            dictSyllBB.Add(4, "pr");
            //
            dictSyllFin.Add(0, "ex");
            dictSyllFin.Add(1, "ix");
            dictSyllFin.Add(2, "do");
            dictSyllFin.Add(3, "da");
            dictSyllFin.Add(4, "dar");
            dictSyllFin.Add(5, "tor");
            dictSyllFin.Add(6, "bar");
            dictSyllFin.Add(7, "tar");
            dictSyllFin.Add(8, "ton");
        }
        static public string BAgenerator()
        {
            int index1 = rndMain.Next(0, letterData.letterNonsonant.Length - 2);
            int index2 = rndMain.Next(0, letterData.letterSonant.Length - 2);
            string syll = letterData.letterNonsonant[index1] + letterData.letterSonant[index2];
            return syll;
        }
        static public string ABgenerator()
        {
            int index1 = rndMain.Next(0, letterData.letterSonant.Length - 2);
            int index2 = rndMain.Next(0, letterData.letterNonsonant.Length - 2);
            string syll = letterData.letterSonant[index1] + letterData.letterNonsonant[index2];
            return syll;
        }

    }
}
