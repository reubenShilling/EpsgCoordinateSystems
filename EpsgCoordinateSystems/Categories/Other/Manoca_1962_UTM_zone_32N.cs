namespace EpsgCoordinateSystems.Categories.Other
{
    public class Manoca_1962_UTM_zone_32N : IEpsgCoordinateSystem
    {
        public string Name => "Manoca 1962 / UTM zone 32N";
        public string Units => "Unspecified";
public int Srid => 2215;

        public string OgcWkt =>
            "PROJCS[Manoca 1962 / UTM zone 32N,GEOGCS[Manoca 1962,DATUM[Manoca_1962,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-70.9,-151.8,-41.4,0,0,0,0],AUTHORITY[EPSG,6193]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4193]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2215],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Manoca 1962 / UTM zone 32N,GEOGCS[Manoca 1962,DATUM[D_Manoca_1962,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}