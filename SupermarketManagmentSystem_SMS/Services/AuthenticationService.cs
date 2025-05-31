using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagmentSystem_SMS.Models;
namespace SupermarketManagmentSystem_SMS.Services
{
    internal static class AuthenticationService
    {
        public static User? CurrentUser { get; set; } = null;
        static AuthenticationService() { }

        public static bool CreateUser(string firstName, string lastName, string nationalID, string password, string role, out string errorMessage)
        {
            errorMessage = string.Empty;
            if (!IsValidName(firstName) || !IsValidName(lastName))
            {
                errorMessage = "Invalid name format.";
                return false;
            }
            if (!IsValidNationalID(nationalID))
            {
                errorMessage = "Invalid National ID format.";
                return false;
            }
            if (!IsValidPassword(password))
            {
                errorMessage = "Password must be at least 8 characters long.";
                return false;
            }
            if (!IsValidRole(role))
            {
                errorMessage = "Invalid role. Must be either 'Admin' or 'Cashier'.";
                return false;
            }
            ApplicationDbContextFactory dbContextFactory = new ApplicationDbContextFactory();
            using var dbContext = dbContextFactory.CreateDbContext(null);
            string hashedPassword = HashPassword(password);
            dbContext.Users.Add(new Models.User
            {
                FirstName = firstName,
                LastName = lastName,
                NationalID = nationalID,
                PasswordHash = hashedPassword,
                Role = role == "Admin" ? Utilities.UserRole.Admin : Utilities.UserRole.Cashier
            });
            return true;
        }
        //login or authenticate the user
        public static bool AuthenticateUser(string nationalID, string password, out Models.User? user)
        {
            user = null;
            if (!IsValidNationalID(nationalID) || !IsValidPassword(password))
            {
                return false;
            }
            ApplicationDbContextFactory dbContextFactory = new ApplicationDbContextFactory();
            using (var dbContext = dbContextFactory.CreateDbContext(null))
            {
                user = dbContext.Users.FirstOrDefault(u => u.NationalID == nationalID);
                if (user != null && VerifyPassword(password, user.PasswordHash))
                {
                    CurrentUser = user;
                    return true;
                }
                return false;
            }
        }
        //logout 
        public static void Logout()
        {
            CurrentUser = null; 
        }

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        
        }
        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
        public static bool IsValidNationalID(string nationalID)
        {
            return nationalID.Length == 14 && nationalID.All(char.IsDigit);
        }
        public static bool IsValidPassword(string password)
        {
            return password.Length >= 8;
        }
        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }


        public static bool IsValidRole(string role)
        {
            return role == "Admin" || role == "Cashier";
        }
    }
}
