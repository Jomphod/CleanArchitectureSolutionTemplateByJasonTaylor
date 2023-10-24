using _9Devster.Application.Common.Interfaces;

namespace _9Devster.Infrastructure.Services;
public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
