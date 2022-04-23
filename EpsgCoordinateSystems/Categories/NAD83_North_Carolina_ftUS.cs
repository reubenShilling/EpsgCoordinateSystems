using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_North_Carolina_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2264;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "North Carolina";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / North Carolina (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.16666666666666],PARAMETER[standard_parallel_2,34.33333333333334],PARAMETER[latitude_of_origin,33.75],PARAMETER[central_meridian,-79],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2264],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / North Carolina (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,36.16666666666666],PARAMETER[standard_parallel_2,34.33333333333334],PARAMETER[latitude_of_origin,33.75],PARAMETER[central_meridian,-79],PARAMETER[false_easting,2000000],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-81.361985, 35.1629838181819, 0),
                    new Vector(-81.32262799999999, 35.1638928181818, 0),
                    new Vector(-81.0491, 35.1516708181818, 0),
                    new Vector(-81.048839, 35.1321588181819, 0),
                    new Vector(-81.028238, 35.1055548181819, 0),
                    new Vector(-81.065354, 35.0666298181818, 0),
                    new Vector(-81.039686, 35.0373438181818, 0),
                    new Vector(-80.92759099999989, 35.1013878181819, 0),
                    new Vector(-80.894507, 35.0598798181818, 0),
                    new Vector(-80.839967, 35.0021628181818, 0),
                    new Vector(-80.7854449999999, 34.9407918181819, 0),
                    new Vector(-80.7998539999999, 34.8162678181819, 0),
                    new Vector(-80.5613359999999, 34.8153858181819, 0),
                    new Vector(-80.325068, 34.8149178181818, 0),
                    new Vector(-79.919735, 34.8080688181819, 0),
                    new Vector(-79.68573499999999, 34.805404818182, 0),
                    new Vector(-79.66728500000001, 34.8008148181819, 0),
                    new Vector(-79.4557489999999, 34.6342518181818, 0),
                    new Vector(-79.446911, 34.6192218181819, 0),
                    new Vector(-79.074257, 34.3047348181819, 0),
                    new Vector(-78.655451, 33.9488478181819, 0),
                    new Vector(-78.579455, 33.8821668181819, 0),
                    new Vector(-78.034514, 33.9144678181818, 0),
                    new Vector(-77.95823900000001, 33.9927588181818, 0),
                    new Vector(-77.9604439999999, 34.1894178181818, 0),
                    new Vector(-77.92646000000001, 34.0622118181819, 0),
                    new Vector(-77.894105, 34.0693578181817, 0),
                    new Vector(-77.86409, 34.1929098181819, 0),
                    new Vector(-77.750231, 34.3052208181819, 0),
                    new Vector(-77.6023069999999, 34.4127978181819, 0),
                    new Vector(-77.60941699999999, 34.4352078181818, 0),
                    new Vector(-77.58645799999999, 34.4210958181819, 0),
                    new Vector(-77.5383259999999, 34.4571768181819, 0),
                    new Vector(-77.15627600000001, 34.6608018181819, 0),
                    new Vector(-77.12906, 34.6850748181819, 0),
                    new Vector(-77.14862599999989, 34.7644908181819, 0),
                    new Vector(-77.050202, 34.6990788181819, 0),
                    new Vector(-76.624961, 34.7199138181819, 0),
                    new Vector(-76.469549, 34.7852268181819, 0),
                    new Vector(-76.31434400000001, 34.9489818181818, 0),
                    new Vector(-76.329041, 34.9761168181818, 0),
                    new Vector(-76.36365499999999, 34.9432758181819, 0),
                    new Vector(-76.423703, 34.9464078181819, 0),
                    new Vector(-76.4446729999999, 35.016814818182, 0),
                    new Vector(-76.529426, 34.9748028181818, 0),
                    new Vector(-76.669709, 34.9701588181818, 0),
                    new Vector(-76.64669600000001, 34.9064928181818, 0),
                    new Vector(-76.912772, 34.9366248181819, 0),
                    new Vector(-77.000855, 35.0530488181818, 0),
                    new Vector(-77.110268, 35.0661888181819, 0),
                    new Vector(-77.10434600000001, 35.0881488181819, 0),
                    new Vector(-77.047556, 35.0923158181818, 0),
                    new Vector(-76.942913, 35.0701938181818, 0),
                    new Vector(-76.941158, 35.0275878181819, 0),
                    new Vector(-76.849124, 34.9823808181818, 0),
                    new Vector(-76.677665, 35.0242488181819, 0),
                    new Vector(-76.62387200000001, 35.0645058181819, 0),
                    new Vector(-76.604873, 35.1387288181818, 0),
                    new Vector(-76.639748, 35.1726858181819, 0),
                    new Vector(-76.506773, 35.2489338181818, 0),
                    new Vector(-76.540631, 35.3038518181818, 0),
                    new Vector(-76.59086000000001, 35.3122488181818, 0),
                    new Vector(-76.614161, 35.2730808181818, 0),
                    new Vector(-76.694558, 35.3505888181818, 0),
                    new Vector(-76.982855, 35.4366648181819, 0),
                    new Vector(-77.10344600000001, 35.5503438181819, 0),
                    new Vector(-76.70502500000001, 35.4121038181818, 0),
                    new Vector(-76.628417, 35.4380598181818, 0),
                    new Vector(-76.63785799999999, 35.5204998181819, 0),
                    new Vector(-76.492193, 35.5419558181819, 0),
                    new Vector(-76.51859, 35.5778118181819, 0),
                    new Vector(-76.44617599999989, 35.5510278181819, 0),
                    new Vector(-76.458083, 35.5045878181818, 0),
                    new Vector(-76.533404, 35.4503628181819, 0),
                    new Vector(-76.498457, 35.4163788181819, 0),
                    new Vector(-76.181252, 35.3416968181819, 0),
                    new Vector(-76.052606, 35.4147768181818, 0),
                    new Vector(-75.891119, 35.6314338181818, 0),
                    new Vector(-75.778673, 35.5788648181818, 0),
                    new Vector(-75.728993, 35.6653458181818, 0),
                    new Vector(-75.748586, 35.8695108181819, 0),
                    new Vector(-75.817679, 35.9236818181819, 0),
                    new Vector(-75.98749100000001, 35.8928658181818, 0),
                    new Vector(-76.02084499999999, 35.6692608181819, 0),
                    new Vector(-76.104383, 35.6638068181819, 0),
                    new Vector(-76.16694200000001, 35.6970078181819, 0),
                    new Vector(-76.042697, 35.6840208181819, 0),
                    new Vector(-76.07555600000001, 35.7569658181819, 0),
                    new Vector(-76.025687, 35.9205858181819, 0),
                    new Vector(-76.089281, 35.9630748181818, 0),
                    new Vector(-76.213418, 35.9770338181818, 0),
                    new Vector(-76.371134, 35.9325108181818, 0),
                    new Vector(-76.40912299999999, 35.9776278181818, 0),
                    new Vector(-76.69687999999999, 35.9416998181818, 0),
                    new Vector(-76.740791, 35.9367948181819, 0),
                    new Vector(-76.69342399999999, 35.9931258181819, 0),
                    new Vector(-76.76034799999999, 36.1447578181818, 0),
                    new Vector(-76.744733, 36.2340738181818, 0),
                    new Vector(-76.707167, 36.2662938181817, 0),
                    new Vector(-76.741016, 36.3153168181818, 0),
                    new Vector(-76.923761, 36.3925998181819, 0),
                    new Vector(-76.776314, 36.3584808181819, 0),
                    new Vector(-76.688411, 36.2946708181819, 0),
                    new Vector(-76.726184, 36.1569798181819, 0),
                    new Vector(-76.689824, 36.0497718181819, 0),
                    new Vector(-76.63287200000001, 36.0372798181818, 0),
                    new Vector(-76.648685, 36.0658728181818, 0),
                    new Vector(-76.59366799999999, 36.0102888181818, 0),
                    new Vector(-76.522676, 36.0073278181818, 0),
                    new Vector(-76.420085, 36.0587628181819, 0),
                    new Vector(-76.480187, 36.0799578181818, 0),
                    new Vector(-76.275167, 36.1105308181819, 0),
                    new Vector(-76.298585, 36.2143908181818, 0),
                    new Vector(-76.23464, 36.1635138181819, 0),
                    new Vector(-76.141589, 36.1478448181817, 0),
                    new Vector(-76.112357, 36.1745838181819, 0),
                    new Vector(-76.218557, 36.2967678181818, 0),
                    new Vector(-76.182818, 36.3153888181819, 0),
                    new Vector(-75.98098400000001, 36.1698858181819, 0),
                    new Vector(-75.956828, 36.1939248181819, 0),
                    new Vector(-76.00861399999999, 36.3197538181819, 0),
                    new Vector(-75.94157300000001, 36.2944998181819, 0),
                    new Vector(-75.95715199999999, 36.2596068181818, 0),
                    new Vector(-75.91341199999999, 36.2449638181819, 0),
                    new Vector(-75.854804, 36.1058238181818, 0),
                    new Vector(-75.79848200000001, 36.0729828181818, 0),
                    new Vector(-75.799688, 36.1129788181819, 0),
                    new Vector(-75.924239, 36.351109818182, 0),
                    new Vector(-75.927767, 36.4233978181817, 0),
                    new Vector(-75.950897, 36.3656268181817, 0),
                    new Vector(-76.00125199999999, 36.4190688181819, 0),
                    new Vector(-75.9694099999999, 36.4152708181819, 0),
                    new Vector(-75.975719, 36.4363758181819, 0),
                    new Vector(-76.090721, 36.503713818182, 0),
                    new Vector(-76.03286, 36.5145228181819, 0),
                    new Vector(-76.045613, 36.5571108181819, 0),
                    new Vector(-76.127054, 36.5573178181818, 0),
                    new Vector(-76.329914, 36.5562108181819, 0),
                    new Vector(-76.497224, 36.5559678181818, 0),
                    new Vector(-76.56325699999999, 36.5554008181818, 0),
                    new Vector(-76.921322, 36.5543118181819, 0),
                    new Vector(-76.923815, 36.5543028181819, 0),
                    new Vector(-77.177048, 36.5564358181818, 0),
                    new Vector(-77.319743, 36.5540688181819, 0),
                    new Vector(-77.763632, 36.5535918181819, 0),
                    new Vector(-77.89856899999999, 36.5530878181819, 0),
                    new Vector(-78.05137999999999, 36.5526198181819, 0),
                    new Vector(-78.320975, 36.5456718181819, 0),
                    new Vector(-78.45853099999999, 36.5416308181818, 0),
                    new Vector(-78.737117, 36.5462208181818, 0),
                    new Vector(-78.79642699999989, 36.5436738181817, 0),
                    new Vector(-79.14406099999999, 36.5462028181819, 0),
                    new Vector(-79.21679899999999, 36.5499198181818, 0),
                    new Vector(-79.510046, 36.5477868181819, 0),
                    new Vector(-79.71719899999989, 36.5480298181819, 0),
                    new Vector(-80.02382, 36.5451678181819, 0),
                    new Vector(-80.04786799999999, 36.5472738181819, 0),
                    new Vector(-80.4350929999999, 36.5511798181818, 0),
                    new Vector(-80.6108449999999, 36.5574258181819, 0),
                    new Vector(-80.837951, 36.5635728181819, 0),
                    new Vector(-80.903237, 36.5653458181819, 0),
                    new Vector(-81.345119, 36.5729868181818, 0),
                    new Vector(-81.669839, 36.5897628181819, 0),
                    new Vector(-81.702635, 36.5194638181818, 0),
                    new Vector(-81.698117, 36.4718988181818, 0),
                    new Vector(-81.74091199999989, 36.3919068181819, 0),
                    new Vector(-81.74021, 36.3619818181818, 0),
                    new Vector(-81.7092949999999, 36.3338568181819, 0),
                    new Vector(-81.730328, 36.3294648181818, 0),
                    new Vector(-81.83040800000001, 36.3347838181819, 0),
                    new Vector(-81.910994, 36.2908728181819, 0),
                    new Vector(-81.9329539999999, 36.2634498181818, 0),
                    new Vector(-82.02029, 36.1298358181819, 0),
                    new Vector(-82.0776019999999, 36.1002618181818, 0),
                    new Vector(-82.117931, 36.0963738181819, 0),
                    new Vector(-82.153904, 36.1397358181819, 0),
                    new Vector(-82.20757999999999, 36.1471248181819, 0),
                    new Vector(-82.262165, 36.1204938181818, 0),
                    new Vector(-82.31178199999999, 36.1222668181818, 0),
                    new Vector(-82.373711, 36.0988128181818, 0),
                    new Vector(-82.40828, 36.0754308181819, 0),
                    new Vector(-82.47505099999999, 35.9932788181818, 0),
                    new Vector(-82.506794, 35.9726508181819, 0),
                    new Vector(-82.554008, 35.9562168181818, 0),
                    new Vector(-82.5991609999999, 35.9634078181819, 0),
                    new Vector(-82.60566799999999, 36.0036558181819, 0),
                    new Vector(-82.59208700000001, 36.0225558181818, 0),
                    new Vector(-82.604264, 36.0430938181818, 0),
                    new Vector(-82.62790699999989, 36.0544428181819, 0),
                    new Vector(-82.643756, 36.0518238181819, 0),
                    new Vector(-82.763087, 35.9996508181818, 0),
                    new Vector(-82.773464, 35.9876088181818, 0),
                    new Vector(-82.776308, 35.9566848181818, 0),
                    new Vector(-82.808537, 35.920972818182, 0),
                    new Vector(-82.856138, 35.9475228181819, 0),
                    new Vector(-82.89584600000001, 35.9484678181819, 0),
                    new Vector(-82.91393600000001, 35.9279748181818, 0),
                    new Vector(-82.906691, 35.8723188181819, 0),
                    new Vector(-82.96261699999999, 35.7919578181819, 0),
                    new Vector(-82.98687200000001, 35.7740928181818, 0),
                    new Vector(-83.059826, 35.7826698181818, 0),
                    new Vector(-83.118056, 35.7639048181819, 0),
                    new Vector(-83.143535, 35.7627798181819, 0),
                    new Vector(-83.185214, 35.7289848181819, 0),
                    new Vector(-83.243723, 35.7183108181819, 0),
                    new Vector(-83.253173, 35.7007968181819, 0),
                    new Vector(-83.258996, 35.6911128181818, 0),
                    new Vector(-83.29828999999999, 35.6564268181817, 0),
                    new Vector(-83.34290300000001, 35.6533578181819, 0),
                    new Vector(-83.386976, 35.6253048181819, 0),
                    new Vector(-83.4581749999999, 35.5973688181818, 0),
                    new Vector(-83.505686, 35.5596498181819, 0),
                    new Vector(-83.560919, 35.5552758181818, 0),
                    new Vector(-83.613758, 35.5718268181818, 0),
                    new Vector(-83.67276200000001, 35.5650678181819, 0),
                    new Vector(-83.77577599999999, 35.5526928181819, 0),
                    new Vector(-83.8301, 35.5191498181818, 0),
                    new Vector(-83.8811299999999, 35.5106718181818, 0),
                    new Vector(-83.90991200000001, 35.4765618181818, 0),
                    new Vector(-83.954606, 35.4555468181819, 0),
                    new Vector(-84.012557, 35.4077118181819, 0),
                    new Vector(-84.006221, 35.3729448181819, 0),
                    new Vector(-84.029117, 35.3253708181819, 0),
                    new Vector(-84.030773, 35.2926108181818, 0),
                    new Vector(-84.0426889999999, 35.2726578181818, 0),
                    new Vector(-84.101567, 35.2456398181819, 0),
                    new Vector(-84.179642, 35.2410768181819, 0),
                    new Vector(-84.225866, 35.2616778181818, 0),
                    new Vector(-84.290963, 35.2106208181818, 0),
                    new Vector(-84.32377700000001, 34.9890948181819, 0),
                    new Vector(-84.118154, 34.9883118181819, 0),
                    new Vector(-83.988455, 34.9891578181819, 0),
                    new Vector(-83.93790199999999, 34.9894818181819, 0),
                    new Vector(-83.5493, 34.9896258181819, 0),
                    new Vector(-83.512895, 34.992118818182, 0),
                    new Vector(-83.10615799999989, 35.0003628181819, 0),
                    new Vector(-83.007149, 35.0242938181819, 0),
                    new Vector(-82.887557, 35.0554698181818, 0),
                    new Vector(-82.771196, 35.0855388181819, 0),
                    new Vector(-82.69720700000001, 35.0913438181819, 0),
                    new Vector(-82.687883, 35.097913818182, 0),
                    new Vector(-82.685903, 35.1215838181818, 0),
                    new Vector(-82.654349, 35.1195768181818, 0),
                    new Vector(-82.569875, 35.1496098181818, 0),
                    new Vector(-82.524479, 35.1546858181819, 0),
                    new Vector(-82.466582, 35.1736218181819, 0),
                    new Vector(-82.437764, 35.1696708181818, 0),
                    new Vector(-82.38945200000001, 35.2083528181819, 0),
                    new Vector(-82.371218, 35.1828378181818, 0),
                    new Vector(-82.35996799999999, 35.1830628181818, 0),
                    new Vector(-82.35069799999999, 35.1927918181819, 0),
                    new Vector(-82.320611, 35.1842958181819, 0),
                    new Vector(-82.278167, 35.1951138181818, 0),
                    new Vector(-82.21001, 35.1932418181818, 0),
                    new Vector(-81.971276, 35.1883998181819, 0),
                    new Vector(-81.870422, 35.1832338181819, 0),
                    new Vector(-81.765185, 35.1826038181819, 0),
                    new Vector(-81.361985, 35.1629838181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-75.782813, 36.2253528181818, 0),
                    new Vector(-75.740495, 36.0504918181818, 0),
                    new Vector(-75.70236199999989, 36.0500238181818, 0),
                    new Vector(-75.544583, 35.7885378181819, 0),
                    new Vector(-75.77278699999989, 36.229420818182, 0),
                    new Vector(-75.877808, 36.5560308181819, 0),
                    new Vector(-75.90163099999999, 36.5563548181819, 0),
                    new Vector(-75.782813, 36.2253528181818, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-75.4908259999999, 35.6706828181818, 0),
                    new Vector(-75.475022, 35.5646718181819, 0),
                    new Vector(-75.521084, 35.281540818182, 0),
                    new Vector(-75.691175, 35.2351638181818, 0),
                    new Vector(-75.748901, 35.1900018181818, 0),
                    new Vector(-75.52589, 35.228089818182, 0),
                    new Vector(-75.456581, 35.6175828181819, 0),
                    new Vector(-75.53323399999989, 35.7690348181818, 0),
                    new Vector(-75.4908259999999, 35.6706828181818, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-76.5439159999999, 34.5879918181819, 0),
                    new Vector(-76.468901, 34.6934448181819, 0),
                    new Vector(-76.287335, 34.8771708181819, 0),
                    new Vector(-76.37432, 34.8130368181817, 0),
                    new Vector(-76.431938, 34.7608458181818, 0),
                    new Vector(-76.484129, 34.6977918181818, 0),
                    new Vector(-76.53740000000001, 34.6140828181819, 0),
                    new Vector(-76.554788, 34.6108248181818, 0),
                    new Vector(-76.5439159999999, 34.5879918181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-76.026821, 36.5568768181819, 0),
                    new Vector(-75.97593500000001, 36.5180778181819, 0),
                    new Vector(-75.97692499999999, 36.4781718181819, 0),
                    new Vector(-75.92445499999999, 36.4741308181819, 0),
                    new Vector(-75.91156700000001, 36.5426838181819, 0),
                    new Vector(-75.9983179999999, 36.5568048181818, 0),
                    new Vector(-76.026821, 36.5568768181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-76.01662399999999, 35.0696088181819, 0),
                    new Vector(-76.002503, 35.0696088181819, 0),
                    new Vector(-75.903566, 35.1326628181819, 0),
                    new Vector(-75.811154, 35.1641898181819, 0),
                    new Vector(-75.76331, 35.1924588181819, 0),
                    new Vector(-75.853544, 35.1674568181818, 0),
                    new Vector(-75.97530500000001, 35.1163548181818, 0),
                    new Vector(-76.01662399999999, 35.0696088181819, 0)
                })
            }
        };
    }
}