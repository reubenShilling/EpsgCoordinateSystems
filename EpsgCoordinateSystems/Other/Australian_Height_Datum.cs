namespace EpsgCoordinateSystems.Other
{
    public class Australian_Height_Datum : IEpsgCoordinateSystem
    {
        public string Name => "Australian Height Datum";
        public long Srid => 5711;

        public string OgcWkt =>
            "VERT_CS[Australian Height Datum,VERT_DATUM[Australian Height Datum,2005,AUTHORITY[EPSG,5111]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5711]]";

        public string EsriWkt =>
            "VERT_CS[Australian Height Datum,VERT_DATUM[Australian Height Datum,2005,AUTHORITY[EPSG,5111]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5711]]";
    }
}