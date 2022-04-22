namespace EpsgCoordinateSystems.Other
{
    public class Canadian_Geodetic_Vertical_Datum_of_1928 : IEpsgCoordinateSystem
    {
        public string Name => "Canadian Geodetic Vertical Datum of 1928";
        public string Units => "Unspecified";
public long Srid => 5713;

        public string OgcWkt =>
            "VERT_CS[Canadian Geodetic Vertical Datum of 1928,VERT_DATUM[Canadian Geodetic Vertical Datum of 1928,2005,AUTHORITY[EPSG,5114]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5713]]";

        public string EsriWkt =>
            "VERT_CS[Canadian Geodetic Vertical Datum of 1928,VERT_DATUM[Canadian Geodetic Vertical Datum of 1928,2005,AUTHORITY[EPSG,5114]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5713]]";
    }
}