using PasswordValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    public interface IPasswordValidation
    {
        PasswordValidationResult ValidatePassword(string password, string confirmPassword);
        PasswordValidationResult ValidatePassword(string password, string confirmPassword, PasswordValidationConfiguration configuration);
    }
}
