namespace DomeGym.Domain.TrainerAggregate;

using ErrorOr;

public static class TrainerErrors
{
    public static readonly Error CannotHaveTwoOrMoreOverlappingSessions = Error.Validation(
        "Trainer.CannotHaveTwoOrMoreOverlappingSessions",
        "A trainer cannot have two or more overlapping sessions");
}