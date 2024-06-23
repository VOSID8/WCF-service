using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfService2
{
    [ServiceContract]
    public interface IService1
    {
        // Category Endpoints
        [OperationContract]
        [WebGet(UriTemplate = "categories", ResponseFormat = WebMessageFormat.Json)]
        List<Category> GetAllCategories();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "category", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Category CreateCategory(Category category);

        [OperationContract]
        [WebGet(UriTemplate = "category/{categoryId}", ResponseFormat = WebMessageFormat.Json)]
        Category GetCategoryById(string categoryId);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "category/{categoryId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Category UpdateCategoryById(string categoryId, Category category);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "category/{categoryId}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteCategoryById(string categoryId);

        [OperationContract]
        [WebGet(UriTemplate = "category/{categoryId}/pokemons", ResponseFormat = WebMessageFormat.Json)]
        List<Pokemon> GetPokemonsByCategoryId(string categoryId);

        // Country Endpoints
        [OperationContract]
        [WebGet(UriTemplate = "countries", ResponseFormat = WebMessageFormat.Json)]
        List<Country> GetAllCountries();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "country", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Country CreateCountry(Country country);

        [OperationContract]
        [WebGet(UriTemplate = "country/{countryId}", ResponseFormat = WebMessageFormat.Json)]
        Country GetCountryById(string countryId);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "country/{countryId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Country UpdateCountryById(string countryId, Country country);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "country/{countryId}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteCountryById(string countryId);

        [OperationContract]
        [WebGet(UriTemplate = "country/{countryId}/owners", ResponseFormat = WebMessageFormat.Json)]
        List<Owner> GetOwnersByCountryId(string countryId);

        // Owner Endpoints
        [OperationContract]
        [WebGet(UriTemplate = "owners", ResponseFormat = WebMessageFormat.Json)]
        List<Owner> GetAllOwners();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "owner", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Owner CreateOwner(Owner owner);

        [OperationContract]
        [WebGet(UriTemplate = "owner/{ownerId}", ResponseFormat = WebMessageFormat.Json)]
        Owner GetOwnerById(string ownerId);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "owner/{ownerId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Owner UpdateOwnerById(string ownerId, Owner owner);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "owner/{ownerId}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteOwnerById(string ownerId);

        [OperationContract]
        [WebGet(UriTemplate = "owner/{ownerId}/pokemons", ResponseFormat = WebMessageFormat.Json)]
        List<Pokemon> GetPokemonsByOwnerId(string ownerId);

        // Pokemon Endpoints
        [OperationContract]
        [WebGet(UriTemplate = "pokemons", ResponseFormat = WebMessageFormat.Json)]
        List<Pokemon> GetAllPokemons();

        [OperationContract]
        [WebGet(UriTemplate = "pokemon/{pokemonId}", ResponseFormat = WebMessageFormat.Json)]
        Pokemon GetPokemonById(string pokemonId);

        [OperationContract]
        [WebGet(UriTemplate = "pokemon/{pokemonId}/rating", ResponseFormat = WebMessageFormat.Json)]
        Rating GetPokemonRatingById(string pokemonId);

        // Review Endpoints
        [OperationContract]
        [WebGet(UriTemplate = "reviews", ResponseFormat = WebMessageFormat.Json)]
        List<Review> GetAllReviews();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "review", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Review CreateReview(Review review);

        [OperationContract]
        [WebGet(UriTemplate = "review/{reviewId}", ResponseFormat = WebMessageFormat.Json)]
        Review GetReviewById(string reviewId);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "review/{reviewId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Review UpdateReviewById(string reviewId, Review review);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "review/{reviewId}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteReviewById(string reviewId);

        [OperationContract]
        [WebGet(UriTemplate = "review/pokemon/{pokemonId}", ResponseFormat = WebMessageFormat.Json)]
        List<Review> GetReviewsByPokemonId(string pokemonId);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "reviews/reviewer/{reviewerId}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteReviewsByReviewerId(string reviewerId);

        // Reviewer Endpoints
        [OperationContract]
        [WebGet(UriTemplate = "reviewers", ResponseFormat = WebMessageFormat.Json)]
        List<Reviewer> GetAllReviewers();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "reviewer", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Reviewer CreateReviewer(Reviewer reviewer);

        [OperationContract]
        [WebGet(UriTemplate = "reviewer/{reviewerId}", ResponseFormat = WebMessageFormat.Json)]
        Reviewer GetReviewerById(string reviewerId);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "reviewer/{reviewerId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        Reviewer UpdateReviewerById(string reviewerId, Reviewer reviewer);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "reviewer/{reviewerId}", ResponseFormat = WebMessageFormat.Json)]
        string DeleteReviewerById(string reviewerId);

        [OperationContract]
        [WebGet(UriTemplate = "reviewer/{reviewerId}/reviews", ResponseFormat = WebMessageFormat.Json)]
        List<Review> GetReviewsByReviewerId(string reviewerId);
    }

    // Data Contracts
    [DataContract]
    public class Category
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public ICollection<Pokemon> Pokemons { get; set; }
    }

    [DataContract]
    public class Country
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public ICollection<Owner> Owners { get; set; }
    }

    [DataContract]
    public class Owner
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Gym { get; set; }

        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        public Country Country { get; set; }

        [DataMember]
        public ICollection<Pokemon> Pokemons { get; set; }
    }

    [DataContract]
    public class Pokemon
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public DateTime BirthDate { get; set; }

        [DataMember]
        public ICollection<Review> Reviews { get; set; }

        [DataMember]
        public ICollection<Category> Categories { get; set; }

        [DataMember]
        public ICollection<Owner> Owners { get; set; }
    }

    [DataContract]
    public class Review
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public int Rating { get; set; }

        [DataMember]
        public int ReviewerId { get; set; }

        [DataMember]
        public int PokemonId { get; set; }

        [DataMember]
        public Pokemon Pokemon { get; set; }

        [DataMember]
        public Reviewer Reviewer { get; set; }
    }

    [DataContract]
    public class Reviewer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public ICollection<Review> Reviews { get; set; }
    }

    [DataContract]
    public class Rating
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public int Score { get; set; }
    }
}
