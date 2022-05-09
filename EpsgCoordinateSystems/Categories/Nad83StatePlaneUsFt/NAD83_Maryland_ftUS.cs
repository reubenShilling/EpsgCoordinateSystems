using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Maryland_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2248;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Maryland";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Maryland (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",39.45],PARAMETER[\"standard_parallel_2\",38.3],PARAMETER[\"latitude_of_origin\",37.66666666666666],PARAMETER[\"central_meridian\",-77],PARAMETER[\"false_easting\",1312333.333],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2248\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Maryland (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",39.45],PARAMETER[\"standard_parallel_2\",38.3],PARAMETER[\"latitude_of_origin\",37.66666666666666],PARAMETER[\"central_meridian\",-77],PARAMETER[\"false_easting\",1312333.333],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(38.9321748181818, -77.122328),
                    new Vector(38.9157048181819, -77.078642),
                    new Vector(38.8862118181818, -77.067581),
                    new Vector(38.8625418181818, -77.03877199999999),
                    new Vector(38.8385298181819, -77.040104),
                    new Vector(38.8294848181819, -77.044892),
                    new Vector(38.8140228181819, -77.034947),
                    new Vector(38.7882378181818, -77.04514399999999),
                    new Vector(38.7188928181818, -77.04617),
                    new Vector(38.7121338181818, -77.056817),
                    new Vector(38.7153918181819, -77.081585),
                    new Vector(38.7040968181819, -77.092844),
                    new Vector(38.6779158181819, -77.124821),
                    new Vector(38.6482428181819, -77.12969),
                    new Vector(38.4872148181819, -77.277461),
                    new Vector(38.4137208181818, -77.255573),
                    new Vector(38.3907888181819, -77.2206259999999),
                    new Vector(38.4269778181818, -77.002088),
                    new Vector(38.3311548181818, -76.97273),
                    new Vector(38.2999788181819, -76.908272),
                    new Vector(38.3914728181819, -76.86387499999999),
                    new Vector(38.2344048181818, -76.759925),
                    new Vector(38.2227678181819, -76.5769549999999),
                    new Vector(38.0458278181819, -76.32983299999999),
                    new Vector(38.2131918181819, -76.3434589999999),
                    new Vector(38.4505488181818, -76.646939),
                    new Vector(38.4102648181819, -76.519751),
                    new Vector(38.3357808181819, -76.47160100000001),
                    new Vector(38.3206248181818, -76.421138),
                    new Vector(38.3461488181818, -76.40512699999999),
                    new Vector(38.3914008181819, -76.38548),
                    new Vector(38.5222158181819, -76.508573),
                    new Vector(38.7097578181819, -76.52492599999989),
                    new Vector(38.7590868181818, -76.548812),
                    new Vector(38.9083518181819, -76.471718),
                    new Vector(39.1184658181818, -76.42362199999999),
                    new Vector(39.196369818182, -76.563608),
                    new Vector(39.1588038181818, -76.594829),
                    new Vector(39.1810878181819, -76.607015),
                    new Vector(39.1982238181819, -76.576667),
                    new Vector(39.2315508181819, -76.564814),
                    new Vector(39.2594598181818, -76.60372099999999),
                    new Vector(39.2427288181818, -76.53098300000001),
                    new Vector(39.2312538181819, -76.398719),
                    new Vector(39.3933888181819, -76.363709),
                    new Vector(39.3750018181818, -76.226333),
                    new Vector(39.4020468181819, -76.15419799999999),
                    new Vector(39.5424738181819, -76.07818399999999),
                    new Vector(39.5700498181818, -76.03107799999999),
                    new Vector(39.5241408181818, -75.974423),
                    new Vector(39.4712928181818, -75.95230100000001),
                    new Vector(39.3946668181818, -75.978464),
                    new Vector(39.3792588181818, -75.84940400000001),
                    new Vector(39.3584778181819, -76.03709000000001),
                    new Vector(39.3214068181819, -76.112042),
                    new Vector(39.2049648181819, -76.218107),
                    new Vector(39.1309398181818, -76.238564),
                    new Vector(39.0930228181818, -76.221446),
                    new Vector(39.1187088181819, -76.11095299999999),
                    new Vector(38.9734668181819, -76.199342),
                    new Vector(38.9208258181818, -76.113536),
                    new Vector(38.9482488181819, -76.095167),
                    new Vector(38.8981368181819, -76.102565),
                    new Vector(38.8896678181818, -76.0755379999999),
                    new Vector(38.8855728181819, -76.11404),
                    new Vector(38.7887238181819, -76.16552900000001),
                    new Vector(38.7653688181818, -76.19484199999999),
                    new Vector(38.8341198181819, -76.27208899999999),
                    new Vector(38.6991468181819, -76.3502),
                    new Vector(38.6794908181819, -76.337294),
                    new Vector(38.7700038181818, -76.26678800000001),
                    new Vector(38.7629118181819, -76.22298499999999),
                    new Vector(38.7092088181819, -76.17371),
                    new Vector(38.7080928181819, -76.12369700000001),
                    new Vector(38.6109018181819, -76.075664),
                    new Vector(38.5919748181819, -76.04658499999989),
                    new Vector(38.6221248181818, -76.027721),
                    new Vector(38.5720398181818, -76.0315999999999),
                    new Vector(38.5951968181818, -76.250714),
                    new Vector(38.5434648181818, -76.191881),
                    new Vector(38.4788538181818, -76.29165500000001),
                    new Vector(38.4370578181818, -76.293941),
                    new Vector(38.2590558181818, -76.065116),
                    new Vector(38.322019818182, -76.020467),
                    new Vector(38.2826448181819, -75.99494300000001),
                    new Vector(38.2821858181817, -75.949583),
                    new Vector(38.3755788181818, -75.886484),
                    new Vector(38.3573538181818, -75.87209300000001),
                    new Vector(38.2589928181818, -75.8946109999999),
                    new Vector(38.2637268181818, -75.793829),
                    new Vector(38.2401648181818, -75.861329),
                    new Vector(38.2317138181819, -75.83773100000001),
                    new Vector(38.1750588181819, -75.89745499999999),
                    new Vector(38.0973708181819, -75.769205),
                    new Vector(37.9797858181819, -75.865379),
                    new Vector(37.9702548181819, -75.64786700000001),
                    new Vector(37.9965438181819, -75.62607800000001),
                    new Vector(38.0168388181819, -75.372422),
                    new Vector(38.069047818182, -75.37307),
                    new Vector(38.2015368181819, -75.262496),
                    new Vector(38.2738788181819, -75.150617),
                    new Vector(38.3697378181819, -75.15487400000001),
                    new Vector(38.4505668181819, -75.09272),
                    new Vector(38.4553188181818, -75.3498409999999),
                    new Vector(38.463184818182, -75.698798),
                    new Vector(38.5575948181819, -75.707069),
                    new Vector(38.6496648181819, -75.710705),
                    new Vector(38.8302858181819, -75.724592),
                    new Vector(39.1416678181819, -75.752573),
                    new Vector(39.2478678181819, -75.761312),
                    new Vector(39.2959638181819, -75.764318),
                    new Vector(39.3831198181819, -75.772355),
                    new Vector(39.7238598181819, -75.791093),
                    new Vector(39.7222308181818, -76.139231),
                    new Vector(39.7218528181818, -76.233119),
                    new Vector(39.7202598181819, -76.569836),
                    new Vector(39.7212588181818, -76.79048899999999),
                    new Vector(39.7208898181818, -76.9968049999999),
                    new Vector(39.7206828181818, -77.221058),
                    new Vector(39.7200708181817, -77.46443600000001),
                    new Vector(39.7196298181819, -77.47579399999999),
                    new Vector(39.7254618181819, -78.09594800000001),
                    new Vector(39.7241028181818, -78.33455600000001),
                    new Vector(39.7237428181818, -78.38478499999999),
                    new Vector(39.7231218181818, -78.817757),
                    new Vector(39.7223388181818, -78.930176),
                    new Vector(39.7193058181819, -79.39661),
                    new Vector(39.7202688181818, -79.480976),
                    new Vector(39.1973868181819, -79.489868),
                    new Vector(39.2132628181819, -79.46119400000001),
                    new Vector(39.2120928181819, -79.44927800000001),
                    new Vector(39.2692968181818, -79.38484699999999),
                    new Vector(39.2920938181819, -79.346192),
                    new Vector(39.3005448181818, -79.29527),
                    new Vector(39.3252498181819, -79.27981699999999),
                    new Vector(39.3486498181817, -79.260161),
                    new Vector(39.3934968181818, -79.163015),
                    new Vector(39.4139628181819, -79.158128),
                    new Vector(39.4170228181818, -79.131398),
                    new Vector(39.4473078181819, -79.104083),
                    new Vector(39.464623818182, -79.096721),
                    new Vector(39.4708698181818, -79.104596),
                    new Vector(39.4708518181818, -79.07062999999989),
                    new Vector(39.4858278181819, -79.06441100000001),
                    new Vector(39.4838208181819, -79.04885899999989),
                    new Vector(39.4385238181818, -78.970433),
                    new Vector(39.4604568181818, -78.955394),
                    new Vector(39.5257878181819, -78.87082100000001),
                    new Vector(39.5633178181819, -78.838115),
                    new Vector(39.5668278181818, -78.806552),
                    new Vector(39.5857008181818, -78.82241),
                    new Vector(39.6154188181819, -78.79846999999999),
                    new Vector(39.6308358181819, -78.79815499999999),
                    new Vector(39.6442458181819, -78.772712),
                    new Vector(39.6266148181818, -78.767618),
                    new Vector(39.6269658181819, -78.732383),
                    new Vector(39.6215478181818, -78.730502),
                    new Vector(39.6087948181818, -78.736253),
                    new Vector(39.6016218181817, -78.773747),
                    new Vector(39.5817948181819, -78.761453),
                    new Vector(39.5766468181819, -78.732716),
                    new Vector(39.5595738181819, -78.716318),
                    new Vector(39.5369298181818, -78.666431),
                    new Vector(39.5380008181818, -78.6491419999999),
                    new Vector(39.5299458181818, -78.63708200000001),
                    new Vector(39.5356788181819, -78.604367),
                    new Vector(39.5210718181819, -78.56419099999989),
                    new Vector(39.5251668181818, -78.50877800000001),
                    new Vector(39.5199378181819, -78.481283),
                    new Vector(39.5337348181818, -78.45581300000001),
                    new Vector(39.5483148181818, -78.445877),
                    new Vector(39.5494128181819, -78.420821),
                    new Vector(39.5808408181819, -78.4618159999999),
                    new Vector(39.5927118181819, -78.45062900000001),
                    new Vector(39.5876088181819, -78.4039999999999),
                    new Vector(39.6209538181819, -78.43189099999999),
                    new Vector(39.6144918181819, -78.384632),
                    new Vector(39.6313218181819, -78.377675),
                    new Vector(39.6323748181818, -78.356786),
                    new Vector(39.6405918181819, -78.34793000000001),
                    new Vector(39.6184068181818, -78.273014),
                    new Vector(39.6411678181819, -78.257723),
                    new Vector(39.6585648181818, -78.229229),
                    new Vector(39.6739908181818, -78.2276),
                    new Vector(39.6759348181819, -78.20429900000001),
                    new Vector(39.6946458181818, -78.182969),
                    new Vector(39.6756018181819, -78.0943369999999),
                    new Vector(39.6228618181818, -78.026414),
                    new Vector(39.5989758181819, -77.9952109999999),
                    new Vector(39.6113238181818, -77.96423299999999),
                    new Vector(39.5860068181819, -77.9449819999999),
                    new Vector(39.5919378181818, -77.935451),
                    new Vector(39.6150048181819, -77.947547),
                    new Vector(39.618217818182, -77.9386099999999),
                    new Vector(39.5961228181819, -77.90325799999989),
                    new Vector(39.6007038181818, -77.890748),
                    new Vector(39.6165708181818, -77.888435),
                    new Vector(39.6021618181819, -77.855531),
                    new Vector(39.6053748181818, -77.842409),
                    new Vector(39.5727408181819, -77.8398619999999),
                    new Vector(39.5654508181819, -77.852966),
                    new Vector(39.5644518181819, -77.8851769999999),
                    new Vector(39.5580888181819, -77.88992),
                    new Vector(39.5459118181819, -77.869562),
                    new Vector(39.514654818182, -77.864639),
                    new Vector(39.5319258181818, -77.84384900000001),
                    new Vector(39.5256078181819, -77.835461),
                    new Vector(39.5292528181819, -77.82892699999999),
                    new Vector(39.5120358181817, -77.825264),
                    new Vector(39.5020098181819, -77.8478719999999),
                    new Vector(39.4939098181818, -77.825192),
                    new Vector(39.4981218181818, -77.771552),
                    new Vector(39.4808238181819, -77.799497),
                    new Vector(39.4590978181818, -77.7851059999999),
                    new Vector(39.4631388181818, -77.80419500000001),
                    new Vector(39.4509168181819, -77.795798),
                    new Vector(39.4400178181818, -77.80468999999999),
                    new Vector(39.4323138181819, -77.802269),
                    new Vector(39.4251678181819, -77.7569809999999),
                    new Vector(39.403432818182, -77.740835),
                    new Vector(39.3961878181819, -77.737235),
                    new Vector(39.3784758181819, -77.756225),
                    new Vector(39.3603768181818, -77.745452),
                    new Vector(39.338587818182, -77.754299),
                    new Vector(39.3268158181818, -77.75008699999999),
                    new Vector(39.3177978181819, -77.72746100000001),
                    new Vector(39.3187788181818, -77.67930200000001),
                    new Vector(39.2998158181819, -77.61623899999999),
                    new Vector(39.2984928181818, -77.568674),
                    new Vector(39.269044818182, -77.541899),
                    new Vector(39.250018818182, -77.493776),
                    new Vector(39.2291658181819, -77.46466100000001),
                    new Vector(39.2187348181818, -77.461709),
                    new Vector(39.1770378181818, -77.478341),
                    new Vector(39.1575438181818, -77.5163299999999),
                    new Vector(39.1167648181819, -77.51275699999999),
                    new Vector(39.1040658181819, -77.478962),
                    new Vector(39.0809448181819, -77.4593959999999),
                    new Vector(39.0668778181818, -77.43274700000001),
                    new Vector(39.0686148181818, -77.34623000000001),
                    new Vector(39.0627018181819, -77.32430600000001),
                    new Vector(39.0276828181819, -77.25569),
                    new Vector(38.9759868181819, -77.243432),
                    new Vector(38.9648898181819, -77.1517489999999),
                    new Vector(38.9321748181818, -77.122328)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(38.9078388181817, -76.292798),
                    new Vector(38.9493468181819, -76.27318699999999),
                    new Vector(38.9236878181818, -76.24641200000001),
                    new Vector(38.9790108181817, -76.247816),
                    new Vector(39.0407058181819, -76.299494),
                    new Vector(38.958301818182, -76.35647299999999),
                    new Vector(38.8542168181818, -76.3752379999999),
                    new Vector(38.8759968181818, -76.3293919999999),
                    new Vector(38.9241738181819, -76.34221700000001),
                    new Vector(38.9122038181818, -76.322309),
                    new Vector(38.9420388181819, -76.314128),
                    new Vector(38.9567718181818, -76.33874299999999),
                    new Vector(38.9676798181818, -76.29419300000001),
                    new Vector(38.9078388181817, -76.292798)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(38.0277108181819, -75.270353),
                    new Vector(38.0286468181819, -75.24221900000001),
                    new Vector(38.1243078181819, -75.172811),
                    new Vector(38.3203188181819, -75.094025),
                    new Vector(38.2049658181817, -75.16436899999999),
                    new Vector(38.0943018181818, -75.20938700000001),
                    new Vector(38.038024818182, -75.2441),
                    new Vector(38.0277108181819, -75.270353)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(38.4500718181818, -75.067925),
                    new Vector(38.3230638181818, -75.08732000000001),
                    new Vector(38.4496038181818, -75.04562300000001),
                    new Vector(38.4500718181818, -75.067925)
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