namespace EpsgCoordinateSystems.Other
{
    public class POSGAR_94_Argentina_4 : IEpsgCoordinateSystem
    {
        public string Name => "POSGAR 94 / Argentina 4";
        public string Units => "Unspecified";
public long Srid => 22184;

        public string OgcWkt =>
            "PROJCS[POSGAR 94 / Argentina 4,GEOGCS[POSGAR 94,DATUM[Posiciones_Geodesicas_Argentinas_1994,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6694]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4694]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,22184],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[POSGAR 94 / Argentina 4,GEOGCS[POSGAR 94,DATUM[Posiciones_Geodesicas_Argentinas_1994,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6694]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4694]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,22184],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}