namespace EpsgCoordinateSystems.Categories.Other
{
    public class Karbala_1979_Polservice_UTM_zone_37N : IEpsgCoordinateSystem
    {
        public string Name => "Karbala 1979 (Polservice) / UTM zone 37N";
        public string Units => "Unspecified";
public int Srid => 3391;

        public string OgcWkt =>
            "PROJCS[Karbala 1979 (Polservice) / UTM zone 37N,GEOGCS[Karbala 1979 (Polservice),DATUM[Karbala_1979_Polservice,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[84.1,-320.1,218.7,0,0,0,0],AUTHORITY[EPSG,6743]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4743]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3391],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Karbala 1979 (Polservice) / UTM zone 37N,GEOGCS[Karbala 1979 (Polservice),DATUM[D_,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}