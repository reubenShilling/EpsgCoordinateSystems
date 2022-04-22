namespace EpsgCoordinateSystems.Other
{
    public class Schwarzeck_UTM_zone_33S : IEpsgCoordinateSystem
    {
        public string Name => "Schwarzeck / UTM zone 33S";
        public string Units => "Unspecified";
public long Srid => 29333;

        public string OgcWkt =>
            "PROJCS[Schwarzeck / UTM zone 33S,GEOGCS[Schwarzeck,DATUM[Schwarzeck,SPHEROID[Bessel Namibia (GLM),6377483.865280419,299.1528128,AUTHORITY[EPSG,7046]],AUTHORITY[EPSG,6293]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4293]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,29333],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Schwarzeck / UTM zone 33S,GEOGCS[Schwarzeck,DATUM[Schwarzeck,SPHEROID[Bessel Namibia (GLM),6377483.865280419,299.1528128,AUTHORITY[EPSG,7046]],AUTHORITY[EPSG,6293]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4293]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,29333],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}