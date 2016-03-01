

namespace GameContester.Contracts.Services
{
    public interface ICaptchaService
    {
        bool checkCaptcha(string response);
    }
}
