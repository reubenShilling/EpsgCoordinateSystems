namespace EpsgCoordinateSystems.Other
{
    public class Sule_Skerry : IEpsgCoordinateSystem
    {
        public string Name => "Sule Skerry";
        public string Units => "Unspecified";
public long Srid => 5744;

        public string OgcWkt =>
            "VERT_CS[Sule Skerry,VERT_DATUM[Sule Skerry,2005,AUTHORITY[EPSG,5142]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5744]]";

        public string EsriWkt => "VERT_CS[Sule Skerry,VERT_DATUM[Sule Skerry,2005],UNIT[m,1.0]]";
    }
}