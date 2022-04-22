namespace EpsgCoordinateSystems.Categories.Other
{
    public class Anguilla_1957_British_West_Indies_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Anguilla 1957 / British West Indies Grid";
        public string Units => "Unspecified";
public int Srid => 2000;

        public string OgcWkt =>
            "PROJCS[Anguilla 1957 / British West Indies Grid,GEOGCS[Anguilla 1957,DATUM[Anguilla_1957,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6600]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4600]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2000],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Anguilla 1957 / British West Indies Grid,GEOGCS[Anguilla 1957,DATUM[D_Anguilla_1957,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}