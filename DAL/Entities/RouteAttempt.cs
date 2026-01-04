namespace MyClients.Entities;

/// <summary>
/// Represents an attempt to climb a route.
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public class RouteAttempt : BaseEntity
{
    /// <summary>
    /// The number of attempts spent on the route.
    /// </summary>
    public int TotalAttempts { get; set; }

    /// <summary>
    /// Indiates whether the route was succesfully finished ("sent").
    /// </summary>
    public bool IsSent { get; set; }

    /// <summary>
    /// The ID of the <see cref="Route"/> being attempted.
    /// </summary>
    public int? RouteId { get; set; }

    /// <summary>
    /// The <see cref="Route"/> object associated with this attempt.
    /// </summary>
    public Route? Route { get; set; }

    /// <summary>
    /// The ID of the <see cref="TrainingSession"/>, on which the route is attempted.
    /// </summary>
    public int TrainingSessionId { get; set; }

    /// <summary>
    /// The <see cref="TrainingSession"/> object associated with this attempt.
    /// </summary>
    public TrainingSession? TrainingSession { get; set; }
}
