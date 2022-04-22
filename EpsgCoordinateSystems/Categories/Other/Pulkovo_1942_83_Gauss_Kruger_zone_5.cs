using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Pulkovo_1942_83_Gauss_Kruger_zone_5 : IEpsgCoordinateSystem
    {private const int _srid = 2399; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Pulkovo 1942(83) / Gauss-Kruger zone 5";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942(83) / Gauss-Kruger zone 5,GEOGCS[Pulkovo 1942(83),DATUM[Pulkovo_1942_83,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[24,-123,-94,0.02,-0.25,-0.13,1.1],AUTHORITY[EPSG,6178]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4178]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,5500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2399],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Pulkovo 1942(83) / Gauss-Kruger zone 5,GEOGCS[Pulkovo 1942(83),DATUM[D_Pulkovo_1942_Adj_1983,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,5500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}