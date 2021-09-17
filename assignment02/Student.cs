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
            var now = DateTime.Now; 
            if(now < StartDate) 
            {
                return Status.New; 
            }
            else if(now > GraduationDate && GraduationDate == EndDate) 
            {
                return Status.Graduated; 
            }
            else if(now > EndDate && GraduationDate > EndDate) 
            {
                return Status.Dropout;
            }
            else if(now < EndDate && now < GraduationDate)
            {
                return Status.Active;
            }
            else {
                return Status.Active; //det her er meget forkert, skal ha' polish
            }
        }

    }
}
