namespace EpsgCoordinateSystems.Categories.Other
{
    public class BDA2000_Bermuda_2000_National_Grid : IEpsgCoordinateSystem
    {
        public string Name => "BDA2000 / Bermuda 2000 National Grid";
        public string Units => "Unspecified";
public int Srid => 3770;

        public string OgcWkt =>
            "PROJCS[BDA2000 / Bermuda 2000 National Grid,GEOGCS[BDA2000,DATUM[Bermuda_2000,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6762]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4762]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,32],PARAMETER[central_meridian,-64.75],PARAMETER[scale_factor,1],PARAMETER[false_easting,550000],PARAMETER[false_northing,100000],AUTHORITY[EPSG,3770],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[BDA2000 / Bermuda 2000 National Grid,GEOGCS[BDA2000,DATUM[D_Bermuda_2000,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,32],PARAMETER[central_meridian,-64.75],PARAMETER[scale_factor,1],PARAMETER[false_easting,550000],PARAMETER[false_northing,100000],UNIT[Meter,1]]";
    }
}