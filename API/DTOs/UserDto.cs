namespace API.DTOs
{
    public class UserDto
    {
        public string Email { get; set; }
        public string Token { get; set; }

        public BasketDto basketDto {get;set;}

    }
}