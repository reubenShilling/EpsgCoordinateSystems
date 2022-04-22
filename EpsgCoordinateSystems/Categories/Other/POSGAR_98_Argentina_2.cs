namespace EpsgCoordinateSystems.Categories.Other
{
    public class POSGAR_98_Argentina_2 : IEpsgCoordinateSystem
    {
        public string Name => "POSGAR 98 / Argentina 2";
        public string Units => "Unspecified";
public int Srid => 22172;

        public string OgcWkt =>
            "PROJCS[POSGAR 98 / Argentina 2,GEOGCS[POSGAR 98,DATUM[Posiciones_Geodesicas_Argentinas_1998,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6190]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4190]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,22172],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[POSGAR 98 / Argentina 2,GEOGCS[POSGAR 98,DATUM[D_POSGAR_1998,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}