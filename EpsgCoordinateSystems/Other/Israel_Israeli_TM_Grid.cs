namespace EpsgCoordinateSystems.Other
{
    public class Israel_Israeli_TM_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Israel / Israeli TM Grid";
        public string Units => "Unspecified";
public long Srid => 2039;

        public string OgcWkt =>
            "PROJCS[Israel / Israeli TM Grid,GEOGCS[Israel,DATUM[Israel,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[-48,55,52,0,0,0,0],AUTHORITY[EPSG,6141]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4141]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31.73439361111111],PARAMETER[central_meridian,35.20451694444445],PARAMETER[scale_factor,1.0000067],PARAMETER[false_easting,219529.584],PARAMETER[false_northing,626907.39],AUTHORITY[EPSG,2039],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Israel / Israeli TM Grid,GEOGCS[Israel,DATUM[Israel,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[-48,55,52,0,0,0,0],AUTHORITY[EPSG,6141]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4141]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31.73439361111111],PARAMETER[central_meridian,35.20451694444445],PARAMETER[scale_factor,1.0000067],PARAMETER[false_easting,219529.584],PARAMETER[false_northing,626907.39],AUTHORITY[EPSG,2039],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}