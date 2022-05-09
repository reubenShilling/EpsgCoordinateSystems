using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_New_York_Long_Island_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2263;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New York Long Island";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / New York Long Island (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",41.03333333333333],PARAMETER[\"standard_parallel_2\",40.66666666666666],PARAMETER[\"latitude_of_origin\",40.16666666666666],PARAMETER[\"central_meridian\",-74],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2263\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / New York Long Island (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",41.03333333333333],PARAMETER[\"standard_parallel_2\",40.66666666666666],PARAMETER[\"latitude_of_origin\",40.16666666666666],PARAMETER[\"central_meridian\",-74],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(40.7888568181818, -73.753916),
                    new Vector(40.7971188181819, -73.89901399999999),
                    new Vector(40.7393838181819, -73.955606),
                    new Vector(40.6393398181818, -74.027714),
                    new Vector(40.5812628181819, -74.004035),
                    new Vector(40.5902718181818, -73.879817),
                    new Vector(40.631122818182, -73.915736),
                    new Vector(40.6525968181818, -73.84606700000001),
                    new Vector(40.6369368181818, -73.764932),
                    new Vector(40.6182348181817, -73.76139499999989),
                    new Vector(40.557655818182, -73.927589),
                    new Vector(40.5945918181818, -73.752206),
                    new Vector(40.6613268181819, -73.422527),
                    new Vector(40.8150468181818, -72.521168),
                    new Vector(41.0305698181818, -71.918699),
                    new Vector(41.0745078181819, -71.869991),
                    new Vector(41.0848758181818, -71.923703),
                    new Vector(41.0005728181818, -72.077009),
                    new Vector(41.0353758181819, -72.2033509999999),
                    new Vector(41.0240178181818, -72.293081),
                    new Vector(40.9201488181819, -72.476105),
                    new Vector(40.9052988181819, -72.604814),
                    new Vector(40.9661838181819, -72.55097600000001),
                    new Vector(41.0260338181818, -72.41634499999989),
                    new Vector(41.1102018181819, -72.354281),
                    new Vector(41.1425388181819, -72.281147),
                    new Vector(41.149333818182, -72.31703),
                    new Vector(40.9812858181818, -72.63157099999999),
                    new Vector(40.968433818182, -73.021271),
                    new Vector(40.9513968181819, -73.14098),
                    new Vector(40.9010418181819, -73.214528),
                    new Vector(40.9225518181819, -73.430645),
                    new Vector(40.8797478181818, -73.478093),
                    new Vector(40.9031478181819, -73.59827),
                    new Vector(40.8449988181819, -73.74947),
                    new Vector(40.7888568181818, -73.753916)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(40.8027978181819, -73.919867),
                    new Vector(40.8323358181818, -73.7963419999999),
                    new Vector(40.8866868181818, -73.78004300000001),
                    new Vector(40.8927438181819, -73.824521),
                    new Vector(40.9081878181818, -73.8378589999999),
                    new Vector(40.9273218181819, -73.908968),
                    new Vector(40.8860388181819, -73.922387),
                    new Vector(40.7974878181819, -73.977062),
                    new Vector(40.7377278181818, -74.00626699999999),
                    new Vector(40.7039958181819, -74.006186),
                    new Vector(40.8027978181819, -73.919867)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(40.5059958181819, -74.236937),
                    new Vector(40.5105678181818, -74.193647),
                    new Vector(40.5447498181819, -74.1229969999999),
                    new Vector(40.6017108181818, -74.05918699999989),
                    new Vector(40.6495638181819, -74.072867),
                    new Vector(40.6244988181819, -74.166296),
                    new Vector(40.5379098181819, -74.236937),
                    new Vector(40.5059958181819, -74.236937)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(40.6263798181819, -73.29306200000001),
                    new Vector(40.6254258181818, -73.24905200000001),
                    new Vector(40.6713438181819, -73.03093699999999),
                    new Vector(40.7000358181819, -72.956318),
                    new Vector(40.7583918181818, -72.76402400000001),
                    new Vector(40.7679678181819, -72.757328),
                    new Vector(40.7641338181819, -72.78220399999999),
                    new Vector(40.7373498181818, -72.87691100000001),
                    new Vector(40.675159818182, -73.0510249999999),
                    new Vector(40.6330758181819, -73.24043899999999),
                    new Vector(40.6330848181819, -73.291145),
                    new Vector(40.6263798181819, -73.29306200000001)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries)
            {
                _boundingBox.Expand(linearRing.CalculateBounds());
            }

            return _boundingBox;
        }
    }
}