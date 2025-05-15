using RSFRecomendations.Models;

namespace RSFRecomendations
{
    public class LoginResult
    {
        public bool Success { get; }
        public string Message { get; }
        public UserModel? User { get; }

        private LoginResult(bool success, string message, UserModel? user = null)
        {
            Success = success;
            Message = message;
            User = user;
        }

        public static LoginResult Fail(string message) => new(false, message);
        public static LoginResult Ok(UserModel user) => new(true, string.Empty, user);
    }
}
