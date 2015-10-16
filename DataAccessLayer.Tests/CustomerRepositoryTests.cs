using System;
using NUnit.Framework;
using Moq;
using DataAccessLayer.Interfaces;

namespace DataAccessLayer.Tests
{
    /// <summary>
    /// Test for class <see cref="CustomerRepository"/>
    /// </summary>
    [TestFixture]
    public class CustomerRepositoryTests
    {
        /// <summary>
        /// Tests that the method under test returns true and the Customer entity
        /// getters are called once inside.
        /// </summary>
        [Test]
        public void Create_ArgumentValid_ReturnsTrue()
        {
            // ARRANGE
            var objectUnderTest = new CustomerRepository();
            var mockCustomer = new Mock<ICustomer>();

            mockCustomer.SetupGet(context => context.firstName).Returns("Eric");
            mockCustomer.SetupGet(context => context.lastName).Returns("Brunner");
            mockCustomer.SetupGet(context => context.streetAddress).Returns("my street");
            mockCustomer.SetupGet(context => context.city).Returns("Vienna");

            // ACT
            var result = objectUnderTest.Create(mockCustomer.Object);

            // ASSERT
            Assert.True(result, "Result has an unexpected value");

            mockCustomer.VerifyGet(context => context.firstName, Times.Exactly(1));
            mockCustomer.VerifyGet(context => context.lastName, Times.Exactly(1));
            mockCustomer.VerifyGet(context => context.streetAddress, Times.Exactly(1));
            mockCustomer.VerifyGet(context => context.city, Times.Exactly(1));
        }
    }
}
