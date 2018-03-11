using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NGOUnnati.BusinessObject;
using NGOUnnati.BusinessObject.Enums;

namespace NGOUnnati.Security.Base.Model
{
    public class UserModel : BaseBusinessObject
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Enums.UserRole UserRole { get; set; } = Enums.UserRole.Volunteer;
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Mobile { get; set; }
        public AddressModel PermanentAddress { get; set; }
        public AddressModel CorrespondenceAddress { get; set; }
    }

    public class AddressModel
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public Enums.AddressType AddressType { get; set; }
    }
}
