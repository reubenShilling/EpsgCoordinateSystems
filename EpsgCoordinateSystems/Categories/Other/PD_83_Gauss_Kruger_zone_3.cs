namespace EpsgCoordinateSystems.Categories.Other
{
    public class PD_83_Gauss_Kruger_zone_3 : IEpsgCoordinateSystem
    {
        public string Name => "PD/83 / Gauss-Kruger zone 3";
        public string Units => "Unspecified";
public int Srid => 3396;

        public string OgcWkt =>
            "PROJCS[PD/83 / Gauss-Kruger zone 3,GEOGCS[PD/83,DATUM[Potsdam_Datum_83,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6746]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4746]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,1],PARAMETER[false_easting,3500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3396],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[PD/83 / Gauss-Kruger zone 3,GEOGCS[PD/83,DATUM[D_,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,1],PARAMETER[false_easting,3500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}