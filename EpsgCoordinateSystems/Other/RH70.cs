namespace EpsgCoordinateSystems.Other
{
    public class RH70 : IEpsgCoordinateSystem
    {
        public string Name => "RH70";
        public string Units => "Unspecified";
public long Srid => 5718;

        public string OgcWkt =>
            "VERT_CS[RH70,VERT_DATUM[Rikets hojdsystem 1970,2005,AUTHORITY[EPSG,5117]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5718]]";

        public string EsriWkt =>
            "VERT_CS[RH70,VERT_DATUM[Rikets hojdsystem 1970,2005,AUTHORITY[EPSG,5117]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5718]]";
    }
}