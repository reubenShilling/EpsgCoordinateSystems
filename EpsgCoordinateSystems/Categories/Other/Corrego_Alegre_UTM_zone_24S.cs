using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Corrego_Alegre_UTM_zone_24S : IEpsgCoordinateSystem
    {private const int _srid = 22524; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Corrego Alegre / UTM zone 24S";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Corrego Alegre / UTM zone 24S,GEOGCS[Corrego Alegre,DATUM[Corrego_Alegre,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-206,172,-6,0,0,0,0],AUTHORITY[EPSG,6225]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4225]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,22524],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Corrego Alegre / UTM zone 24S,GEOGCS[Corrego Alegre,DATUM[D_Corrego_Alegre,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}