namespace EpsgCoordinateSystems.Other
{
    public class Dunedin : IEpsgCoordinateSystem
    {
        public string Name => "Dunedin";
        public string Units => "Unspecified";
public long Srid => 5761;

        public string OgcWkt =>
            "VERT_CS[Dunedin,VERT_DATUM[Dunedin,2005,AUTHORITY[EPSG,5159]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5761]]";

        public string EsriWkt =>
            "VERT_CS[Dunedin,VERT_DATUM[Dunedin,2005,AUTHORITY[EPSG,5159]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5761]]";
    }
}