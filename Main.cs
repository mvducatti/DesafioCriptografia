using EncryptionChallenge.Models;
using System;

namespace EncryptionChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region .: Instanciando Objectos :.

            Encrypt encode = new Encrypt();
            Decrypt decode = new Decrypt();
            EncryptedTextModel text = new EncryptedTextModel();

            #endregion

            Console.WriteLine("#############################################################");
            Console.WriteLine("################### Programa de Segurança ###################");
            Console.WriteLine("#############################################################");
            Console.WriteLine("");
            Console.ReadKey();

            Console.WriteLine("########## Texto Inicial ##########\n");
            Console.WriteLine($"{text.textToEncrypt}");
            Console.ReadKey();

            #region .: Codificando e Descodificando 
            decode.Descodificar(encode.Codificar(text.textToEncrypt, text.secretToEncrypt), text.secretToEncrypt);

            #endregion

            Console.ReadLine();
        }
    }
}
