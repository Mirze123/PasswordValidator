
# Password Validation Library

This program provides functionality to validate a password based on various conditions like length, containing uppercase and lowercase letters, numbers, symbols, etc. The program is written in C# and uses Regular Expressions to match patterns.

# How to use

1. Include the PasswordValidator namespace.
2. Create an instance of the PasswordValidation class.
3. Call the ValidatePassword() method, passing the password and confirm password strings as arguments.
4. The method returns an instance of the PasswordValidationResult class that indicates whether the password is valid or not.
5. You can also pass an instance of the PasswordValidationConfiguration class to customize the validation conditions.


# Methods

`ValidatePassword(string password, string confirmPassword)`

This method validates the password and confirm password strings and returns a PasswordValidationResult instance.

`ValidatePassword(string password, string confirmPassword, PasswordValidationConfiguration configuration)`

This method validates the password and confirm password strings and returns a PasswordValidationResult instance based on the specified PasswordValidationConfiguration conditions.

`PasswordValidationResult`

This class represents the result of password validation.

`Properties`

`IsValid`  
This property gets a value indicating whether the password is valid or not.

`FailureMessages`  
This property gets a list of failure messages if the password is not valid.

`PasswordValidationConfiguration`

This class represents the configuration options for password validation.

`Properties`

`ContainWhiteSpace`  

This property indicates whether the password should contain white space or not.

`ContainUpperCase`

This property indicates whether the password should contain uppercase letters or not.

`ContainLowerCase`

This property indicates whether the password should contain lowercase letters or not.

`ContainNumber`

This property indicates whether the password should contain numbers or not.

`ContainSymbol`

This property indicates whether the password should contain symbols or not.

`MinimumLength`

This property indicates the minimum length of the password.

`FailureMessages`

This property contains a list of failure messages for each validation condition.

# Examples

1. With Default Configurations

```cs

IPasswordValidation passwordValidation = new PasswordValidation();
var result = passwordValidation.ValidatePassword(password,confirmPassword);

if(result.IsValid)
{
  //do some stuff here
}
else
{
  Console.Writeline(result.FailureMessages);
}

```

2. With Customized configurations

``` cs
IPasswordValidation passwordValidation = new PasswordValidation();

var result = passwordValidation.ValidatePassword(password, confirmPassword,new PasswordValidationConfiguration()
{
    ContainLowerCase = true,
    ContainNumber = true,
    ContainSymbol = false,
    ContainUpperCase = true,
    ContainWhiteSpace = false,
    FailureMessages = new PasswordValidationFailureMessages()
    {
        PasswordsDoesntMatch = "Passwords are incorrect",
        DoesNotContainNumber = "Password does not contain a number"
    }
});

```


