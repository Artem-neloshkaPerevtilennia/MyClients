using System.ComponentModel.DataAnnotations.Schema;

namespace MyClients.Entities;

/// <summary>
/// Represent's a grade of the route.
/// Inherits from <see cref="BaseEntity"/>.
/// </summary>
public class RouteGrade : BaseEntity
{
    /// <summary>
    /// The code of the grade.
    /// </summary>
    public string Grade { get; set; } = string.Empty;

    /// <summary>
    /// List of climbers, who climbs most of the boulders with this grade.
    /// </summary>
    [InverseProperty("ComfortableBoulderGrade")]
    public ICollection<Climber> ComfortableBoulderClimbers { get; set; } = new List<Climber>();

    /// <summary>
    /// List of climbers, who climbs most of the top rope routes with this grade.
    /// </summary>
    [InverseProperty("ComfortableTopGrade")]
    public ICollection<Climber> ComfortableTopClimbers { get; set; } = new List<Climber>();

    /// <summary>
    /// List of climbers, who climbs most of the lead climbing routes with this grade.
    /// </summary>
    [InverseProperty("ComfortableLeadGrade")]
    public ICollection<Climber> ComfortableLeadClimbers { get; set; } = new List<Climber>();

    /// <summary>
    /// List of the routes with this grade.
    /// </summary>
    public ICollection<Route> Routes { get; set; } = new List<Route>();
}
