using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Egypt_1907_Blue_Belt : IEpsgCoordinateSystem
    {private const int _srid = 22991; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Egypt 1907 / Blue Belt";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Egypt 1907 / Blue Belt,GEOGCS[Egypt 1907,DATUM[Egypt_1907,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6229]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4229]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,35],PARAMETER[scale_factor,1],PARAMETER[false_easting,300000],PARAMETER[false_northing,1100000],AUTHORITY[EPSG,22991],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Egypt 1907 / Blue Belt,GEOGCS[Egypt 1907,DATUM[D_Egypt_1907,SPHEROID[Helmert_1906,6378200,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,35],PARAMETER[scale_factor,1],PARAMETER[false_easting,300000],PARAMETER[false_northing,1100000],UNIT[Meter,1]]";
    }
}