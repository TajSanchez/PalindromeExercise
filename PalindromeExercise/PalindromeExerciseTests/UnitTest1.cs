using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hey", false)]
        [InlineData("civic", true)]
        [InlineData("noon", true)]
        [InlineData("howdy", false)]
        [InlineData("hannah", true)]
        [InlineData("brother",false)]

        public void Test1(string name, bool expected)
        {
            //Arrange
            var pal = new WordSmith();

            //Act
            var actual = pal.IsAPalindrome(name);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
