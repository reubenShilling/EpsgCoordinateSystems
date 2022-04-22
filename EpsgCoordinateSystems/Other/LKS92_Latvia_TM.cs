namespace EpsgCoordinateSystems.Other
{
    public class LKS92_Latvia_TM : IEpsgCoordinateSystem
    {
        public string Name => "LKS92 / Latvia TM";
        public string Units => "Unspecified";
public long Srid => 3059;

        public string OgcWkt =>
            "PROJCS[LKS92 / Latvia TM,GEOGCS[LKS92,DATUM[Latvia_1992,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6661]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4661]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,24],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,-6000000],AUTHORITY[EPSG,3059],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[LKS92 / Latvia TM,GEOGCS[LKS92,DATUM[D_Latvia_1992,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,24],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,-6000000],UNIT[Meter,1]]";
    }
}