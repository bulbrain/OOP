struct Location
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public Planet Planet { get; set; }

    public Location(double latitide, double longitude, Planet planet)  : this()
    {
        this.Latitude = latitide;
        this.Longitude = longitude;
        this.Planet = planet;
    }

    public override string ToString()
    {
        return this.Latitude + ", " + this.Longitude + " - " + this.Planet;
    }
}