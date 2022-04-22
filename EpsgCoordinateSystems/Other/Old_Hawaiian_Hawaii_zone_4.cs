namespace EpsgCoordinateSystems.Other
{
    public class Old_Hawaiian_Hawaii_zone_4 : IEpsgCoordinateSystem
    {
        public string Name => "Old Hawaiian / Hawaii zone 4";
        public string Units => "Unspecified";
public long Srid => 3564;

        public string OgcWkt =>
            "PROJCS[Old Hawaiian / Hawaii zone 4,GEOGCS[Old Hawaiian,DATUM[Old_Hawaiian,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6135]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4135]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,21.83333333333333],PARAMETER[central_meridian,-159.5],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3564],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Old Hawaiian / Hawaii zone 4,GEOGCS[Old Hawaiian,DATUM[Old_Hawaiian,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6135]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4135]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,21.83333333333333],PARAMETER[central_meridian,-159.5],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3564],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}