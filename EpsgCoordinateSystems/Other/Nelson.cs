namespace EpsgCoordinateSystems.Other
{
    public class Nelson : IEpsgCoordinateSystem
    {
        public string Name => "Nelson";
        public string Units => "Unspecified";
public long Srid => 5766;

        public string OgcWkt =>
            "VERT_CS[Nelson,VERT_DATUM[Nelson,2005,AUTHORITY[EPSG,5164]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5766]]";

        public string EsriWkt => "VERT_CS[Nelson,VERT_DATUM[Nelson,2005],UNIT[m,1.0]]";
    }
}