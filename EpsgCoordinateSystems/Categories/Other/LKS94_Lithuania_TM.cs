using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class LKS94_Lithuania_TM : IEpsgCoordinateSystem
    {private const int _srid = 3346; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "LKS94 / Lithuania TM";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[LKS94 / Lithuania TM,GEOGCS[LKS94,DATUM[Lithuania_1994_ETRS89,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6126]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4669]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,24],PARAMETER[scale_factor,0.9998],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3346],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[LKS94 / Lithuania TM,GEOGCS[LKS94,DATUM[D_Lithuania_1994,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,24],PARAMETER[scale_factor,0.9998],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}