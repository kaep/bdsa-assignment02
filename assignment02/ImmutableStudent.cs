using System;

namespace assignment02
{
    public record ImmutableStudent
    {
        public int Id  {get; init;} 
        public string GivenName  {get; init;} 
        public string Surname  {get; init;} 
        public Status Status  {get {return calculateStatus();}}
        public DateTime StartDate  {get; init;}
        public DateTime EndDate  {get; init;}
        public DateTime GraduationDate  {get; init;}  

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
    }
}
