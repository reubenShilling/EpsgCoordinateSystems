using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class CSG67_UTM_zone_21N : IEpsgCoordinateSystem
    {private const int _srid = 3312; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "CSG67 / UTM zone 21N";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[CSG67 / UTM zone 21N,GEOGCS[CSG67,DATUM[Centre_Spatial_Guyanais_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-186,230,110,0,0,0,0],AUTHORITY[EPSG,6623]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4623]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3312],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[CSG67 / UTM zone 21N,GEOGCS[CSG67,DATUM[D_CSG_1967,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}