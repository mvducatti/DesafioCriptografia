using SimpleJWT;
using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionChallenge
{
    class Encrypt
    {
        public string Codificar(string textToConvert, string mySecret)
        {
            Console.WriteLine("");
            Console.WriteLine("#Criptografia");
            Console.WriteLine("");
            Console.ReadKey();

            JwtEncoder jwtEncoder = new JwtEncoder();

            Dictionary<string, object> payload = new Dictionary<string, object>
            {
                { "text", textToConvert }
            };

            string secret = mySecret;

            //Encode do JWT
            string jwtEncoded = jwtEncoder.Encode(payload, secret);

            Console.WriteLine("########## JWT Gerado pelo JwtEncoder ##########\n");
            Console.WriteLine($"{jwtEncoded}");
            Console.WriteLine("");
            Console.ReadKey();

            string base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(jwtEncoded));

            Console.WriteLine("########## Base64 Gerado ##########\n");
            Console.WriteLine($"{jwtEncoded}");
            Console.WriteLine("");
            Console.ReadKey();

            return base64;
        }
    }
}
