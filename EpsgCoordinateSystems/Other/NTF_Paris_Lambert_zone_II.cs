namespace EpsgCoordinateSystems.Other
{
    public class NTF_Paris_Lambert_zone_II : IEpsgCoordinateSystem
    {
        public string Name => "NTF (Paris) / Lambert zone II";
        public string Units => "Unspecified";
public long Srid => 27572;

        public string OgcWkt =>
            "PROJCS[NTF (Paris) / Lambert zone II,GEOGCS[NTF (Paris),DATUM[Nouvelle_Triangulation_Francaise_Paris,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-168,-60,320,0,0,0,0],AUTHORITY[EPSG,6807]],PRIMEM[Paris,2.33722917,AUTHORITY[EPSG,8903]],UNIT[grad,0.01570796326794897,AUTHORITY[EPSG,9105]],AUTHORITY[EPSG,4807]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,52],PARAMETER[central_meridian,0],PARAMETER[scale_factor,0.99987742],PARAMETER[false_easting,600000],PARAMETER[false_northing,2200000],AUTHORITY[EPSG,27572],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NTF (Paris) / Lambert zone II,GEOGCS[NTF (Paris),DATUM[D_NTF,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Paris,2.33722917],UNIT[grad,0.01570796326794897]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,52],PARAMETER[central_meridian,0],PARAMETER[scale_factor,0.99987742],PARAMETER[false_easting,600000],PARAMETER[false_northing,2200000],UNIT[Meter,1]]";
    }
}