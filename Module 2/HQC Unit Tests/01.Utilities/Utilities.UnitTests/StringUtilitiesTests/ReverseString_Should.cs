using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Utilities.UnitTests.StringUtilitiesTests
{
    [TestClass]
    public class ReverseString_Should
    {
        [TestMethod]
        [DataRow("Test 1234@", "@4321 tseT")]//generic cases
        [DataRow("TeT", "TeT")]
        [DataRow("Friend", "dneirF")]
        public void ReturnReversedString_WhenParameterIsCorrect(string textToReverse, string expectedResult)
        {
            //Arrange            
            StringUtilities stringUtilities = new StringUtilities();
            
            //Act
            string actualResult = stringUtilities.ReverseString(textToReverse);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnEmptyString_WhenParameterIsEmptyString()
        {
            //Arrange
            string textToReverse = string.Empty;     
            StringUtilities stringUtilities = new StringUtilities();

            string expectedResult = string.Empty;

            //Act
            string actualResult = stringUtilities.ReverseString(textToReverse);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ThrowException_WhenParameterIsNull()
        {
            //Arrange
            string textToReverse = null;     
            StringUtilities stringUtilities = new StringUtilities();

            //Act & Assert
            Assert.ThrowsException<ArgumentNullException>(() => stringUtilities.ReverseString(textToReverse));            
        }
    }
}
