using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ELD79_Libya_zone_10 : IEpsgCoordinateSystem
    {private const int _srid = 2073; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ELD79 / Libya zone 10";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[ELD79 / Libya zone 10,GEOGCS[ELD79,DATUM[European_Libyan_Datum_1979,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6159]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4159]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,19],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2073],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[ELD79 / Libya zone 10,GEOGCS[ELD79,DATUM[D_European_Libyan_1979,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,19],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}