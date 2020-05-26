using System;
namespace api.Models
{
    public class User
    {
        public enum UserStatus { ADMIN, SIMPLE_CUSTOMER, ACCOUNT_CUSTOMER };

        public User(){}

        public long id { set; get; }
        public string firstname { set; get; }
        public string lastname { set; get; }
        public int age { set; get; }
        public string password { set; get; }
        public string email { set; get; }
        public string gender { set; get; }
        public string phoneNumber { set; get; }
        public UserStatus status { set; get; }
    }
}
