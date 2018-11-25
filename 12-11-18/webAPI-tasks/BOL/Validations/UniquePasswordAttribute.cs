﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace BOL.Validations
{
    class UniquePasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ValidationResult validationResult = ValidationResult.Success;
            try
            {
                string password = "";
                //Take userId and email of the user parameter
                int userId = (validationContext.ObjectInstance as User).UserId;
                if ((validationContext.ObjectInstance as User).IsNewWorker == false)
                    return null;
                try
                {
                     password = value.ToString();
                }
                catch
                {
                    ErrorMessage = "password can not be null";
                    validationResult = new ValidationResult(ErrorMessageString);
                    return validationResult;
                }
                //Invoke method 'getAllUsers' from 'UserService' in 'BLL project' by reflection (not by adding reference!)

                //1. Load 'BLL' project
                Assembly assembly = Assembly.LoadFrom(@"S:\ChavyBerman\webAPI-tasks\BLL\bin\Debug\BLL.dll");

                //2. Get 'UserService' type
                Type userServiceType = assembly.GetTypes().First(t => t.Name.Equals("LogicManager"));

                //3. Get 'GetAllUsers' method
                MethodInfo getAllUsersMethod = userServiceType.GetMethods().First(m => m.Name.Equals("GetAllUsers"));

                //4. Invoke this method
                List<User> users = getAllUsersMethod.Invoke(Activator.CreateInstance(userServiceType), new object[] { }) as List<User>;

                //The result of this method is list of users


                bool isUnique = users.Any(user => user.Password.Equals(password) && user.UserId != userId) == false;
                if (isUnique == false)
                {
                    ErrorMessage = "password nust be unique";
                    validationResult = new ValidationResult(ErrorMessageString);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return validationResult;
        }

    }




    
   
}
