namespace FreakyFashion.Models.DTO
{
    public class UserTokenDto
    {
        public AuthTokenDto AuthToken { get; set; }
        public ApplicationUserDto User { get; set; }
    }
}
