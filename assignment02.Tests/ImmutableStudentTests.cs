using System;
using Xunit;

namespace assignment02.Tests
{
    public class ImmutableStudentTests
    {
        [Fact]
        public void given_two_immutablestudents_with_same_properties_are_equal()
        {
            var student1 = new ImmutableStudent() 
            {
                GivenName = "Lars-Boerge", 
                Surname = "Erdogan", 
                Id = 1234, 
                StartDate = new DateTime(2019, 1, 1),
                EndDate = new DateTime(2022, 1, 1),
                GraduationDate = new DateTime(2022, 1 , 1)
            };
            var student2 = new ImmutableStudent()
            {
                GivenName = "Lars-Boerge", 
                Surname = "Erdogan", 
                Id = 1234, 
                StartDate = new DateTime(2019, 1, 1),
                EndDate = new DateTime(2022, 1, 1),
                GraduationDate = new DateTime(2022, 1 , 1)
            };
            Assert.True(student1 == student2); 
        }

        [Fact]
        public void given_two_immutablestudents_with_different_properties_are_not_equal() 
        {
            var student1 = new ImmutableStudent() 
            {
                GivenName = "Lars-Boerge", 
                Surname = "Erdogan", 
                Id = 1239, 
                StartDate = new DateTime(2019, 1, 1),
                EndDate = new DateTime(2022, 1, 1),
                GraduationDate = new DateTime(2022, 1 , 1)
            };
            var student2 = new ImmutableStudent()
            {
                GivenName = "Lars-Boerge", 
                Surname = "Erdogan", 
                Id = 1234, 
                StartDate = new DateTime(2019, 1, 1),
                EndDate = new DateTime(2022, 1, 1),
                GraduationDate = new DateTime(2022, 1 , 1)
            };
            Assert.False(student1 == student2);    
        }

        [Fact]
        public void ToString_of_immutablestudent_returns_string_of_properties_in_order()
        {   
            var student = new ImmutableStudent() 
            {
                GivenName = "Lars-Boerge", 
                Surname = "Erdogan", 
                Id = 1239, 
                StartDate = new DateTime(2019, 1, 1),
                EndDate = new DateTime(2022, 1, 1),
                GraduationDate = new DateTime(2022, 1 , 1)
            };
            var expected = $"ImmutableStudent {{ Id = 1239, GivenName = Lars-Boerge, Surname = Erdogan, Status = Active, StartDate = {student.StartDate.ToString()}, EndDate = {student.EndDate.ToString()}, GraduationDate = {student.GraduationDate.ToString()} }}";
            Assert.Equal(expected, student.ToString());
        }
    }
}
