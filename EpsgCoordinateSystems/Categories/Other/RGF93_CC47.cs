using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class RGF93_CC47 : IEpsgCoordinateSystem
    {private const int _srid = 3947; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "RGF93 / CC47";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[RGF93 / CC47,GEOGCS[RGF93,DATUM[Reseau_Geodesique_Francais_1993,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6171]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4171]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,46.25],PARAMETER[standard_parallel_2,47.75],PARAMETER[latitude_of_origin,47],PARAMETER[central_meridian,3],PARAMETER[false_easting,1700000],PARAMETER[false_northing,6200000],AUTHORITY[EPSG,3947],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[RGF93 / CC47,GEOGCS[RGF93,DATUM[D_RGF_1993,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,46.25],PARAMETER[standard_parallel_2,47.75],PARAMETER[latitude_of_origin,47],PARAMETER[central_meridian,3],PARAMETER[false_easting,1700000],PARAMETER[false_northing,6200000],UNIT[Meter,1]]";
    }
}