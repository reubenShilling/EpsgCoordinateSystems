namespace EpsgCoordinateSystems.Other
{
    public class Caspian_height : IEpsgCoordinateSystem
    {
        public string Name => "Caspian height";
        public string Units => "Unspecified";
public long Srid => 5611;

        public string OgcWkt =>
            "VERT_CS[Caspian height,VERT_DATUM[Caspian Sea,2005,AUTHORITY[EPSG,5106]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5611]]";

        public string EsriWkt => "VERT_CS[Caspian height,VERT_DATUM[Caspian Sea,2005],UNIT[m,1.0]]";
    }
}