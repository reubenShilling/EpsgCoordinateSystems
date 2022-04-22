namespace EpsgCoordinateSystems.Other
{
    public class DHHN92 : IEpsgCoordinateSystem
    {
        public string Name => "DHHN92";
        public string Units => "Unspecified";
public long Srid => 5783;

        public string OgcWkt =>
            "VERT_CS[DHHN92,VERT_DATUM[Deutches Haupthohennetz 1992,2005,AUTHORITY[EPSG,5181]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5783]]";

        public string EsriWkt =>
            "VERT_CS[DHHN92,VERT_DATUM[Deutches Haupthohennetz 1992,2005,AUTHORITY[EPSG,5181]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5783]]";
    }
}