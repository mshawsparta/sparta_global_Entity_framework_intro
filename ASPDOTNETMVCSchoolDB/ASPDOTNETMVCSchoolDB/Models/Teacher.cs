using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASPDOTNETMVCSchoolDB.Models
{
    public class Teacher
    {

        private int id;
        private string fName;
        private string lName;
        private string speciality;
        private string yearGroup;
        private DateTime startDate;
        private float salary;
        private string photoURL;
        private string address;
        private string contactDetails;


        
        public int Id { get => id; set => id = value; }
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Speciality { get => speciality; set => speciality = value; }
        public string YearGroup { get => yearGroup; set => yearGroup = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public float Salary { get => salary; set => salary = value; }
        public string PhotoURL { get => photoURL; set => photoURL = value; }
        public string Address { get => address; set => address = value; }
        public string ContactDetails { get => contactDetails; set => contactDetails = value; }
        
    }
}