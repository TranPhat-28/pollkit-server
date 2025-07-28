using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pollkit_server.Services.UserService
{
    public interface IUserService
    {
        ServiceResponse<User> GetUserById(int id);
        Task<ServiceResponse<int>> CreateMockUser();
    }
}