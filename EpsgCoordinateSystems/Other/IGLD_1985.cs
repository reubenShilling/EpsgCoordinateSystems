namespace EpsgCoordinateSystems.Other
{
    public class IGLD_1985 : IEpsgCoordinateSystem
    {
        public string Name => "IGLD 1985";
        public string Units => "Unspecified";
public long Srid => 5609;

        public string OgcWkt =>
            "VERT_CS[IGLD 1985,VERT_DATUM[International Great Lakes Datum 1985,2005,AUTHORITY[EPSG,5205]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5609]]";

        public string EsriWkt =>
            "VERT_CS[IGLD 1985,VERT_DATUM[International Great Lakes Datum 1985,2005,AUTHORITY[EPSG,5205]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5609]]";
    }
}