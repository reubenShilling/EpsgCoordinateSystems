namespace EpsgCoordinateSystems.Other
{
    public class Campo_Inchauspe_Argentina_7 : IEpsgCoordinateSystem
    {
        public string Name => "Campo Inchauspe / Argentina 7";
        public string Units => "Unspecified";
public long Srid => 22197;

        public string OgcWkt =>
            "PROJCS[Campo Inchauspe / Argentina 7,GEOGCS[Campo Inchauspe,DATUM[Campo_Inchauspe,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6221]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4221]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-54],PARAMETER[scale_factor,1],PARAMETER[false_easting,7500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,22197],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Campo Inchauspe / Argentina 7,GEOGCS[Campo Inchauspe,DATUM[Campo_Inchauspe,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6221]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4221]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-54],PARAMETER[scale_factor,1],PARAMETER[false_easting,7500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,22197],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}