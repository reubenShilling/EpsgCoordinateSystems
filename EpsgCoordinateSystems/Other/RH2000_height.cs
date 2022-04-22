namespace EpsgCoordinateSystems.Other
{
    public class RH2000_height : IEpsgCoordinateSystem
    {
        public string Name => "RH2000 height";
        public string Units => "Unspecified";
public long Srid => 5613;

        public string OgcWkt =>
            "VERT_CS[RH2000 height,VERT_DATUM[Rikets hojdsystem 2000,2005,AUTHORITY[EPSG,5208]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5613]]";

        public string EsriWkt =>
            "VERT_CS[RH2000 height,VERT_DATUM[Rikets hojdsystem 2000,2005,AUTHORITY[EPSG,5208]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5613]]";
    }
}