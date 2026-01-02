namespace MyClients.Entities;

/// <summary>
/// Represents zones in the gym.
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public class ZoneInGym : BaseEntity
{
    /// <summary>
    /// The name of the zone.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The ID of the <see cref="Gym"/> where zone is located.
    /// </summary>
    public int GymId { get; set; }

    /// <summary>
    /// The <see cref="Gym"/> object associated with this zone.
    /// </summary>
    public Gym? Gym { get; set; }

    /// <summary>
    /// The list of <see cref="Route"/> in this zone.
    /// </summary>
    public ICollection<Route> Routes { get; set; } = new List<Route>();
}