namespace EpsgCoordinateSystems.Other
{
    public class IGN_1988_SB_height : IEpsgCoordinateSystem
    {
        public string Name => "IGN 1988 SB height";
        public string Units => "Unspecified";
public long Srid => 5619;

        public string OgcWkt =>
            "VERT_CS[IGN 1988 SB height,VERT_DATUM[IGN 1988 SB,2005,AUTHORITY[EPSG,5213]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5619]]";

        public string EsriWkt =>
            "VERT_CS[IGN 1988 SB height,VERT_DATUM[IGN 1988 SB,2005,AUTHORITY[EPSG,5213]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5619]]";
    }
}