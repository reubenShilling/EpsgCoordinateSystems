namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tananarive_Paris_Laborde_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Tananarive (Paris) / Laborde Grid";
        public string Units => "Unspecified";
public int Srid => 29701;

        public string OgcWkt =>
            "PROJCS[Tananarive (Paris) / Laborde Grid,GEOGCS[Tananarive (Paris),DATUM[Tananarive_1925_Paris,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-189,-242,-91,0,0,0,0],AUTHORITY[EPSG,6810]],PRIMEM[Paris,2.33722917,AUTHORITY[EPSG,8903]],UNIT[grad,0.01570796326794897,AUTHORITY[EPSG,9105]],AUTHORITY[EPSG,4810]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Laborde_Oblique_Mercator],PARAMETER[latitude_of_center,-21],PARAMETER[longitude_of_center,49],PARAMETER[azimuth,21],PARAMETER[rectified_grid_angle,100],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,800000],AUTHORITY[EPSG,29701],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Tananarive (Paris) / Laborde Grid,GEOGCS[Tananarive (Paris),DATUM[D_Tananarive_1925,SPHEROID[International_1924,6378388,297]],PRIMEM[Paris,2.33722917],UNIT[grad,0.01570796326794897]],PROJECTION[Laborde_Oblique_Mercator],PARAMETER[latitude_of_center,-21],PARAMETER[longitude_of_center,49],PARAMETER[azimuth,21],PARAMETER[rectified_grid_angle,100],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,800000],UNIT[Meter,1]]";
    }
}