using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kalianpur_1975_UTM_zone_44N : IEpsgCoordinateSystem
    {private const int _srid = 24344; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kalianpur 1975 / UTM zone 44N";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1975 / UTM zone 44N,GEOGCS[Kalianpur 1975,DATUM[Kalianpur_1975,SPHEROID[Everest 1830 (1975 Definition),6377299.151,300.8017255,AUTHORITY[EPSG,7045]],TOWGS84[295,736,257,0,0,0,0],AUTHORITY[EPSG,6146]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4146]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24344],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kalianpur 1975 / UTM zone 44N,GEOGCS[Kalianpur 1975,DATUM[D_Kalianpur_1975,SPHEROID[Everest_1830_1975_Definition,6377299.151,300.8017255]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}