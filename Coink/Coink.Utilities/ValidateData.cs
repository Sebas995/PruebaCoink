using System;

namespace Coink.Utilities
{
    /// <summary>
    /// Validate data
    /// </summary>
    public class ValidateData
    {
        /// <summary>
        /// Validate Number
        /// </summary>
        /// <param name="StringIn"></param>
        /// <returns></returns>
        public static string ValidateNumber(string StringIn)
        {
            try
            {
                Convert.ToInt32(StringIn);
            }
            catch (Exception)
            {
                return String.Format("{0} isn't number.", StringIn);
            }
            return null;
        }

        /// <summary>
        /// Validate long number
        /// </summary>
        /// <param name="StringIn"></param>
        /// <returns></returns>
        public static string ValidateLong(string StringIn)
        {
            try
            {
                Convert.ToInt64(StringIn);
            }
            catch (Exception)
            {
                return String.Format("{0} isn't long number.", StringIn);
            }
            return null;
        }

        /// <summary>
        /// Validate decimal
        /// </summary>
        /// <param name="StringIn"></param>
        /// <returns></returns>
        public static string ValidateDecimal(string StringIn)
        {
            try
            {
                Convert.ToDecimal(StringIn);
            }
            catch (Exception)
            {                
                return String.Format("{0} isn't decimal.", StringIn);
            }
            return null;
        }

        /// <summary>
        /// Length of string
        /// </summary>
        /// <param name="StringIn"></param>
        /// <returns></returns>
        public static string ValidateStringLength(string StringIn, int Length)
        {
            try
            {
                if (StringIn.Length > Length)
                    throw new Exception();
            }
            catch (Exception)
            {
                return String.Format("{0} has max length is {1}.", StringIn, Length);
            }

            return null;
        }

    }
}
