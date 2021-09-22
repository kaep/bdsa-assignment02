using System;
using Xunit;

namespace assignment02.Tests
{
    public class StudentTests
    {
        [Theory]
        [InlineData(2019, 1, 1, 2022, 1, 1, 2022, 1, 1, Status.Active)]
        [InlineData(2018, 8, 1, 2020, 12, 12, 2020, 12, 12, Status.Graduated)]
        [InlineData(2022,1,1,2023,8,4,2023,8,4, Status.New)]
        [InlineData(2020,4,20,2020,5,30,2021,6,20, Status.Dropout)]
        public void GetStatus_returns_correct_Status(int startY, int startM, int startD, int endY, int endM, int endD, int gradY, int gradM, int gradD, Status expected)
        {
            var start = new DateTime(startY, startM, startD);
            var end = new DateTime(endY, endM, endD);
            var graduation = new DateTime(gradY, gradM, gradD); 
            var student = new Student()
            {
                StartDate = start,
                EndDate = end,
                GraduationDate = graduation
            };
            var actualStatus = student.Status; 
            var expectedStatus = expected; 
            Assert.Equal(expectedStatus, actualStatus); 

        }
    }
}
