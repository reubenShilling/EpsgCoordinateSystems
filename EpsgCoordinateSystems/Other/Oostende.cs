namespace EpsgCoordinateSystems.Other
{
    public class Oostende : IEpsgCoordinateSystem
    {
        public string Name => "Oostende";
        public string Units => "Unspecified";
public long Srid => 5710;

        public string OgcWkt =>
            "VERT_CS[Oostende,VERT_DATUM[Oostende,2005,AUTHORITY[EPSG,5110]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5710]]";

        public string EsriWkt =>
            "VERT_CS[Oostende,VERT_DATUM[Oostende,2005,AUTHORITY[EPSG,5110]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5710]]";
    }
}