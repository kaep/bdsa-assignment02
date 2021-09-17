using System;

namespace assignment02
{
    public class Student
    {
        public int Id 
        {
            get { return Id; }
            set { Id = value; }
        } 

        public string GivenName
        {
            get {return GivenName; }
            set {GivenName = value; }
        } 

        public string Surname 
        {
            get {return Surname; }
            set {Surname = value; }
        }

        public Status Status 
        {
            get {return Status; } //correct logic coming 
        }

        public DateTime StartDate 
        {
            get {return StartDate; }
            set {StartDate = value}
        }

        public DateTime EndDate 
        {
            get {return EndDate; }
            set {EndDate = value}
        }

        public DateTime GraduationDate 
        {
            get {return GraduationDate; }
            set {GraduationDate = value}
        }

    }
}
