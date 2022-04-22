using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class American_Samoa_1962_American_Samoa_Lambert : IEpsgCoordinateSystem
    {private const int _srid = 3102; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "American Samoa 1962 / American Samoa Lambert";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[American Samoa 1962 / American Samoa Lambert,GEOGCS[American Samoa 1962,DATUM[American_Samoa_1962,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[-115,118,426,0,0,0,0],AUTHORITY[EPSG,6169]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4169]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,-14.26666666666667],PARAMETER[central_meridian,-170],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,312234.65],AUTHORITY[EPSG,3102],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[American Samoa 1962 / American Samoa Lambert,GEOGCS[American Samoa 1962,DATUM[D_American_Samoa_1962,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,-14.26666666666667],PARAMETER[central_meridian,-170],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,312234.65],UNIT[Foot_US,0.30480060960121924]]";
    }
}