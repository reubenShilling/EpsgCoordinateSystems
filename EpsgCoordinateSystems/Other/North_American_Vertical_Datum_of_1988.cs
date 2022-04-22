namespace EpsgCoordinateSystems.Other
{
    public class North_American_Vertical_Datum_of_1988 : IEpsgCoordinateSystem
    {
        public string Name => "North American Vertical Datum of 1988";
        public string Units => "Unspecified";
public long Srid => 5703;

        public string OgcWkt =>
            "VERT_CS[North American Vertical Datum of 1988,VERT_DATUM[North American Vertical Datum 1988,2005,AUTHORITY[EPSG,5103]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5703]]";

        public string EsriWkt =>
            "VERT_CS[North American Vertical Datum of 1988,VERT_DATUM[North American Vertical Datum 1988,2005,AUTHORITY[EPSG,5103]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5703]]";
    }
}