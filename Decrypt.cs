using EncryptionChallenge.Models;
using SimpleJWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncryptionChallenge
{
    class Decrypt
    {
        public void Descodificar(string base64, string secretToDecode)
        {
            Console.WriteLine("#Descriptografia");
            Console.WriteLine("");
            Console.ReadKey();

            JwtDecoder jwtDecoder = new JwtDecoder();

            Console.WriteLine("########## Base64 Recebida ##########\n");
            Console.WriteLine($"{base64}");
            Console.WriteLine("");
            Console.ReadKey();

            byte[] base64Decoded = Convert.FromBase64String(base64);
            string decodedjwt = Encoding.UTF8.GetString(base64Decoded);

            string secret = secretToDecode;
            string jwt = decodedjwt;

            Console.WriteLine("########## JWT retirado do base64 ##########\n");
            Console.WriteLine($"{jwt}");
            Console.WriteLine("");
            Console.ReadKey();

            IDictionary<string, object> payload = jwtDecoder.Decode(jwt, secret);

            //Transformando em dicionário
            Dictionary<string, object> payloadConverted = payload.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            //Pegando o resultado do dicionário
            KeyValuePair<string, object> firstElement = payloadConverted.FirstOrDefault();
            string firstElementKey = firstElement.Value.ToString();

            Console.WriteLine("########## Texto Final ##########\n");
            Console.WriteLine(firstElementKey);
            Console.WriteLine("");
        }
    }
}
