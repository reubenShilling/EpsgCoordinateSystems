namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kalianpur_1962_India_zone_I : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1962 / India zone I";
        public string Units => "Unspecified";
public int Srid => 24376;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1962 / India zone I,GEOGCS[Kalianpur 1962,DATUM[Kalianpur_1962,SPHEROID[Everest 1830 (1962 Definition),6377301.243,300.8017255,AUTHORITY[EPSG,7044]],AUTHORITY[EPSG,6145]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4145]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,68],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743196.4],PARAMETER[false_northing,914398.8],AUTHORITY[EPSG,24376],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kalianpur 1962 / India zone I,GEOGCS[Kalianpur 1962,DATUM[D_Kalianpur_1962,SPHEROID[Everest_1830_1962_Definition,6377301.243,300.8017255]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,68],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743196.4],PARAMETER[false_northing,914398.8],UNIT[Meter,1]]";
    }
}