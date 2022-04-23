using SharpKml.Base;using SharpKml.Dom;using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Utah_South_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {private const int _srid = 3567; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Utah South";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Utah South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,38.35],PARAMETER[standard_parallel_2,37.21666666666667],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,1640416.6667],PARAMETER[false_northing,9842500.000000002],AUTHORITY[EPSG,3567],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Utah South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,38.35],PARAMETER[standard_parallel_2,37.21666666666667],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,1640416.6667],PARAMETER[false_northing,9842500.000000002],UNIT[Foot_US,0.30480060960121924]]";
public LinearRing Wgs84Boundary => new LinearRing{Coordinates = new CoordinateCollection(new[]{new Vector(-109.045598,37.6308198181818,0),
new Vector(-109.043213,37.8874188181819,0),
new Vector(-109.043465,38.1529368181818,0),
new Vector(-109.055867,38.2449168181819,0),
new Vector(-109.053941,38.4946578181819,0),
new Vector(-110.039702,38.4980148181818,0),
new Vector(-111.303662,38.4998508181819,0),
new Vector(-111.304274,38.5071498181818,0),
new Vector(-111.740027,38.5092828181819,0),
new Vector(-111.768692,38.4955218181818,0),
new Vector(-112.067159,38.4964938181819,0),
new Vector(-112.066376,38.5082568181819,0),
new Vector(-112.513973,38.5067538181819,0),
new Vector(-112.517546,38.5731288181818,0),
new Vector(-113.127773,38.5765578181819,0),
new Vector(-113.127449,38.5715538181819,0),
new Vector(-113.563562,38.5790238181818,0),
new Vector(-114.045089,38.5710948181818,0),
new Vector(-114.047276,38.1376548181818,0),
new Vector(-114.047267,37.5984828181818,0),
new Vector(-114.043937,36.9965358181818,0),
new Vector(-112.899992,36.9962298181819,0),
new Vector(-112.542521,36.9979938181818,0),
new Vector(-112.237259,36.9954918181819,0),
new Vector(-111.356168,37.0017108181819,0),
new Vector(-110.740064,37.0024938181818,0),
new Vector(-110.484095,37.0039248181819,0),
new Vector(-110.452244,36.9917478181819,0),
new Vector(-109.997069,36.9920628181819,0),
new Vector(-109.048478,36.9966438181818,0),
new Vector(-109.045598,37.6308198181818,0)})};
    }
}