using System;
using Xunit;

namespace assignment02.Tests
{
    public class StudentTests
    {
        [Fact]
        public void GetStatus_returns_correct_Status()
        {
            var student = new Student()
            {
                StartDate = new DateTime(2014, 1, 1),
                EndDate = new DateTime(2019, 1, 6), 
                GraduationDate = new DateTime(2019, 1, 6)
            };

            var actualStatus = student.Status; 
            var expectedStatus = Status.Graduated; 
            Assert.Equal(expectedStatus, actualStatus); 

        }
    }
}
