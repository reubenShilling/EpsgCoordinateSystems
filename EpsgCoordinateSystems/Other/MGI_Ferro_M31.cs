namespace EpsgCoordinateSystems.Other
{
    public class MGI_Ferro_M31 : IEpsgCoordinateSystem
    {
        public string Name => "MGI (Ferro) / M31";
        public string Units => "Unspecified";
public long Srid => 31289;

        public string OgcWkt =>
            "PROJCS[MGI (Ferro) / M31,GEOGCS[MGI (Ferro),DATUM[Militar_Geographische_Institut_Ferro,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6805]],PRIMEM[Ferro,-17.66666666666667,AUTHORITY[EPSG,8909]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4805]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,31],PARAMETER[scale_factor,1],PARAMETER[false_easting,450000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31289],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[MGI (Ferro) / M31,GEOGCS[MGI (Ferro),DATUM[Militar_Geographische_Institut_Ferro,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6805]],PRIMEM[Ferro,-17.66666666666667,AUTHORITY[EPSG,8909]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4805]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,31],PARAMETER[scale_factor,1],PARAMETER[false_easting,450000],PARAMETER[false_northing,0],AUTHORITY[EPSG,31289],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}