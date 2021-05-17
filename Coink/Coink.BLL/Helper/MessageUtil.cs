namespace Coink.BLL.Helper
{
    /// <summary>
    /// Message
    /// </summary>
    public class MessageUtil
    {
        public static string GetMessage(string Message)
        {
            return Properties.Message.ResourceManager.GetString(Message);
        }
    }
}
