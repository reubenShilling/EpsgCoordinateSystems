namespace EpsgCoordinateSystems.Other
{
    public class GDA94_BCSG02 : IEpsgCoordinateSystem
    {
        public string Name => "GDA94 / BCSG02";
        public string Units => "Unspecified";
public long Srid => 3113;

        public string OgcWkt =>
            "PROJCS[GDA94 / BCSG02,GEOGCS[GDA94,DATUM[Geocentric_Datum_of_Australia_1994,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6283]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4283]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-28],PARAMETER[central_meridian,153],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,50000],PARAMETER[false_northing,100000],AUTHORITY[EPSG,3113],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[GDA94 / BCSG02,GEOGCS[GDA94,DATUM[D_GDA_1994,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-28],PARAMETER[central_meridian,153],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,50000],PARAMETER[false_northing,100000],UNIT[Meter,1]]";
    }
}