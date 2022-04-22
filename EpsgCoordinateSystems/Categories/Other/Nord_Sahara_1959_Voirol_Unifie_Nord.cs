namespace EpsgCoordinateSystems.Categories.Other
{
    public class Nord_Sahara_1959_Voirol_Unifie_Nord : IEpsgCoordinateSystem
    {
        public string Name => "Nord Sahara 1959 / Voirol Unifie Nord";
        public string Units => "Unspecified";
public int Srid => 30791;

        public string OgcWkt =>
            "PROJCS[Nord Sahara 1959 / Voirol Unifie Nord,GEOGCS[Nord Sahara 1959,DATUM[Nord_Sahara_1959,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6307]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4307]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,36],PARAMETER[central_meridian,2.7],PARAMETER[scale_factor,0.999625544],PARAMETER[false_easting,500135],PARAMETER[false_northing,300090],AUTHORITY[EPSG,30791],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Nord Sahara 1959 / Voirol Unifie Nord,GEOGCS[Nord Sahara 1959,DATUM[D_Nord_Sahara_1959,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,36],PARAMETER[central_meridian,2.7],PARAMETER[scale_factor,0.999625544],PARAMETER[false_easting,500135],PARAMETER[false_northing,300090],UNIT[Meter,1]]";
    }
}