using System;
namespace GameContester.Contracts.Services
{
    public interface IMailService
    {
        void Send(string userEmail, string message);
    }
}
