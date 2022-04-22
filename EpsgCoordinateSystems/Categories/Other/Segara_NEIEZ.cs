namespace EpsgCoordinateSystems.Categories.Other
{
    public class Segara_NEIEZ : IEpsgCoordinateSystem
    {
        public string Name => "Segara / NEIEZ";
        public string Units => "Unspecified";
public int Srid => 3000;

        public string OgcWkt =>
            "PROJCS[Segara / NEIEZ,GEOGCS[Segara,DATUM[Gunung_Segara,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6613]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4613]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Mercator_1SP],PARAMETER[central_meridian,110],PARAMETER[scale_factor,0.997],PARAMETER[false_easting,3900000],PARAMETER[false_northing,900000],AUTHORITY[EPSG,3000],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Segara / NEIEZ,GEOGCS[Segara,DATUM[D_Gunung_Segara,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Mercator],PARAMETER[central_meridian,110],PARAMETER[scale_factor,0.997],PARAMETER[false_easting,3900000],PARAMETER[false_northing,900000],UNIT[Meter,1]]";
    }
}