namespace EpsgCoordinateSystems.Other
{
    public class KOC_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "KOC Lambert";
        public string Units => "Unspecified";
public long Srid => 24600;

        public string OgcWkt =>
            "PROJCS[KOC Lambert,GEOGCS[KOC,DATUM[Kuwait_Oil_Company,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-294.7,-200.1,525.5,0,0,0,0],AUTHORITY[EPSG,6246]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4246]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9987864078],PARAMETER[false_easting,1500000],PARAMETER[false_northing,1166200],AUTHORITY[EPSG,24600],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[KOC Lambert,GEOGCS[KOC,DATUM[Kuwait_Oil_Company,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-294.7,-200.1,525.5,0,0,0,0],AUTHORITY[EPSG,6246]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4246]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9987864078],PARAMETER[false_easting,1500000],PARAMETER[false_northing,1166200],AUTHORITY[EPSG,24600],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}