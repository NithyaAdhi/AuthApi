namespace AuthApi.Models
{
    public class RefreshTokenResponseDto
    {
        public Guid UserId { get; set; }
        public required string RefreshToken { get; set; }
    }
}
