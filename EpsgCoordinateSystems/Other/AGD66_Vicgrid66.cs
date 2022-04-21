namespace EpsgCoordinateSystems.Other
{
    public class AGD66_Vicgrid66 : IEpsgCoordinateSystem
    {
        public string Name => "AGD66 / Vicgrid66";
        public long Srid => 3110;

        public string OgcWkt =>
            "PROJCS[AGD66 / Vicgrid66,GEOGCS[AGD66,DATUM[Australian_Geodetic_Datum_1966,SPHEROID[Australian National Spheroid,6378160,298.25,AUTHORITY[EPSG,7003]],AUTHORITY[EPSG,6202]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4202]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-36],PARAMETER[standard_parallel_2,-38],PARAMETER[latitude_of_origin,-37],PARAMETER[central_meridian,145],PARAMETER[false_easting,2500000],PARAMETER[false_northing,4500000],AUTHORITY[EPSG,3110],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[AGD66 / Vicgrid66,GEOGCS[AGD66,DATUM[Australian_Geodetic_Datum_1966,SPHEROID[Australian National Spheroid,6378160,298.25,AUTHORITY[EPSG,7003]],AUTHORITY[EPSG,6202]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4202]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-36],PARAMETER[standard_parallel_2,-38],PARAMETER[latitude_of_origin,-37],PARAMETER[central_meridian,145],PARAMETER[false_easting,2500000],PARAMETER[false_northing,4500000],AUTHORITY[EPSG,3110],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}