using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Accra_Ghana_National_Grid : IEpsgCoordinateSystem
    {private const int _srid = 2136; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Accra / Ghana National Grid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Accra / Ghana National Grid,GEOGCS[Accra,DATUM[Accra,SPHEROID[War Office,6378300,296,AUTHORITY[EPSG,7029]],TOWGS84[-199,32,322,0,0,0,0],AUTHORITY[EPSG,6168]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4168]],UNIT[Gold Coast foot,0.3047997101815088,AUTHORITY[EPSG,9094]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4.666666666666667],PARAMETER[central_meridian,-1],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,900000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2136],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Accra / Ghana National Grid,GEOGCS[Accra,DATUM[D_Accra,SPHEROID[War_Office,6378300,296]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4.666666666666667],PARAMETER[central_meridian,-1],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,900000],PARAMETER[false_northing,0],UNIT[Gold Coast foot,0.3047997101815088]]";
    }
}