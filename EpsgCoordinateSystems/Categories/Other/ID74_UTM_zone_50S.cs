using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ID74_UTM_zone_50S : IEpsgCoordinateSystem
    {private const int _srid = 23890; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ID74 / UTM zone 50S";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[ID74 / UTM zone 50S,GEOGCS[ID74,DATUM[Indonesian_Datum_1974,SPHEROID[Indonesian National Spheroid,6378160,298.247,AUTHORITY[EPSG,7021]],AUTHORITY[EPSG,6238]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4238]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,117],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,23890],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[ID74 / UTM zone 50S,GEOGCS[ID74,DATUM[D_Indonesian_1974,SPHEROID[Indonesian_National_Spheroid,6378160,298.247]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,117],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}