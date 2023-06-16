using FreakyFashion.Models.Domain;
using FreakyFashion.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace FreakyFashion.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;

        public AuthController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<ActionResult<AuthTokenDto>> CreateToken(CredentialsDto credentialsDto)
        {

            var user = await userManager.FindByNameAsync(credentialsDto.UserName);

            var hasAccess = await userManager.CheckPasswordAsync(user, credentialsDto.Password);

            if (!hasAccess)
            {
                return Unauthorized();
            }

            var token = GenerateToken(user);

            //return Ok(token);

            var userToken = new UserTokenDto
            {
                AuthToken = token,
                User = MapUserToDto(user) // Konvertera ApplicationUser till ApplicationUserDto
            };

            return Ok(userToken);
        }

        private AuthTokenDto GenerateToken(ApplicationUser user)
        {
            var signingKey = Convert.FromBase64String("tKE+pMd2rQAHBbOjXWTZqacLJRLqlrnTzZdmKRJEXLjtiGOnFY3w+vuUxPSgLdMFbbVXxPrFWNUd/yQyG5PsEg==");

            var claims = new List<Claim>();

            var roles = userManager.GetRolesAsync(user).Result;

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(signingKey),
                    SecurityAlgorithms.HmacSha256Signature),
                Subject = new ClaimsIdentity(claims),
            };

            var jwtTokenHandler = new JwtSecurityTokenHandler();

            var jwtSecurityToken = jwtTokenHandler
              .CreateJwtSecurityToken(tokenDescriptor);

            var authToken = new AuthTokenDto
            {
                Token = jwtTokenHandler.WriteToken(jwtSecurityToken)
            };

            return authToken;
        }

        private ApplicationUserDto MapUserToDto(ApplicationUser user)
           => new ApplicationUserDto
           {
               FirstName = user.FirstName,
               LastName = user.LastName,
               Email = user.Email,
               Address = user.Address,
               City = user.City,
               Region = user.Region,
               PostalCode = user.PostalCode,
           };

    }
}
