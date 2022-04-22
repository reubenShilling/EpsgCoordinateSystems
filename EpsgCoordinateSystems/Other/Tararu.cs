namespace EpsgCoordinateSystems.Other
{
    public class Tararu : IEpsgCoordinateSystem
    {
        public string Name => "Tararu";
        public string Units => "Unspecified";
public long Srid => 5768;

        public string OgcWkt =>
            "VERT_CS[Tararu,VERT_DATUM[Tararu,2005,AUTHORITY[EPSG,5166]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5768]]";

        public string EsriWkt =>
            "VERT_CS[Tararu,VERT_DATUM[Tararu,2005,AUTHORITY[EPSG,5166]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5768]]";
    }
}