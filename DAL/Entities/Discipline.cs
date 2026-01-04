namespace MyClients.Entities;

/// <summary>
/// Represents the climbing's discipline.
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public class Discipline : BaseEntity
{
    /// <summary>
    /// The name of the discipline.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// The list of the <see cref="Route"/> in this discipline. 
    /// </summary>
    public ICollection<Route> Routes { get; set; } = new List<Route>();
}