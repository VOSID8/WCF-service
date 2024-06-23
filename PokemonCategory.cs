namespace WcfService1
{
    public class PokemonCategory
    {
        public int PokemonId { get; internal set; }
        public int CategoryId { get; internal set; }
        public Pokemon Pokemon { get; internal set; }
        public Category Category { get; internal set; }
    }
}