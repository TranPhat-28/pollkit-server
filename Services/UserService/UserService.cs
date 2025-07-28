using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pollkit_server.Data;

namespace pollkit_server.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService(DataContext dataContext)
        {
            this._dataContext = dataContext;
        }

        public async Task<ServiceResponse<int>> CreateMockUser()
        {
            User mockUser = new User
            {
                Name = "Mr Demo User"
            };

            _dataContext.Users.Add(mockUser);
            await _dataContext.SaveChangesAsync();

            var result = new ServiceResponse<int>
            {
                Data = mockUser.Id,
                Message = "Mock user has been created"
            };

            return result;
        }

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