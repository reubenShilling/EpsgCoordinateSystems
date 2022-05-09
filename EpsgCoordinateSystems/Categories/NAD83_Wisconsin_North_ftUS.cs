using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wisconsin_North_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 2287;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Wisconsin North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Wisconsin North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,46.76666666666667],PARAMETER[standard_parallel_2,45.56666666666667],PARAMETER[latitude_of_origin,45.16666666666666],PARAMETER[central_meridian,-90],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2287],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Wisconsin North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,46.76666666666667],PARAMETER[standard_parallel_2,45.56666666666667],PARAMETER[latitude_of_origin,45.16666666666666],PARAMETER[central_meridian,-90],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(45.6449508181818, -92.885396),
                    new Vector(45.6449778181819, -92.537357),
                    new Vector(45.7279488181819, -92.53004900000001),
                    new Vector(45.72431281818181, -92.158646),
                    new Vector(45.6383178181819, -92.15781799999999),
                    new Vector(45.6402438181819, -92.03344700000001),
                    new Vector(45.6408018181819, -91.540913),
                    new Vector(45.63689581818189, -90.677048),
                    new Vector(45.37955881818181, -90.675752),
                    new Vector(45.3840408181819, -90.043205),
                    new Vector(45.5545188181818, -90.04134200000001),
                    new Vector(45.5569488181818, -89.42142200000001),
                    new Vector(45.4700988181819, -89.4202159999999),
                    new Vector(45.4679838181818, -89.0421259999999),
                    new Vector(45.4638528181818, -88.919375),
                    new Vector(45.3829608181819, -88.91942899999999),
                    new Vector(45.3784608181819, -88.669679),
                    new Vector(45.3757968181819, -88.4225299999999),
                    new Vector(45.7213518181819, -88.41498799999989),
                    new Vector(45.715258818182, -88.055789),
                    new Vector(45.7861068181817, -88.05164000000001),
                    new Vector(45.7915338181819, -88.08873800000001),
                    new Vector(45.8193978181819, -88.129949),
                    new Vector(45.8348778181819, -88.121786),
                    new Vector(45.87364981818181, -88.06541900000001),
                    new Vector(45.89180281818191, -88.095767),
                    new Vector(45.9206208181819, -88.09385899999999),
                    new Vector(45.9262908181819, -88.111391),
                    new Vector(45.9362898181818, -88.15043300000001),
                    new Vector(45.9535158181819, -88.180187),
                    new Vector(45.947899818182, -88.21499),
                    new Vector(45.96705181818191, -88.257164),
                    new Vector(45.9619488181819, -88.29915800000001),
                    new Vector(45.9667098181819, -88.321325),
                    new Vector(45.9945918181818, -88.369934),
                    new Vector(45.98341381818191, -88.403522),
                    new Vector(46.0007658181818, -88.454318),
                    new Vector(45.99915481818191, -88.48381999999999),
                    new Vector(46.0129608181819, -88.4940799999999),
                    new Vector(46.01861281818201, -88.515608),
                    new Vector(46.01929681818191, -88.548359),
                    new Vector(46.00896481818181, -88.57535900000001),
                    new Vector(46.01551681818181, -88.59753499999989),
                    new Vector(45.9941148181819, -88.615499),
                    new Vector(45.9933948181817, -88.643669),
                    new Vector(46.0201428181819, -88.67738300000001),
                    new Vector(46.0189278181819, -88.703609),
                    new Vector(46.0295838181818, -88.726406),
                    new Vector(46.0211418181818, -88.773017),
                    new Vector(46.032616818182, -88.77748099999999),
                    new Vector(46.0363608181819, -88.79381599999989),
                    new Vector(46.0268028181818, -88.8044),
                    new Vector(46.0736028181819, -88.925189),
                    new Vector(46.10038681818181, -88.9853),
                    new Vector(46.14564781818179, -89.099807),
                    new Vector(46.3040298181819, -89.925134),
                    new Vector(46.3404258181819, -90.11166800000001),
                    new Vector(46.3651578181818, -90.11516899999999),
                    new Vector(46.3939038181819, -90.1418),
                    new Vector(46.4423778181819, -90.161393),
                    new Vector(46.5062868181818, -90.21152299999999),
                    new Vector(46.5087888181819, -90.2584039999999),
                    new Vector(46.5224778181819, -90.26978),
                    new Vector(46.52505181818191, -90.30018199999999),
                    new Vector(46.54430281818189, -90.30238699999998),
                    new Vector(46.5515658181819, -90.313709),
                    new Vector(46.5396588181819, -90.38552900000001),
                    new Vector(46.5686118181819, -90.40819999999999),
                    new Vector(46.5875298181818, -90.540869),
                    new Vector(46.6456968181819, -90.73071500000002),
                    new Vector(46.58549581818189, -90.92624899999988),
                    new Vector(46.8831168181819, -90.77744299999999),
                    new Vector(46.9202328181819, -90.77448200000001),
                    new Vector(46.95247981818181, -90.86172800000001),
                    new Vector(46.7568648181818, -91.555772),
                    new Vector(46.6801398181819, -91.92146000000001),
                    new Vector(46.68380281818181, -92.004152),
                    new Vector(46.7426268181819, -92.09596999999999),
                    new Vector(46.6468758181819, -92.2091539999999),
                    new Vector(46.6587828181817, -92.287274),
                    new Vector(46.4159808181819, -92.288678),
                    new Vector(46.15660081818181, -92.288948),
                    new Vector(46.0732248181819, -92.289371),
                    new Vector(46.0568808181819, -92.32736900000002),
                    new Vector(46.0225998181818, -92.34622400000001),
                    new Vector(46.0162458181819, -92.36496200000001),
                    new Vector(46.0254978181818, -92.42500100000001),
                    new Vector(45.9811998181819, -92.46234199999991),
                    new Vector(45.9825858181818, -92.523974),
                    new Vector(45.95127481818179, -92.55267499999988),
                    new Vector(45.9156978181819, -92.66620999999989),
                    new Vector(45.8909568181819, -92.706242),
                    new Vector(45.8449848181818, -92.73409699999999),
                    new Vector(45.8372988181819, -92.74876700000002),
                    new Vector(45.7633368181819, -92.779106),
                    new Vector(45.7308918181819, -92.8336369999999),
                    new Vector(45.7105608181819, -92.860016),
                    new Vector(45.6449508181818, -92.885396)
                })
            }
        };
    }
}