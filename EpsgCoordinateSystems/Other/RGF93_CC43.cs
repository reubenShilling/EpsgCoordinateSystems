namespace EpsgCoordinateSystems.Other
{
    public class RGF93_CC43 : IEpsgCoordinateSystem
    {
        public string Name => "RGF93 / CC43";
        public string Units => "Unspecified";
public long Srid => 3943;

        public string OgcWkt =>
            "PROJCS[RGF93 / CC43,GEOGCS[RGF93,DATUM[Reseau_Geodesique_Francais_1993,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6171]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4171]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.25],PARAMETER[standard_parallel_2,43.75],PARAMETER[latitude_of_origin,43],PARAMETER[central_meridian,3],PARAMETER[false_easting,1700000],PARAMETER[false_northing,2200000],AUTHORITY[EPSG,3943],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[RGF93 / CC43,GEOGCS[RGF93,DATUM[Reseau_Geodesique_Francais_1993,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6171]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4171]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.25],PARAMETER[standard_parallel_2,43.75],PARAMETER[latitude_of_origin,43],PARAMETER[central_meridian,3],PARAMETER[false_easting,1700000],PARAMETER[false_northing,2200000],AUTHORITY[EPSG,3943],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}