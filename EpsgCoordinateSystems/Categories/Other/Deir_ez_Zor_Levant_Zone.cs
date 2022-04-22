namespace EpsgCoordinateSystems.Categories.Other
{
    public class Deir_ez_Zor_Levant_Zone : IEpsgCoordinateSystem
    {
        public string Name => "Deir ez Zor / Levant Zone";
        public string Units => "Unspecified";
public int Srid => 22700;

        public string OgcWkt =>
            "PROJCS[Deir ez Zor / Levant Zone,GEOGCS[Deir ez Zor,DATUM[Deir_ez_Zor,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6227]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4227]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,34.65],PARAMETER[central_meridian,37.35],PARAMETER[scale_factor,0.9996256],PARAMETER[false_easting,300000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,22700],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Deir ez Zor / Levant Zone,GEOGCS[Deir ez Zor,DATUM[D_Deir_ez_Zor,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,34.65],PARAMETER[central_meridian,37.35],PARAMETER[scale_factor,0.9996256],PARAMETER[false_easting,300000],PARAMETER[false_northing,300000],UNIT[Meter,1]]";
    }
}