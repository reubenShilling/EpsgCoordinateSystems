using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class MGI_Austria_Lambert : IEpsgCoordinateSystem
    {private const int _srid = 31287; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "MGI / Austria Lambert";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[MGI / Austria Lambert,GEOGCS[MGI,DATUM[Militar_Geographische_Institute,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[577.326,90.129,463.919,5.137,1.474,5.297,2.4232],AUTHORITY[EPSG,6312]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4312]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,49],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,47.5],PARAMETER[central_meridian,13.33333333333333],PARAMETER[false_easting,400000],PARAMETER[false_northing,400000],AUTHORITY[EPSG,31287],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[MGI / Austria Lambert,GEOGCS[MGI,DATUM[D_MGI,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,49],PARAMETER[standard_parallel_2,46],PARAMETER[latitude_of_origin,47.5],PARAMETER[central_meridian,13.33333333333333],PARAMETER[false_easting,400000],PARAMETER[false_northing,400000],UNIT[Meter,1]]";
    }
}