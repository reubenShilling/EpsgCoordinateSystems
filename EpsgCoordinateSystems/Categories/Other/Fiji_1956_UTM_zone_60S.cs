using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fiji_1956_UTM_zone_60S : IEpsgCoordinateSystem
    {private const int _srid = 3141; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Fiji 1956 / UTM zone 60S";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Fiji 1956 / UTM zone 60S,GEOGCS[Fiji 1956,DATUM[Fiji_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[265.025,384.929,-194.046,0,0,0,0],AUTHORITY[EPSG,6721]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4721]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,177],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3141],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Fiji 1956 / UTM zone 60S,GEOGCS[Fiji 1956,DATUM[D_Fiji_1956,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,177],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}