using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGenerator
{
    public class generator
    {
        public int[] Chain;
        public string Word;
        public Random rndMain = new Random();
        public string Generate(int count, bool ba_syll, bool finalize)
        {
            letterData.Init();
            syllableData.Init();
            Chain = new int[count];
            if (!ba_syll)
            {
                Chain[0] = rndMain.Next(0, 3);
                for (int i = 1; i < count; i += 1)
                {
                    Chain[i] = addGenerate(Chain[i-1]);
                }
                //llalallalalala
            }
            else
            {
                for (int i = 0; i < count; i += 1)
                {
                    Chain[i] = 2;
                }
            }
            Word = "";
            for (int i = 0; i < count; i += 1)
            {
                Word += syllGenerate(Chain[i]);
            }
            if (finalize)
            {
                Word += syllableData.dictSyllFin[rndMain.Next(0, syllableData.dictSyllFin.Count - 2)];
            }
            return Word;
        }
        public int addGenerate(int old)
        {
            
            int type = 0;
            if (old == 0) type = 2;
            else if (old == 1) type = rndMain.Next(0, 2);
            else if (old == 2) type = rndMain.Next(1, 4);
            else if (old == 3) type = rndMain.Next(0, 2);
            return type;
        }
        public string syllGenerate(int type)
        {
            string syll = "";
            if (type == 0) syll = syllableData.dictSyllAA[rndMain.Next(0, syllableData.dictSyllAA.Count - 2)];
            else if (type == 1) syll = syllableData.ABgenerator();
            else if (type == 2) syll = syllableData.BAgenerator();
            else if (type == 3) syll = syllableData.dictSyllBB[rndMain.Next(0, syllableData.dictSyllBB.Count - 2)];
            return syll;
        }
    }
}
