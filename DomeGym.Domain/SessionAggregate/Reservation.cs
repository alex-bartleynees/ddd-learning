namespace DomeGym.Domain.SessionAggregate;

using DomeGym.Domain.Common;

public class Reservation : Entity
{
    public readonly Guid ParticipantId;

    public Reservation(Guid participantId, Guid? id = null) : base(id ?? Guid.NewGuid())
    {
        participantId = participantId;
    }
}
