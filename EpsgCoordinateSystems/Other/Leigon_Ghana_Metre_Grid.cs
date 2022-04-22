namespace EpsgCoordinateSystems.Other
{
    public class Leigon_Ghana_Metre_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Leigon / Ghana Metre Grid";
        public string Units => "Unspecified";
public long Srid => 25000;

        public string OgcWkt =>
            "PROJCS[Leigon / Ghana Metre Grid,GEOGCS[Leigon,DATUM[Leigon,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-130,29,364,0,0,0,0],AUTHORITY[EPSG,6250]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4250]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4.666666666666667],PARAMETER[central_meridian,-1],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,274319.51],PARAMETER[false_northing,0],AUTHORITY[EPSG,25000],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Leigon / Ghana Metre Grid,GEOGCS[Leigon,DATUM[Leigon,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-130,29,364,0,0,0,0],AUTHORITY[EPSG,6250]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4250]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4.666666666666667],PARAMETER[central_meridian,-1],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,274319.51],PARAMETER[false_northing,0],AUTHORITY[EPSG,25000],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}