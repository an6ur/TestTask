using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask;

namespace Notes.Tests
{
    public class ServerTests
    {
        [Fact]
        public void GetCount_ReturnsInitialValue()
        {
            // Arrange

            // Act
            int count = Server.GetCount();

            // Assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void AddToCount_IncrementsCountByGivenValue()
        {
            // Arrange
            int valueToAdd = 5;

            // Act
            Server.AddToCount(valueToAdd);

            // Assert
            Assert.Equal(valueToAdd, Server.GetCount());
        }
    }
}
