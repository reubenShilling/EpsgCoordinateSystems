using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bissau_UTM_zone_28N : IEpsgCoordinateSystem
    {private const int _srid = 2095; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Bissau / UTM zone 28N";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Bissau / UTM zone 28N,GEOGCS[Bissau,DATUM[Bissau,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-173,253,27,0,0,0,0],AUTHORITY[EPSG,6165]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4165]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2095],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Bissau / UTM zone 28N,GEOGCS[Bissau,DATUM[D_Bissau,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}