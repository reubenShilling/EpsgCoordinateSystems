using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tananarive_UTM_zone_38S : IEpsgCoordinateSystem
    {private const int _srid = 29738; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tananarive / UTM zone 38S";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Tananarive / UTM zone 38S,GEOGCS[Tananarive,DATUM[Tananarive_1925,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-189,-242,-91,0,0,0,0],AUTHORITY[EPSG,6297]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4297]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,29738],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Tananarive / UTM zone 38S,GEOGCS[Tananarive,DATUM[D_Tananarive_1925,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}