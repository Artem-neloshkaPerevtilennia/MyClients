namespace MyClients.Entities;

/// <summary>
/// Represents the client's training session.
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public class TrainingSession : BaseEntity
{
    /// <summary>
    /// The training session's date.
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// The training session's warm-up.
    /// </summary>
    public string WarmUp { get; set; } = string.Empty;

    /// <summary>
    /// The training session's calm-down.
    /// </summary>
    public string CalmDown { get; set; } = string.Empty;

    /// <summary>
    /// The ID of the <see cref="Climber"/> being trained.
    /// </summary>
    public int? ClimberId { get; set; }

    /// <summary>
    /// The <see cref="Climber"/> object associated with this training session.
    /// </summary>
    public Climber? Climber { get; set; }

    /// <summary>
    /// The list of <see cref="RouteAttempt"/> being completed during the training.
    /// </summary>
    public ICollection<RouteAttempt> RouteAttempts { get; set; } = new List<RouteAttempt>();
}