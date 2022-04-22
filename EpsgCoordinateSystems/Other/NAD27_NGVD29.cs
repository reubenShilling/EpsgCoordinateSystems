namespace EpsgCoordinateSystems.Other
{
    public class NAD27_NGVD29 : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 + NGVD29";
        public string Units => "Unspecified";
public long Srid => 7406;

        public string OgcWkt =>
            "COMPD_CS[NAD27 + NGVD29,GEOGCS[NAD27,DATUM[North American Datum 1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[-4.2,135.4,181.9,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4267]],VERT_CS[National Geodetic Vertical Datum of 1929,VERT_DATUM[National Geodetic Vertical Datum 1929,2005,AUTHORITY[EPSG,5102]],UNIT[foot_survey_us,0.30480060960121924],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5702]],AUTHORITY[EPSG,7406]]";

        public string EsriWkt => "COMPD_CS[NAD27 + NGVD29,GEOGCS[GCS_North_American_1927,DATUM[D_North American Datum 1927,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],VERT_CS[National Geodetic Vertical Datum of 1929,VERT_DATUM[National Geodetic Vertical Datum 1929,2005],UNIT[foot_survey_us,0.30480060960121924]]]";
    }
}