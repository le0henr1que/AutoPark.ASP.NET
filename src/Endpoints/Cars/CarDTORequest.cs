namespace AutoPark.Endpoints.Cars
{
    public class CarDTORequest
    {
        
        public string Name {get; set;}
        public string City { get; set; }
        public string Brand { get; set; }  
        public string Model { get; set; }
        public string Year { get; set; }
        public string Quilometragem { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
    }
}