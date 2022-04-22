namespace EpsgCoordinateSystems.Other
{
    public class Bern_1898_Bern_LV03C : IEpsgCoordinateSystem
    {
        public string Name => "Bern 1898 (Bern) / LV03C";
        public string Units => "Unspecified";
public long Srid => 21780;

        public string OgcWkt =>
            "PROJCS[Bern 1898 (Bern) / LV03C,GEOGCS[Bern 1898 (Bern),DATUM[CH1903_Bern,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6801]],PRIMEM[Bern,7.439583333333333,AUTHORITY[EPSG,8907]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4801]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,46.95240555555556],PARAMETER[longitude_of_center,0],PARAMETER[azimuth,90],PARAMETER[rectified_grid_angle,90],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,21780],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Bern 1898 (Bern) / LV03C,GEOGCS[Bern 1898 (Bern),DATUM[D_Bern_1898,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Bern,7.439583333333333],UNIT[Degree,0.017453292519943295]],PROJECTION[Hotine_Oblique_Mercator_Azimuth_Center],PARAMETER[latitude_of_center,46.95240555555556],PARAMETER[longitude_of_center,0],PARAMETER[azimuth,90],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}