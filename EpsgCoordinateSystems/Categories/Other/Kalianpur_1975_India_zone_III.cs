using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kalianpur_1975_India_zone_III : IEpsgCoordinateSystem
    {private const int _srid = 24381; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kalianpur 1975 / India zone III";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1975 / India zone III,GEOGCS[Kalianpur 1975,DATUM[Kalianpur_1975,SPHEROID[Everest 1830 (1975 Definition),6377299.151,300.8017255,AUTHORITY[EPSG,7045]],TOWGS84[295,736,257,0,0,0,0],AUTHORITY[EPSG,6146]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4146]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,19],PARAMETER[central_meridian,80],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743195.5],PARAMETER[false_northing,914398.5],AUTHORITY[EPSG,24381],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kalianpur 1975 / India zone III,GEOGCS[Kalianpur 1975,DATUM[D_Kalianpur_1975,SPHEROID[Everest_1830_1975_Definition,6377299.151,300.8017255]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,19],PARAMETER[central_meridian,80],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743195.5],PARAMETER[false_northing,914398.5],UNIT[Meter,1]]";
    }
}