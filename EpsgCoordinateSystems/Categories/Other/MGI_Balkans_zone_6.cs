using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class MGI_Balkans_zone_6 : IEpsgCoordinateSystem
    {private const int _srid = 31276; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "MGI / Balkans zone 6";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[MGI / Balkans zone 6,GEOGCS[MGI,DATUM[Militar_Geographische_Institute,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[577.326,90.129,463.919,5.137,1.474,5.297,2.4232],AUTHORITY[EPSG,6312]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4312]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,18],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,6500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31276],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[MGI / Balkans zone 6,GEOGCS[MGI,DATUM[D_MGI,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,18],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,6500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}