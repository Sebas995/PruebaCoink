using Coink.BLL.Helper;
using Coink.DAL;
using Coink.DTO;
using Coink.Utilities;
using Coink.Utilities.Logs;
using System;
using System.Collections.Generic;
using System.Data;

namespace Coink.BLL
{
    /// <summary>
    /// Administration of users
    /// </summary>
    public class UserBLL
    {
        #region Globals
        UserDAL UserDAL = new UserDAL();
        #endregion

        #region Methods
        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="IdUser"></param>
        /// <returns>User</returns>
        public UserRes GetUserById(int IdUser)
        {
            UserRes User = null;
            try
            {
                User = UserDAL.GetUserById(IdUser);
            }
            catch (DataException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_DATABASE.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (ArgumentException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_ARGUMENT.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (NullReferenceException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_NULLREFERENCE.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (TimeoutException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_TIMEOUT.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (Exception exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_EXCEPTION.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }

            return User;
        }

        /// <summary>
        /// Get all users register
        /// </summary>
        /// <returns>All Users</returns>
        public List<UserRes> GetUsers()
        {
            List<UserRes> Users = new List<UserRes>();
            try
            {
                Users = UserDAL.GetUsers();
            }
            catch (DataException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_DATABASE.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (ArgumentException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_ARGUMENT.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (NullReferenceException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_NULLREFERENCE.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (TimeoutException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_TIMEOUT.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (Exception exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_EXCEPTION.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }

            return Users;
        }

        /// <summary>
        /// Create Users
        /// </summary>
        /// <param name="User"></param>
        /// <returns>Errors in creation user</returns>
        public Dictionary<string, string> CreateUser(UserReq UserModel)
        {
            Dictionary<string, string> Errors = new Dictionary<string, string>();
            try
            {
                var ValName = ValidateData.ValidateStringLength(UserModel.Name,200);
                var ValLastName = ValidateData.ValidateStringLength(UserModel.LastName,200);
                var ValAddress = ValidateData.ValidateStringLength(UserModel.Address,200);

                if (!String.IsNullOrEmpty(ValName))
                    Errors.Add("StringLength-Name", ValName);
                if (!String.IsNullOrEmpty(ValLastName))
                    Errors.Add("StringLength-LastName", ValLastName);
                if (!String.IsNullOrEmpty(ValAddress))
                    Errors.Add("StringLength-Address", ValAddress);

                if (Errors.Count == 0)
                    UserDAL.CreateUser(UserModel);
            }
            catch (DataException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_DATABASE.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (ArgumentException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_ARGUMENT.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (NullReferenceException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_NULLREFERENCE.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (TimeoutException exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_TIMEOUT.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }
            catch (Exception exc)
            {
                throw new CoinkException(EnumMensajes.ERROR_EXCEPTION.ToString(), exc.GetType().ToString(), exc.Message, exc.StackTrace);
            }

            return Errors;
        }
        #endregion
    }
}
