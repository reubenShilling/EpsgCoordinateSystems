namespace EpsgCoordinateSystems.Categories.Other
{
    public class ETRS89_ETRS_LAEA : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / ETRS-LAEA";
        public string Units => "Unspecified";
public int Srid => 3035;

        public string OgcWkt =>
            "PROJCS[ETRS89 / ETRS-LAEA,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Azimuthal_Equal_Area],PARAMETER[latitude_of_center,52],PARAMETER[longitude_of_center,10],PARAMETER[false_easting,4321000],PARAMETER[false_northing,3210000],AUTHORITY[EPSG,3035],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[ETRS89 / ETRS-LAEA,GEOGCS[ETRS89,DATUM[D_ETRS_1989,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Azimuthal_Equal_Area],PARAMETER[latitude_of_origin,52],PARAMETER[central_meridian,10],PARAMETER[false_easting,4321000],PARAMETER[false_northing,3210000],UNIT[Meter,1]]";
    }
}