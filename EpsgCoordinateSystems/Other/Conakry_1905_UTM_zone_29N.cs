namespace EpsgCoordinateSystems.Other
{
    public class Conakry_1905_UTM_zone_29N : IEpsgCoordinateSystem
    {
        public string Name => "Conakry 1905 / UTM zone 29N";
        public string Units => "Unspecified";
public long Srid => 31529;

        public string OgcWkt =>
            "PROJCS[Conakry 1905 / UTM zone 29N,GEOGCS[Conakry 1905,DATUM[Conakry_1905,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-23,259,-9,0,0,0,0],AUTHORITY[EPSG,6315]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4315]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31529],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Conakry 1905 / UTM zone 29N,GEOGCS[Conakry 1905,DATUM[D_Conakry_1905,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}