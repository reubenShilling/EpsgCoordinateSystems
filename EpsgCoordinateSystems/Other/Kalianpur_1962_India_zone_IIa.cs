namespace EpsgCoordinateSystems.Other
{
    public class Kalianpur_1962_India_zone_IIa : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1962 / India zone IIa";
        public string Units => "Unspecified";
public long Srid => 24377;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1962 / India zone IIa,GEOGCS[Kalianpur 1962,DATUM[Kalianpur_1962,SPHEROID[Everest 1830 (1962 Definition),6377301.243,300.8017255,AUTHORITY[EPSG,7044]],AUTHORITY[EPSG,6145]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4145]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,74],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743196.4],PARAMETER[false_northing,914398.8],AUTHORITY[EPSG,24377],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kalianpur 1962 / India zone IIa,GEOGCS[Kalianpur 1962,DATUM[D_Kalianpur_1962,SPHEROID[Everest_1830_1962_Definition,6377301.243,300.8017255]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,74],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743196.4],PARAMETER[false_northing,914398.8],UNIT[Meter,1]]";
    }
}