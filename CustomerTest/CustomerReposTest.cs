using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM.BL;
using System.Collections.Generic;

namespace CustomerTest
{
    [TestClass]
    public class CustomerReposTest
    {
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-Arrange
            var customerReposit = new CustomerReposit();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                     },

                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywwater",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "146"
                    }
              }
        };
            //--Act
            var actual = customerReposit.Retrieve(1);

            //-Asert
            // Assert.AreEqual(expected, actual); - Não é possivel comparar 2 objetos iguais, pois cada instância é diferente
            Assert.AreEqual(actual.EmailAddress, expected.EmailAddress);
            Assert.AreEqual(actual.FirstName, expected.FirstName);
            Assert.AreEqual(actual.LastName, expected.LastName);

            for (int i=0;i<1;i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);


            }
        }
    }
}
