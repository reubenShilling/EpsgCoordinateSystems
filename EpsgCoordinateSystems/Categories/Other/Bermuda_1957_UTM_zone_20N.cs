namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bermuda_1957_UTM_zone_20N : IEpsgCoordinateSystem
    {
        public string Name => "Bermuda 1957 / UTM zone 20N";
        public string Units => "Unspecified";
public int Srid => 3769;

        public string OgcWkt =>
            "PROJCS[Bermuda 1957 / UTM zone 20N,GEOGCS[Bermuda 1957,DATUM[Bermuda_1957,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6216]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4216]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3769],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Bermuda 1957 / UTM zone 20N,GEOGCS[Bermuda 1957,DATUM[D_Bermuda_1957,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}