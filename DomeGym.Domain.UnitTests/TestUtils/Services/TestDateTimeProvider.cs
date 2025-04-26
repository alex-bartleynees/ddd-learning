namespace DomeGym.Domain.UnitTests.TestUtils.Services;

using Domain.Common.Interfaces;

public class TestDateTimeProvider : IDateTimeProvider
{
    private readonly DateTime? _fixedDateTime;

    public TestDateTimeProvider(DateTime? fixedDateTime = null)
    {
        _fixedDateTime = fixedDateTime;
    }

    public DateTime UtcNow => _fixedDateTime ?? DateTime.UtcNow;
}
