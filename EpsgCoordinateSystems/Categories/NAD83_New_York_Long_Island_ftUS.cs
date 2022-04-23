using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_New_York_Long_Island_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2263;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New York Long Island";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / New York Long Island (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.03333333333333],PARAMETER[standard_parallel_2,40.66666666666666],PARAMETER[latitude_of_origin,40.16666666666666],PARAMETER[central_meridian,-74],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],AUTHORITY[EPSG,2263],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / New York Long Island (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,41.03333333333333],PARAMETER[standard_parallel_2,40.66666666666666],PARAMETER[latitude_of_origin,40.16666666666666],PARAMETER[central_meridian,-74],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-73.753916, 40.7888568181818, 0),
                    new Vector(-73.89901399999999, 40.7971188181819, 0),
                    new Vector(-73.955606, 40.7393838181819, 0),
                    new Vector(-74.027714, 40.6393398181818, 0),
                    new Vector(-74.004035, 40.5812628181819, 0),
                    new Vector(-73.879817, 40.5902718181818, 0),
                    new Vector(-73.915736, 40.631122818182, 0),
                    new Vector(-73.84606700000001, 40.6525968181818, 0),
                    new Vector(-73.764932, 40.6369368181818, 0),
                    new Vector(-73.76139499999989, 40.6182348181817, 0),
                    new Vector(-73.927589, 40.557655818182, 0),
                    new Vector(-73.752206, 40.5945918181818, 0),
                    new Vector(-73.422527, 40.6613268181819, 0),
                    new Vector(-72.521168, 40.8150468181818, 0),
                    new Vector(-71.918699, 41.0305698181818, 0),
                    new Vector(-71.869991, 41.0745078181819, 0),
                    new Vector(-71.923703, 41.0848758181818, 0),
                    new Vector(-72.077009, 41.0005728181818, 0),
                    new Vector(-72.2033509999999, 41.0353758181819, 0),
                    new Vector(-72.293081, 41.0240178181818, 0),
                    new Vector(-72.476105, 40.9201488181819, 0),
                    new Vector(-72.604814, 40.9052988181819, 0),
                    new Vector(-72.55097600000001, 40.9661838181819, 0),
                    new Vector(-72.41634499999989, 41.0260338181818, 0),
                    new Vector(-72.354281, 41.1102018181819, 0),
                    new Vector(-72.281147, 41.1425388181819, 0),
                    new Vector(-72.31703, 41.149333818182, 0),
                    new Vector(-72.63157099999999, 40.9812858181818, 0),
                    new Vector(-73.021271, 40.968433818182, 0),
                    new Vector(-73.14098, 40.9513968181819, 0),
                    new Vector(-73.214528, 40.9010418181819, 0),
                    new Vector(-73.430645, 40.9225518181819, 0),
                    new Vector(-73.478093, 40.8797478181818, 0),
                    new Vector(-73.59827, 40.9031478181819, 0),
                    new Vector(-73.74947, 40.8449988181819, 0),
                    new Vector(-73.753916, 40.7888568181818, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-73.919867, 40.8027978181819, 0),
                    new Vector(-73.7963419999999, 40.8323358181818, 0),
                    new Vector(-73.78004300000001, 40.8866868181818, 0),
                    new Vector(-73.824521, 40.8927438181819, 0),
                    new Vector(-73.8378589999999, 40.9081878181818, 0),
                    new Vector(-73.908968, 40.9273218181819, 0),
                    new Vector(-73.922387, 40.8860388181819, 0),
                    new Vector(-73.977062, 40.7974878181819, 0),
                    new Vector(-74.00626699999999, 40.7377278181818, 0),
                    new Vector(-74.006186, 40.7039958181819, 0),
                    new Vector(-73.919867, 40.8027978181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-74.236937, 40.5059958181819, 0),
                    new Vector(-74.193647, 40.5105678181818, 0),
                    new Vector(-74.1229969999999, 40.5447498181819, 0),
                    new Vector(-74.05918699999989, 40.6017108181818, 0),
                    new Vector(-74.072867, 40.6495638181819, 0),
                    new Vector(-74.166296, 40.6244988181819, 0),
                    new Vector(-74.236937, 40.5379098181819, 0),
                    new Vector(-74.236937, 40.5059958181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-73.29306200000001, 40.6263798181819, 0),
                    new Vector(-73.24905200000001, 40.6254258181818, 0),
                    new Vector(-73.03093699999999, 40.6713438181819, 0),
                    new Vector(-72.956318, 40.7000358181819, 0),
                    new Vector(-72.76402400000001, 40.7583918181818, 0),
                    new Vector(-72.757328, 40.7679678181819, 0),
                    new Vector(-72.78220399999999, 40.7641338181819, 0),
                    new Vector(-72.87691100000001, 40.7373498181818, 0),
                    new Vector(-73.0510249999999, 40.675159818182, 0),
                    new Vector(-73.24043899999999, 40.6330758181819, 0),
                    new Vector(-73.291145, 40.6330848181819, 0),
                    new Vector(-73.29306200000001, 40.6263798181819, 0)
                })
            }
        };
    }
}