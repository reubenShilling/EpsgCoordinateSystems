namespace EpsgCoordinateSystems.Other
{
    public class DHDN_Gauss_Kruger_zone_5 : IEpsgCoordinateSystem
    {
        public string Name => "DHDN / Gauss-Kruger zone 5";
        public string Units => "Unspecified";
public long Srid => 31469;

        public string OgcWkt =>
            "PROJCS[DHDN / Gauss-Kruger zone 5,GEOGCS[DHDN,DATUM[Deutsches_Hauptdreiecksnetz,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6314]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4314]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,5500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31469],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[DHDN / Gauss-Kruger zone 5,GEOGCS[DHDN,DATUM[D_Deutsches_Hauptdreiecksnetz,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,5500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}