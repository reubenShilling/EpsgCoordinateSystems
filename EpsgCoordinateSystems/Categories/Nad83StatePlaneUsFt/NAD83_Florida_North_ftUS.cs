using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Florida_North_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2238;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Florida North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Florida North (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",30.75],PARAMETER[\"standard_parallel_2\",29.58333333333333],PARAMETER[\"latitude_of_origin\",29],PARAMETER[\"central_meridian\",-84.5],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2238\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Florida North (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",30.75],PARAMETER[\"standard_parallel_2\",29.58333333333333],PARAMETER[\"latitude_of_origin\",29],PARAMETER[\"central_meridian\",-84.5],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(30.5577378181819, -87.17155700000001),
                    new Vector(30.5646678181818, -87.124532),
                    new Vector(30.4505658181818, -87.069272),
                    new Vector(30.587464818182, -87.019583),
                    new Vector(30.5904258181818, -86.986193),
                    new Vector(30.5144388181818, -87.014399),
                    new Vector(30.4635618181819, -86.932508),
                    new Vector(30.3552198181818, -87.193382),
                    new Vector(30.4179678181819, -86.790344),
                    new Vector(30.4236558181819, -86.610236),
                    new Vector(30.5012358181819, -86.452637),
                    new Vector(30.4621668181819, -86.387882),
                    new Vector(30.4878528181819, -86.21960900000001),
                    new Vector(30.4264638181819, -86.12294),
                    new Vector(30.3858018181817, -86.114642),
                    new Vector(30.4285248181819, -86.24156000000001),
                    new Vector(30.39988681818191, -86.240039),
                    new Vector(30.4060068181818, -86.38810700000001),
                    new Vector(30.4099758181819, -86.505314),
                    new Vector(30.3876648181819, -86.387468),
                    new Vector(30.274426818182, -85.987013),
                    new Vector(30.1288428181819, -85.72639100000001),
                    new Vector(30.2289498181818, -85.757918),
                    new Vector(30.232819818182, -85.829945),
                    new Vector(30.2803668181819, -85.85042),
                    new Vector(30.2969268181818, -85.752707),
                    new Vector(30.2650668181818, -85.7171299999999),
                    new Vector(30.3110028181819, -85.56947599999999),
                    new Vector(30.2511528181818, -85.60017499999999),
                    new Vector(30.25169281818191, -85.666055),
                    new Vector(30.1787748181819, -85.70983099999999),
                    new Vector(30.1316778181818, -85.529714),
                    new Vector(30.0511638181819, -85.46432),
                    new Vector(30.0585618181819, -85.39567700000001),
                    new Vector(30.0362778181818, -85.382654),
                    new Vector(30.02427181818191, -85.38269),
                    new Vector(30.0457548181819, -85.4323789999999),
                    new Vector(30.0315528181819, -85.4150089999999),
                    new Vector(30.0218598181818, -85.471358),
                    new Vector(30.0982878181819, -85.56853099999999),
                    new Vector(30.0925908181818, -85.62849799999999),
                    new Vector(29.9237958181819, -85.384787),
                    new Vector(29.8098018181819, -85.300529),
                    new Vector(29.7017118181819, -85.306595),
                    new Vector(29.6912538181818, -85.358048),
                    new Vector(29.7943668181818, -85.40254400000001),
                    new Vector(29.8754118181819, -85.392995),
                    new Vector(29.8630638181818, -85.414055),
                    new Vector(29.7767628181819, -85.4096),
                    new Vector(29.6830188181819, -85.364879),
                    new Vector(29.7015588181819, -85.21476800000001),
                    new Vector(29.7199188181818, -84.988283),
                    new Vector(29.7779688181818, -84.928505),
                    new Vector(29.7468648181818, -84.858026),
                    new Vector(29.9296278181818, -84.46453700000001),
                    new Vector(29.9101698181819, -84.346907),
                    new Vector(29.9471418181819, -84.3389329999999),
                    new Vector(29.9595438181819, -84.4330999999999),
                    new Vector(29.9917908181819, -84.43769),
                    new Vector(29.9773908181818, -84.360416),
                    new Vector(30.06962281818191, -84.3539269999999),
                    new Vector(30.1081068181818, -84.233075),
                    new Vector(30.0817278181818, -84.1478539999999),
                    new Vector(30.0999438181819, -84.07463),
                    new Vector(30.0774798181819, -83.971733),
                    new Vector(29.9109618181819, -83.6541859999999),
                    new Vector(29.7373248181819, -83.550443),
                    new Vector(29.6695998181818, -83.404976),
                    new Vector(29.519875818182, -83.380028),
                    new Vector(29.4339348181819, -83.23432699999999),
                    new Vector(29.3436828181819, -83.174639),
                    new Vector(29.3281848181819, -83.1089929999999),
                    new Vector(29.3433408181818, -83.090597),
                    new Vector(29.3527818181819, -83.061554),
                    new Vector(29.3638698181819, -83.06542399999999),
                    new Vector(29.3810688181819, -83.055497),
                    new Vector(29.4055128181818, -83.020757),
                    new Vector(29.4370938181818, -83.018246),
                    new Vector(29.4812028181819, -82.982345),
                    new Vector(29.5191828181818, -82.97908699999989),
                    new Vector(29.5308468181818, -82.968251),
                    new Vector(29.5496028181818, -82.9666399999999),
                    new Vector(29.5769808181819, -82.94167400000001),
                    new Vector(29.599759818182, -82.935716),
                    new Vector(29.5964748181819, -82.85554399999999),
                    new Vector(29.5900578181819, -82.85574200000001),
                    new Vector(29.5893738181818, -82.77234799999989),
                    new Vector(29.5806528181818, -82.772105),
                    new Vector(29.5797618181818, -82.754825),
                    new Vector(29.5641828181818, -82.75481600000001),
                    new Vector(29.5662168181819, -82.6556089999999),
                    new Vector(29.5414128181819, -82.653836),
                    new Vector(29.5392438181818, -82.555322),
                    new Vector(29.4809958181818, -82.5547729999999),
                    new Vector(29.4850998181819, -82.405265),
                    new Vector(29.4880248181818, -82.208606),
                    new Vector(29.4626268181818, -82.18760899999999),
                    new Vector(29.4526278181819, -82.20580699999989),
                    new Vector(29.4323148181818, -82.201379),
                    new Vector(29.422747818182, -82.143626),
                    new Vector(29.4356898181818, -82.117436),
                    new Vector(29.4319908181818, -82.087205),
                    new Vector(29.4400728181819, -82.066964),
                    new Vector(29.4561108181818, -82.05216799999999),
                    new Vector(29.4776748181818, -82.052312),
                    new Vector(29.7236178181818, -82.0436629999999),
                    new Vector(30.1397058181819, -82.0462909999999),
                    new Vector(30.1892148181818, -82.04792),
                    new Vector(30.2702958181819, -82.04926999999989),
                    new Vector(30.3637878181819, -82.052762),
                    new Vector(30.3612948181819, -82.164632),
                    new Vector(30.36862981818181, -82.180238),
                    new Vector(30.423853818182, -82.205564),
                    new Vector(30.4900218181818, -82.199192),
                    new Vector(30.5029728181819, -82.21936100000001),
                    new Vector(30.5314488181818, -82.23839599999999),
                    new Vector(30.5670708181819, -82.221035),
                    new Vector(30.5773128181818, -82.412087),
                    new Vector(30.5826948181819, -82.46313499999999),
                    new Vector(30.5890578181819, -82.58295200000001),
                    new Vector(30.5957178181818, -82.696352),
                    new Vector(30.621349818182, -83.13243799999989),
                    new Vector(30.6332838181819, -83.301314),
                    new Vector(30.6343008181819, -83.310602),
                    new Vector(30.6507798181818, -83.60905099999999),
                    new Vector(30.6604908181819, -83.737841),
                    new Vector(30.6755388181819, -84.000731),
                    new Vector(30.6785808181818, -84.07556599999999),
                    new Vector(30.6904158181818, -84.281666),
                    new Vector(30.6940878181819, -84.374447),
                    new Vector(30.7126638181817, -84.86300300000001),
                    new Vector(30.7144998181818, -84.8645779999999),
                    new Vector(30.7438938181818, -84.888293),
                    new Vector(30.7540908181818, -84.9153469999999),
                    new Vector(30.7760868181819, -84.926894),
                    new Vector(30.80262781818171, -84.932564),
                    new Vector(30.8469168181818, -84.9269299999999),
                    new Vector(30.8949588181819, -84.937775),
                    new Vector(30.9270888181818, -84.969005),
                    new Vector(30.9636648181819, -84.973568),
                    new Vector(30.9793158181819, -85.000145),
                    new Vector(31.0012578181818, -85.00161199999999),
                    new Vector(31.0009968181819, -85.485011),
                    new Vector(31.0009968181819, -85.486604),
                    new Vector(30.9933288181818, -86.03181499999999),
                    new Vector(30.9952278181819, -86.181476),
                    new Vector(30.9915378181819, -86.3839219999999),
                    new Vector(30.9980898181819, -86.70185600000001),
                    new Vector(30.9981888181819, -86.779364),
                    new Vector(31.0031568181819, -87.163115),
                    new Vector(31.0026258181819, -87.5985799999999),
                    new Vector(30.9543678181819, -87.589868),
                    new Vector(30.8768958181818, -87.62570599999999),
                    new Vector(30.8483028181819, -87.615914),
                    new Vector(30.7856898181819, -87.541898),
                    new Vector(30.7484928181819, -87.52659800000001),
                    new Vector(30.7057968181819, -87.460133),
                    new Vector(30.6928098181818, -87.41889500000001),
                    new Vector(30.6680148181818, -87.398645),
                    new Vector(30.6200988181818, -87.393281),
                    new Vector(30.5564868181819, -87.42206299999989),
                    new Vector(30.5313948181818, -87.44535500000001),
                    new Vector(30.4816968181819, -87.418814),
                    new Vector(30.4571718181818, -87.34739),
                    new Vector(30.4315038181819, -87.346805),
                    new Vector(30.4022358181819, -87.409256),
                    new Vector(30.3236748181819, -87.42407900000001),
                    new Vector(30.3573798181818, -87.27389599999999),
                    new Vector(30.4650378181819, -87.1601),
                    new Vector(30.5577378181819, -87.17155700000001)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(30.4039728181819, -86.79155900000001),
                    new Vector(30.3997338181818, -86.83388600000001),
                    new Vector(30.3813918181819, -86.929124),
                    new Vector(30.3694038181819, -87.047645),
                    new Vector(30.35176381818181, -87.139346),
                    new Vector(30.3348348181818, -87.20214799999999),
                    new Vector(30.3397758181819, -87.286091),
                    new Vector(30.3327198181819, -87.2903299999999),
                    new Vector(30.321433818182, -87.26704700000001),
                    new Vector(30.321433818182, -87.24234199999999),
                    new Vector(30.3870348181818, -86.83457900000001),
                    new Vector(30.3905628181819, -86.792963),
                    new Vector(30.4025508181819, -86.738648),
                    new Vector(30.3933888181819, -86.532647),
                    new Vector(30.4011468181819, -86.522774),
                    new Vector(30.4067898181819, -86.53475299999999),
                    new Vector(30.4145568181819, -86.620829),
                    new Vector(30.4039728181819, -86.79155900000001)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries) _boundingBox.Expand(linearRing.CalculateBounds());

            return _boundingBox;
        }
    }
}