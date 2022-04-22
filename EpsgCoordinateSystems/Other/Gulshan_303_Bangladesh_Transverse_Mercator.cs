namespace EpsgCoordinateSystems.Other
{
    public class Gulshan_303_Bangladesh_Transverse_Mercator : IEpsgCoordinateSystem
    {
        public string Name => "Gulshan 303 / Bangladesh Transverse Mercator";
        public string Units => "Unspecified";
public long Srid => 3106;

        public string OgcWkt =>
            "PROJCS[Gulshan 303 / Bangladesh Transverse Mercator,GEOGCS[Gulshan 303,DATUM[Gulshan_303,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6682]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4682]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,90],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3106],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Gulshan 303 / Bangladesh Transverse Mercator,GEOGCS[Gulshan 303,DATUM[Gulshan_303,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6682]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4682]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,90],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3106],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}