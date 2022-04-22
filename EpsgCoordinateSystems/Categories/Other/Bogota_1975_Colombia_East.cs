using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bogota_1975_Colombia_East : IEpsgCoordinateSystem
    {private const int _srid = 21899; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Bogota 1975 / Colombia East";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Bogota 1975 / Colombia East,GEOGCS[Bogota 1975,DATUM[Bogota_1975,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[307,304,-318,0,0,0,0],AUTHORITY[EPSG,6218]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4218]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4.599047222222222],PARAMETER[central_meridian,-68.08091666666667],PARAMETER[scale_factor,1],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,21899],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Bogota 1975 / Colombia East,GEOGCS[Bogota 1975,DATUM[D_Bogota,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4.599047222222222],PARAMETER[central_meridian,-68.08091666666667],PARAMETER[scale_factor,1],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],UNIT[Meter,1]]";
    }
}