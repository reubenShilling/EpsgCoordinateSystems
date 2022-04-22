namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_Average_Terrestrial_System_1977_ellipsoid : IEpsgCoordinateSystem
    {
        public string Name => "Unknown datum based upon the Average Terrestrial System 1977 ellipsoid";
        public string Units => "Unspecified";
public int Srid => 4041;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the Average Terrestrial System 1977 ellipsoid,DATUM[Not_specified_based_on_Average_Terrestrial_System_1977_ellipsoid,SPHEROID[Average Terrestrial System 1977,6378135,298.257,AUTHORITY[EPSG,7041]],AUTHORITY[EPSG,6041]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4041]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the Average Terrestrial System 1977 ellipsoid,DATUM[D_,SPHEROID[Average_Terrestrial_System_1977,6378135,298.257]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}