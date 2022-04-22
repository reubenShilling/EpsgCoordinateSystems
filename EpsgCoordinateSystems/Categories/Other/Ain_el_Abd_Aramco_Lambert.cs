using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Ain_el_Abd_Aramco_Lambert : IEpsgCoordinateSystem
    {private const int _srid = 2318; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Ain el Abd / Aramco Lambert";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Ain el Abd / Aramco Lambert,GEOGCS[Ain el Abd,DATUM[Ain_el_Abd_1970,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6204]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4204]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,17],PARAMETER[standard_parallel_2,33],PARAMETER[latitude_of_origin,25.08951],PARAMETER[central_meridian,48],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2318],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Ain el Abd / Aramco Lambert,GEOGCS[Ain el Abd,DATUM[D_Ain_el_Abd_1970,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,17],PARAMETER[standard_parallel_2,33],PARAMETER[latitude_of_origin,25.08951],PARAMETER[central_meridian,48],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}