namespace EpsgCoordinateSystems.Other
{
    public class Batavia_NEIEZ : IEpsgCoordinateSystem
    {
        public string Name => "Batavia / NEIEZ";
        public long Srid => 3001;

        public string OgcWkt =>
            "PROJCS[Batavia / NEIEZ,GEOGCS[Batavia,DATUM[Batavia,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6211]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4211]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Mercator_1SP],PARAMETER[central_meridian,110],PARAMETER[scale_factor,0.997],PARAMETER[false_easting,3900000],PARAMETER[false_northing,900000],AUTHORITY[EPSG,3001],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Batavia / NEIEZ,GEOGCS[Batavia,DATUM[Batavia,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6211]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4211]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Mercator_1SP],PARAMETER[central_meridian,110],PARAMETER[scale_factor,0.997],PARAMETER[false_easting,3900000],PARAMETER[false_northing,900000],AUTHORITY[EPSG,3001],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}