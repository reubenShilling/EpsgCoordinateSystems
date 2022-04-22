namespace EpsgCoordinateSystems.Categories.Other
{
    public class RGNC91_93_Lambert_New_Caledonia : IEpsgCoordinateSystem
    {
        public string Name => "RGNC91-93 / Lambert New Caledonia";
        public string Units => "Unspecified";
public int Srid => 3163;

        public string OgcWkt =>
            "PROJCS[RGNC91-93 / Lambert New Caledonia,GEOGCS[RGNC91-93,DATUM[Reseau_Geodesique_de_Nouvelle_Caledonie_91_93,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6749]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4749]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-20.66666666666667],PARAMETER[standard_parallel_2,-22.33333333333333],PARAMETER[latitude_of_origin,-21.5],PARAMETER[central_meridian,166],PARAMETER[false_easting,400000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,3163],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[RGNC91-93 / Lambert New Caledonia,GEOGCS[RGNC91-93,DATUM[D_,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,-20.66666666666667],PARAMETER[standard_parallel_2,-22.33333333333333],PARAMETER[latitude_of_origin,-21.5],PARAMETER[central_meridian,166],PARAMETER[false_easting,400000],PARAMETER[false_northing,300000],UNIT[Meter,1]]";
    }
}