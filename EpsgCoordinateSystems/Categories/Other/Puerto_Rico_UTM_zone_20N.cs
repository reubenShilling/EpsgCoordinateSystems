namespace EpsgCoordinateSystems.Categories.Other
{
    public class Puerto_Rico_UTM_zone_20N : IEpsgCoordinateSystem
    {
        public string Name => "Puerto Rico / UTM zone 20N";
        public string Units => "Unspecified";
public int Srid => 3920;

        public string OgcWkt =>
            "PROJCS[Puerto Rico / UTM zone 20N,GEOGCS[Puerto Rico,DATUM[Puerto_Rico,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[11,72,-101,0,0,0,0],AUTHORITY[EPSG,6139]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4139]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3920],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Puerto Rico / UTM zone 20N,GEOGCS[Puerto Rico,DATUM[D_Puerto_Rico,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}