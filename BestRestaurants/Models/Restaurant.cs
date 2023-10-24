namespace BestRestaurants.Models
{

  public class Restaurant
  {

    public string Name { get; set; }

    public string Description { get; set; }

    public int CuisineId { get; set; }

    public int RestaurantId { get; set; }

    public Cuisine Cuisine { get; set; }

  }
}