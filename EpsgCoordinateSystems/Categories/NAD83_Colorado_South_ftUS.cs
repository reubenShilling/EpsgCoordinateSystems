using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
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
                    new Vector(36.9987768181817, -107.47247),
                    new Vector(36.9975258181818, -107.41082),
                    new Vector(36.9990828181819, -106.890377),
                    new Vector(36.9894978181819, -106.861244),
                    new Vector(36.9914958181819, -106.472174),
                    new Vector(36.9922878181819, -105.991988),
                    new Vector(36.9945648181818, -105.713465),
                    new Vector(36.9926028181818, -105.213092),
                    new Vector(36.9932058181819, -105.146168),
                    new Vector(36.9944748181818, -103.993637),
                    new Vector(36.9997668181818, -103.07786),
                    new Vector(36.9985248181819, -102.997706),
                    new Vector(36.9889938181818, -102.037208),
                    new Vector(37.3862808181818, -102.042005),
                    new Vector(37.6414758181819, -102.044453),
                    new Vector(37.7344008181819, -102.043976),
                    new Vector(38.2538178181819, -102.046064),
                    new Vector(38.263348818182, -102.045542),
                    new Vector(38.6155008181819, -102.047585),
                    new Vector(38.6085258181819, -103.174169),
                    new Vector(38.5151328181819, -103.174961),
                    new Vector(38.5126308181818, -103.49609),
                    new Vector(38.5071498181818, -103.49888),
                    new Vector(38.515150818182, -104.048006),
                    new Vector(38.5177788181818, -104.930771),
                    new Vector(38.2583448181818, -104.931572),
                    new Vector(38.2566168181818, -105.040571),
                    new Vector(38.2496688181819, -105.772199),
                    new Vector(38.2953978181819, -105.839438),
                    new Vector(38.3559228181819, -105.898235),
                    new Vector(38.3890158181817, -105.949607),
                    new Vector(38.4512958181818, -106.02104),
                    new Vector(38.4601968181818, -106.050416),
                    new Vector(38.4515118181819, -106.064582),
                    new Vector(38.4298218181819, -106.07441),
                    new Vector(38.4303888181819, -106.239146),
                    new Vector(38.423647818182, -106.237535),
                    new Vector(38.4189678181818, -106.994273),
                    new Vector(38.1477618181819, -106.998035),
                    new Vector(38.1469878181819, -107.563172),
                    new Vector(38.2332798181818, -107.581442),
                    new Vector(38.3033178181819, -107.634254),
                    new Vector(38.3014008181819, -107.498354),
                    new Vector(38.6629488181819, -107.497355),
                    new Vector(38.670004818182, -108.372254),
                    new Vector(38.5001298181818, -108.379274),
                    new Vector(38.4946578181819, -109.053941),
                    new Vector(38.2449168181819, -109.055867),
                    new Vector(38.1529368181818, -109.043465),
                    new Vector(37.8874188181819, -109.043213),
                    new Vector(37.6308198181818, -109.045598),
                    new Vector(36.9966438181818, -109.048478),
                    new Vector(36.9994698181819, -108.37247),
                    new Vector(36.9987768181817, -107.47247)
                })
            }
        };
    }
}