using System.ComponentModel.DataAnnotations.Schema;

namespace MyClients.Entities;

/// <summary>
/// Represents a climbing route in the gym.
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public class Route : BaseEntity
{
    /// <summary>
    /// The route's number (if applicable).
    /// </summary>
    public int? Number { get; set; }

    /// <summary>
    /// The route's description: type of holds, key movements, color, etc.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// The ID of the <see cref="RouteGrade"/>.
    /// </summary>
    public int GradeId { get; set; }

    /// <summary>
    /// The grade object associated with this route.
    /// </summary>
    public RouteGrade? Grade { get; set; }

    /// <summary>
    /// The ID of the climbing <see cref="Discipline"/> this route is made for.
    /// </summary>
    public int DisciplineId { get; set; }

    /// <summary>
    /// The discipline object associated with this route.
    /// </summary>
    public Discipline? Discipline { get; set; }

    /// <summary>
    /// The ID of the <see cref="ZoneInGym"/> where the route is located.
    /// </summary>
    public int ZoneInGymId { get; set; }

    /// <summary>
    /// The zone object associated with this route.
    /// </summary>
    public ZoneInGym? ZoneInGym { get; set; }

    /// <summary>
    /// The list of attempts made on this route.
    /// </summary>
    public ICollection<RouteAttempt> RouteAttempts { get; set; } = new List<RouteAttempt>();

    /// <summary>
    /// The list of climbers who consider this their best boulder.
    /// </summary>
    [InverseProperty("BestBoulderRoute")]
    public ICollection<Climber> BestBoulderClimbers { get; set; } = new List<Climber>();

    /// <summary>
    /// The list of climbers who consider this their best top rope route.
    /// </summary>
    [InverseProperty("BestTopRoute")]
    public ICollection<Climber> BestTopClimbers { get; set; } = new List<Climber>();

    /// <summary>
    /// The list of climbers who consider this their best lead route.
    /// </summary>
    [InverseProperty("BestLeadRoute")]
    public ICollection<Climber> BestLeadClimbers { get; set; } = new List<Climber>();
}
