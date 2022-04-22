namespace EpsgCoordinateSystems.Categories.Other
{
    public class Luzon_1911_Philippines_zone_III : IEpsgCoordinateSystem
    {
        public string Name => "Luzon 1911 / Philippines zone III";
        public string Units => "Unspecified";
public int Srid => 25393;

        public string OgcWkt =>
            "PROJCS[Luzon 1911 / Philippines zone III,GEOGCS[Luzon 1911,DATUM[Luzon_1911,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6253]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4253]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,121],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,25393],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Luzon 1911 / Philippines zone III,GEOGCS[Luzon 1911,DATUM[D_Luzon_1911,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,121],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}