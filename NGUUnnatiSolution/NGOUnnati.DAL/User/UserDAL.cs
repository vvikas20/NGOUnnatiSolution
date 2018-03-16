using NGOUnnati.BusinessObject.Enums;
using NGOUnnati.DALEntity;
using NGOUnnati.Security.Base.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGOUnnati.DAL.User
{
    public class UserDAL
    {
        private NGOUnnatiEntities entities;

        public UserDAL()
        {
            entities = new NGOUnnatiEntities();
        }

        #region Manage User

        public void AddUser(UserModel userModel)
        {
            using (var transaction = entities.Database.BeginTransaction())
            {
                DALEntity.Address dbAddressPermanent = new DALEntity.Address()
                {
                    AddressLine1 = userModel.PermanentAddress.AddressLine1,
                    AddressLine2 = userModel.PermanentAddress.AddressLine2,
                    City = userModel.PermanentAddress.City,
                    ZipCode = userModel.PermanentAddress.ZipCode,
                    State = userModel.PermanentAddress.State,
                    Country = userModel.PermanentAddress.Country,
                    AddressType = Convert.ToByte(Enums.AddressType.Permanent)
                };

                entities.Address.Add(dbAddressPermanent);

                DALEntity.Address dbAddressCorrespondence = new DALEntity.Address()
                {
                    AddressLine1 = userModel.CorrespondenceAddress.AddressLine1,
                    AddressLine2 = userModel.CorrespondenceAddress.AddressLine2,
                    City = userModel.CorrespondenceAddress.City,
                    ZipCode = userModel.CorrespondenceAddress.ZipCode,
                    State = userModel.CorrespondenceAddress.State,
                    Country = userModel.CorrespondenceAddress.Country,
                    AddressType = Convert.ToByte(Enums.AddressType.Correnspondence)
                };

                entities.Address.Add(dbAddressCorrespondence);

                DALEntity.User dbUser = new DALEntity.User()
                {
                    UserName = userModel.UserName,
                    Password = userModel.Password,
                    UserRole = Convert.ToByte(userModel.UserRole),
                    FirstName = userModel.FirstName,
                    SecondName = userModel.SecondName,
                    EmailID = userModel.EmailID,
                    Mobile = userModel.Mobile,
                    PermanentAddress = dbAddressPermanent.AddressID,
                    CorrespondenceAddress = dbAddressCorrespondence.AddressID
                };

                entities.User.Add(dbUser);


                entities.SaveChanges();
                transaction.Commit();
            };


        }

        public void UpdateUser(UserModel userModel)
        {
            using (var transaction = entities.Database.BeginTransaction())
            {
                DALEntity.Address dbAddressPermanent = new DALEntity.Address()
                {
                    AddressLine1 = userModel.PermanentAddress.AddressLine1,
                    AddressLine2 = userModel.PermanentAddress.AddressLine2,
                    City = userModel.PermanentAddress.City,
                    ZipCode = userModel.PermanentAddress.ZipCode,
                    State = userModel.PermanentAddress.State,
                    Country = userModel.PermanentAddress.Country,
                    AddressType = Convert.ToByte(Enums.AddressType.Permanent)
                };

                entities.Address.Add(dbAddressPermanent);

                DALEntity.Address dbAddressCorrespondence = new DALEntity.Address()
                {
                    AddressLine1 = userModel.CorrespondenceAddress.AddressLine1,
                    AddressLine2 = userModel.CorrespondenceAddress.AddressLine2,
                    City = userModel.CorrespondenceAddress.City,
                    ZipCode = userModel.CorrespondenceAddress.ZipCode,
                    State = userModel.CorrespondenceAddress.State,
                    Country = userModel.CorrespondenceAddress.Country,
                    AddressType = Convert.ToByte(Enums.AddressType.Correnspondence)
                };

                entities.Address.Add(dbAddressCorrespondence);

                DALEntity.User dbUser = new DALEntity.User()
                {
                    UserName = userModel.UserName,
                    Password = userModel.Password,
                    UserRole = Convert.ToByte(userModel.UserRole),
                    FirstName = userModel.FirstName,
                    SecondName = userModel.SecondName,
                    EmailID = userModel.EmailID,
                    Mobile = userModel.Mobile,
                    PermanentAddress = dbAddressPermanent.AddressID,
                    CorrespondenceAddress = dbAddressCorrespondence.AddressID
                };

                entities.User.Add(dbUser);


                entities.SaveChanges();
                transaction.Commit();
            };


        }

        public void DeleteUser(UserModel userModel)
        {
            using (var transaction = entities.Database.BeginTransaction())
            {
                var dbUser = entities.User.FirstOrDefault(user => user.UserName == userModel.UserName);
                entities.User.Remove(dbUser);

                entities.SaveChanges();
                transaction.Commit();
            };
        }

        #endregion  

    }
}
