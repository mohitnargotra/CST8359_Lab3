using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Lab3.Models
{
    public class Person
    {

        public string? FirstName
        {
            get;
            set;
        }

        public string? LastName
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        
        public string? EmailAddresss
        {
            get;
            set;
        }

     
        public string? Password
        {
            get;
            set;
        }

        public string? Desc
        {
            get;
            set;
        }
    }
}
