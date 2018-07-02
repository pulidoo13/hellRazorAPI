using DataContractTormund.Solution.Users;
using Model.Comercial.Customers;
using Model.Solution.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BussinessLogic.Comercial.Solution.Users
{
   public static class UserManager
    {
        public static List<UserDC> users_search(Model.Configuration.Context _context, UserDC user)
        {

           return _context.Users
                .Where(p =>
                (
                    user.user_id == 0 || user.user_id > 0 && user.user_id == p.Id) &&
                    (string.IsNullOrEmpty(user.name) || (!string.IsNullOrEmpty(user.name) && user.name == p.Name))      &&
                    (string.IsNullOrEmpty(user.facebook_user_id) || (!string.IsNullOrEmpty(user.facebook_user_id) && user.facebook_user_id == p.TokenFacebook))&&
                    (string.IsNullOrEmpty(user.google_user_id) || (!string.IsNullOrEmpty(user.google_user_id) && user.google_user_id == p.TokenGoogle)) 

                )
                .Select(p => new UserDC { user_id = p.Id, name = p.Name,fromApplication=p.FromApplication,creationDate=p.CreationDate }).ToList();
        }

        public static List<UserDC> users_create(Model.Configuration.Context _context, UserDC userDC)
        {
            try
            {
               

                User newUser = new User();
                Customer customer = new Customer();
                customer.User = newUser;
                customer.CreationDate = DateTime.Now;

                newUser.Name = userDC.name;
                newUser.TokenFacebook = userDC.facebook_user_id;
                newUser.TokenGoogle = userDC.google_user_id;
                newUser.Email = userDC.google_mail;
                newUser.User_type = userDC.user_type;
                newUser.CreationDate = DateTime.Now;
                newUser.FromApplication = userDC.fromApplication;

                _context.Users.Add(newUser);
                _context.Customers.Add(customer);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                return users_search(_context, userDC) ;
            }
           
            return users_search(_context, userDC);
        }


        public static bool users_exists(Model.Configuration.Context _context, UserDC user)
        {
            try
            {
                var users = users_search(_context,  user);
                if (users.Any())
                {
                    return true;
                }
                else {
                    return false;
                }

                
            }
            catch (Exception e)
            {

                return false;
            }

            return true;
        }


    }
}
