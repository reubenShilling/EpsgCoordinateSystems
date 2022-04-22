using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Hanoi_1972_Gauss_Kruger_zone_18 : IEpsgCoordinateSystem
    {private const int _srid = 2044; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Hanoi 1972 / Gauss-Kruger zone 18";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Hanoi 1972 / Gauss-Kruger zone 18,GEOGCS[Hanoi 1972,DATUM[Hanoi_1972,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-17.51,-108.32,-62.39,0,0,0,0],AUTHORITY[EPSG,6147]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4147]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,1],PARAMETER[false_easting,18500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2044],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Hanoi 1972 / Gauss-Kruger zone 18,GEOGCS[Hanoi 1972,DATUM[D_Hanoi_1972,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,1],PARAMETER[false_easting,18500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}