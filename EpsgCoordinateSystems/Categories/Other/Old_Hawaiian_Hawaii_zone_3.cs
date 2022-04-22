using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Old_Hawaiian_Hawaii_zone_3 : IEpsgCoordinateSystem
    {private const int _srid = 3563; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Old Hawaiian / Hawaii zone 3";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Old Hawaiian / Hawaii zone 3,GEOGCS[Old Hawaiian,DATUM[Old_Hawaiian,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6135]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4135]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,21.16666666666667],PARAMETER[central_meridian,-158],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3563],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Old Hawaiian / Hawaii zone 3,GEOGCS[Old Hawaiian,DATUM[D_Old_Hawaiian,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,21.16666666666667],PARAMETER[central_meridian,-158],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";
    }
}