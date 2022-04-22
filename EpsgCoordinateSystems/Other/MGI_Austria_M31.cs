namespace EpsgCoordinateSystems.Other
{
    public class MGI_Austria_M31 : IEpsgCoordinateSystem
    {
        public string Name => "MGI / Austria M31";
        public string Units => "Unspecified";
public long Srid => 31285;

        public string OgcWkt =>
            "PROJCS[MGI / Austria M31,GEOGCS[MGI,DATUM[Militar_Geographische_Institute,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[577.326,90.129,463.919,5.137,1.474,5.297,2.4232],AUTHORITY[EPSG,6312]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4312]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,13.33333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,450000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31285],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[MGI / Austria M31,GEOGCS[MGI,DATUM[Militar_Geographische_Institute,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[577.326,90.129,463.919,5.137,1.474,5.297,2.4232],AUTHORITY[EPSG,6312]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4312]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,13.33333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,450000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31285],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}