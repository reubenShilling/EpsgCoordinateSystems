namespace EpsgCoordinateSystems.Other
{
    public class RT38_2_5_gon_O : IEpsgCoordinateSystem
    {
        public string Name => "RT38 2.5 gon O";
        public string Units => "Unspecified";
public long Srid => 3029;

        public string OgcWkt =>
            "PROJCS[RT38 2.5 gon O,GEOGCS[RT38,DATUM[Stockholm_1938,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6308]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4308]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,20.30827777777778],PARAMETER[scale_factor,1],PARAMETER[false_easting,1500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3029],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[RT38 2.5 gon O,GEOGCS[RT38,DATUM[Stockholm_1938,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6308]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4308]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,20.30827777777778],PARAMETER[scale_factor,1],PARAMETER[false_easting,1500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3029],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}