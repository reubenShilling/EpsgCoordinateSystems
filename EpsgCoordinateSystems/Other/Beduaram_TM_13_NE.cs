namespace EpsgCoordinateSystems.Other
{
    public class Beduaram_TM_13_NE : IEpsgCoordinateSystem
    {
        public string Name => "Beduaram / TM 13 NE";
        public string Units => "Unspecified";
public long Srid => 2931;

        public string OgcWkt =>
            "PROJCS[Beduaram / TM 13 NE,GEOGCS[Beduaram,DATUM[Beduaram,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-106,-87,188,0,0,0,0],AUTHORITY[EPSG,6213]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4213]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,13],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2931],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Beduaram / TM 13 NE,GEOGCS[Beduaram,DATUM[Beduaram,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-106,-87,188,0,0,0,0],AUTHORITY[EPSG,6213]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4213]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,13],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2931],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}