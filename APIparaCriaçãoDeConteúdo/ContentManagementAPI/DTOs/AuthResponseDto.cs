namespace ContentManagementAPI.DTOs
{
    public class AuthResponseDto
    {
        public string Token { get; set; } = string.Empty; 
        public string UserId { get; set; } = string.Empty; 

        public AuthResponseDto() { }
    }
}
