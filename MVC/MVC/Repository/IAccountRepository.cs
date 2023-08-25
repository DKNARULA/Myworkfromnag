using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(Register userModel);
        
        Task<SignInResult> PasswordSignInAsync(SignInModel signInModel);

        Task SignOutAsync();
    }
}