using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Colorado_South_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2233;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Colorado South";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Colorado South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,38.43333333333333],PARAMETER[standard_parallel_2,37.23333333333333],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-105.5],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,2233],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Colorado South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,38.43333333333333],PARAMETER[standard_parallel_2,37.23333333333333],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-105.5],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-107.47247, 36.9987768181817, 0),
                    new Vector(-107.41082, 36.9975258181818, 0),
                    new Vector(-106.890377, 36.9990828181819, 0),
                    new Vector(-106.861244, 36.9894978181819, 0),
                    new Vector(-106.472174, 36.9914958181819, 0),
                    new Vector(-105.991988, 36.9922878181819, 0),
                    new Vector(-105.713465, 36.9945648181818, 0),
                    new Vector(-105.213092, 36.9926028181818, 0),
                    new Vector(-105.146168, 36.9932058181819, 0),
                    new Vector(-103.993637, 36.9944748181818, 0),
                    new Vector(-103.07786, 36.9997668181818, 0),
                    new Vector(-102.997706, 36.9985248181819, 0),
                    new Vector(-102.037208, 36.9889938181818, 0),
                    new Vector(-102.042005, 37.3862808181818, 0),
                    new Vector(-102.044453, 37.6414758181819, 0),
                    new Vector(-102.043976, 37.7344008181819, 0),
                    new Vector(-102.046064, 38.2538178181819, 0),
                    new Vector(-102.045542, 38.263348818182, 0),
                    new Vector(-102.047585, 38.6155008181819, 0),
                    new Vector(-103.174169, 38.6085258181819, 0),
                    new Vector(-103.174961, 38.5151328181819, 0),
                    new Vector(-103.49609, 38.5126308181818, 0),
                    new Vector(-103.49888, 38.5071498181818, 0),
                    new Vector(-104.048006, 38.515150818182, 0),
                    new Vector(-104.930771, 38.5177788181818, 0),
                    new Vector(-104.931572, 38.2583448181818, 0),
                    new Vector(-105.040571, 38.2566168181818, 0),
                    new Vector(-105.772199, 38.2496688181819, 0),
                    new Vector(-105.839438, 38.2953978181819, 0),
                    new Vector(-105.898235, 38.3559228181819, 0),
                    new Vector(-105.949607, 38.3890158181817, 0),
                    new Vector(-106.02104, 38.4512958181818, 0),
                    new Vector(-106.050416, 38.4601968181818, 0),
                    new Vector(-106.064582, 38.4515118181819, 0),
                    new Vector(-106.07441, 38.4298218181819, 0),
                    new Vector(-106.239146, 38.4303888181819, 0),
                    new Vector(-106.237535, 38.423647818182, 0),
                    new Vector(-106.994273, 38.4189678181818, 0),
                    new Vector(-106.998035, 38.1477618181819, 0),
                    new Vector(-107.563172, 38.1469878181819, 0),
                    new Vector(-107.581442, 38.2332798181818, 0),
                    new Vector(-107.634254, 38.3033178181819, 0),
                    new Vector(-107.498354, 38.3014008181819, 0),
                    new Vector(-107.497355, 38.6629488181819, 0),
                    new Vector(-108.372254, 38.670004818182, 0),
                    new Vector(-108.379274, 38.5001298181818, 0),
                    new Vector(-109.053941, 38.4946578181819, 0),
                    new Vector(-109.055867, 38.2449168181819, 0),
                    new Vector(-109.043465, 38.1529368181818, 0),
                    new Vector(-109.043213, 37.8874188181819, 0),
                    new Vector(-109.045598, 37.6308198181818, 0),
                    new Vector(-109.048478, 36.9966438181818, 0),
                    new Vector(-108.37247, 36.9994698181819, 0),
                    new Vector(-107.47247, 36.9987768181817, 0)
                })
            }
        };
    }
}