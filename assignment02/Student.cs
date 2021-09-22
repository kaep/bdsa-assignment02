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
            get {return calculateStatus(); } 
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
            var now = DateTime.Now; 
            if(now < StartDate)
            {
                return Status.New; 
            }
            else if (now < GraduationDate)
            {
                return Status.Active;
            }
            else if (now >= EndDate && EndDate == GraduationDate)
            {
                return Status.Graduated; 
            }
            else 
            {
                return Status.Dropout;
            }
        }

        public override string ToString() => $"Student: {Id} Status: {Status} Name: {GivenName} {Surname}";

    }
}
