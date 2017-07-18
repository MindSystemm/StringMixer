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
        private static string PrivateKey = " éèêâABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#|&{}()$*";
        private static string PublicKey = " èéâêZHKAJULIBTYXRSEWVGOQCNMPDFzhkajulibtyxrsewvgoqcnmpdf9876543210#@&|}{)(*$";
        public static string Encrypt(string Input)
        {
            string Value = "";
            if (!new Regex(@"^[a-zA-Z0-9éèâê@#|&{}()$* ]*$").IsMatch(Input))
                return "Special Character found ! Error !";
            for (int i = 0; i < Input.Length; i++)
                Value += PublicKey[PrivateKey.IndexOf(Input[i])];
            return Value;
        }

        public static string Decrypt(string Input)
        {
            string Value = "";
            if (!new Regex(@"^[a-zA-Z0-9éèâê@#|&{}()$* ]*$").IsMatch(Input))
                return "Special Character found ! Error !";
            for (int i = 0; i < Input.Length; i++)
                Value += PrivateKey[PublicKey.IndexOf(Input[i])];
            return Value;
        }
    }
}
