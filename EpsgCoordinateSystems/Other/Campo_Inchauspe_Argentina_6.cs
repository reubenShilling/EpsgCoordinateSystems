namespace EpsgCoordinateSystems.Other
{
    public class Campo_Inchauspe_Argentina_6 : IEpsgCoordinateSystem
    {
        public string Name => "Campo Inchauspe / Argentina 6";
        public string Units => "Unspecified";
public long Srid => 22196;

        public string OgcWkt =>
            "PROJCS[Campo Inchauspe / Argentina 6,GEOGCS[Campo Inchauspe,DATUM[Campo_Inchauspe,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6221]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4221]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,1],PARAMETER[false_easting,6500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,22196],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Campo Inchauspe / Argentina 6,GEOGCS[Campo Inchauspe,DATUM[D_Campo_Inchauspe,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,1],PARAMETER[false_easting,6500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}