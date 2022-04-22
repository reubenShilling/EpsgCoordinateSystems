namespace EpsgCoordinateSystems.Categories.Other
{
    public class Grand_Cayman_1959_UTM_zone_17N : IEpsgCoordinateSystem
    {
        public string Name => "Grand Cayman 1959 / UTM zone 17N";
        public string Units => "Unspecified";
public int Srid => 3356;

        public string OgcWkt =>
            "PROJCS[Grand Cayman 1959 / UTM zone 17N,GEOGCS[Grand Cayman 1959,DATUM[Grand_Cayman_1959,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[67.8,106.1,138.8,0,0,0,0],AUTHORITY[EPSG,6723]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4723]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3356],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Grand Cayman 1959 / UTM zone 17N,GEOGCS[Grand Cayman 1959,DATUM[D_Grand_Cayman_1959,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}