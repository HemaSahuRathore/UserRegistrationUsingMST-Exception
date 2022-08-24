using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationWithMSTestNException;

namespace UserRegexUnitTest
{
    [TestClass]
    public class UserRegistrationUnitTest
    {
       public UserRegistration urObj;

        [TestInitialize]
        public void SetUp()
        {
            urObj = new UserRegistration();
        }

        [TestMethod]
        [TestCategory("Name Validation")]
        [DataRow("Hema", "Valid")]
        [DataRow("hema", "InValid")]
        public void GivenNameReturnValidOrInvalid(string name, string expectedMsg)
        {   
            //Act
            string actualMsg = urObj.ValidateName(name);
            //Assert
            Assert.AreEqual(expectedMsg, actualMsg);
        }

        [TestMethod]
        [TestCategory("Name Validation")]
        [DataRow(null, "Name cannot be Null", UserRegistrationException.ExceptionTypes.NULL_MESSAGE)]
        [DataRow("", "Name cannot be Empty", UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE)]
        public void GivenInvalidNameShouldReturnException(string name, string expectedMsg, UserRegistrationException.ExceptionTypes exceptionTypes)
        {
            try 
            {
                //Act
                string actualMsg = urObj.ValidateName(name);
            }
            catch(UserRegistrationException ex)
            {
                //Assert
                Assert.AreEqual(expectedMsg, ex.message);
                Assert.AreEqual(exceptionTypes, ex.exceptionType);
            }
           
        }
    }
}
