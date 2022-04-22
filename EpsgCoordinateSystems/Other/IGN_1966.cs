namespace EpsgCoordinateSystems.Other
{
    public class IGN_1966 : IEpsgCoordinateSystem
    {
        public string Name => "IGN 1966";
        public string Units => "Unspecified";
public long Srid => 5601;

        public string OgcWkt =>
            "VERT_CS[IGN 1966,VERT_DATUM[IGN 1966,2005,AUTHORITY[EPSG,5196]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5601]]";

        public string EsriWkt => "VERT_CS[IGN 1966,VERT_DATUM[IGN 1966,2005],UNIT[m,1.0]]";
    }
}