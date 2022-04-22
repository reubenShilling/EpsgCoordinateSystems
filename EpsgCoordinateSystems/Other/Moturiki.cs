namespace EpsgCoordinateSystems.Other
{
    public class Moturiki : IEpsgCoordinateSystem
    {
        public string Name => "Moturiki";
        public string Units => "Unspecified";
public long Srid => 5764;

        public string OgcWkt =>
            "VERT_CS[Moturiki,VERT_DATUM[Moturiki,2005,AUTHORITY[EPSG,5162]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5764]]";

        public string EsriWkt =>
            "VERT_CS[Moturiki,VERT_DATUM[Moturiki,2005,AUTHORITY[EPSG,5162]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5764]]";
    }
}