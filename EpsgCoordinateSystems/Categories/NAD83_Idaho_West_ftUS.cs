using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Idaho_West_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 2243;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Idaho West";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Idaho West (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-115.75],PARAMETER[scale_factor,0.999933333],PARAMETER[false_easting,2624666.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2243],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Idaho West (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-115.75],PARAMETER[scale_factor,0.999933333],PARAMETER[false_easting,2624666.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(44.3006658181818, -117.217463),
                    new Vector(44.2847178181819, -117.213575),
                    new Vector(44.2533348181819, -117.170726),
                    new Vector(44.2506348181818, -117.143285),
                    new Vector(44.2698048181819, -117.112694),
                    new Vector(44.2670778181818, -117.100571),
                    new Vector(44.2438488181818, -117.081392),
                    new Vector(44.231554818182, -117.052034),
                    new Vector(44.2493388181819, -117.030353),
                    new Vector(44.2470618181817, -116.992706),
                    new Vector(44.2251828181818, -116.976128),
                    new Vector(44.1978498181819, -116.98187),
                    new Vector(44.1773028181818, -116.913065),
                    new Vector(44.1463068181819, -116.902256),
                    new Vector(44.0930268181818, -116.946878),
                    new Vector(44.0902998181818, -116.963447),
                    new Vector(44.0738928181818, -116.976821),
                    new Vector(44.0141958181818, -116.933594),
                    new Vector(43.9631928181819, -116.967947),
                    new Vector(43.9285788181819, -116.959712),
                    new Vector(43.9044498181819, -116.978144),
                    new Vector(43.8734718181819, -116.978144),
                    new Vector(43.8593508181818, -116.985776),
                    new Vector(43.8529698181818, -117.016214),
                    new Vector(43.8397758181819, -117.010499),
                    new Vector(43.8315768181819, -117.027617),
                    new Vector(43.8001488181819, -117.03713),
                    new Vector(43.7536998181819, -117.023792),
                    new Vector(43.6790268181819, -117.026294),
                    new Vector(41.994793818182, -117.01886),
                    new Vector(41.994793818182, -116.992319),
                    new Vector(41.9945958181819, -115.947545),
                    new Vector(41.9965128181819, -115.024865),
                    new Vector(42.7647348181819, -115.026656),
                    new Vector(42.9066288181819, -115.02761),
                    new Vector(42.9084108181819, -115.055717),
                    new Vector(42.9191838181819, -115.076687),
                    new Vector(43.1893548181819, -115.074788),
                    new Vector(43.5912048181818, -115.072961),
                    new Vector(43.5952638181819, -115.038716),
                    new Vector(43.6182408181818, -115.022255),
                    new Vector(43.6588308181819, -115.026782),
                    new Vector(43.7017068181819, -115.001483),
                    new Vector(43.7350158181819, -115.03598),
                    new Vector(43.7935788181819, -115.023524),
                    new Vector(43.8614748181819, -114.964439),
                    new Vector(43.9031898181819, -114.982241),
                    new Vector(43.9339608181819, -114.968003),
                    new Vector(43.9675128181819, -114.957464),
                    new Vector(43.9746408181819, -114.976319),
                    new Vector(43.9974288181818, -114.976913),
                    new Vector(44.0090928181818, -115.025531),
                    new Vector(44.0289288181818, -115.041488),
                    new Vector(44.0493948181818, -115.038995),
                    new Vector(44.0672958181818, -115.017485),
                    new Vector(44.0751348181819, -114.993059),
                    new Vector(44.0852238181819, -114.997217),
                    new Vector(44.0947278181819, -115.023056),
                    new Vector(44.1099828181818, -115.03787),
                    new Vector(44.1291978181819, -115.011851),
                    new Vector(44.141590818182, -115.017854),
                    new Vector(44.1504378181819, -115.030346),
                    new Vector(44.1554688181818, -115.062701),
                    new Vector(44.1689418181819, -115.080161),
                    new Vector(44.1659988181819, -115.097459),
                    new Vector(44.1864018181818, -115.121741),
                    new Vector(44.1946278181819, -115.155959),
                    new Vector(44.2262538181819, -115.168478),
                    new Vector(44.2434258181818, -115.157822),
                    new Vector(44.2800738181818, -115.170863),
                    new Vector(44.2791018181819, -115.199627),
                    new Vector(44.3039328181819, -115.215575),
                    new Vector(44.3069928181818, -115.239758),
                    new Vector(44.3226618181819, -115.252133),
                    new Vector(44.3308248181819, -115.284497),
                    new Vector(44.3516328181819, -115.271834),
                    new Vector(44.3623068181819, -115.251098),
                    new Vector(44.4215988181818, -115.217591),
                    new Vector(44.4998538181818, -115.238579),
                    new Vector(44.5080168181818, -115.269116),
                    new Vector(44.5223448181818, -115.284128),
                    new Vector(44.5608018181817, -115.294685),
                    new Vector(44.5780548181818, -115.288475),
                    new Vector(44.5978908181818, -115.270664),
                    new Vector(44.5967478181818, -115.252727),
                    new Vector(44.6076648181818, -115.249883),
                    new Vector(44.6150718181818, -115.190024),
                    new Vector(44.668333818182, -115.148156),
                    new Vector(44.7051168181818, -115.135583),
                    new Vector(44.7293538181818, -115.139408),
                    new Vector(44.7572358181818, -115.077551),
                    new Vector(44.7369048181819, -115.029284),
                    new Vector(44.7123348181819, -115.003013),
                    new Vector(44.7146118181819, -114.941912),
                    new Vector(44.7634098181818, -114.881891),
                    new Vector(44.7701238181818, -114.845027),
                    new Vector(44.7974208181819, -114.811349),
                    new Vector(44.8294788181818, -114.790352),
                    new Vector(44.8319088181819, -114.771605),
                    new Vector(44.8417818181819, -114.760985),
                    new Vector(44.8582968181818, -114.766214),
                    new Vector(44.8616808181819, -114.749996),
                    new Vector(44.8800408181818, -114.728783),
                    new Vector(44.9604738181819, -114.733166),
                    new Vector(44.9926308181818, -114.717884),
                    new Vector(45.1307178181818, -114.727406),
                    new Vector(45.16705981818189, -114.715184),
                    new Vector(45.1849338181818, -114.691928),
                    new Vector(45.2257218181817, -114.672389),
                    new Vector(45.2843028181818, -114.599714),
                    new Vector(45.3129138181819, -114.642131),
                    new Vector(45.38356381818189, -114.709739),
                    new Vector(45.3928158181818, -114.743822),
                    new Vector(45.4228668181819, -114.763595),
                    new Vector(45.4339548181818, -114.798947),
                    new Vector(45.4768218181818, -114.792323),
                    new Vector(45.4963068181819, -114.781928),
                    new Vector(45.50014081818189, -114.764252),
                    new Vector(45.4639338181819, -114.678392),
                    new Vector(45.4631958181818, -114.662174),
                    new Vector(45.51295681818181, -114.63116),
                    new Vector(45.5236488181819, -114.589157),
                    new Vector(45.548740818182, -114.560924),
                    new Vector(45.5963958181818, -114.540953),
                    new Vector(45.6242688181819, -114.564686),
                    new Vector(45.652393818182, -114.501749),
                    new Vector(45.6740568181818, -114.510713),
                    new Vector(45.6943968181819, -114.497573),
                    new Vector(45.722998818182, -114.534977),
                    new Vector(45.7460028181818, -114.541952),
                    new Vector(45.762400818182, -114.563534),
                    new Vector(45.8100648181818, -114.517373),
                    new Vector(45.8426808181819, -114.499166),
                    new Vector(45.8394768181819, -114.473804),
                    new Vector(45.8526168181818, -114.443231),
                    new Vector(45.8464518181819, -114.407528),
                    new Vector(45.87087781818181, -114.392831),
                    new Vector(45.91065781818179, -114.41354),
                    new Vector(45.9214848181818, -114.42947),
                    new Vector(45.9539838181819, -114.405296),
                    new Vector(45.97197481818191, -114.412442),
                    new Vector(45.9898128181819, -114.484451),
                    new Vector(46.0097658181818, -114.474524),
                    new Vector(46.0234098181818, -114.494315),
                    new Vector(46.0508148181818, -114.465758),
                    new Vector(46.08222481818189, -114.456029),
                    new Vector(46.10735281818179, -114.477377),
                    new Vector(46.1161458181819, -114.506573),
                    new Vector(46.13606281818189, -114.518948),
                    new Vector(46.15741981818191, -114.509615),
                    new Vector(46.15525981818189, -114.467018),
                    new Vector(46.1689758181818, -114.440882),
                    new Vector(46.2202578181819, -114.439559),
                    new Vector(46.243783818182, -114.472832),
                    new Vector(46.2529638181819, -114.473795),
                    new Vector(46.2847068181818, -114.431801),
                    new Vector(46.3929048181819, -114.409796),
                    new Vector(46.3995468181818, -114.397016),
                    new Vector(46.4281848181819, -114.384029),
                    new Vector(46.48736881818189, -114.410705),
                    new Vector(46.5061248181819, -114.360476),
                    new Vector(46.5173928181819, -114.350108),
                    new Vector(46.58788081818189, -114.343322),
                    new Vector(46.6228368181819, -114.32471),
                    new Vector(46.6542288181819, -114.334682),
                    new Vector(46.66159981818179, -114.38402),
                    new Vector(46.6457148181819, -114.441539),
                    new Vector(46.62357481818191, -114.484721),
                    new Vector(46.6378938181818, -114.540386),
                    new Vector(46.6290468181818, -114.610829),
                    new Vector(46.6608258181819, -114.644732),
                    new Vector(46.6709148181819, -114.645038),
                    new Vector(46.6871058181819, -114.625931),
                    new Vector(46.7347158181819, -114.673892),
                    new Vector(46.7337618181818, -114.698426),
                    new Vector(46.6951338181819, -114.748097),
                    new Vector(46.7030358181818, -114.782918),
                    new Vector(46.75572181818189, -114.777833),
                    new Vector(46.7665308181819, -114.794033),
                    new Vector(46.77553981818189, -114.840797),
                    new Vector(46.79704981818171, -114.8666),
                    new Vector(46.79943481818191, -114.90233),
                    new Vector(46.8524448181818, -114.94841),
                    new Vector(46.8908928181819, -114.940571),
                    new Vector(46.9071648181818, -114.924119),
                    new Vector(46.9252098181818, -114.964727),
                    new Vector(46.9588068181818, -115.001573),
                    new Vector(46.96300081818189, -115.037339),
                    new Vector(46.9733508181819, -115.055636),
                    new Vector(47.0265228181818, -115.08134),
                    new Vector(47.0635578181819, -115.135511),
                    new Vector(47.09174581818181, -115.148678),
                    new Vector(47.0975688181819, -115.172492),
                    new Vector(47.1240288181818, -115.193075),
                    new Vector(47.1795588181819, -115.296233),
                    new Vector(47.24515081818191, -115.325231),
                    new Vector(47.255014818182, -115.343663),
                    new Vector(47.2635918181818, -115.408211),
                    new Vector(47.2743738181818, -115.426643),
                    new Vector(47.2816458181819, -115.501937),
                    new Vector(47.2919778181819, -115.52306),
                    new Vector(47.3346108181819, -115.555505),
                    new Vector(47.3699988181818, -115.599533),
                    new Vector(47.38004281818179, -115.638773),
                    new Vector(47.3991678181819, -115.666484),
                    new Vector(47.4224688181819, -115.750328),
                    new Vector(47.4339618181818, -115.750103),
                    new Vector(47.4453018181818, -115.732481),
                    new Vector(47.449180818182, -115.656089),
                    new Vector(47.4577938181819, -115.643183),
                    new Vector(47.4752358181819, -115.640141),
                    new Vector(47.4895368181818, -115.692773),
                    new Vector(47.5208928181818, -115.701521),
                    new Vector(47.53369081818191, -115.742831),
                    new Vector(47.59071481818189, -115.692089),
                    new Vector(47.6160858181818, -115.698281),
                    new Vector(47.6398818181819, -115.734065),
                    new Vector(47.6955558181818, -115.733669),
                    new Vector(47.7097398181818, -115.775726),
                    new Vector(47.744839818182, -115.790549),
                    new Vector(47.75627881818181, -115.836746),
                    new Vector(47.8051848181819, -115.849328),
                    new Vector(47.8274508181818, -115.869803),
                    new Vector(47.84107681818189, -115.903931),
                    new Vector(47.86712281818191, -115.937843),
                    new Vector(47.925136818182, -115.998926),
                    new Vector(47.96493481818191, -116.025314),
                    new Vector(47.9761938181819, -116.053493),
                    new Vector(48.2084838181818, -116.0555),
                    new Vector(48.4986618181819, -116.056688),
                    new Vector(48.9999528181818, -116.063528),
                    new Vector(48.9999258181819, -117.032054),
                    new Vector(48.8380698181818, -117.02912),
                    new Vector(48.0461778181818, -117.038867),
                    new Vector(47.97109081818191, -117.037472),
                    new Vector(47.3614488181819, -117.041792),
                    new Vector(47.2584978181818, -117.042395),
                    new Vector(47.11932181818181, -117.040973),
                    new Vector(46.5365988181818, -117.041927),
                    new Vector(46.4279778181819, -117.038552),
                    new Vector(46.3885758181819, -117.044474),
                    new Vector(46.34869681818181, -117.064175),
                    new Vector(46.33543081818191, -117.027986),
                    new Vector(46.30244581818189, -117.001652),
                    new Vector(46.2493098181819, -116.972726),
                    new Vector(46.1975508181818, -116.967488),
                    new Vector(46.1654838181819, -116.929418),
                    new Vector(46.0972728181818, -116.961647),
                    new Vector(46.07850781818179, -116.987207),
                    new Vector(46.0656918181818, -116.957723),
                    new Vector(45.9951768181818, -116.91914),
                    new Vector(45.9805158181818, -116.898197),
                    new Vector(45.9036018181819, -116.856473),
                    new Vector(45.84586681818179, -116.791268),
                    new Vector(45.81976681818181, -116.773709),
                    new Vector(45.8191728181819, -116.703185),
                    new Vector(45.7806258181819, -116.654396),
                    new Vector(45.7474248181819, -116.560625),
                    new Vector(45.71072281818181, -116.52827),
                    new Vector(45.6644898181818, -116.514914),
                    new Vector(45.6062508181818, -116.470409),
                    new Vector(45.5660568181819, -116.478554),
                    new Vector(45.4936428181818, -116.554496),
                    new Vector(45.4598658181818, -116.565773),
                    new Vector(45.3354048181819, -116.672261),
                    new Vector(45.2623518181819, -116.688821),
                    new Vector(45.13730581818169, -116.736584),
                    new Vector(45.1063008181818, -116.761262),
                    new Vector(45.0994788181819, -116.778092),
                    new Vector(45.0757548181818, -116.7872),
                    new Vector(45.0497538181818, -116.807306),
                    new Vector(45.0169488181818, -116.854511),
                    new Vector(45.0000468181819, -116.848103),
                    new Vector(44.9799678181819, -116.855888),
                    new Vector(44.9717418181818, -116.848166),
                    new Vector(44.9726328181819, -116.831399),
                    new Vector(44.9548578181819, -116.847563),
                    new Vector(44.9201448181818, -116.835395),
                    new Vector(44.8686108181818, -116.867075),
                    new Vector(44.8485588181819, -116.89736),
                    new Vector(44.8289388181819, -116.909618),
                    new Vector(44.7760368181819, -116.951495),
                    new Vector(44.749117818182, -117.039569),
                    new Vector(44.6975568181819, -117.066515),
                    new Vector(44.6893398181818, -117.079358),
                    new Vector(44.5725288181818, -117.130496),
                    new Vector(44.5592898181819, -117.143933),
                    new Vector(44.5346568181819, -117.145166),
                    new Vector(44.5118058181818, -117.187394),
                    new Vector(44.4857778181819, -117.203963),
                    new Vector(44.4729888181819, -117.224411),
                    new Vector(44.4278538181819, -117.21722),
                    new Vector(44.3899818181818, -117.236921),
                    new Vector(44.3394378181819, -117.201596),
                    new Vector(44.3006658181818, -117.217463)
                })
            }
        };
    }
}