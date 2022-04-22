namespace EpsgCoordinateSystems.Categories.Other
{
    public class GDM2000_East_Malaysia_BRSO : IEpsgCoordinateSystem
    {
        public string Name => "GDM2000 / East Malaysia BRSO";
        public string Units => "Unspecified";
public int Srid => 3376;

        public string OgcWkt =>
            "PROJCS[GDM2000 / East Malaysia BRSO,GEOGCS[GDM2000,DATUM[Geodetic_Datum_of_Malaysia_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6742]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4742]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,4],PARAMETER[longitude_of_center,115],PARAMETER[azimuth,53.31580995],PARAMETER[rectified_grid_angle,53.13010236111111],PARAMETER[scale_factor,0.99984],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3376],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[GDM2000 / East Malaysia BRSO,GEOGCS[GDM2000,DATUM[D_GDM_2000,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Hotine_Oblique_Mercator_Azimuth_Natural_Origin],PARAMETER[latitude_of_center,4],PARAMETER[longitude_of_center,115],PARAMETER[azimuth,53.31580995],PARAMETER[rectified_grid_angle,53.13010236111111],PARAMETER[scale_factor,0.99984],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}