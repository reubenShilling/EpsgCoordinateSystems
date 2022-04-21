namespace EpsgCoordinateSystems.Other
{
    public class Baltic_1982 : IEpsgCoordinateSystem
    {
        public string Name => "Baltic 1982";
        public long Srid => 5786;

        public string OgcWkt =>
            "VERT_CS[Baltic 1982,VERT_DATUM[Baltic 1982,2005,AUTHORITY[EPSG,5184]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5786]]";

        public string EsriWkt =>
            "VERT_CS[Baltic 1982,VERT_DATUM[Baltic 1982,2005,AUTHORITY[EPSG,5184]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5786]]";
    }
}