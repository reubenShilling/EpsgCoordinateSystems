using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class LGD2006_Libya_TM_zone_8 : IEpsgCoordinateSystem
    {private const int _srid = 3193; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "LGD2006 / Libya TM zone 8";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[LGD2006 / Libya TM zone 8,GEOGCS[LGD2006,DATUM[Libyan_Geodetic_Datum_2006,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-208.406,-109.878,-2.5764,0,0,0,0],AUTHORITY[EPSG,6754]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4754]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3193],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[LGD2006 / Libya TM zone 8,GEOGCS[LGD2006,DATUM[D_,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}