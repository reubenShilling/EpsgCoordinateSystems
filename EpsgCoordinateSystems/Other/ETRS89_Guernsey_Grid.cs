namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_Guernsey_Grid : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / Guernsey Grid";
        public string Units => "Unspecified";
public long Srid => 3108;

        public string OgcWkt =>
            "PROJCS[ETRS89 / Guernsey Grid,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,49.5],PARAMETER[central_meridian,-2.416666666666667],PARAMETER[scale_factor,0.999997],PARAMETER[false_easting,47000],PARAMETER[false_northing,50000],AUTHORITY[EPSG,3108],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[ETRS89 / Guernsey Grid,GEOGCS[ETRS89,DATUM[D_ETRS_1989,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,49.5],PARAMETER[central_meridian,-2.416666666666667],PARAMETER[scale_factor,0.999997],PARAMETER[false_easting,47000],PARAMETER[false_northing,50000],UNIT[Meter,1]]";
    }
}