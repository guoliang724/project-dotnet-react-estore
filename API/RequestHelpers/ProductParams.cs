namespace API.RequestHelpers
{
    public class ProductParams : PageinationParams
    {
        public string OrderBy { get; set; }
        public string Search { get; set; }
        public string Brands { get; set; }
        public string Types { get; set; }

    }
}