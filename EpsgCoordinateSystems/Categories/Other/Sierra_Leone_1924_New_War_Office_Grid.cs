using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Sierra_Leone_1924_New_War_Office_Grid : IEpsgCoordinateSystem
    {private const int _srid = 2160; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Sierra Leone 1924 / New War Office Grid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Sierra Leone 1924 / New War Office Grid,GEOGCS[Sierra Leone 1924,DATUM[Sierra_Leone_Colony_1924,SPHEROID[War Office,6378300,296,AUTHORITY[EPSG,7029]],AUTHORITY[EPSG,6174]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4174]],UNIT[Gold Coast foot,0.3047997101815088,AUTHORITY[EPSG,9094]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,6.666666666666667],PARAMETER[central_meridian,-12],PARAMETER[scale_factor,1],PARAMETER[false_easting,800000],PARAMETER[false_northing,600000],AUTHORITY[EPSG,2160],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Sierra Leone 1924 / New War Office Grid,GEOGCS[Sierra Leone 1924,DATUM[D_Sierra_Leone_1924,SPHEROID[War_Office,6378300,296]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,6.666666666666667],PARAMETER[central_meridian,-12],PARAMETER[scale_factor,1],PARAMETER[false_easting,800000],PARAMETER[false_northing,600000],UNIT[Gold Coast foot,0.3047997101815088]]";
    }
}