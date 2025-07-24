using Sadie.Db.Models.Rooms;

namespace Sadie.Game.Navigator.Filterers;

public class OwnerFilterer : INavigatorSearchFilterer
{
    public string Name => "owner";
    
    public IQueryable<Room> Apply(IQueryable<Room> query, string value)
    {
        return query
            .Where(x => x.Owner.Username.Contains(value));
    }
}