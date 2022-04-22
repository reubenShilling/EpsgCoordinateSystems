namespace EpsgCoordinateSystems.Other
{
    public class Slovenia_1996_Slovene_National_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Slovenia 1996 / Slovene National Grid";
        public string Units => "Unspecified";
public long Srid => 3794;

        public string OgcWkt =>
            "PROJCS[Slovenia 1996 / Slovene National Grid,GEOGCS[Slovenia 1996,DATUM[Slovenia_Geodetic_Datum_1996,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6765]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4765]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,-5000000],AUTHORITY[EPSG,3794],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Slovenia 1996 / Slovene National Grid,GEOGCS[Slovenia 1996,DATUM[Slovenia_Geodetic_Datum_1996,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6765]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4765]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,-5000000],AUTHORITY[EPSG,3794],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}