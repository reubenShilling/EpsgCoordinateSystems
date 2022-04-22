namespace EpsgCoordinateSystems.Categories.Other
{
    public class Dominica_1945_British_West_Indies_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Dominica 1945 / British West Indies Grid";
        public string Units => "Unspecified";
public int Srid => 2002;

        public string OgcWkt =>
            "PROJCS[Dominica 1945 / British West Indies Grid,GEOGCS[Dominica 1945,DATUM[Dominica_1945,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[725,685,536,0,0,0,0],AUTHORITY[EPSG,6602]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4602]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2002],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Dominica 1945 / British West Indies Grid,GEOGCS[Dominica 1945,DATUM[D_Dominica_1945,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}