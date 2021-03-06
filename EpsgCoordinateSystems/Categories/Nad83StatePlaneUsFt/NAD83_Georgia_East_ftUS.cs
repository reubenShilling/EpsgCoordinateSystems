using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Georgia_East_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2239;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Georgia East";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Georgia East (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",30],PARAMETER[\"central_meridian\",-82.16666666666667],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",656166.667],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2239\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Georgia East (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",30],PARAMETER[\"central_meridian\",-82.16666666666667],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",656166.667],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(31.7757888181819, -82.997501),
                    new Vector(31.6739178181818, -83.0012449999999),
                    new Vector(31.6579338181818, -83.001182),
                    new Vector(31.6589418181819, -83.01468199999999),
                    new Vector(31.6364598181819, -83.019218),
                    new Vector(31.6383948181818, -83.032196),
                    new Vector(31.6260828181819, -83.03173699999989),
                    new Vector(31.6262268181819, -83.043032),
                    new Vector(31.6083978181818, -83.0439769999999),
                    new Vector(31.6085148181819, -83.056361),
                    new Vector(31.5613998181819, -83.059943),
                    new Vector(31.4856198181819, -83.1091729999999),
                    new Vector(31.4727678181819, -83.128001),
                    new Vector(31.4719938181819, -83.155361),
                    new Vector(31.4149248181819, -83.138648),
                    new Vector(31.3998768181819, -83.138054),
                    new Vector(31.34886481818191, -83.10016400000001),
                    new Vector(31.3338078181819, -83.06634200000001),
                    new Vector(31.2863868181819, -83.046875),
                    new Vector(31.2740118181819, -83.031953),
                    new Vector(31.2310998181819, -83.0474779999999),
                    new Vector(31.1918418181819, -83.046002),
                    new Vector(31.1455278181818, -83.035706),
                    new Vector(31.1450958181818, -83.1656389999999),
                    new Vector(31.0623228181819, -83.167754),
                    new Vector(31.0620798181818, -83.19231499999999),
                    new Vector(31.0285368181819, -83.19848),
                    new Vector(31.0289508181818, -83.16805100000001),
                    new Vector(30.9493098181819, -83.17189399999999),
                    new Vector(30.9470328181819, -83.04109699999999),
                    new Vector(30.9133188181818, -83.037173),
                    new Vector(30.8928978181819, -83.015078),
                    new Vector(30.8520018181819, -83.02262899999999),
                    new Vector(30.8506968181819, -83.08651999999999),
                    new Vector(30.8323998181818, -83.086889),
                    new Vector(30.8321208181819, -83.097005),
                    new Vector(30.7987038181818, -83.0984),
                    new Vector(30.7993158181818, -83.1250579999999),
                    new Vector(30.7605708181819, -83.136875),
                    new Vector(30.7096398181819, -83.12693899999989),
                    new Vector(30.621349818182, -83.13243799999989),
                    new Vector(30.5957178181818, -82.696352),
                    new Vector(30.5890578181819, -82.58295200000001),
                    new Vector(30.5826948181819, -82.46313499999999),
                    new Vector(30.5773128181818, -82.412087),
                    new Vector(30.5670708181819, -82.221035),
                    new Vector(30.5314488181818, -82.23839599999999),
                    new Vector(30.5029728181819, -82.21936100000001),
                    new Vector(30.4900218181818, -82.199192),
                    new Vector(30.423853818182, -82.205564),
                    new Vector(30.36862981818181, -82.180238),
                    new Vector(30.3612948181819, -82.164632),
                    new Vector(30.3637878181819, -82.052762),
                    new Vector(30.3788988181819, -82.038353),
                    new Vector(30.4340688181818, -82.046102),
                    new Vector(30.442879818182, -82.035122),
                    new Vector(30.4777188181819, -82.022513),
                    new Vector(30.5709948181818, -82.00579999999989),
                    new Vector(30.5986878181819, -82.0136569999999),
                    new Vector(30.6509058181819, -82.044905),
                    new Vector(30.75753781818189, -82.0318819999999),
                    new Vector(30.7642518181819, -82.012964),
                    new Vector(30.7913148181819, -82.01553800000001),
                    new Vector(30.7783548181819, -81.981482),
                    new Vector(30.7960128181819, -81.961556),
                    new Vector(30.8204298181819, -81.953024),
                    new Vector(30.8242458181819, -81.943808),
                    new Vector(30.8134728181819, -81.90752000000001),
                    new Vector(30.8283048181819, -81.899141),
                    new Vector(30.7990818181818, -81.872996),
                    new Vector(30.7880838181819, -81.803201),
                    new Vector(30.7615788181819, -81.77670500000001),
                    new Vector(30.7696248181819, -81.757706),
                    new Vector(30.7638918181818, -81.7366729999999),
                    new Vector(30.7453698181819, -81.716774),
                    new Vector(30.7290798181818, -81.64247),
                    new Vector(30.7317708181819, -81.62797999999999),
                    new Vector(30.7163178181819, -81.604769),
                    new Vector(30.724894818182, -81.601169),
                    new Vector(30.7065798181818, -81.53659399999999),
                    new Vector(30.7214568181819, -81.528593),
                    new Vector(30.7575198181818, -81.49838),
                    new Vector(30.8647818181819, -81.52927699999999),
                    new Vector(30.9448998181819, -81.484826),
                    new Vector(30.9621168181819, -81.528566),
                    new Vector(30.9858048181819, -81.49085599999999),
                    new Vector(31.0767588181819, -81.53542400000001),
                    new Vector(31.0438278181819, -81.47534),
                    new Vector(31.0865418181818, -81.5252629999999),
                    new Vector(31.1311278181819, -81.528395),
                    new Vector(31.1489478181819, -81.381011),
                    new Vector(31.2426918181818, -81.310244),
                    new Vector(31.275820818182, -81.300839),
                    new Vector(31.297141818182, -81.388805),
                    new Vector(31.26409381818191, -81.394772),
                    new Vector(31.3114788181818, -81.410342),
                    new Vector(31.3445538181818, -81.365585),
                    new Vector(31.3375968181819, -81.313061),
                    new Vector(31.4668998181818, -81.20857100000001),
                    new Vector(31.5051588181819, -81.1947739999999),
                    new Vector(31.5568818181819, -81.239144),
                    new Vector(31.6401768181818, -81.240719),
                    new Vector(31.5999018181819, -81.18718699999989),
                    new Vector(31.6460718181818, -81.134933),
                    new Vector(31.7996658181818, -81.28972399999989),
                    new Vector(31.7358018181818, -81.175172),
                    new Vector(31.7848428181819, -81.196367),
                    new Vector(31.7998098181818, -81.17401099999999),
                    new Vector(31.7270718181819, -81.13682300000001),
                    new Vector(31.7775438181818, -81.0610429999999),
                    new Vector(31.8233628181817, -81.039011),
                    new Vector(31.8535218181819, -81.14146700000001),
                    new Vector(31.8976758181819, -81.180257),
                    new Vector(31.8931398181818, -81.22010899999999),
                    new Vector(31.9206528181819, -81.206492),
                    new Vector(31.8946878181818, -81.24494900000001),
                    new Vector(31.9494258181819, -81.284288),
                    new Vector(31.9034178181819, -81.239684),
                    new Vector(31.9284378181819, -81.203909),
                    new Vector(31.9198878181818, -81.19730300000001),
                    new Vector(31.9001148181818, -81.207257),
                    new Vector(31.9058928181818, -81.179996),
                    new Vector(31.8643398181819, -81.13985599999999),
                    new Vector(31.8903138181819, -80.970872),
                    new Vector(31.94792281818181, -80.97355399999999),
                    new Vector(32.0059908181819, -80.89475899999999),
                    new Vector(32.1054498181819, -81.104873),
                    new Vector(32.1176178181818, -81.119111),
                    new Vector(32.1905898181819, -81.11471899999999),
                    new Vector(32.2244478181818, -81.147695),
                    new Vector(32.2577118181818, -81.148172),
                    new Vector(32.2766478181818, -81.124043),
                    new Vector(32.3326188181819, -81.1318909999999),
                    new Vector(32.3484678181817, -81.141881),
                    new Vector(32.3387388181818, -81.157478),
                    new Vector(32.3717778181818, -81.179123),
                    new Vector(32.3868258181819, -81.178259),
                    new Vector(32.4203148181819, -81.19993100000001),
                    new Vector(32.4645678181819, -81.19515199999999),
                    new Vector(32.5206198181818, -81.236237),
                    new Vector(32.5339308181818, -81.26797999999999),
                    new Vector(32.554819818182, -81.274298),
                    new Vector(32.5672938181818, -81.298985),
                    new Vector(32.5713618181818, -81.34040299999999),
                    new Vector(32.5835298181819, -81.351491),
                    new Vector(32.5819818181819, -81.36670100000001),
                    new Vector(32.588362818182, -81.36626),
                    new Vector(32.5958778181818, -81.3849079999999),
                    new Vector(32.6256048181819, -81.41210599999999),
                    new Vector(32.6508138181819, -81.399479),
                    new Vector(32.6866968181819, -81.40719199999999),
                    new Vector(32.7015648181817, -81.42053900000001),
                    new Vector(32.7418128181819, -81.407624),
                    new Vector(32.7498048181819, -81.42303200000001),
                    new Vector(32.7567258181818, -81.41607500000001),
                    new Vector(32.7861558181818, -81.430232),
                    new Vector(32.8094928181819, -81.42083599999999),
                    new Vector(32.8203108181818, -81.430313),
                    new Vector(32.8317768181819, -81.423968),
                    new Vector(32.8416858181819, -81.4323289999999),
                    new Vector(32.8445748181818, -81.455315),
                    new Vector(32.8714038181819, -81.45853699999989),
                    new Vector(32.8760928181819, -81.483206),
                    new Vector(32.8977288181819, -81.465035),
                    new Vector(32.8975758181818, -81.477041),
                    new Vector(32.9472198181819, -81.510233),
                    new Vector(32.9554188181819, -81.509837),
                    new Vector(32.9596758181819, -81.49790299999999),
                    new Vector(33.0048108181817, -81.49273700000001),
                    new Vector(33.0127938181818, -81.5087479999999),
                    new Vector(33.0439248181819, -81.529601),
                    new Vector(33.0436818181819, -81.5476639999999),
                    new Vector(33.0608178181818, -81.560039),
                    new Vector(33.0707898181818, -81.595823),
                    new Vector(33.0878718181819, -81.610961),
                    new Vector(33.1229358181818, -81.70428200000001),
                    new Vector(33.1446978181818, -81.74037199999989),
                    new Vector(33.1698348181819, -81.763412),
                    new Vector(33.1953858181818, -81.759587),
                    new Vector(33.2138808181818, -81.76988299999999),
                    new Vector(33.2173728181818, -81.779837),
                    new Vector(33.2079228181819, -81.801563),
                    new Vector(33.2264448181818, -81.810761),
                    new Vector(33.2434998181818, -81.853961),
                    new Vector(33.2606088181818, -81.836798),
                    new Vector(33.2733078181818, -81.83984),
                    new Vector(33.2694288181819, -81.82657399999999),
                    new Vector(33.2970948181818, -81.86072),
                    new Vector(33.3083448181818, -81.8401099999999),
                    new Vector(33.3156708181818, -81.865544),
                    new Vector(33.3068328181819, -81.876875),
                    new Vector(33.335236818182, -81.89348),
                    new Vector(33.3322038181818, -81.912092),
                    new Vector(33.3494928181818, -81.91140799999999),
                    new Vector(33.3504378181818, -81.936707),
                    new Vector(33.3771498181819, -81.94506800000001),
                    new Vector(33.3765648181818, -81.925808),
                    new Vector(33.4081638181818, -81.94033399999999),
                    new Vector(33.4154448181819, -81.913568),
                    new Vector(33.4361448181819, -81.92727499999999),
                    new Vector(33.4513368181819, -81.91663699999999),
                    new Vector(33.471019818182, -81.93638300000001),
                    new Vector(33.4907388181819, -81.980915),
                    new Vector(33.5204928181819, -81.996539),
                    new Vector(33.5387358181818, -82.02013700000001),
                    new Vector(33.5475108181819, -82.03854200000001),
                    new Vector(33.5738628181817, -82.065686),
                    new Vector(33.5947698181818, -82.116401),
                    new Vector(33.5939058181819, -82.138982),
                    new Vector(33.6152178181819, -82.167134),
                    new Vector(33.6238398181819, -82.19219),
                    new Vector(33.6807378181819, -82.214213),
                    new Vector(33.6903408181819, -82.234904),
                    new Vector(33.7615938181819, -82.266215),
                    new Vector(33.7826448181819, -82.305509),
                    new Vector(33.803920818182, -82.3111159999999),
                    new Vector(33.8353938181819, -82.35131),
                    new Vector(33.8360058181819, -82.36571000000001),
                    new Vector(33.8541408181819, -82.3906039999999),
                    new Vector(33.8602518181818, -82.424525),
                    new Vector(33.8782248181819, -82.45662799999999),
                    new Vector(33.9310278181819, -82.5175399999999),
                    new Vector(33.9592878181819, -82.576616),
                    new Vector(33.9688998181817, -82.57361),
                    new Vector(34.0134138181818, -82.5961369999999),
                    new Vector(34.0346358181819, -82.602941),
                    new Vector(34.1083548181818, -82.660352),
                    new Vector(34.1697978181819, -82.735781),
                    new Vector(34.2055548181819, -82.742594),
                    new Vector(34.2333738181819, -82.75802899999999),
                    new Vector(34.2809658181818, -82.76417600000001),
                    new Vector(34.2905148181817, -82.78286900000001),
                    new Vector(34.339897818182, -82.808582),
                    new Vector(34.3710468181819, -82.836437),
                    new Vector(34.4126718181818, -82.844087),
                    new Vector(34.4575458181819, -82.868045),
                    new Vector(34.4779848181818, -82.905053),
                    new Vector(34.4764998181818, -82.9819669999999),
                    new Vector(34.4708298181818, -83.007941),
                    new Vector(34.4900628181819, -83.054993),
                    new Vector(34.5189708181819, -83.079014),
                    new Vector(34.5350178181818, -83.10812),
                    new Vector(34.5678678181819, -83.1373609999999),
                    new Vector(34.5768228181819, -83.158952),
                    new Vector(34.5989358181819, -83.164883),
                    new Vector(34.6133178181818, -83.236991),
                    new Vector(34.6629438181819, -83.29889300000001),
                    new Vector(34.6776948181819, -83.339789),
                    new Vector(34.6582818181818, -83.366906),
                    new Vector(34.4786868181818, -83.46173),
                    new Vector(34.4636838181819, -83.40026899999999),
                    new Vector(34.4551968181819, -83.394869),
                    new Vector(34.4219238181819, -83.38226899999999),
                    new Vector(34.3257138181818, -83.3919889999999),
                    new Vector(34.2744408181817, -83.341346),
                    new Vector(34.2625338181819, -83.344172),
                    new Vector(34.2433908181818, -83.32999700000001),
                    new Vector(34.2271098181819, -83.358761),
                    new Vector(34.2165618181819, -83.361659),
                    new Vector(34.2054558181819, -83.399531),
                    new Vector(34.1800398181818, -83.3822959999999),
                    new Vector(34.1754498181818, -83.368202),
                    new Vector(34.1408448181819, -83.353937),
                    new Vector(34.1171208181818, -83.356799),
                    new Vector(34.0846488181818, -83.37869600000001),
                    new Vector(34.0541838181818, -83.37849799999999),
                    new Vector(34.0407558181819, -83.323553),
                    new Vector(34.008913818182, -83.291702),
                    new Vector(33.992092818182, -83.259401),
                    new Vector(33.9419808181818, -83.278355),
                    new Vector(33.8989338181819, -83.239997),
                    new Vector(33.8496588181818, -83.27779700000001),
                    new Vector(33.8149368181819, -83.299019),
                    new Vector(33.7612518181818, -83.28293600000001),
                    new Vector(33.7271508181818, -83.29808300000001),
                    new Vector(33.6945348181818, -83.402726),
                    new Vector(33.598000818182, -83.34284),
                    new Vector(33.5732418181819, -83.317514),
                    new Vector(33.5478618181818, -83.266295),
                    new Vector(33.5100528181818, -83.2834579999999),
                    new Vector(33.4806048181819, -83.278364),
                    new Vector(33.4620558181819, -83.25887),
                    new Vector(33.447448818182, -83.260463),
                    new Vector(33.4248408181818, -83.23916),
                    new Vector(33.4027278181819, -83.232203),
                    new Vector(33.4031238181819, -83.217911),
                    new Vector(33.3842778181819, -83.224301),
                    new Vector(33.3962298181819, -83.187923),
                    new Vector(33.3538308181817, -83.15761999999999),
                    new Vector(33.3337698181819, -83.141969),
                    new Vector(33.3132678181818, -83.14280599999999),
                    new Vector(33.2874558181818, -83.203304),
                    new Vector(33.2682228181819, -83.223383),
                    new Vector(33.2649288181819, -83.24357000000001),
                    new Vector(33.2144658181819, -83.256863),
                    new Vector(33.1869618181819, -83.279309),
                    new Vector(33.1669098181819, -83.327297),
                    new Vector(33.1844958181819, -83.410331),
                    new Vector(33.1821468181819, -83.427791),
                    new Vector(32.9182488181818, -83.357843),
                    new Vector(32.8890348181818, -83.40581299999999),
                    new Vector(32.5789578181818, -83.226461),
                    new Vector(32.4186858181819, -83.139566),
                    new Vector(32.440672818182, -83.16814100000001),
                    new Vector(32.3292888181819, -83.3004949999999),
                    new Vector(32.3146638181819, -83.28632),
                    new Vector(32.2711128181818, -83.340932),
                    new Vector(32.2418088181819, -83.37549199999999),
                    new Vector(32.173651818182, -83.289731),
                    new Vector(32.1443928181819, -83.3231839999999),
                    new Vector(32.120335818182, -83.30378),
                    new Vector(32.0999598181818, -83.329457),
                    new Vector(32.0766948181819, -83.298731),
                    new Vector(32.0429268181818, -83.298965),
                    new Vector(31.9547628181818, -83.27155999999999),
                    new Vector(31.9429818181819, -83.253263),
                    new Vector(31.9475988181819, -83.235623),
                    new Vector(31.9268358181818, -83.22777499999989),
                    new Vector(31.9235688181819, -83.21414),
                    new Vector(31.9028688181819, -83.2041229999999),
                    new Vector(31.8817638181819, -83.208155),
                    new Vector(31.8746898181818, -83.200316),
                    new Vector(31.8734658181818, -83.17922),
                    new Vector(31.8488148181818, -83.17931900000001),
                    new Vector(31.8239478181819, -83.155145),
                    new Vector(31.8233988181819, -83.1421849999999),
                    new Vector(31.8079278181819, -83.124329),
                    new Vector(31.8092868181819, -83.09147900000001),
                    new Vector(31.7894238181819, -83.066999),
                    new Vector(31.7757888181819, -82.997501)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(30.9038778181817, -81.485051),
                    new Vector(30.8817378181818, -81.50331199999989),
                    new Vector(30.8602638181818, -81.46989499999999),
                    new Vector(30.7368828181819, -81.479462),
                    new Vector(30.7164258181818, -81.45572),
                    new Vector(30.9387978181818, -81.403052),
                    new Vector(30.9706038181818, -81.416408),
                    new Vector(30.9038778181817, -81.485051)
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