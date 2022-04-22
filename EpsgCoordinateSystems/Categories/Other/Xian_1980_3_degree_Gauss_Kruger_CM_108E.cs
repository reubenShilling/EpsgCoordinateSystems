using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Xian_1980_3_degree_Gauss_Kruger_CM_108E : IEpsgCoordinateSystem
    {private const int _srid = 2381; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Xian 1980 / 3-degree Gauss-Kruger CM 108E";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Xian 1980 / 3-degree Gauss-Kruger CM 108E,GEOGCS[Xian 1980,DATUM[Xian_1980,SPHEROID[Xian 1980,6378140,298.257,AUTHORITY[EPSG,7049]],AUTHORITY[EPSG,6610]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4610]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,108],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2381],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Xian 1980 / 3-degree Gauss-Kruger CM 108E,GEOGCS[Xian 1980,DATUM[D_Xian_1980,SPHEROID[Xian_1980,6378140,298.257]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,108],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}