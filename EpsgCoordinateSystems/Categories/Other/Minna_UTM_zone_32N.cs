namespace EpsgCoordinateSystems.Categories.Other
{
    public class Minna_UTM_zone_32N : IEpsgCoordinateSystem
    {
        public string Name => "Minna / UTM zone 32N";
        public string Units => "Unspecified";
public int Srid => 26332;

        public string OgcWkt =>
            "PROJCS[Minna / UTM zone 32N,GEOGCS[Minna,DATUM[Minna,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6263]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4263]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26332],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Minna / UTM zone 32N,GEOGCS[Minna,DATUM[D_Minna,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}