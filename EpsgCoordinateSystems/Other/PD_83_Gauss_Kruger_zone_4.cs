namespace EpsgCoordinateSystems.Other
{
    public class PD_83_Gauss_Kruger_zone_4 : IEpsgCoordinateSystem
    {
        public string Name => "PD/83 / Gauss-Kruger zone 4";
        public string Units => "Unspecified";
public long Srid => 3397;

        public string OgcWkt =>
            "PROJCS[PD/83 / Gauss-Kruger zone 4,GEOGCS[PD/83,DATUM[Potsdam_Datum_83,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6746]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4746]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3397],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[PD/83 / Gauss-Kruger zone 4,GEOGCS[PD/83,DATUM[Potsdam_Datum_83,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6746]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4746]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3397],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}