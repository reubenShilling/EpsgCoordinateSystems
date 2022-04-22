using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kalianpur_1880_India_zone_I : IEpsgCoordinateSystem
    {private const int _srid = 24371; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kalianpur 1880 / India zone I";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1880 / India zone I,GEOGCS[Kalianpur 1880,DATUM[Kalianpur_1880,SPHEROID[Everest (1830 Definition),6377299.36559538,300.8017255433612,AUTHORITY[EPSG,7042]],AUTHORITY[EPSG,6243]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4243]],UNIT[Indian yard,0.9143985307444408,AUTHORITY[EPSG,9084]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,68],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,24371],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kalianpur 1880 / India zone I,GEOGCS[Kalianpur 1880,DATUM[D_Kalianpur_1880,SPHEROID[Everest_1830_Definition,6377299.36559538,300.8017255433612]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,68],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],UNIT[Indian yard,0.9143985307444408]]";
    }
}