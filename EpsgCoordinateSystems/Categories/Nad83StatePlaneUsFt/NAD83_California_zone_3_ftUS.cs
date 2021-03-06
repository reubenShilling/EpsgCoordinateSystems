using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_California_zone_3_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2227;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "California zone 3";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / California zone 3 (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",38.43333333333333],PARAMETER[\"standard_parallel_2\",37.06666666666667],PARAMETER[\"latitude_of_origin\",36.5],PARAMETER[\"central_meridian\",-120.5],PARAMETER[\"false_easting\",6561666.667],PARAMETER[\"false_northing\",1640416.667],AUTHORITY[\"EPSG\",\"2227\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / California zone 3 (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",38.43333333333333],PARAMETER[\"standard_parallel_2\",37.06666666666667],PARAMETER[\"latitude_of_origin\",36.5],PARAMETER[\"central_meridian\",-120.5],PARAMETER[\"false_easting\",6561666.667],PARAMETER[\"false_northing\",1640416.667],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(37.4525478181819, -122.089298),
                    new Vector(37.6097778181818, -122.359676),
                    new Vector(37.7024508181819, -122.366327),
                    new Vector(37.7252298181818, -122.346473),
                    new Vector(37.8086238181818, -122.400923),
                    new Vector(37.7829468181818, -122.498222),
                    new Vector(37.7002548181818, -122.498213),
                    new Vector(37.5229098181818, -122.505683),
                    new Vector(37.4794848181818, -122.441468),
                    new Vector(37.3524048181818, -122.389259),
                    new Vector(37.2391308181819, -122.414639),
                    new Vector(37.1067858181819, -122.274635),
                    new Vector(37.0008738181819, -122.173448),
                    new Vector(36.9475128181819, -122.061335),
                    new Vector(36.962101818182, -121.88354),
                    new Vector(36.8503308181819, -121.791713),
                    new Vector(36.8783388181819, -121.776107),
                    new Vector(36.8842248181818, -121.753445),
                    new Vector(36.9058428181818, -121.734644),
                    new Vector(36.9120438181819, -121.715456),
                    new Vector(36.9108288181819, -121.641611),
                    new Vector(36.8959518181819, -121.626851),
                    new Vector(36.9050418181818, -121.614746),
                    new Vector(36.8977788181818, -121.579151),
                    new Vector(36.8890938181819, -121.568837),
                    new Vector(36.8898228181819, -121.549289),
                    new Vector(36.9176508181819, -121.533692),
                    new Vector(36.939412818182, -121.498124),
                    new Vector(36.9701568181818, -121.489016),
                    new Vector(36.9799668181819, -121.469432),
                    new Vector(36.9826578181817, -121.433261),
                    new Vector(36.958861818182, -121.401284),
                    new Vector(36.955396818182, -121.205642),
                    new Vector(36.9336348181819, -121.218251),
                    new Vector(36.9197208181819, -121.214003),
                    new Vector(36.9045198181818, -121.168229),
                    new Vector(36.8563428181818, -121.13042),
                    new Vector(36.8382798181819, -121.127711),
                    new Vector(36.7556058181819, -120.926543),
                    new Vector(36.7385868181819, -120.905537),
                    new Vector(37.0406628181819, -120.526691),
                    new Vector(36.9938268181818, -120.499106),
                    new Vector(36.9852048181818, -120.483707),
                    new Vector(36.9283248181818, -120.441893),
                    new Vector(36.9044388181819, -120.436763),
                    new Vector(36.8874198181818, -120.444611),
                    new Vector(36.8542188181819, -120.431561),
                    new Vector(36.8121798181818, -120.361784),
                    new Vector(36.7966728181819, -120.348428),
                    new Vector(36.7861518181818, -120.351407),
                    new Vector(36.7817508181818, -120.329951),
                    new Vector(36.7940718181817, -120.327629),
                    new Vector(36.7588728181819, -120.270884),
                    new Vector(36.7752708181819, -120.234821),
                    new Vector(36.7722018181818, -120.213995),
                    new Vector(36.7826688181819, -120.212717),
                    new Vector(36.790138818182, -120.187733),
                    new Vector(36.7780878181819, -120.180317),
                    new Vector(36.7765938181819, -120.168185),
                    new Vector(36.7964118181819, -120.156377),
                    new Vector(36.7993818181818, -120.129476),
                    new Vector(36.821296818182, -120.071156),
                    new Vector(36.8154108181819, -120.016859),
                    new Vector(36.8350938181819, -119.973344),
                    new Vector(36.8336538181819, -119.920937),
                    new Vector(36.8576658181818, -119.865479),
                    new Vector(36.8516178181818, -119.852609),
                    new Vector(36.8558838181818, -119.825708),
                    new Vector(36.8505558181819, -119.801354),
                    new Vector(36.876637818182, -119.771825),
                    new Vector(36.9097128181818, -119.754041),
                    new Vector(36.9219618181818, -119.733764),
                    new Vector(36.9795078181819, -119.716268),
                    new Vector(37.0078218181819, -119.646392),
                    new Vector(37.0261368181819, -119.638391),
                    new Vector(37.0387818181819, -119.619797),
                    new Vector(37.0244718181818, -119.610653),
                    new Vector(37.0259658181818, -119.604362),
                    new Vector(37.0659618181819, -119.579207),
                    new Vector(37.0595718181818, -119.559956),
                    new Vector(37.0704078181819, -119.540705),
                    new Vector(37.0808118181819, -119.542217),
                    new Vector(37.0939788181819, -119.519573),
                    new Vector(37.1012328181819, -119.519825),
                    new Vector(37.1065968181818, -119.544836),
                    new Vector(37.1343168181819, -119.542316),
                    new Vector(37.1367378181818, -119.535467),
                    new Vector(37.1218338181818, -119.510123),
                    new Vector(37.1243178181818, -119.499818),
                    new Vector(37.1379258181819, -119.499701),
                    new Vector(37.1404998181819, -119.48477),
                    new Vector(37.109170818182, -119.464673),
                    new Vector(37.1075418181818, -119.455394),
                    new Vector(37.1346138181819, -119.439536),
                    new Vector(37.1382408181818, -119.417702),
                    new Vector(37.1532798181818, -119.413571),
                    new Vector(37.1545668181819, -119.394554),
                    new Vector(37.1447298181819, -119.3873),
                    new Vector(37.143658818182, -119.372819),
                    new Vector(37.1586888181819, -119.346161),
                    new Vector(37.169101818182, -119.34707),
                    new Vector(37.1868858181819, -119.318729),
                    new Vector(37.2001518181819, -119.312213),
                    new Vector(37.3023288181819, -119.328692),
                    new Vector(37.3457988181818, -119.30747),
                    new Vector(37.3603878181819, -119.279534),
                    new Vector(37.5744978181818, -119.017211),
                    new Vector(37.5277608181819, -118.906808),
                    new Vector(37.5058548181818, -118.887098),
                    new Vector(37.5012018181819, -118.865516),
                    new Vector(37.4813568181818, -118.858631),
                    new Vector(37.4734278181818, -118.843358),
                    new Vector(37.4767758181819, -118.801679),
                    new Vector(37.453186818182, -118.770953),
                    new Vector(37.4572998181819, -117.838679),
                    new Vector(37.8866718181819, -118.417424),
                    new Vector(38.4118038181819, -119.152454),
                    new Vector(38.5271118181818, -119.318828),
                    new Vector(38.7029088181818, -119.575679),
                    new Vector(38.6623458181818, -119.607269),
                    new Vector(38.6150148181819, -119.615612),
                    new Vector(38.5120278181818, -119.554268),
                    new Vector(38.4827058181819, -119.54678),
                    new Vector(38.4612048181819, -119.556023),
                    new Vector(38.4158808181818, -119.555618),
                    new Vector(38.4039468181819, -119.562836),
                    new Vector(38.3942898181818, -119.612435),
                    new Vector(38.3621508181819, -119.609537),
                    new Vector(38.338183818182, -119.628041),
                    new Vector(38.3434938181819, -119.655239),
                    new Vector(38.3646528181818, -119.683022),
                    new Vector(38.4003198181818, -119.690204),
                    new Vector(38.4171408181818, -119.709023),
                    new Vector(38.4182568181818, -119.740208),
                    new Vector(38.4012828181819, -119.78951),
                    new Vector(38.3665878181818, -119.83928),
                    new Vector(38.3586678181818, -119.868323),
                    new Vector(38.4322338181818, -120.015212),
                    new Vector(38.4481638181819, -120.04997),
                    new Vector(38.4412788181818, -120.071435),
                    new Vector(38.5079958181818, -120.068924),
                    new Vector(38.4916248181819, -120.142967),
                    new Vector(38.4940368181818, -120.207776),
                    new Vector(38.4650118181819, -120.327656),
                    new Vector(38.4654708181819, -120.426485),
                    new Vector(38.4428808181819, -120.488333),
                    new Vector(38.4217308181818, -120.514361),
                    new Vector(38.3930208181819, -120.597611),
                    new Vector(38.3625378181819, -120.600806),
                    new Vector(38.3326398181819, -120.630452),
                    new Vector(38.2895298181819, -120.752141),
                    new Vector(38.2850118181818, -120.795917),
                    new Vector(38.2572648181818, -120.841988),
                    new Vector(38.2198248181818, -120.878744),
                    new Vector(38.2252878181819, -120.906581),
                    new Vector(38.2223538181819, -120.98381),
                    new Vector(38.2993308181819, -121.016165),
                    new Vector(38.2886478181819, -121.092458),
                    new Vector(38.2537638181818, -121.158554),
                    new Vector(38.2447278181818, -121.197344),
                    new Vector(38.2491468181819, -121.266806),
                    new Vector(38.2291758181819, -121.319015),
                    new Vector(38.2321908181819, -121.400132),
                    new Vector(38.254546818182, -121.42202),
                    new Vector(38.2548078181819, -121.464851),
                    new Vector(38.1926268181819, -121.515008),
                    new Vector(38.1545388181819, -121.526735),
                    new Vector(38.1373668181818, -121.554158),
                    new Vector(38.1137958181818, -121.572833),
                    new Vector(38.0634768181818, -121.547471),
                    new Vector(38.0636658181818, -121.569548),
                    new Vector(38.0941398181819, -121.576883),
                    new Vector(38.0861028181818, -121.657748),
                    new Vector(38.0234988181818, -121.698959),
                    new Vector(38.0571588181818, -122.00063),
                    new Vector(38.014786818182, -122.295515),
                    new Vector(37.9734498181819, -122.379683),
                    new Vector(37.9093428181819, -122.371493),
                    new Vector(37.8917658181819, -122.307557),
                    new Vector(37.7784648181818, -122.312408),
                    new Vector(37.735201818182, -122.199728),
                    new Vector(37.4973048181819, -122.093024),
                    new Vector(37.4607198181819, -121.975349),
                    new Vector(37.4525478181819, -122.089298)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(38.1506688181818, -122.528642),
                    new Vector(38.1853638181819, -122.564687),
                    new Vector(38.1794418181818, -122.634617),
                    new Vector(38.2050018181819, -122.710487),
                    new Vector(38.2031928181819, -122.729729),
                    new Vector(38.3138658181818, -122.895284),
                    new Vector(38.3083038181819, -122.935379),
                    new Vector(38.3122908181819, -122.965655),
                    new Vector(38.2972248181817, -122.994644),
                    new Vector(38.1532608181818, -122.939276),
                    new Vector(37.9944648181818, -123.010727),
                    new Vector(37.9907568181818, -122.956601),
                    new Vector(38.0306268181818, -122.921177),
                    new Vector(38.0076768181818, -122.822195),
                    new Vector(37.8943938181819, -122.691731),
                    new Vector(37.9069218181818, -122.666387),
                    new Vector(37.8221058181819, -122.515727),
                    new Vector(37.8342198181819, -122.458262),
                    new Vector(37.9317618181818, -122.490014),
                    new Vector(37.9829538181819, -122.441783),
                    new Vector(38.0186568181819, -122.506457),
                    new Vector(38.0854548181818, -122.474543),
                    new Vector(38.1506688181818, -122.528642)
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