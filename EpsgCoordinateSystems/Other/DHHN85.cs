namespace EpsgCoordinateSystems.Other
{
    public class DHHN85 : IEpsgCoordinateSystem
    {
        public string Name => "DHHN85";
        public string Units => "Unspecified";
public long Srid => 5784;

        public string OgcWkt =>
            "VERT_CS[DHHN85,VERT_DATUM[Deutches Haupthohennetz 1985,2005,AUTHORITY[EPSG,5182]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5784]]";

        public string EsriWkt =>
            "VERT_CS[DHHN85,VERT_DATUM[Deutches Haupthohennetz 1985,2005,AUTHORITY[EPSG,5182]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5784]]";
    }
}