using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IRENET95_Irish_Transverse_Mercator : IEpsgCoordinateSystem
    {private const int _srid = 2157; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IRENET95 / Irish Transverse Mercator";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[IRENET95 / Irish Transverse Mercator,GEOGCS[IRENET95,DATUM[IRENET95,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6173]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4173]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,53.5],PARAMETER[central_meridian,-8],PARAMETER[scale_factor,0.99982],PARAMETER[false_easting,600000],PARAMETER[false_northing,750000],AUTHORITY[EPSG,2157],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[IRENET95 / Irish Transverse Mercator,GEOGCS[IRENET95,DATUM[D_IRENET95,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,53.5],PARAMETER[central_meridian,-8],PARAMETER[scale_factor,0.99982],PARAMETER[false_easting,600000],PARAMETER[false_northing,750000],UNIT[Meter,1]]";
    }
}