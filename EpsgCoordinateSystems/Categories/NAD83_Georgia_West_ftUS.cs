using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Georgia_West_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 2240;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Georgia West";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Georgia West (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,-84.16666666666667],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,2296583.333],PARAMETER[false_northing,0],AUTHORITY[EPSG,2240],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Georgia West (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,-84.16666666666667],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,2296583.333],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(32.0696478181818, -85.056656),
                    new Vector(32.0500098181818, -85.062011),
                    new Vector(32.0173758181819, -85.056701),
                    new Vector(31.980700818182, -85.070066),
                    new Vector(31.9074228181819, -85.115156),
                    new Vector(31.8548808181819, -85.13556800000001),
                    new Vector(31.7838168181819, -85.131563),
                    new Vector(31.7788578181818, -85.130168),
                    new Vector(31.7315628181819, -85.115291),
                    new Vector(31.7085768181818, -85.1186749999999),
                    new Vector(31.6842498181817, -85.111205),
                    new Vector(31.6212678181819, -85.05928400000001),
                    new Vector(31.5543888181818, -85.042715),
                    new Vector(31.5196668181819, -85.042697),
                    new Vector(31.4760888181818, -85.06631299999999),
                    new Vector(31.4406648181818, -85.061408),
                    new Vector(31.3672338181819, -85.0879489999999),
                    new Vector(31.3323408181818, -85.0825669999999),
                    new Vector(31.3030818181817, -85.081226),
                    new Vector(31.2714378181819, -85.10336599999999),
                    new Vector(31.2270768181819, -85.09360100000001),
                    new Vector(31.1969178181818, -85.102952),
                    new Vector(31.1722128181819, -85.093367),
                    new Vector(31.1623668181819, -85.068662),
                    new Vector(31.1267088181819, -85.038062),
                    new Vector(31.0800978181819, -85.016993),
                    new Vector(31.0012578181818, -85.00161199999999),
                    new Vector(30.9793158181819, -85.000145),
                    new Vector(30.9636648181819, -84.973568),
                    new Vector(30.9270888181818, -84.969005),
                    new Vector(30.8949588181819, -84.937775),
                    new Vector(30.8469168181818, -84.9269299999999),
                    new Vector(30.80262781818171, -84.932564),
                    new Vector(30.7760868181819, -84.926894),
                    new Vector(30.7540908181818, -84.9153469999999),
                    new Vector(30.7438938181818, -84.888293),
                    new Vector(30.7144998181818, -84.8645779999999),
                    new Vector(30.7126638181817, -84.86300300000001),
                    new Vector(30.6940878181819, -84.374447),
                    new Vector(30.6904158181818, -84.281666),
                    new Vector(30.6785808181818, -84.07556599999999),
                    new Vector(30.6755388181819, -84.000731),
                    new Vector(30.6604908181819, -83.737841),
                    new Vector(30.6507798181818, -83.60905099999999),
                    new Vector(30.6343008181819, -83.310602),
                    new Vector(30.6332838181819, -83.301314),
                    new Vector(30.621349818182, -83.13243799999989),
                    new Vector(30.7096398181819, -83.12693899999989),
                    new Vector(30.7605708181819, -83.136875),
                    new Vector(30.7993158181818, -83.1250579999999),
                    new Vector(30.7987038181818, -83.0984),
                    new Vector(30.8321208181819, -83.097005),
                    new Vector(30.8323998181818, -83.086889),
                    new Vector(30.8506968181819, -83.08651999999999),
                    new Vector(30.8520018181819, -83.02262899999999),
                    new Vector(30.8928978181819, -83.015078),
                    new Vector(30.9133188181818, -83.037173),
                    new Vector(30.9470328181819, -83.04109699999999),
                    new Vector(30.9493098181819, -83.17189399999999),
                    new Vector(31.0289508181818, -83.16805100000001),
                    new Vector(31.0285368181819, -83.19848),
                    new Vector(31.0620798181818, -83.19231499999999),
                    new Vector(31.0623228181819, -83.167754),
                    new Vector(31.1450958181818, -83.1656389999999),
                    new Vector(31.1455278181818, -83.035706),
                    new Vector(31.1918418181819, -83.046002),
                    new Vector(31.2310998181819, -83.0474779999999),
                    new Vector(31.2740118181819, -83.031953),
                    new Vector(31.2863868181819, -83.046875),
                    new Vector(31.3338078181819, -83.06634200000001),
                    new Vector(31.34886481818191, -83.10016400000001),
                    new Vector(31.3998768181819, -83.138054),
                    new Vector(31.4149248181819, -83.138648),
                    new Vector(31.4719938181819, -83.155361),
                    new Vector(31.4727678181819, -83.128001),
                    new Vector(31.4856198181819, -83.1091729999999),
                    new Vector(31.5613998181819, -83.059943),
                    new Vector(31.6085148181819, -83.056361),
                    new Vector(31.6083978181818, -83.0439769999999),
                    new Vector(31.6262268181819, -83.043032),
                    new Vector(31.6260828181819, -83.03173699999989),
                    new Vector(31.6383948181818, -83.032196),
                    new Vector(31.6364598181819, -83.019218),
                    new Vector(31.6589418181819, -83.01468199999999),
                    new Vector(31.6579338181818, -83.001182),
                    new Vector(31.6739178181818, -83.0012449999999),
                    new Vector(31.7757888181819, -82.997501),
                    new Vector(31.7894238181819, -83.066999),
                    new Vector(31.8092868181819, -83.09147900000001),
                    new Vector(31.8079278181819, -83.124329),
                    new Vector(31.8233988181819, -83.1421849999999),
                    new Vector(31.8239478181819, -83.155145),
                    new Vector(31.8488148181818, -83.17931900000001),
                    new Vector(31.8734658181818, -83.17922),
                    new Vector(31.8746898181818, -83.200316),
                    new Vector(31.8817638181819, -83.208155),
                    new Vector(31.9028688181819, -83.2041229999999),
                    new Vector(31.9235688181819, -83.21414),
                    new Vector(31.9268358181818, -83.22777499999989),
                    new Vector(31.9475988181819, -83.235623),
                    new Vector(31.9429818181819, -83.253263),
                    new Vector(31.9547628181818, -83.27155999999999),
                    new Vector(32.0429268181818, -83.298965),
                    new Vector(32.0766948181819, -83.298731),
                    new Vector(32.0999598181818, -83.329457),
                    new Vector(32.120335818182, -83.30378),
                    new Vector(32.1443928181819, -83.3231839999999),
                    new Vector(32.173651818182, -83.289731),
                    new Vector(32.2418088181819, -83.37549199999999),
                    new Vector(32.2711128181818, -83.340932),
                    new Vector(32.3146638181819, -83.28632),
                    new Vector(32.3292888181819, -83.3004949999999),
                    new Vector(32.440672818182, -83.16814100000001),
                    new Vector(32.4186858181819, -83.139566),
                    new Vector(32.5789578181818, -83.226461),
                    new Vector(32.8890348181818, -83.40581299999999),
                    new Vector(32.9182488181818, -83.357843),
                    new Vector(33.1821468181819, -83.427791),
                    new Vector(33.1844958181819, -83.410331),
                    new Vector(33.1669098181819, -83.327297),
                    new Vector(33.1869618181819, -83.279309),
                    new Vector(33.2144658181819, -83.256863),
                    new Vector(33.2649288181819, -83.24357000000001),
                    new Vector(33.2682228181819, -83.223383),
                    new Vector(33.2874558181818, -83.203304),
                    new Vector(33.3132678181818, -83.14280599999999),
                    new Vector(33.3337698181819, -83.141969),
                    new Vector(33.3538308181817, -83.15761999999999),
                    new Vector(33.3962298181819, -83.187923),
                    new Vector(33.3842778181819, -83.224301),
                    new Vector(33.4031238181819, -83.217911),
                    new Vector(33.4027278181819, -83.232203),
                    new Vector(33.4248408181818, -83.23916),
                    new Vector(33.447448818182, -83.260463),
                    new Vector(33.4620558181819, -83.25887),
                    new Vector(33.4806048181819, -83.278364),
                    new Vector(33.5100528181818, -83.2834579999999),
                    new Vector(33.5478618181818, -83.266295),
                    new Vector(33.5732418181819, -83.317514),
                    new Vector(33.598000818182, -83.34284),
                    new Vector(33.6945348181818, -83.402726),
                    new Vector(33.7271508181818, -83.29808300000001),
                    new Vector(33.7612518181818, -83.28293600000001),
                    new Vector(33.8149368181819, -83.299019),
                    new Vector(33.8496588181818, -83.27779700000001),
                    new Vector(33.8989338181819, -83.239997),
                    new Vector(33.9419808181818, -83.278355),
                    new Vector(33.992092818182, -83.259401),
                    new Vector(34.008913818182, -83.291702),
                    new Vector(34.0407558181819, -83.323553),
                    new Vector(34.0541838181818, -83.37849799999999),
                    new Vector(34.0846488181818, -83.37869600000001),
                    new Vector(34.1171208181818, -83.356799),
                    new Vector(34.1408448181819, -83.353937),
                    new Vector(34.1754498181818, -83.368202),
                    new Vector(34.1800398181818, -83.3822959999999),
                    new Vector(34.2054558181819, -83.399531),
                    new Vector(34.2165618181819, -83.361659),
                    new Vector(34.2271098181819, -83.358761),
                    new Vector(34.2433908181818, -83.32999700000001),
                    new Vector(34.2625338181819, -83.344172),
                    new Vector(34.2744408181817, -83.341346),
                    new Vector(34.3257138181818, -83.3919889999999),
                    new Vector(34.4219238181819, -83.38226899999999),
                    new Vector(34.4551968181819, -83.394869),
                    new Vector(34.4636838181819, -83.40026899999999),
                    new Vector(34.4786868181818, -83.46173),
                    new Vector(34.6582818181818, -83.366906),
                    new Vector(34.6776948181819, -83.339789),
                    new Vector(34.7096448181818, -83.350679),
                    new Vector(34.7273838181819, -83.3503369999999),
                    new Vector(34.7522328181818, -83.323427),
                    new Vector(34.7872428181818, -83.3226889999999),
                    new Vector(34.8055308181819, -83.30275399999989),
                    new Vector(34.8150798181819, -83.27012000000001),
                    new Vector(34.8392268181819, -83.267771),
                    new Vector(34.8397128181818, -83.25041899999999),
                    new Vector(34.8501618181818, -83.250311),
                    new Vector(34.8623838181818, -83.23569500000001),
                    new Vector(34.878079818182, -83.243075),
                    new Vector(34.8738138181818, -83.23279700000001),
                    new Vector(34.8891858181818, -83.21942300000001),
                    new Vector(34.8841728181818, -83.20351100000001),
                    new Vector(34.9106418181819, -83.182181),
                    new Vector(34.9176528181819, -83.15835800000001),
                    new Vector(34.9322778181819, -83.155028),
                    new Vector(34.9304688181818, -83.137568),
                    new Vector(34.9407918181819, -83.12563400000001),
                    new Vector(34.9361298181819, -83.113097),
                    new Vector(34.9543728181818, -83.12731700000001),
                    new Vector(34.9608888181818, -83.1214039999999),
                    new Vector(34.9546878181818, -83.1155449999999),
                    new Vector(34.9841628181818, -83.100452),
                    new Vector(35.0003628181819, -83.10615799999989),
                    new Vector(34.992118818182, -83.512895),
                    new Vector(34.9896258181819, -83.5493),
                    new Vector(34.9894818181819, -83.93790199999999),
                    new Vector(34.9891578181819, -83.988455),
                    new Vector(34.9883118181819, -84.118154),
                    new Vector(34.9890948181819, -84.32377700000001),
                    new Vector(34.9887618181818, -84.6186799999999),
                    new Vector(34.9907508181819, -84.77114),
                    new Vector(34.9928388181818, -84.800417),
                    new Vector(34.9926858181819, -84.96785300000001),
                    new Vector(34.9926228181819, -84.97279399999999),
                    new Vector(34.9891488181819, -85.267715),
                    new Vector(34.9899858181818, -85.35994700000001),
                    new Vector(34.9901298181819, -85.46738000000001),
                    new Vector(34.9901658181818, -85.608968),
                    new Vector(34.8623208181819, -85.583057),
                    new Vector(34.6224888181818, -85.534691),
                    new Vector(34.5846798181818, -85.525835),
                    new Vector(34.5230208181818, -85.511858),
                    new Vector(34.2901638181818, -85.460279),
                    new Vector(34.0869168181819, -85.416566),
                    new Vector(33.9598278181819, -85.39574),
                    new Vector(33.9054048181819, -85.384013),
                    new Vector(33.6549258181819, -85.33528699999999),
                    new Vector(33.4905948181819, -85.304984),
                    new Vector(33.4258758181819, -85.293824),
                    new Vector(33.1292358181819, -85.23384799999999),
                    new Vector(33.1201368181818, -85.233497),
                    new Vector(32.8718088181818, -85.18072100000001),
                    new Vector(32.8074498181819, -85.16229800000001),
                    new Vector(32.7770748181819, -85.128089),
                    new Vector(32.7563208181818, -85.13330000000001),
                    new Vector(32.7443778181819, -85.12488500000001),
                    new Vector(32.7343878181819, -85.11386),
                    new Vector(32.6899728181818, -85.10774000000001),
                    new Vector(32.6761578181819, -85.090469),
                    new Vector(32.6459088181818, -85.103798),
                    new Vector(32.6284578181819, -85.08632900000001),
                    new Vector(32.6029968181818, -85.084142),
                    new Vector(32.5812528181818, -85.07077700000001),
                    new Vector(32.5189278181818, -84.995654),
                    new Vector(32.4548388181818, -84.989822),
                    new Vector(32.4294588181818, -84.965378),
                    new Vector(32.3968068181819, -84.970967),
                    new Vector(32.3870868181818, -84.9844939999999),
                    new Vector(32.3714988181819, -84.97166),
                    new Vector(32.3470818181818, -85.002089),
                    new Vector(32.3295948181818, -85.00533799999999),
                    new Vector(32.293135818182, -84.921071),
                    new Vector(32.2687368181818, -84.89460200000001),
                    new Vector(32.2591698181818, -84.89401700000001),
                    new Vector(32.2495578181818, -84.905366),
                    new Vector(32.2473888181819, -84.923681),
                    new Vector(32.2285518181819, -84.916004),
                    new Vector(32.2179858181818, -84.92837),
                    new Vector(32.2122438181819, -84.975746),
                    new Vector(32.191930818182, -84.96038299999999),
                    new Vector(32.1788808181819, -85.007831),
                    new Vector(32.1662718181819, -85.024382),
                    new Vector(32.1266358181819, -85.053308),
                    new Vector(32.0908878181819, -85.046189),
                    new Vector(32.0696478181818, -85.056656)
                })
            }
        };
    }
}