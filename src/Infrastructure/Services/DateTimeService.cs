using CA.XUnit.Application.Common.Interfaces;

namespace CA.XUnit.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
