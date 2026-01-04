namespace MyClients.Entities;

/// <summary>
/// Represents the person who registers and pays for training. 
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public class Client : BaseEntity
{
    /// <summary>
    /// The client's first name.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The client's last name (surname).
    /// </summary>
    public string Surname { get; set; } = string.Empty;

    /// <summary>
    /// The list of <see cref="Climber"/> (athletes) this client is responsible for.
    /// </summary>
    public ICollection<Climber> Climbers { get; set; } = new List<Climber>();
}
