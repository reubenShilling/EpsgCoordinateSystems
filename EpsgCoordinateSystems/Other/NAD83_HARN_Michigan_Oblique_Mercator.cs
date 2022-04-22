namespace EpsgCoordinateSystems.Other
{
    public class NAD83_HARN_Michigan_Oblique_Mercator : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Michigan Oblique Mercator";
        public string Units => "Unspecified";
public long Srid => 3079;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Michigan Oblique Mercator,GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,45.30916666666666],PARAMETER[longitude_of_center,-86],PARAMETER[azimuth,337.25556],PARAMETER[rectified_grid_angle,337.25556],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,2546731.496],PARAMETER[false_northing,-4354009.816],AUTHORITY[EPSG,3079],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(HARN) / Michigan Oblique Mercator,GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Hotine_Oblique_Mercator_Azimuth_Natural_Origin],PARAMETER[latitude_of_center,45.30916666666666],PARAMETER[longitude_of_center,-86],PARAMETER[azimuth,337.25556],PARAMETER[rectified_grid_angle,337.25556],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,2546731.496],PARAMETER[false_northing,-4354009.816],UNIT[Meter,1]]";
    }
}