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
        public static string EncryptWithKey(string Input, string key)
        {
            string Value = "";
            if (!new Regex(@"^[a-zA-Z0-9éèâê@#|&{}()$* ]*$").IsMatch(Input))
                return "Special Character found ! Error !";
            for (int i = 0; i < Input.Length; i++)
                Value += PublicKey[PrivateKey.IndexOf(Input[i])];
            int num = key.Length * 256;
            string chArray = Value;
            string FinalValue = "";
            for (int i = 0; i < Value.Length; i++)
            {
                int num3 = chArray[i] + num;
                FinalValue = FinalValue + ((char)num3);
            }
            return FinalValue;
        }
        public static string DecryptWithKey(string Input, string key)
        {
            int num = key.Length * 256;
            string chArray = Input;
            string Value = null;
            for (int i = 0; i < Input.Length; i++)
            {
                int num3 = chArray[i] - num;
                Value = Value + ((char)num3);
            }
            string FinaleValue = "";
            if (!new Regex(@"^[a-zA-Z0-9éèâê@#|&{}()$* ]*$").IsMatch(Value))
                return "Special Character found ! Error !";
            for (int i = 0; i < Value.Length; i++)
                FinaleValue += PrivateKey[PublicKey.IndexOf(Value[i])];
            return FinaleValue;
        }
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
