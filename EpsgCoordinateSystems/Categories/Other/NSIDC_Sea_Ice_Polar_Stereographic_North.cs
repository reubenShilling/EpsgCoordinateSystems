using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NSIDC_Sea_Ice_Polar_Stereographic_North : IEpsgCoordinateSystem
    {private const int _srid = 3411; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NSIDC Sea Ice Polar Stereographic North";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NSIDC Sea Ice Polar Stereographic North,GEOGCS[Unspecified datum based upon the Hughes 1980 ellipsoid,DATUM[Not_specified_based_on_Hughes_1980_ellipsoid,SPHEROID[Hughes 1980,6378273,298.279411123064,AUTHORITY[EPSG,7058]],AUTHORITY[EPSG,6054]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4054]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Polar_Stereographic],PARAMETER[latitude_of_origin,70],PARAMETER[central_meridian,-45],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3411],AXIS[X,UNKNOWN],AXIS[Y,UNKNOWN]]";

        public string EsriWkt => "PROJCS[NSIDC Sea Ice Polar Stereographic North,GEOGCS[Unspecified datum based upon the Hughes 1980 ellipsoid,DATUM[D_,SPHEROID[Hughes_1980,6378273,298.279411123064]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Stereographic_North_Pole],PARAMETER[standard_parallel_1,70],PARAMETER[central_meridian,-45],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}