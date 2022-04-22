namespace EpsgCoordinateSystems.Other
{
    public class IGC_1962_Congo_TM_zone_28 : IEpsgCoordinateSystem
    {
        public string Name => "IGC 1962 / Congo TM zone 28";
        public string Units => "Unspecified";
public long Srid => 3326;

        public string OgcWkt =>
            "PROJCS[IGC 1962 / Congo TM zone 28,GEOGCS[IGC 1962 6th Parallel South,DATUM[IGC_1962_Arc_of_the_6th_Parallel_South,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6697]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4697]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,28],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3326],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[IGC 1962 / Congo TM zone 28,GEOGCS[IGC 1962 6th Parallel South,DATUM[D_IGC_1962_Arc_of_the_6th_Parallel_South,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,28],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}