namespace EpsgCoordinateSystems.Other
{
    public class RT90_5_gon_O : IEpsgCoordinateSystem
    {
        public string Name => "RT90 5 gon O";
        public long Srid => 3024;

        public string OgcWkt =>
            "PROJCS[RT90 5 gon O,GEOGCS[RT90,DATUM[Rikets_koordinatsystem_1990,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6124]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4124]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,22.55827777777778],PARAMETER[scale_factor,1],PARAMETER[false_easting,1500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3024],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[RT90 5 gon O,GEOGCS[RT90,DATUM[Rikets_koordinatsystem_1990,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6124]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4124]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,22.55827777777778],PARAMETER[scale_factor,1],PARAMETER[false_easting,1500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3024],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}