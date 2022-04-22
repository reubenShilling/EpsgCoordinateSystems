namespace EpsgCoordinateSystems.Other
{
    public class GDM2000_Peninsula_RSO : IEpsgCoordinateSystem
    {
        public string Name => "GDM2000 / Peninsula RSO";
        public string Units => "Unspecified";
public long Srid => 3375;

        public string OgcWkt =>
            "PROJCS[GDM2000 / Peninsula RSO,GEOGCS[GDM2000,DATUM[Geodetic_Datum_of_Malaysia_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6742]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4742]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,4],PARAMETER[longitude_of_center,102.25],PARAMETER[azimuth,323.0257964666666],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.99984],PARAMETER[false_easting,804671],PARAMETER[false_northing,0],AUTHORITY[EPSG,3375],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[GDM2000 / Peninsula RSO,GEOGCS[GDM2000,DATUM[D_GDM_2000,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Hotine_Oblique_Mercator_Azimuth_Natural_Origin],PARAMETER[latitude_of_center,4],PARAMETER[longitude_of_center,102.25],PARAMETER[azimuth,323.0257964666666],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.99984],PARAMETER[false_easting,804671],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}