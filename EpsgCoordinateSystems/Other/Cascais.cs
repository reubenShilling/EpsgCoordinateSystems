namespace EpsgCoordinateSystems.Other
{
    public class Cascais : IEpsgCoordinateSystem
    {
        public string Name => "Cascais";
        public string Units => "Unspecified";
public long Srid => 5780;

        public string OgcWkt =>
            "VERT_CS[Cascais,VERT_DATUM[Cascais,2005,AUTHORITY[EPSG,5178]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5780]]";

        public string EsriWkt =>
            "VERT_CS[Cascais,VERT_DATUM[Cascais,2005,AUTHORITY[EPSG,5178]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5780]]";
    }
}