using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wisconsin_North_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2287;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Wisconsin North";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Wisconsin North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,46.76666666666667],PARAMETER[standard_parallel_2,45.56666666666667],PARAMETER[latitude_of_origin,45.16666666666666],PARAMETER[central_meridian,-90],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2287],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Wisconsin North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,46.76666666666667],PARAMETER[standard_parallel_2,45.56666666666667],PARAMETER[latitude_of_origin,45.16666666666666],PARAMETER[central_meridian,-90],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-92.885396, 45.6449508181818, 0),
                    new Vector(-92.537357, 45.6449778181819, 0),
                    new Vector(-92.53004900000001, 45.7279488181819, 0),
                    new Vector(-92.158646, 45.72431281818181, 0),
                    new Vector(-92.15781799999999, 45.6383178181819, 0),
                    new Vector(-92.03344700000001, 45.6402438181819, 0),
                    new Vector(-91.540913, 45.6408018181819, 0),
                    new Vector(-90.677048, 45.63689581818189, 0),
                    new Vector(-90.675752, 45.37955881818181, 0),
                    new Vector(-90.043205, 45.3840408181819, 0),
                    new Vector(-90.04134200000001, 45.5545188181818, 0),
                    new Vector(-89.42142200000001, 45.5569488181818, 0),
                    new Vector(-89.4202159999999, 45.4700988181819, 0),
                    new Vector(-89.0421259999999, 45.4679838181818, 0),
                    new Vector(-88.919375, 45.4638528181818, 0),
                    new Vector(-88.91942899999999, 45.3829608181819, 0),
                    new Vector(-88.669679, 45.3784608181819, 0),
                    new Vector(-88.4225299999999, 45.3757968181819, 0),
                    new Vector(-88.41498799999989, 45.7213518181819, 0),
                    new Vector(-88.055789, 45.715258818182, 0),
                    new Vector(-88.05164000000001, 45.7861068181817, 0),
                    new Vector(-88.08873800000001, 45.7915338181819, 0),
                    new Vector(-88.129949, 45.8193978181819, 0),
                    new Vector(-88.121786, 45.8348778181819, 0),
                    new Vector(-88.06541900000001, 45.87364981818181, 0),
                    new Vector(-88.095767, 45.89180281818191, 0),
                    new Vector(-88.09385899999999, 45.9206208181819, 0),
                    new Vector(-88.111391, 45.9262908181819, 0),
                    new Vector(-88.15043300000001, 45.9362898181818, 0),
                    new Vector(-88.180187, 45.9535158181819, 0),
                    new Vector(-88.21499, 45.947899818182, 0),
                    new Vector(-88.257164, 45.96705181818191, 0),
                    new Vector(-88.29915800000001, 45.9619488181819, 0),
                    new Vector(-88.321325, 45.9667098181819, 0),
                    new Vector(-88.369934, 45.9945918181818, 0),
                    new Vector(-88.403522, 45.98341381818191, 0),
                    new Vector(-88.454318, 46.0007658181818, 0),
                    new Vector(-88.48381999999999, 45.99915481818191, 0),
                    new Vector(-88.4940799999999, 46.0129608181819, 0),
                    new Vector(-88.515608, 46.01861281818201, 0),
                    new Vector(-88.548359, 46.01929681818191, 0),
                    new Vector(-88.57535900000001, 46.00896481818181, 0),
                    new Vector(-88.59753499999989, 46.01551681818181, 0),
                    new Vector(-88.615499, 45.9941148181819, 0),
                    new Vector(-88.643669, 45.9933948181817, 0),
                    new Vector(-88.67738300000001, 46.0201428181819, 0),
                    new Vector(-88.703609, 46.0189278181819, 0),
                    new Vector(-88.726406, 46.0295838181818, 0),
                    new Vector(-88.773017, 46.0211418181818, 0),
                    new Vector(-88.77748099999999, 46.032616818182, 0),
                    new Vector(-88.79381599999989, 46.0363608181819, 0),
                    new Vector(-88.8044, 46.0268028181818, 0),
                    new Vector(-88.925189, 46.0736028181819, 0),
                    new Vector(-88.9853, 46.10038681818181, 0),
                    new Vector(-89.099807, 46.14564781818179, 0),
                    new Vector(-89.925134, 46.3040298181819, 0),
                    new Vector(-90.11166800000001, 46.3404258181819, 0),
                    new Vector(-90.11516899999999, 46.3651578181818, 0),
                    new Vector(-90.1418, 46.3939038181819, 0),
                    new Vector(-90.161393, 46.4423778181819, 0),
                    new Vector(-90.21152299999999, 46.5062868181818, 0),
                    new Vector(-90.2584039999999, 46.5087888181819, 0),
                    new Vector(-90.26978, 46.5224778181819, 0),
                    new Vector(-90.30018199999999, 46.52505181818191, 0),
                    new Vector(-90.30238699999998, 46.54430281818189, 0),
                    new Vector(-90.313709, 46.5515658181819, 0),
                    new Vector(-90.38552900000001, 46.5396588181819, 0),
                    new Vector(-90.40819999999999, 46.5686118181819, 0),
                    new Vector(-90.540869, 46.5875298181818, 0),
                    new Vector(-90.73071500000002, 46.6456968181819, 0),
                    new Vector(-90.92624899999988, 46.58549581818189, 0),
                    new Vector(-90.77744299999999, 46.8831168181819, 0),
                    new Vector(-90.77448200000001, 46.9202328181819, 0),
                    new Vector(-90.86172800000001, 46.95247981818181, 0),
                    new Vector(-91.555772, 46.7568648181818, 0),
                    new Vector(-91.92146000000001, 46.6801398181819, 0),
                    new Vector(-92.004152, 46.68380281818181, 0),
                    new Vector(-92.09596999999999, 46.7426268181819, 0),
                    new Vector(-92.2091539999999, 46.6468758181819, 0),
                    new Vector(-92.287274, 46.6587828181817, 0),
                    new Vector(-92.288678, 46.4159808181819, 0),
                    new Vector(-92.288948, 46.15660081818181, 0),
                    new Vector(-92.289371, 46.0732248181819, 0),
                    new Vector(-92.32736900000002, 46.0568808181819, 0),
                    new Vector(-92.34622400000001, 46.0225998181818, 0),
                    new Vector(-92.36496200000001, 46.0162458181819, 0),
                    new Vector(-92.42500100000001, 46.0254978181818, 0),
                    new Vector(-92.46234199999991, 45.9811998181819, 0),
                    new Vector(-92.523974, 45.9825858181818, 0),
                    new Vector(-92.55267499999988, 45.95127481818179, 0),
                    new Vector(-92.66620999999989, 45.9156978181819, 0),
                    new Vector(-92.706242, 45.8909568181819, 0),
                    new Vector(-92.73409699999999, 45.8449848181818, 0),
                    new Vector(-92.74876700000002, 45.8372988181819, 0),
                    new Vector(-92.779106, 45.7633368181819, 0),
                    new Vector(-92.8336369999999, 45.7308918181819, 0),
                    new Vector(-92.860016, 45.7105608181819, 0),
                    new Vector(-92.885396, 45.6449508181818, 0)
                })
            }
        };
    }
}