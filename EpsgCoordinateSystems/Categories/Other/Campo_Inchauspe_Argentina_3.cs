using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Campo_Inchauspe_Argentina_3 : IEpsgCoordinateSystem
    {private const int _srid = 22193; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Campo Inchauspe / Argentina 3";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Campo Inchauspe / Argentina 3,GEOGCS[Campo Inchauspe,DATUM[Campo_Inchauspe,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6221]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4221]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-66],PARAMETER[scale_factor,1],PARAMETER[false_easting,3500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,22193],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Campo Inchauspe / Argentina 3,GEOGCS[Campo Inchauspe,DATUM[D_Campo_Inchauspe,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-66],PARAMETER[scale_factor,1],PARAMETER[false_easting,3500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}