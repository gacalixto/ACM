using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BL.Test
{
    [TestClass]
    public class CustomerTest
    {
        //Test for a valid full name
        [TestMethod]
        public void FullNameTestValid()
        {
            //-Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";

            string expected = "Baggins, Bilbo";

            //-Act
            string actual = customer.FullName;

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        // Empty First Name test
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-Arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            string expected = "Baggins";  
            
            //-Act
            string actual = customer.FullName;

            //-Assert
            Assert.AreEqual(expected, actual);
        }

        //Empty Last name Test
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-Arrange
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            string expected = "Bilbo";

            //-Act
            string actual = customer.FullName;

            //-Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StaticTest()
        {
            //-Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount++;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount++;


            var c3 = new Customer();
            c3.FirstName = "Legolas";
            Customer.InstanceCount++;

            //-Act

            //-Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateVoid()
        {
            //--Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@hobbiton.me";

            var expected = true;
            //--Act
            var actual = customer.Validate();
            //-Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
