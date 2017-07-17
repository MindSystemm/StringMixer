using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MindSystem_Mixer
{
    class StringMixer
    {
        public static string Encrypt(string tocheck)
        {
            string final = "";

            Regex objAlphaPattern = new Regex(@"^[a-zA-Z0-9éèêâ]*$");
            bool sts = objAlphaPattern.IsMatch(tocheck);
            if (!sts)
            {
                return "Special Character found ! Error !";
            }

            for (int i = 0; i < tocheck.Length; i++)
            {
                if (tocheck[i] == 'é')
                {
                    final += "è";
                }
                if (tocheck[i] == 'è')
                {
                    final += "é";
                }
                if (tocheck[i] == 'ê')
                {
                    final += "â";
                }
                if (tocheck[i] == 'â')
                {
                    final += "ê";
                }
                if (tocheck[i] == 'A')
                {
                    final += "Z";
                }
                if (tocheck[i] == 'B')
                {
                    final += "H";
                }
                if (tocheck[i] == 'C')
                {
                    final += "K";
                }
                if (tocheck[i] == 'D')
                {
                    final += "A";
                }
                if (tocheck[i] == 'E')
                {
                    final += "J";
                }
                if (tocheck[i] == 'F')
                {
                    final += "U";
                }
                if (tocheck[i] == 'G')
                {
                    final += "L";
                }
                if (tocheck[i] == 'H')
                {
                    final += "I";
                }
                if (tocheck[i] == 'I')
                {
                    final += "B";
                }
                if (tocheck[i] == 'J')
                {
                    final += "T";
                }
                if (tocheck[i] == 'K')
                {
                    final += "Y";
                }
                if (tocheck[i] == 'L')
                {
                    final += "X";
                }
                if (tocheck[i] == 'M')
                {
                    final += "R";
                }
                if (tocheck[i] == 'N')
                {
                    final += "S";
                }
                if (tocheck[i] == 'O')
                {
                    final += "E";
                }
                if (tocheck[i] == 'P')
                {
                    final += "W";
                }
                if (tocheck[i] == 'Q')
                {
                    final += "V";
                }
                if (tocheck[i] == 'R')
                {
                    final += "G";
                }
                if (tocheck[i] == 'S')
                {
                    final += "O";
                }
                if (tocheck[i] == 'T')
                {
                    final += "Q";
                }
                if (tocheck[i] == 'U')
                {
                    final += "C";
                }
                if (tocheck[i] == 'V')
                {
                    final += "N";
                }
                if (tocheck[i] == 'W')
                {
                    final += "M";
                }
                if (tocheck[i] == 'X')
                {
                    final += "P";
                }
                if (tocheck[i] == 'Y')
                {
                    final += "D";
                }
                if (tocheck[i] == 'Z')
                {
                    final += "F";
                }
                if (tocheck[i] == 'a')
                {
                    final += "z";
                }
                if (tocheck[i] == 'b')
                {
                    final += "h";
                }
                if (tocheck[i] == 'c')
                {
                    final += "k";
                }
                if (tocheck[i] == 'd')
                {
                    final += "a";
                }
                if (tocheck[i] == 'e')
                {
                    final += "j";
                }
                if (tocheck[i] == 'f')
                {
                    final += "u";
                }
                if (tocheck[i] == 'g')
                {
                    final += "l";
                }
                if (tocheck[i] == 'h')
                {
                    final += "i";
                }
                if (tocheck[i] == 'i')
                {
                    final += "b";
                }
                if (tocheck[i] == 'j')
                {
                    final += "t";
                }
                if (tocheck[i] == 'k')
                {
                    final += "y";
                }
                if (tocheck[i] == 'l')
                {
                    final += "x";
                }
                if (tocheck[i] == 'm')
                {
                    final += "r";
                }
                if (tocheck[i] == 'n')
                {
                    final += "s";
                }
                if (tocheck[i] == 'o')
                {
                    final += "e";
                }
                if (tocheck[i] == 'p')
                {
                    final += "w";
                }
                if (tocheck[i] == 'q')
                {
                    final += "v";
                }
                if (tocheck[i] == 'r')
                {
                    final += "g";
                }
                if (tocheck[i] == 's')
                {
                    final += "o";
                }
                if (tocheck[i] == 't')
                {
                    final += "q";
                }
                if (tocheck[i] == 'u')
                {
                    final += "c";
                }
                if (tocheck[i] == 'v')
                {
                    final += "n";
                }
                if (tocheck[i] == 'w')
                {
                    final += "m";
                }
                if (tocheck[i] == 'x')
                {
                    final += "p";
                }
                if (tocheck[i] == 'y')
                {
                    final += "d";
                }
                if (tocheck[i] == 'z')
                {
                    final += "f";
                }

                if (tocheck[i] == '0')
                {
                    final += "9";
                }
                if (tocheck[i] == '1')
                {
                    final += "8";
                }
                if (tocheck[i] == '2')
                {
                    final += "7";
                }
                if (tocheck[i] == '3')
                {
                    final += "6";
                }
                if (tocheck[i] == '4')
                {
                    final += "5";
                }
                if (tocheck[i] == '5')
                {
                    final += "4";
                }
                if (tocheck[i] == '6')
                {
                    final += "3";
                }
                if (tocheck[i] == '7')
                {
                    final += "2";
                }
                if (tocheck[i] == '8')
                {
                    final += "1";
                }
                if (tocheck[i] == '9')
                {
                    final += "0";
                }
            }
            return final;
        }
        public static string Decrypt(string tocheck)
        {
            string final = "";
            Regex objAlphaPattern = new Regex(@"^[a-zA-Z0-9éèâê]*$");
            bool sts = objAlphaPattern.IsMatch(tocheck);
            if (!sts)
            {
                return "Special Character found ! Error !";
            }

            for (int i = 0; i < tocheck.Length; i++)
            {
                if (tocheck[i] == 'è')
                {
                    final += "é";
                }
                if (tocheck[i] == 'é')
                {
                    final += "è";
                }
                if (tocheck[i] == 'â')
                {
                    final += "ê";
                }
                if (tocheck[i] == 'ê')
                {
                    final += "â";
                }
                if (tocheck[i] == 'Z')
                {
                    final += "A";
                }
                if (tocheck[i] == 'H')
                {
                    final += "B";
                }
                if (tocheck[i] == 'K')
                {
                    final += "C";
                }
                if (tocheck[i] == 'A')
                {
                    final += "D";
                }
                if (tocheck[i] == 'J')
                {
                    final += "E";
                }
                if (tocheck[i] == 'U')
                {
                    final += "F";
                }
                if (tocheck[i] == 'L')
                {
                    final += "G";
                }
                if (tocheck[i] == 'I')
                {
                    final += "H";
                }
                if (tocheck[i] == 'B')
                {
                    final += "I";
                }
                if (tocheck[i] == 'T')
                {
                    final += "J";
                }
                if (tocheck[i] == 'Y')
                {
                    final += "K";
                }
                if (tocheck[i] == 'X')
                {
                    final += "L";
                }
                if (tocheck[i] == 'R')
                {
                    final += "M";
                }
                if (tocheck[i] == 'S')
                {
                    final += "N";
                }
                if (tocheck[i] == 'E')
                {
                    final += "O";
                }
                if (tocheck[i] == 'W')
                {
                    final += "P";
                }
                if (tocheck[i] == 'V')
                {
                    final += "Q";
                }
                if (tocheck[i] == 'G')
                {
                    final += "R";
                }
                if (tocheck[i] == 'O')
                {
                    final += "S";
                }
                if (tocheck[i] == 'Q')
                {
                    final += "T";
                }
                if (tocheck[i] == 'C')
                {
                    final += "U";
                }
                if (tocheck[i] == 'N')
                {
                    final += "V";
                }
                if (tocheck[i] == 'M')
                {
                    final += "W";
                }
                if (tocheck[i] == 'P')
                {
                    final += "X";
                }
                if (tocheck[i] == 'D')
                {
                    final += "Y";
                }
                if (tocheck[i] == 'F')
                {
                    final += "Z";
                }




                if (tocheck[i] == 'z')
                {
                    final += "a";
                }
                if (tocheck[i] == 'h')
                {
                    final += "b";
                }
                if (tocheck[i] == 'k')
                {
                    final += "c";
                }
                if (tocheck[i] == 'a')
                {
                    final += "d";
                }
                if (tocheck[i] == 'j')
                {
                    final += "e";
                }
                if (tocheck[i] == 'u')
                {
                    final += "f";
                }
                if (tocheck[i] == 'l')
                {
                    final += "g";
                }
                if (tocheck[i] == 'i')
                {
                    final += "h";
                }
                if (tocheck[i] == 'b')
                {
                    final += "i";
                }
                if (tocheck[i] == 't')
                {
                    final += "j";
                }
                if (tocheck[i] == 'y')
                {
                    final += "k";
                }
                if (tocheck[i] == 'x')
                {
                    final += "l";
                }
                if (tocheck[i] == 'r')
                {
                    final += "m";
                }
                if (tocheck[i] == 's')
                {
                    final += "n";
                }
                if (tocheck[i] == 'e')
                {
                    final += "o";
                }
                if (tocheck[i] == 'w')
                {
                    final += "p";
                }
                if (tocheck[i] == 'v')
                {
                    final += "q";
                }
                if (tocheck[i] == 'g')
                {
                    final += "r";
                }
                if (tocheck[i] == 'o')
                {
                    final += "s";
                }
                if (tocheck[i] == 'q')
                {
                    final += "t";
                }
                if (tocheck[i] == 'c')
                {
                    final += "u";
                }
                if (tocheck[i] == 'n')
                {
                    final += "v";
                }
                if (tocheck[i] == 'm')
                {
                    final += "w";
                }
                if (tocheck[i] == 'p')
                {
                    final += "x";
                }
                if (tocheck[i] == 'd')
                {
                    final += "y";
                }
                if (tocheck[i] == 'f')
                {
                    final += "z";
                }
                if (tocheck[i] == '9')
                {
                    final += "0";
                }
                if (tocheck[i] == '8')
                {
                    final += "1";
                }
                if (tocheck[i] == '7')
                {
                    final += "2";
                }
                if (tocheck[i] == '6')
                {
                    final += "3";
                }
                if (tocheck[i] == '5')
                {
                    final += "4";
                }
                if (tocheck[i] == '4')
                {
                    final += "5";
                }
                if (tocheck[i] == '3')
                {
                    final += "6";
                }
                if (tocheck[i] == '2')
                {
                    final += "7";
                }
                if (tocheck[i] == '1')
                {
                    final += "8";
                }
                if (tocheck[i] == '0')
                {
                    final += "9";
                }
            }
            return final;
        } 
    }
}
