using Postgrest.Attributes;
using Postgrest.Models;

namespace Database.Entity;
[Table("cities")]
public class CitiesEntity : BaseModel
{
    [PrimaryKey("id")]
    public int ID { get; set; }
    [Column("name")]
    public string? FullName { get; set; }
    [Column("country_id")]
    public int? CountryID { get; set; }
}