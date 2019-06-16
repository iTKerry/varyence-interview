using System;
using Moq;
using VaryenceInterview.Infrastructure.Http;
using VaryenceInterview.Infrastructure.Repositories;
using Xunit;

namespace VaryenceInterview.Services.Tests
{
    //TODO: Implement Tests
    public class GeolocationServiceTests
    {
        [Fact]
        public void GetCoordinates_ValidAddress_ShouldReturnCoordinates()
        {
            throw new NotImplementedException();
            
            // Arrange
            
            // Act
            
            // Assign
        }

        [Fact]
        public void GetCoordinates_InvalidAddress_ShouldReturnEmptyCoordinates()
        {
            throw new NotImplementedException();
            
            // Arrange
            
            // Act
            
            // Assign
        }

        [Fact]
        public void GetCoordinates_GoogleApiUnavailable_ShouldReturnEmptyCoordinates()
        {
            throw new NotImplementedException();
            
            // Arrange
            
            // Act
            
            // Assign
        }

        private IGeolocationService CreateSut(IGeocodingRepository geocodingRepository = null)
        {
            return new GeolocationService(geocodingRepository ?? new Mock<IGeocodingRepository>().Object);
        }
    }
}