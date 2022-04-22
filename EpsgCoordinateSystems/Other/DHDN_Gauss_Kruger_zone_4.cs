namespace EpsgCoordinateSystems.Other
{
    public class DHDN_Gauss_Kruger_zone_4 : IEpsgCoordinateSystem
    {
        public string Name => "DHDN / Gauss-Kruger zone 4";
        public string Units => "Unspecified";
public long Srid => 31468;

        public string OgcWkt =>
            "PROJCS[DHDN / Gauss-Kruger zone 4,GEOGCS[DHDN,DATUM[Deutsches_Hauptdreiecksnetz,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6314]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4314]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31468],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[DHDN / Gauss-Kruger zone 4,GEOGCS[DHDN,DATUM[Deutsches_Hauptdreiecksnetz,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6314]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4314]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31468],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}