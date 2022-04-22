using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_NSRS2007_Virginia_South : IEpsgCoordinateSystem
    {private const int _srid = 3687; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NAD83(NSRS2007) / Virginia South";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83(NSRS2007) / Virginia South,GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,36.76666666666667],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,3500000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,3687],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(NSRS2007) / Virginia South,GEOGCS[NAD83(NSRS2007),DATUM[D_,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,36.76666666666667],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,3500000],PARAMETER[false_northing,1000000],UNIT[Meter,1]]";
    }
}