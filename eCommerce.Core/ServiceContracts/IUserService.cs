using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Core.DTO;

namespace eCommerce.Core.ServiceContracts
{
    public interface IUserService
    {
        /// <summary>
        /// Method to handle login use case and returns authentication response object that contains the login status
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        Task<AuthenticationResponse> Login(LoginRequest loginRequest);

        /// <summary>
        /// Method to handle registration use case and return authentication response type that represents status of user registration
        /// </summary>
        /// <param name="registerRequest"></param>
        /// <returns></returns>
        Task<AuthenticationResponse> Register(RegisterRequest registerRequest);

    }
}
