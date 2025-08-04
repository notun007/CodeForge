using Application.Services.Implementations.Security;
using Application.Services.Interfaces.Security;

namespace OA.Service.Implementation;

public class DateTimeService : IDateTimeService
{
    public DateTime NowUtc => DateTime.UtcNow;
}