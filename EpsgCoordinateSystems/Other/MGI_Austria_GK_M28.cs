namespace EpsgCoordinateSystems.Other
{
    public class MGI_Austria_GK_M28 : IEpsgCoordinateSystem
    {
        public string Name => "MGI / Austria GK M28";
        public string Units => "Unspecified";
public long Srid => 31257;

        public string OgcWkt =>
            "PROJCS[MGI / Austria GK M28,GEOGCS[MGI,DATUM[Militar_Geographische_Institute,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[577.326,90.129,463.919,5.137,1.474,5.297,2.4232],AUTHORITY[EPSG,6312]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4312]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,10.33333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,150000],PARAMETER[false_northing,-5000000],AUTHORITY[EPSG,31257],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[MGI / Austria GK M28,GEOGCS[MGI,DATUM[Militar_Geographische_Institute,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[577.326,90.129,463.919,5.137,1.474,5.297,2.4232],AUTHORITY[EPSG,6312]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4312]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,10.33333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,150000],PARAMETER[false_northing,-5000000],AUTHORITY[EPSG,31257],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}