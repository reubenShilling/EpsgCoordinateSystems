namespace EpsgCoordinateSystems.Categories.Other
{
    public class Massawa_UTM_zone_37N : IEpsgCoordinateSystem
    {
        public string Name => "Massawa / UTM zone 37N";
        public string Units => "Unspecified";
public int Srid => 26237;

        public string OgcWkt =>
            "PROJCS[Massawa / UTM zone 37N,GEOGCS[Massawa,DATUM[Massawa,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[639,405,60,0,0,0,0],AUTHORITY[EPSG,6262]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4262]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26237],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Massawa / UTM zone 37N,GEOGCS[Massawa,DATUM[D_Massawa,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}