using System.Collections.Generic;

namespace PasswordValidator
{
    public class PasswordValidationResult
    {
        internal bool Status { get; }
        internal string Message { get; }

        public bool IsValid { get; set; }
        public List<string> FailureMessages { get; set; }


        public PasswordValidationResult()
        {
            FailureMessages = new();
        }
        public PasswordValidationResult(bool status)
        {
            Status = status;
        }

        public PasswordValidationResult(bool status, string message) : this(status)
        {
            Message = message;
        }


    }
}
