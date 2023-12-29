namespace Domain.Model;
public class Cities
{
    private int _id;
    private string? _name;
    private int? _countryId;

    public Cities(int id, string? name, int? countryId)
    {
        _id = id;
        _name = name;
        _countryId = countryId;
    }

    public int Id { get => _id; }
    public string? Name { get => _name; }
    public int? CountryId { get => _countryId; }
}