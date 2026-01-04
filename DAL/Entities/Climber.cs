namespace MyClients.Entities;

/// <summary>
/// Represents a person who climbs.
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public class Climber : BaseEntity
{
    /// <summary>
    /// The name of a climber.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The age of a climber.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// The gender of a climber.
    /// </summary>
    public char Gender { get; set; }

    /// <summary>
    /// The ID of climber's comfortable boulder's grade to climb.
    /// </summary>
    public int? ComfortableBoulderGradeId { get; set; }

    /// <summary>
    /// The <see cref="RouteGrade"/> object associated with this climber.
    /// </summary>
    public RouteGrade? ComfortableBoulderGrade { get; set; }

    /// <summary>
    /// The ID of climber's comfortable top rope route's grade to climb.
    /// </summary>
    public int? ComfortableTopGradeId { get; set; }

    /// <summary>
    /// The <see cref="RouteGrade"/> object associated with this climber.
    /// </summary>
    public RouteGrade? ComfortableTopGrade { get; set; }

    /// <summary>
    /// The ID of climber's comfortable lead climbing route's grade to climb.
    /// </summary>
    public int? ComfortableLeadGradeId { get; set; }

    /// <summary>
    /// The <see cref="RouteGrade"/> object associated with this climber.
    /// </summary>
    public RouteGrade? ComfortableLeadGrade { get; set; }

    /// <summary>
    /// The ID of climber's best boulder by grade.
    /// </summary>
    public int? BestBoulderRouteId { get; set; }

    /// <summary>
    /// The <see cref="Route"/> object associated with this climber.
    /// </summary>
    public Route? BestBoulderRoute { get; set; }

    /// <summary>
    /// The ID of climber's best top rope route by grade.
    /// </summary>
    public int? BestTopRouteId { get; set; }

    /// <summary>
    /// The <see cref="Route"/> object associated with this climber.
    /// </summary>
    public Route? BestTopRoute { get; set; }

    /// <summary>
    /// The ID of climber's best lead climbing route by grade.
    /// </summary>
    public int? BestLeadRouteId { get; set; }

    /// <summary>
    /// The <see cref="Route"/> object associated with this climber.
    /// </summary>
    public Route? BestLeadRoute { get; set; }

    /// <summary>
    /// The climber's fastest time on speed route.
    /// </summary>
    public TimeOnly? BestSpeedTime { get; set; }

    /// <summary>
    /// An additional information about the climber.
    /// </summary>
    public string? Description { get; set; } = string.Empty;

    /// <summary>
    /// List of the clients, who registrates a training session for the climber.
    /// </summary>
    public ICollection<Client> Clients { get; set; } = new List<Client>();

    /// <summary>
    /// List of training sessions, completed by the climber.
    /// </summary>
    public ICollection<TrainingSession> TrainingSessions { get; set; } = new List<TrainingSession>();
}