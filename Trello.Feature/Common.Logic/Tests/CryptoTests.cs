using Common.Logic.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Common.Logic.Tests
{
    public class CryptoTests
    {
        [Fact]
        [Trait("Unit Test", "Crypto")]
        public void Encrypt()
        {
            //string passPhrase = "test";
            //string unencryptedString = "test";

            string passPhrase = "TrelloEncryption";
            string unencryptedString = "9c55c9fb8f";

            string encryptedString = Crypto.Encrypt(unencryptedString, passPhrase);

            Assert.NotEqual(encryptedString, unencryptedString);
        }

        [Fact]
        [Trait("Unit Test", "Crypto")]
        public void EncryptAndDecrypt()
        {
            string passPhrase = "test";
            string unencryptedString = "test";

            string encryptedString = Crypto.Encrypt(unencryptedString, passPhrase);
            string decryptedString = Crypto.Decrypt(encryptedString, passPhrase);

            Assert.Equal(unencryptedString, decryptedString);
        }
    }
}
