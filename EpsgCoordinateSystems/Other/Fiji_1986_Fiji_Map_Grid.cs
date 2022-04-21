namespace EpsgCoordinateSystems.Other
{
    public class Fiji_1986_Fiji_Map_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Fiji 1986 / Fiji Map Grid";
        public long Srid => 3460;

        public string OgcWkt =>
            "PROJCS[Fiji 1986 / Fiji Map Grid,GEOGCS[Fiji 1986,DATUM[Fiji_Geodetic_Datum_1986,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],AUTHORITY[EPSG,6720]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4720]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-17],PARAMETER[central_meridian,178.75],PARAMETER[scale_factor,0.99985],PARAMETER[false_easting,2000000],PARAMETER[false_northing,4000000],AUTHORITY[EPSG,3460],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Fiji 1986 / Fiji Map Grid,GEOGCS[Fiji 1986,DATUM[Fiji_Geodetic_Datum_1986,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],AUTHORITY[EPSG,6720]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4720]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-17],PARAMETER[central_meridian,178.75],PARAMETER[scale_factor,0.99985],PARAMETER[false_easting,2000000],PARAMETER[false_northing,4000000],AUTHORITY[EPSG,3460],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}