using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Delaware_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2235;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Delaware";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Delaware (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38],PARAMETER[central_meridian,-75.41666666666667],PARAMETER[scale_factor,0.999995],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2235],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Delaware (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38],PARAMETER[central_meridian,-75.41666666666667],PARAMETER[scale_factor,0.999995],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-75.724592, 38.8302858181819, 0),
                    new Vector(-75.710705, 38.6496648181819, 0),
                    new Vector(-75.707069, 38.5575948181819, 0),
                    new Vector(-75.698798, 38.463184818182, 0),
                    new Vector(-75.3498409999999, 38.4553188181818, 0),
                    new Vector(-75.09272, 38.4505668181819, 0),
                    new Vector(-75.067925, 38.4500718181818, 0),
                    new Vector(-75.04562300000001, 38.4496038181818, 0),
                    new Vector(-75.08276600000001, 38.7999288181819, 0),
                    new Vector(-75.190577, 38.8087848181819, 0),
                    new Vector(-75.3075319999999, 38.9460258181817, 0),
                    new Vector(-75.324488, 39.0124998181819, 0),
                    new Vector(-75.397361, 39.0731418181817, 0),
                    new Vector(-75.40212200000001, 39.2577588181818, 0),
                    new Vector(-75.515216, 39.3670548181819, 0),
                    new Vector(-75.58983499999989, 39.4638858181818, 0),
                    new Vector(-75.562646, 39.5668368181819, 0),
                    new Vector(-75.610373, 39.6129078181819, 0),
                    new Vector(-75.489278, 39.7148508181818, 0),
                    new Vector(-75.475976, 39.7200798181818, 0),
                    new Vector(-75.474761, 39.7418328181818, 0),
                    new Vector(-75.46038799999999, 39.7633608181819, 0),
                    new Vector(-75.4276459999999, 39.7782468181819, 0),
                    new Vector(-75.41175200000001, 39.7897758181819, 0),
                    new Vector(-75.420464, 39.7989828181818, 0),
                    new Vector(-75.469982, 39.8265498181818, 0),
                    new Vector(-75.583445, 39.840121818182, 0),
                    new Vector(-75.64398799999999, 39.8383128181819, 0),
                    new Vector(-75.69477500000001, 39.8204568181819, 0),
                    new Vector(-75.7455889999999, 39.7749258181819, 0),
                    new Vector(-75.774929, 39.7245528181819, 0),
                    new Vector(-75.791093, 39.7238598181819, 0),
                    new Vector(-75.772355, 39.3831198181819, 0),
                    new Vector(-75.764318, 39.2959638181819, 0),
                    new Vector(-75.761312, 39.2478678181819, 0),
                    new Vector(-75.752573, 39.1416678181819, 0),
                    new Vector(-75.724592, 38.8302858181819, 0)
                })
            }
        };
    }
}