namespace MyClients.Entities;

/// <summary>
/// Represents a climbing gym.
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public class Gym : BaseEntity
{
    /// <summary>
    /// The gym's name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// List of the zones in the gym.
    /// </summary>
    public ICollection<ZoneInGym> ZonesInGym { get; set; } = new List<ZoneInGym>();
}
