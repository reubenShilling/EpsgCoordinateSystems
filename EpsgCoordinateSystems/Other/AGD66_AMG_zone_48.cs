namespace EpsgCoordinateSystems.Other
{
    public class AGD66_AMG_zone_48 : IEpsgCoordinateSystem
    {
        public string Name => "AGD66 / AMG zone 48";
        public string Units => "Unspecified";
public long Srid => 20248;

        public string OgcWkt =>
            "PROJCS[AGD66 / AMG zone 48,GEOGCS[AGD66,DATUM[Australian_Geodetic_Datum_1966,SPHEROID[Australian National Spheroid,6378160,298.25,AUTHORITY[EPSG,7003]],AUTHORITY[EPSG,6202]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4202]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,20248],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[AGD66 / AMG zone 48,GEOGCS[AGD66,DATUM[D_Australian_1966,SPHEROID[Australian_National_Spheroid,6378160,298.25]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}