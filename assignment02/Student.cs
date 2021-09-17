using System;

namespace assignment02
{
    public class Student
    {
        public int Id  {get; init;} 

        public string GivenName
        {
            get; set; 
        } 

        public string Surname 
        {
            get; set; 
        }

        public Status Status 
        {
            get {return calculateStatus(); } //correct logic coming 
        }

        public DateTime StartDate 
        {
            get; set; 
        }

        public DateTime EndDate 
        {
            get; set; 
        }

        public DateTime GraduationDate 
        {
            get; set; 
        }


        private Status calculateStatus()
        {
            throw new NotImplementedException(); 
        }

    }
}
