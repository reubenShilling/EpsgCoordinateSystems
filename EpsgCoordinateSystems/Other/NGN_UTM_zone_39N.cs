namespace EpsgCoordinateSystems.Other
{
    public class NGN_UTM_zone_39N : IEpsgCoordinateSystem
    {
        public string Name => "NGN / UTM zone 39N";
        public string Units => "Unspecified";
public long Srid => 31839;

        public string OgcWkt =>
            "PROJCS[NGN / UTM zone 39N,GEOGCS[NGN,DATUM[National_Geodetic_Network,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[-3.2,-5.7,2.8,0,0,0,0],AUTHORITY[EPSG,6318]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4318]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31839],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NGN / UTM zone 39N,GEOGCS[NGN,DATUM[D_NGN,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}