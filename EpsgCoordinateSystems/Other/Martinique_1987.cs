namespace EpsgCoordinateSystems.Other
{
    public class Martinique_1987 : IEpsgCoordinateSystem
    {
        public string Name => "Martinique 1987";
        public string Units => "Unspecified";
public long Srid => 5756;

        public string OgcWkt =>
            "VERT_CS[Martinique 1987,VERT_DATUM[Martinique 1987,2005,AUTHORITY[EPSG,5154]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5756]]";

        public string EsriWkt => "VERT_CS[Martinique 1987,VERT_DATUM[Martinique 1987,2005],UNIT[m,1.0]]";
    }
}