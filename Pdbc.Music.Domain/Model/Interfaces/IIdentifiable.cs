namespace Pdbc.Music.Domain.Model
{
    public interface IIdentifiable<TId>
    {
        TId Id { get; set; }
    }
}