using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Pampa_del_Castillo_Argentina_zone_2 : IEpsgCoordinateSystem
    {private const int _srid = 2082; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Pampa del Castillo / Argentina zone 2";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Pampa del Castillo / Argentina zone 2,GEOGCS[Pampa del Castillo,DATUM[Pampa_del_Castillo,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[27.5,14,186.4,0,0,0,0],AUTHORITY[EPSG,6161]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4161]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2082],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Pampa del Castillo / Argentina zone 2,GEOGCS[Pampa del Castillo,DATUM[D_Pampa_del_Castillo,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}