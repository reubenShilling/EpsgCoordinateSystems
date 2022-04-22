namespace EpsgCoordinateSystems.Categories.Other
{
    public class Locodjo_1965_UTM_zone_29N : IEpsgCoordinateSystem
    {
        public string Name => "Locodjo 1965 / UTM zone 29N";
        public string Units => "Unspecified";
public int Srid => 2042;

        public string OgcWkt =>
            "PROJCS[Locodjo 1965 / UTM zone 29N,GEOGCS[Locodjo 1965,DATUM[Locodjo_1965,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-125,53,467,0,0,0,0],AUTHORITY[EPSG,6142]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4142]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2042],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Locodjo 1965 / UTM zone 29N,GEOGCS[Locodjo 1965,DATUM[D_Locodjo_1965,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}