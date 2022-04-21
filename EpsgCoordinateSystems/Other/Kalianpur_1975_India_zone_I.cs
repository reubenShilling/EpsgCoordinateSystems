namespace EpsgCoordinateSystems.Other
{
    public class Kalianpur_1975_India_zone_I : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1975 / India zone I";
        public long Srid => 24378;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1975 / India zone I,GEOGCS[Kalianpur 1975,DATUM[Kalianpur_1975,SPHEROID[Everest 1830 (1975 Definition),6377299.151,300.8017255,AUTHORITY[EPSG,7045]],TOWGS84[295,736,257,0,0,0,0],AUTHORITY[EPSG,6146]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4146]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,68],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743195.5],PARAMETER[false_northing,914398.5],AUTHORITY[EPSG,24378],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Kalianpur 1975 / India zone I,GEOGCS[Kalianpur 1975,DATUM[Kalianpur_1975,SPHEROID[Everest 1830 (1975 Definition),6377299.151,300.8017255,AUTHORITY[EPSG,7045]],TOWGS84[295,736,257,0,0,0,0],AUTHORITY[EPSG,6146]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4146]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,68],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743195.5],PARAMETER[false_northing,914398.5],AUTHORITY[EPSG,24378],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}