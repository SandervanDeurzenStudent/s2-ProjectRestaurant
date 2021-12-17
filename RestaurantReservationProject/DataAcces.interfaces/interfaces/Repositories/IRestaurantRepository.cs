
using DataAccess.interfaces.RestaurantsDto;

 namespace DataAcces.interfaces.Repositories
{
    public interface IRestaurantRepository
    {
       void update(int id, RestaurantDto restaurant);   
    }
}
