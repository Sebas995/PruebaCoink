using Coink.BLL;
using Coink.BLL.Helper;
using Coink.DTO;
using Coink.Utilities;
using Coink.Utilities.Logs;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Coink.Controllers
{
    /// <summary>
    /// Administration of users
    /// </summary>
    public class UserController : ApiController
    {
        #region Globals
        private UserBLL UserBLL = new UserBLL();
        #endregion

        #region Globals
        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="IdUser"></param>
        /// <returns>User</returns>
        [HttpGet]
        [Route("Api/GetUserById/{IdUser}")]
        public ResponseModel GetUserById(int IdUser)
        {
            ResponseModel responseModel = new ResponseModel();
            UserRes User = null;
            try
            {
                User = UserBLL.GetUserById(IdUser);

                if (User != null)
                {
                    responseModel.Message = MessageUtil.GetMessage(EnumMensajes.MESSAGE_SUCCESS.ToString());
                    responseModel.Response = true;
                    responseModel.Data.Add("UserData", User);
                }
                else
                {
                    responseModel.Message = MessageUtil.GetMessage(EnumMensajes.ERROR_NOT_FOUND.ToString());
                    responseModel.Response = false;
                }

            }
            catch (CoinkException exc)
            {
                responseModel.Message = MessageUtil.GetMessage(exc.CodeError);
                responseModel.Response = false;
                Log.SaveError(exc);
            }
            catch (Exception exc)
            {
                responseModel.Message = MessageUtil.GetMessage(EnumMensajes.ERROR_EXCEPTION.ToString());
                responseModel.Response = false;
                CoinkException pruebaExc = new CoinkException(MessageUtil.GetMessage(EnumMensajes.ERROR_EXCEPTION.ToString()), exc.GetType().ToString(), exc.Message, exc.StackTrace);
                Log.SaveError(pruebaExc);
            }

            return responseModel;
        }

        /// <summary>
        /// Get all users register
        /// </summary>
        /// <returns>All Users</returns>
        [HttpGet]
        [Route("Api/GetUsers")]
        public ResponseModel GetUsers()
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                responseModel.Message = MessageUtil.GetMessage(EnumMensajes.MESSAGE_SUCCESS.ToString());
                responseModel.Response = true;
                responseModel.Data.Add("UserData", UserBLL.GetUsers());
            }
            catch (CoinkException exc)
            {
                responseModel.Message = MessageUtil.GetMessage(exc.CodeError);
                responseModel.Response = false;
                Log.SaveError(exc);
            }
            catch (Exception exc)
            {
                responseModel.Message = MessageUtil.GetMessage(EnumMensajes.ERROR_EXCEPTION.ToString());
                responseModel.Response = false;
                CoinkException pruebaExc = new CoinkException(MessageUtil.GetMessage(EnumMensajes.ERROR_EXCEPTION.ToString()), exc.GetType().ToString(), exc.Message, exc.StackTrace);
                Log.SaveError(pruebaExc);
            }

            return responseModel;
        }

        /// <summary>
        /// Create Users
        /// </summary>
        /// <param name="User"></param>
        /// <returns>Errors in creation user</returns>
        [HttpPost]
        [Route("Api/CreateUser")]
        public ResponseModel CreateUser(UserReq User)
        {
            ResponseModel responseModel = new ResponseModel();
            Dictionary<string, string> Errors = new Dictionary<string, string>();

            try
            {
                Errors = UserBLL.CreateUser(User);

                if (Errors.Count == 0)
                {
                    responseModel.Message = MessageUtil.GetMessage(EnumMensajes.MESSAGE_SUCCESS.ToString());
                    responseModel.Response = true;
                }
                else
                {
                    responseModel.Message = MessageUtil.GetMessage(EnumMensajes.ERROR_PARAMS.ToString());
                    responseModel.Response = false;
                    responseModel.Data.Add("UserData", Errors);
                }
            }
            catch (CoinkException exc)
            {
                responseModel.Message = MessageUtil.GetMessage(exc.CodeError);
                responseModel.Response = false;
                Log.SaveError(exc);
            }
            catch (Exception exc)
            {
                responseModel.Message = MessageUtil.GetMessage(EnumMensajes.ERROR_EXCEPTION.ToString());
                responseModel.Response = false;
                CoinkException pruebaExc = new CoinkException(MessageUtil.GetMessage(EnumMensajes.ERROR_EXCEPTION.ToString()), exc.GetType().ToString(), exc.Message, exc.StackTrace);
                Log.SaveError(pruebaExc);
            }

            return responseModel;
        }
        #endregion
    }
}
