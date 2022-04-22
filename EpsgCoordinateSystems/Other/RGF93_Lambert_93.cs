namespace EpsgCoordinateSystems.Other
{
    public class RGF93_Lambert_93 : IEpsgCoordinateSystem
    {
        public string Name => "RGF93 / Lambert-93";
        public string Units => "Unspecified";
public long Srid => 2154;

        public string OgcWkt =>
            "PROJCS[RGF93 / Lambert-93,GEOGCS[RGF93,DATUM[Reseau_Geodesique_Francais_1993,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6171]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4171]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,49],PARAMETER[standard_parallel_2,44],PARAMETER[latitude_of_origin,46.5],PARAMETER[central_meridian,3],PARAMETER[false_easting,700000],PARAMETER[false_northing,6600000],AUTHORITY[EPSG,2154],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[RGF93 / Lambert-93,GEOGCS[RGF93,DATUM[Reseau_Geodesique_Francais_1993,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6171]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4171]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,49],PARAMETER[standard_parallel_2,44],PARAMETER[latitude_of_origin,46.5],PARAMETER[central_meridian,3],PARAMETER[false_easting,700000],PARAMETER[false_northing,6600000],AUTHORITY[EPSG,2154],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}