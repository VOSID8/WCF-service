using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfService1
{
    [ServiceContract]
    public interface IPokemonService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetPokemonDb")]
        List<Pokemon> GetPokemonDb();

        [OperationContract]
        [WebGet(UriTemplate = "/GetPokemonById/{id}")]
        Pokemon GetPokemonById(string id);


        [OperationContract]
        [WebGet(UriTemplate = "/GetPokemon")]
        List<Pokemon> GetPokemon();

        [OperationContract]
        [WebGet(UriTemplate = "/GetOwners")]
        List<Owner> GetOwners();

        [OperationContract]
        [WebGet(UriTemplate = "/GetReviewers")]
        List<Reviewer> GetReviewers();

        [OperationContract]
        [WebGet(UriTemplate = "/GetReviews")]
        List<Review> GetReviews();

        [OperationContract]
        [WebGet(UriTemplate = "/GetCategories")]
        List<Category> GetCategories();

        [OperationContract]
        [WebGet(UriTemplate = "/GetPokemonCategories")]
        List<PokemonCategory> GetPokemonCategories();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddPokemon", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddPokemon(Pokemon pokemon);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddOwner", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddOwner(Owner owner);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddReview", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddReview(Review review);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/AddCategory", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        void AddCategory(Category category);
    }
}
