using ErrorOr;

namespace SessionReservation.Domain.Common.EventualConsistency;

public class EventualConsistencyException : Exception
{
    public Error EventualConsistencyError { get; }
    public List<Error> UnderlyingErrors { get; }

    public EventualConsistencyException(Error eventualConsistencyError, List<Error>? underlyingErrors = null) : base(message: eventualConsistencyError.Description)
    {
        EventualConsistencyError = eventualConsistencyError;
        UnderlyingErrors = underlyingErrors ?? new();
    }
}