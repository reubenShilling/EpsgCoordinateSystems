namespace EpsgCoordinateSystems.Other
{
    public class Deir_ez_Zor_Syria_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "Deir ez Zor / Syria Lambert";
        public string Units => "Unspecified";
public long Srid => 22770;

        public string OgcWkt =>
            "PROJCS[Deir ez Zor / Syria Lambert,GEOGCS[Deir ez Zor,DATUM[Deir_ez_Zor,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6227]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4227]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,34.65],PARAMETER[central_meridian,37.35],PARAMETER[scale_factor,0.9996256],PARAMETER[false_easting,300000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,22770],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Deir ez Zor / Syria Lambert,GEOGCS[Deir ez Zor,DATUM[D_Deir_ez_Zor,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,34.65],PARAMETER[central_meridian,37.35],PARAMETER[scale_factor,0.9996256],PARAMETER[false_easting,300000],PARAMETER[false_northing,300000],UNIT[Meter,1]]";
    }
}