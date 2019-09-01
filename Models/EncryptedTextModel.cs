namespace EncryptionChallenge.Models
{
    public class EncryptedTextModel
    {

        private readonly string text = "A segurança da informação(SI) está diretamente relacionada com proteção de um conjunto de informações, no sentido de preservar o valor que possuem para um indivíduo ou uma organização.São propriedades básicas da segurança da informação: confidencialidade, integridade, disponibilidade, autenticidade e legalidade.A SI não está restrita somente a sistemas computacionais, informações eletrônicas ou sistemas de armazenamento. O conceito aplica - se a todos os aspectos de proteção de informações e dados. O conceito de Segurança Informática ou Segurança de Computadores está intimamente relacionado com o de Segurança da Informação, incluindo não apenas a segurança dos dados/informação, mas em si o sistema.";
        private readonly string secret = "secret";

        public string textToEncrypt
        {
            get
            {
                return text;
            }
        }

        public string secretToEncrypt
        {
            get
            {
                return secret;
            }
        }

    }
}
