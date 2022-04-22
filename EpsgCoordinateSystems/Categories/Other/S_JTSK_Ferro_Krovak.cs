using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class S_JTSK_Ferro_Krovak : IEpsgCoordinateSystem
    {private const int _srid = 2065; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "S-JTSK (Ferro) / Krovak";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[S-JTSK (Ferro) / Krovak,GEOGCS[S-JTSK (Ferro),DATUM[S_JTSK_Ferro,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6818]],PRIMEM[Ferro,-17.66666666666667,AUTHORITY[EPSG,8909]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4818]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Krovak],PARAMETER[latitude_of_center,49.5],PARAMETER[longitude_of_center,42.5],PARAMETER[azimuth,30.28813972222222],PARAMETER[pseudo_standard_parallel_1,78.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2065],AXIS[Y,WEST],AXIS[X,SOUTH]]";

        public string EsriWkt => "PROJCS[S-JTSK (Ferro) / Krovak,GEOGCS[S-JTSK (Ferro),DATUM[D_S_JTSK,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Ferro,-17.66666666666667],UNIT[Degree,0.017453292519943295]],PROJECTION[Krovak],PARAMETER[latitude_of_center,49.5],PARAMETER[longitude_of_center,42.5],PARAMETER[azimuth,30.28813972222222],PARAMETER[pseudo_standard_parallel_1,78.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}