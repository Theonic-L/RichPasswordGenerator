using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainGenerator
{
    static class letterData
    {
        static public string[] letterSonant;
        static public string[] letterNonsonant;
        static public void Init()
        {
            LoadPack2();
        }
        static public void LoadPack1()
        {
            letterSonant = new string[5];
            letterNonsonant = new string[12];
            letterSonant[0] = "a";
            letterSonant[1] = "e";
            letterSonant[2] = "i";
            letterSonant[3] = "o";
            letterSonant[4] = "u";
            //
            letterNonsonant[0] = "k";
            letterNonsonant[1] = "l";
            letterNonsonant[2] = "m";
            letterNonsonant[3] = "n";
            letterNonsonant[4] = "p";
            letterNonsonant[5] = "r";
            letterNonsonant[6] = "s";
            letterNonsonant[7] = "t";
            letterNonsonant[8] = "j";
            letterNonsonant[9] = "v";
            letterNonsonant[10] = "b";
            letterNonsonant[11] = "z";
        }
        static public void LoadPack2()
        {
            letterSonant = new string[5];
            letterNonsonant = new string[12];
            letterSonant[0] = "a";
            letterSonant[1] = "e";
            letterSonant[2] = "i";
            letterSonant[3] = "o";
            letterSonant[4] = "u";
            //
            letterNonsonant[0] = "c";
            letterNonsonant[1] = "l";
            letterNonsonant[2] = "m";
            letterNonsonant[3] = "n";
            letterNonsonant[4] = "p";
            letterNonsonant[5] = "r";
            letterNonsonant[6] = "s";
            letterNonsonant[7] = "t";
            letterNonsonant[8] = "h";
            letterNonsonant[9] = "v";
            letterNonsonant[10] = "b";
            letterNonsonant[11] = "g";
        }
    }
}
