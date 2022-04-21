namespace EpsgCoordinateSystems.Other
{
    public class Nord_Sahara_1959_Voirol_Unifie_Sud : IEpsgCoordinateSystem
    {
        public string Name => "Nord Sahara 1959 / Voirol Unifie Sud";
        public long Srid => 30792;

        public string OgcWkt =>
            "PROJCS[Nord Sahara 1959 / Voirol Unifie Sud,GEOGCS[Nord Sahara 1959,DATUM[Nord_Sahara_1959,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6307]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4307]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,33.3],PARAMETER[central_meridian,2.7],PARAMETER[scale_factor,0.999625769],PARAMETER[false_easting,500135],PARAMETER[false_northing,300090],AUTHORITY[EPSG,30792],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Nord Sahara 1959 / Voirol Unifie Sud,GEOGCS[Nord Sahara 1959,DATUM[Nord_Sahara_1959,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6307]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4307]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,33.3],PARAMETER[central_meridian,2.7],PARAMETER[scale_factor,0.999625769],PARAMETER[false_easting,500135],PARAMETER[false_northing,300090],AUTHORITY[EPSG,30792],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}