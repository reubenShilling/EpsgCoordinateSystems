namespace EpsgCoordinateSystems.Other
{
    public class St_Vincent_45_British_West_Indies_Grid : IEpsgCoordinateSystem
    {
        public string Name => "St. Vincent 45 / British West Indies Grid";
        public string Units => "Unspecified";
public long Srid => 2007;

        public string OgcWkt =>
            "PROJCS[St. Vincent 45 / British West Indies Grid,GEOGCS[St. Vincent 1945,DATUM[St_Vincent_1945,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[195.671,332.517,274.607,0,0,0,0],AUTHORITY[EPSG,6607]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4607]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2007],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[St. Vincent 45 / British West Indies Grid,GEOGCS[St. Vincent 1945,DATUM[St_Vincent_1945,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[195.671,332.517,274.607,0,0,0,0],AUTHORITY[EPSG,6607]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4607]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2007],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}