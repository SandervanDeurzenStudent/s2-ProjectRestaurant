using BusinessLogic.Models;

namespace BusinessLogic.Restraurants
{
    public interface IRestaurantLogic
    {
        void update(int id, RestaurantModel restaurant);
    }
}