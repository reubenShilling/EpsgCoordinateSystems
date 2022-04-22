using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class CH1903_LV03 : IEpsgCoordinateSystem
    {private const int _srid = 21781; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "CH1903 / LV03";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[CH1903 / LV03,GEOGCS[CH1903,DATUM[CH1903,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[674.374,15.056,405.346,0,0,0,0],AUTHORITY[EPSG,6149]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4149]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,46.95240555555556],PARAMETER[longitude_of_center,7.439583333333333],PARAMETER[azimuth,90],PARAMETER[rectified_grid_angle,90],PARAMETER[scale_factor,1],PARAMETER[false_easting,600000],PARAMETER[false_northing,200000],AUTHORITY[EPSG,21781],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[CH1903 / LV03,GEOGCS[CH1903,DATUM[D_CH1903,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Hotine_Oblique_Mercator_Azimuth_Center],PARAMETER[latitude_of_center,46.95240555555556],PARAMETER[longitude_of_center,7.439583333333333],PARAMETER[azimuth,90],PARAMETER[scale_factor,1],PARAMETER[false_easting,600000],PARAMETER[false_northing,200000],UNIT[Meter,1]]";
    }
}