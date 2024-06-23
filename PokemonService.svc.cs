using System;
using System.Collections.Generic;
using System.Linq;

namespace WcfService1
{
    public class PokemonService : IPokemonService
    {
        public List<Pokemon> GetPokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon { Id = 1, Name = "Pikachu", BirthDate = new DateTime(2020, 1, 1) },
                new Pokemon { Id = 2, Name = "Charmander", BirthDate = new DateTime(2020, 2, 1) }
            };
        }

        public List<Pokemon> GetPokemonDb()
        {
            //read from database
            using (var context = new PokemonEntities())
            {
                return context.Pokemons.ToList();
            }
        }

        public Pokemon GetPokemonById(string id)
        {
            Int32.TryParse(id, out int intId);
            using (var context = new PokemonEntities())
            {
                return context.Pokemons.FirstOrDefault(p => p.Id == intId);
            }
        }

        public List<Owner> GetOwners()
        {
            return new List<Owner>
            {
                new Owner { Id = 1, Name = "Ash", Gym = "Pewter Gym" },
                new Owner { Id = 2, Name = "Misty", Gym = "Cerulean Gym"}
            };
        }

        public List<Reviewer> GetReviewers()
        {
            return new List<Reviewer>
            {
                new Reviewer { Id = 1, FirstName = "John", LastName = "Doe" },
                new Reviewer { Id = 2, FirstName = "Jane", LastName = "Smith" }
            };
        }

        public List<Review> GetReviews()
        {
            var reviewer = new Reviewer { Id = 1, FirstName = "John", LastName = "Doe" };
            var pokemon = new Pokemon { Id = 1, Name = "Pikachu", BirthDate = new DateTime(2020, 1, 1) };
            return new List<Review>
            {
                new Review { Id = 1, Title = "Great Pokemon", Text = "Pikachu is awesome!", Reviewer = reviewer, Pokemon = pokemon },
                new Review { Id = 2, Title = "Not bad", Text = "Charmander is pretty good.", Reviewer = reviewer, Pokemon = pokemon }
            };
        }

        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Electric" },
                new Category { Id = 2, Name = "Fire" }
            };
        }

        public List<PokemonCategory> GetPokemonCategories()
        {
            var pokemon = new Pokemon { Id = 1, Name = "Pikachu", BirthDate = new DateTime(2020, 1, 1) };
            var category = new Category { Id = 1, Name = "Electric" };
            return new List<PokemonCategory>
            {
                new PokemonCategory { PokemonId = 1, CategoryId = 1, Pokemon = pokemon, Category = category },
                new PokemonCategory { PokemonId = 2, CategoryId = 2, Pokemon = pokemon, Category = category }
            };
        }

        public void AddPokemon(Pokemon pokemon)
        {
            // Logic to add a Pokemon
        }

        public void AddOwner(Owner owner)
        {
            // Logic to add an Owner
        }

        public void AddReview(Review review)
        {
            // Logic to add a Review
        }

        public void AddCategory(Category category)
        {
            // Logic to add a Category
        }
    }
}
