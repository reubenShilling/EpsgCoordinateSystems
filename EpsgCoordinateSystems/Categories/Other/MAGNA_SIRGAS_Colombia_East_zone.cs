using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class MAGNA_SIRGAS_Colombia_East_zone : IEpsgCoordinateSystem
    {private const int _srid = 3118; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "MAGNA-SIRGAS / Colombia East zone";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[MAGNA-SIRGAS / Colombia East zone,GEOGCS[MAGNA-SIRGAS,DATUM[Marco_Geocentrico_Nacional_de_Referencia,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6686]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4686]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4.596200416666666],PARAMETER[central_meridian,-68.07750791666666],PARAMETER[scale_factor,1],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,3118],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[MAGNA-SIRGAS / Colombia East zone,GEOGCS[MAGNA-SIRGAS,DATUM[D_MAGNA,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,4.596200416666666],PARAMETER[central_meridian,-68.07750791666666],PARAMETER[scale_factor,1],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],UNIT[Meter,1]]";
    }
}