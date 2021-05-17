using System;

namespace Coink.Utilities.Logs
{
    public class CoinkException : Exception
    {
        public string CodeError { get; set; }
        public string TypeError { get; set; }
        public string MessageError { get; set; }
        public string StackError { get; set; }

        public CoinkException(string CodeError, string TypeError, string MessageError, string StackError)
        {
            this.CodeError = CodeError;
            this.TypeError = TypeError;
            this.MessageError = MessageError;
            this.StackError = StackError;
        }
    }
}
