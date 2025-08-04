using Application.Services.Interfaces.Security;
using Domain.Identity.Settings;

namespace Application.Services.Interfaces.Security;

public interface IEmailService
{
    Task SendEmailAsync(MailRequest mailRequest);

}