namespace EpsgCoordinateSystems.Other
{
    public class ATS77_MTM_Nova_Scotia_zone_5 : IEpsgCoordinateSystem
    {
        public string Name => "ATS77 / MTM Nova Scotia zone 5";
        public string Units => "Unspecified";
public long Srid => 2295;

        public string OgcWkt =>
            "PROJCS[ATS77 / MTM Nova Scotia zone 5,GEOGCS[ATS77,DATUM[Average_Terrestrial_System_1977,SPHEROID[Average Terrestrial System 1977,6378135,298.257,AUTHORITY[EPSG,7041]],AUTHORITY[EPSG,6122]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4122]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-64.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,5500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2295],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ATS77 / MTM Nova Scotia zone 5,GEOGCS[ATS77,DATUM[Average_Terrestrial_System_1977,SPHEROID[Average Terrestrial System 1977,6378135,298.257,AUTHORITY[EPSG,7041]],AUTHORITY[EPSG,6122]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4122]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-64.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,5500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2295],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}