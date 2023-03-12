using PasswordValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    public class PasswordValidationConfiguration
    {

        public bool ContainUpperCase { get; set; } = true;
        public bool ContainLowerCase { get; set; } = true;
        public bool ContainSymbol { get; set; } = true;
        public bool ContainNumber { get; set; } = true;
        public bool ContainWhiteSpace { get; set; } = false;
        public int MinimumLength { get; set; } = 10;
        public PasswordValidationFailureMessages FailureMessages { get; set; }

    }
}
