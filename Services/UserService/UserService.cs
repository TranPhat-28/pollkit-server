using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollkit_server.Services.UserService
{
    public class UserService : IUserService
    {
        public ServiceResponse<User> GetUserById(int id)
        {
            User mockUser = new User
            {
                Id = id,
                Name = "Mr Mock Data"
            };

            ServiceResponse<User> result = new ServiceResponse<User>
            {
                Data = mockUser
            };

            return result;
        }
    }
}