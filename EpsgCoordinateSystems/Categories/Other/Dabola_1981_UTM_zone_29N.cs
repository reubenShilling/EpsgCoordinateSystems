namespace EpsgCoordinateSystems.Categories.Other
{
    public class Dabola_1981_UTM_zone_29N : IEpsgCoordinateSystem
    {
        public string Name => "Dabola 1981 / UTM zone 29N";
        public string Units => "Unspecified";
public int Srid => 3462;

        public string OgcWkt =>
            "PROJCS[Dabola 1981 / UTM zone 29N,GEOGCS[Dabola 1981,DATUM[Dabola_1981,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-83,37,124,0,0,0,0],AUTHORITY[EPSG,6155]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4155]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3462],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Dabola 1981 / UTM zone 29N,GEOGCS[Dabola 1981,DATUM[D_Dabola_1981,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}