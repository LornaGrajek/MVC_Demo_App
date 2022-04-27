using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace StoreApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        private string _password; //when creating a custom getter/setter, you must first set a private backing field
        [Required]
        public string Password {
            get { return _password; }
            set 
            {

                Regex pattern = new Regex("^[a-zA-Z0-9 !?']+$"); //Pattern can only contain alphanumeric characters, an !, and ?
                // Here, we could implement custom exception handling that will throw an error if the user input is 0 characters, or out of bounds
                // of the regex expression

                if(pattern.IsMatch(value))
                {
                    _password = value;
                }
            }
        }


        

    }
}