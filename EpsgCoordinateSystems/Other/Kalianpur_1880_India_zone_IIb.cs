namespace EpsgCoordinateSystems.Other
{
    public class Kalianpur_1880_India_zone_IIb : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1880 / India zone IIb";
        public long Srid => 24382;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1880 / India zone IIb,GEOGCS[Kalianpur 1880,DATUM[Kalianpur_1880,SPHEROID[Everest (1830 Definition),6377299.36559538,300.8017255433612,AUTHORITY[EPSG,7042]],AUTHORITY[EPSG,6243]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4243]],UNIT[Indian yard,0.9143985307444408,AUTHORITY[EPSG,9084]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,90],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,24382],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Kalianpur 1880 / India zone IIb,GEOGCS[Kalianpur 1880,DATUM[Kalianpur_1880,SPHEROID[Everest (1830 Definition),6377299.36559538,300.8017255433612,AUTHORITY[EPSG,7042]],AUTHORITY[EPSG,6243]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4243]],UNIT[Indian yard,0.9143985307444408,AUTHORITY[EPSG,9084]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,90],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,24382],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}