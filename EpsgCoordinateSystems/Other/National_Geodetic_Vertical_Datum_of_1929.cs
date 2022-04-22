namespace EpsgCoordinateSystems.Other
{
    public class National_Geodetic_Vertical_Datum_of_1929 : IEpsgCoordinateSystem
    {
        public string Name => "National Geodetic Vertical Datum of 1929";
        public string Units => "Unspecified";
public long Srid => 5702;

        public string OgcWkt =>
            "VERT_CS[National Geodetic Vertical Datum of 1929,VERT_DATUM[National Geodetic Vertical Datum 1929,2005,AUTHORITY[EPSG,5102]],UNIT[foot_survey_us,0.30480060960121924],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5702]]";

        public string EsriWkt =>
            "VERT_CS[National Geodetic Vertical Datum of 1929,VERT_DATUM[National Geodetic Vertical Datum 1929,2005,AUTHORITY[EPSG,5102]],UNIT[foot_survey_us,0.30480060960121924],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5702]]";
    }
}