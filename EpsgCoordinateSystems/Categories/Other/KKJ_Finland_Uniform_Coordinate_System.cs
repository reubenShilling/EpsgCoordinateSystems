using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class KKJ_Finland_Uniform_Coordinate_System : IEpsgCoordinateSystem
    {private const int _srid = 2393; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "KKJ / Finland Uniform Coordinate System";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[KKJ / Finland Uniform Coordinate System,GEOGCS[KKJ,DATUM[Kartastokoordinaattijarjestelma_1966,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6123]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4123]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,27],PARAMETER[scale_factor,1],PARAMETER[false_easting,3500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2393],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[KKJ / Finland Uniform Coordinate System,GEOGCS[KKJ,DATUM[D_KKJ,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,27],PARAMETER[scale_factor,1],PARAMETER[false_easting,3500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}