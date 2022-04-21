namespace EpsgCoordinateSystems.Other
{
    public class RH00_height : IEpsgCoordinateSystem
    {
        public string Name => "RH00 height";
        public long Srid => 5615;

        public string OgcWkt =>
            "VERT_CS[RH00 height,VERT_DATUM[Rikets hojdsystem 1900,2005,AUTHORITY[EPSG,5209]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5615]]";

        public string EsriWkt =>
            "VERT_CS[RH00 height,VERT_DATUM[Rikets hojdsystem 1900,2005,AUTHORITY[EPSG,5209]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5615]]";
    }
}