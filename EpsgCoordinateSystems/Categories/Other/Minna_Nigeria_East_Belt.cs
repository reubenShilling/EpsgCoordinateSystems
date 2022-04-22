namespace EpsgCoordinateSystems.Categories.Other
{
    public class Minna_Nigeria_East_Belt : IEpsgCoordinateSystem
    {
        public string Name => "Minna / Nigeria East Belt";
        public string Units => "Unspecified";
public int Srid => 26393;

        public string OgcWkt =>
            "PROJCS[Minna / Nigeria East Belt,GEOGCS[Minna,DATUM[Minna,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6263]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4263]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4],PARAMETER[central_meridian,12.5],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,1110369.7],PARAMETER[false_northing,0],AUTHORITY[EPSG,26393],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Minna / Nigeria East Belt,GEOGCS[Minna,DATUM[D_Minna,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4],PARAMETER[central_meridian,12.5],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,1110369.7],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}