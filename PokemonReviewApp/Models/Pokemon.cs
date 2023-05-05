namespace PokemonReviewApp.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<PokemonOwner> PokemonOwner { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }
    }
}
