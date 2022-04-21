namespace EpsgCoordinateSystems.Other
{
    public class Korean_1985_Korea_West_Belt : IEpsgCoordinateSystem
    {
        public string Name => "Korean 1985 / Korea West Belt";
        public long Srid => 2098;

        public string OgcWkt =>
            "PROJCS[Korean 1985 / Korea West Belt,GEOGCS[Korean 1985,DATUM[Korean_Datum_1985,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6162]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4162]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38],PARAMETER[central_meridian,125],PARAMETER[scale_factor,1],PARAMETER[false_easting,200000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,2098],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Korean 1985 / Korea West Belt,GEOGCS[Korean 1985,DATUM[Korean_Datum_1985,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6162]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4162]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38],PARAMETER[central_meridian,125],PARAMETER[scale_factor,1],PARAMETER[false_easting,200000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,2098],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}