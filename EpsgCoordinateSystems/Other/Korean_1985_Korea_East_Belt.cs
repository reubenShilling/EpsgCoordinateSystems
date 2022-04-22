namespace EpsgCoordinateSystems.Other
{
    public class Korean_1985_Korea_East_Belt : IEpsgCoordinateSystem
    {
        public string Name => "Korean 1985 / Korea East Belt";
        public string Units => "Unspecified";
public long Srid => 2096;

        public string OgcWkt =>
            "PROJCS[Korean 1985 / Korea East Belt,GEOGCS[Korean 1985,DATUM[Korean_Datum_1985,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6162]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4162]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38],PARAMETER[central_meridian,129],PARAMETER[scale_factor,1],PARAMETER[false_easting,200000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,2096],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Korean 1985 / Korea East Belt,GEOGCS[Korean 1985,DATUM[D_Korean_Datum_1985,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38],PARAMETER[central_meridian,129],PARAMETER[scale_factor,1],PARAMETER[false_easting,200000],PARAMETER[false_northing,500000],UNIT[Meter,1]]";
    }
}