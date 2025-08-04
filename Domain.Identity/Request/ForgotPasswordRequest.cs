using System.ComponentModel.DataAnnotations;

namespace Domain.Identity.Request;

public class ForgotPasswordRequest
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }
}