using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Arkansas_South_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 3434;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Arkansas South";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Arkansas South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,34.76666666666667],PARAMETER[standard_parallel_2,33.3],PARAMETER[latitude_of_origin,32.66666666666666],PARAMETER[central_meridian,-92],PARAMETER[false_easting,1312333.3333],PARAMETER[false_northing,1312333.3333],AUTHORITY[EPSG,3434],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Arkansas South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,34.76666666666667],PARAMETER[standard_parallel_2,33.3],PARAMETER[latitude_of_origin,32.66666666666666],PARAMETER[central_meridian,-92],PARAMETER[false_easting,1312333.3333],PARAMETER[false_northing,1312333.3333],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(33.2704548181819, -94.03669399999998),
                    new Vector(33.023413818182, -94.038935),
                    new Vector(33.0227298181819, -93.80993000000001),
                    new Vector(33.0212898181819, -93.51192200000001),
                    new Vector(33.0215238181819, -93.47907200000002),
                    new Vector(33.0193728181819, -93.23254399999999),
                    new Vector(33.0182748181819, -92.97898699999999),
                    new Vector(33.0168348181818, -92.71724),
                    new Vector(33.0101568181819, -92.06344400000002),
                    new Vector(33.0139998181818, -91.4544769999999),
                    new Vector(33.0135498181818, -91.42764800000002),
                    new Vector(33.0136038181819, -91.25473099999989),
                    new Vector(33.0131628181818, -91.16224699999999),
                    new Vector(33.0218388181818, -91.16077999999999),
                    new Vector(33.0405588181819, -91.15679299999998),
                    new Vector(33.0473898181819, -91.12408699999999),
                    new Vector(33.0656868181818, -91.117904),
                    new Vector(33.0907698181819, -91.14690200000001),
                    new Vector(33.1133418181818, -91.190642),
                    new Vector(33.1405848181819, -91.19561),
                    new Vector(33.1504128181818, -91.177736),
                    new Vector(33.1311888181818, -91.121432),
                    new Vector(33.1452108181819, -91.095962),
                    new Vector(33.1617258181819, -91.086431),
                    new Vector(33.2258148181819, -91.09211000000001),
                    new Vector(33.2459028181818, -91.0546429999999),
                    new Vector(33.2820378181819, -91.04053999999999),
                    new Vector(33.2936928181819, -91.053932),
                    new Vector(33.2924688181818, -91.07642300000001),
                    new Vector(33.2493228181818, -91.103009),
                    new Vector(33.2686278181819, -91.12261100000001),
                    new Vector(33.3225018181818, -91.1418529999999),
                    new Vector(33.3595188181818, -91.13053999999991),
                    new Vector(33.3935208181817, -91.1070409999999),
                    new Vector(33.4102878181819, -91.078799),
                    new Vector(33.4319058181818, -91.061627),
                    new Vector(33.4601298181819, -91.061087),
                    new Vector(33.4663218181819, -91.07386700000001),
                    new Vector(33.4629738181818, -91.085909),
                    new Vector(33.4150128181819, -91.099238),
                    new Vector(33.3889938181819, -91.137749),
                    new Vector(33.3919458181819, -91.185089),
                    new Vector(33.414418818182, -91.204277),
                    new Vector(33.4222308181819, -91.1989489999999),
                    new Vector(33.443236818182, -91.13063),
                    new Vector(33.4529478181818, -91.119821),
                    new Vector(33.4697868181819, -91.11906500000001),
                    new Vector(33.4933128181819, -91.12891099999999),
                    new Vector(33.5118888181818, -91.16509100000002),
                    new Vector(33.5044818181818, -91.174289),
                    new Vector(33.4667538181819, -91.171841),
                    new Vector(33.4475028181818, -91.18188499999988),
                    new Vector(33.4435518181819, -91.23296000000001),
                    new Vector(33.4595628181818, -91.22726300000001),
                    new Vector(33.4735128181818, -91.207751),
                    new Vector(33.5121228181818, -91.18051699999998),
                    new Vector(33.5234628181818, -91.18295600000002),
                    new Vector(33.5386188181819, -91.20421399999989),
                    new Vector(33.5393928181818, -91.213601),
                    new Vector(33.5564658181819, -91.227749),
                    new Vector(33.5905938181818, -91.226849),
                    new Vector(33.5747898181819, -91.187915),
                    new Vector(33.5773548181818, -91.168133),
                    new Vector(33.6162708181819, -91.1507629999999),
                    new Vector(33.6371418181819, -91.154516),
                    new Vector(33.6700548181819, -91.20542),
                    new Vector(33.6908358181818, -91.21525699999999),
                    new Vector(33.7090698181819, -91.211792),
                    new Vector(33.7184298181818, -91.163408),
                    new Vector(33.6776328181819, -91.12115299999989),
                    new Vector(33.6627018181817, -91.0838839999999),
                    new Vector(33.6833298181818, -91.037948),
                    new Vector(33.7055958181818, -91.038938),
                    new Vector(33.7194648181818, -91.05631699999989),
                    new Vector(33.7083498181818, -91.10468299999999),
                    new Vector(33.7125528181819, -91.12905499999999),
                    new Vector(33.7233348181818, -91.13810900000001),
                    new Vector(33.7719258181818, -91.142996),
                    new Vector(33.7801878181818, -91.137101),
                    new Vector(33.7765428181819, -91.105529),
                    new Vector(33.7866408181818, -91.066496),
                    new Vector(33.7696668181819, -91.04350999999998),
                    new Vector(33.7640778181819, -91.018535),
                    new Vector(33.7716648181819, -90.99548600000001),
                    new Vector(33.7854528181819, -90.984146),
                    new Vector(33.7990068181818, -90.990482),
                    new Vector(33.8166918181819, -91.028966),
                    new Vector(33.8436378181819, -91.05493100000001),
                    new Vector(33.8671908181818, -91.061483),
                    new Vector(33.9364098181819, -91.01857099999999),
                    new Vector(33.9747498181819, -91.07581999999999),
                    new Vector(33.9945768181819, -91.08896000000001),
                    new Vector(34.0061958181819, -91.0698079999999),
                    new Vector(33.9858108181817, -91.031171),
                    new Vector(33.9906348181819, -91.009652),
                    new Vector(33.9684858181818, -91.000364),
                    new Vector(33.9609258181819, -90.98692699999998),
                    new Vector(33.9675768181819, -90.964904),
                    new Vector(33.9789798181818, -90.9612319999999),
                    new Vector(33.9947118181819, -90.97538),
                    new Vector(34.0111008181819, -90.973472),
                    new Vector(34.0313868181819, -90.95057600000001),
                    new Vector(34.0408188181819, -90.88645099999999),
                    new Vector(34.1010648181819, -90.866435),
                    new Vector(34.1028558181819, -90.90642200000001),
                    new Vector(34.1260488181819, -90.9423589999999),
                    new Vector(34.1559108181818, -90.953456),
                    new Vector(34.1857548181818, -90.92903),
                    new Vector(34.1476578181818, -90.846716),
                    new Vector(34.1487648181819, -90.82897699999999),
                    new Vector(34.1662788181819, -90.80761999999999),
                    new Vector(34.1906508181819, -90.82302799999999),
                    new Vector(34.2049338181819, -90.921587),
                    new Vector(34.2347778181818, -90.93381799999999),
                    new Vector(34.2503028181819, -90.92854400000002),
                    new Vector(34.2192618181818, -90.8635189999999),
                    new Vector(34.2296388181819, -90.831461),
                    new Vector(34.2774468181818, -90.82394600000001),
                    new Vector(34.2994518181819, -90.80653100000002),
                    new Vector(34.3000638181819, -90.79263499999999),
                    new Vector(34.2790848181818, -90.758363),
                    new Vector(34.317829818182, -90.74786000000002),
                    new Vector(34.3640178181819, -90.76196299999999),
                    new Vector(34.3722708181819, -90.75542000000002),
                    new Vector(34.3779768181819, -90.68758699999999),
                    new Vector(34.3634958181819, -90.681242),
                    new Vector(34.3202418181818, -90.689486),
                    new Vector(34.3180818181818, -90.679433),
                    new Vector(34.3301058181819, -90.65791400000002),
                    new Vector(34.3660158181818, -90.657347),
                    new Vector(34.4046978181819, -90.603887),
                    new Vector(34.4331018181818, -90.57922699999999),
                    new Vector(34.454044818182, -90.574511),
                    new Vector(34.4966058181819, -90.590153),
                    new Vector(34.5203298181819, -90.58045099999998),
                    new Vector(34.5326058181819, -90.565781),
                    new Vector(34.5434238181819, -90.53725100000001),
                    new Vector(34.5557538181819, -90.53071699999998),
                    new Vector(34.6048488181819, -90.57771499999998),
                    new Vector(34.6279158181817, -90.58809199999999),
                    new Vector(34.6457088181819, -90.579407),
                    new Vector(34.7003838181819, -90.56116400000001),
                    new Vector(34.6860468181819, -90.539168),
                    new Vector(34.6519098181818, -90.54765500000001),
                    new Vector(34.6369878181819, -90.53906000000001),
                    new Vector(34.6381668181819, -90.50891900000001),
                    new Vector(34.6721328181819, -90.46633100000001),
                    new Vector(34.7043528181818, -90.470084),
                    new Vector(34.7021748181819, -90.513662),
                    new Vector(34.7133528181818, -90.53338100000001),
                    new Vector(34.7904378181819, -90.547844),
                    new Vector(34.8074208181818, -90.52736),
                    new Vector(34.8057018181818, -90.51614600000001),
                    new Vector(34.7899248181819, -90.50138599999988),
                    new Vector(34.7658858181819, -90.498839),
                    new Vector(34.7484708181819, -90.517073),
                    new Vector(34.7299578181819, -90.504518),
                    new Vector(34.7269338181818, -90.48602300000002),
                    new Vector(34.7412978181819, -90.45153499999989),
                    new Vector(34.7608458181818, -90.44897),
                    new Vector(34.7997618181819, -90.466808),
                    new Vector(34.8253218181818, -90.452012),
                    new Vector(34.8578298181819, -90.474818),
                    new Vector(34.8810138181819, -90.47062399999999),
                    new Vector(34.886278818182, -90.4381879999999),
                    new Vector(34.8727338181819, -90.42794600000002),
                    new Vector(34.8354558181819, -90.433643),
                    new Vector(34.8323598181818, -90.422411),
                    new Vector(34.8411348181819, -90.40402400000002),
                    new Vector(34.9051608181818, -90.40478),
                    new Vector(34.9137198181819, -91.093919),
                    new Vector(34.8718878181817, -91.09696999999991),
                    new Vector(34.8724908181819, -91.11939800000002),
                    new Vector(34.9147188181819, -91.120289),
                    new Vector(34.9152678181819, -91.146101),
                    new Vector(35.006977818182, -91.14749600000002),
                    new Vector(35.0074818181819, -91.23845900000001),
                    new Vector(34.9810938181819, -91.24178000000001),
                    new Vector(34.9817958181819, -91.285574),
                    new Vector(34.9136838181819, -91.28567299999999),
                    new Vector(34.9134138181818, -91.36079599999999),
                    new Vector(35.0569998181819, -91.355846),
                    new Vector(35.0643078181819, -91.465007),
                    new Vector(35.0695818181818, -91.475825),
                    new Vector(35.0691678181818, -91.44603499999999),
                    new Vector(35.0769798181818, -91.44005900000001),
                    new Vector(35.0956818181818, -91.463009),
                    new Vector(35.0941158181819, -91.579874),
                    new Vector(35.0350758181819, -91.580522),
                    new Vector(35.0335998181818, -91.586651),
                    new Vector(35.0297208181818, -91.62586399999989),
                    new Vector(35.0547138181819, -91.64958800000001),
                    new Vector(35.0690148181818, -91.71123799999988),
                    new Vector(35.0432838181819, -91.798106),
                    new Vector(35.0282358181819, -91.8695479999999),
                    new Vector(35.0472348181818, -91.91787799999999),
                    new Vector(35.0474688181818, -91.9504759999999),
                    new Vector(35.0738568181819, -92.013125),
                    new Vector(35.0754498181818, -92.065442),
                    new Vector(35.0689248181818, -92.0933239999999),
                    new Vector(35.0733618181819, -92.11876700000001),
                    new Vector(35.0224578181819, -92.12038699999998),
                    new Vector(35.0241408181818, -92.22604699999998),
                    new Vector(34.9286418181818, -92.23051099999989),
                    new Vector(34.9343208181818, -92.410223),
                    new Vector(34.9210818181819, -92.412536),
                    new Vector(34.9116678181817, -92.426198),
                    new Vector(34.8613488181818, -92.4399769999999),
                    new Vector(34.8701508181819, -92.45096599999989),
                    new Vector(34.9097778181819, -92.446871),
                    new Vector(34.9448508181818, -92.461127),
                    new Vector(34.9526448181819, -92.47657100000002),
                    new Vector(34.9578108181819, -92.540741),
                    new Vector(34.9359048181818, -92.544377),
                    new Vector(34.9404498181818, -92.64778700000001),
                    new Vector(34.9108668181819, -92.64995600000002),
                    new Vector(34.9098858181819, -92.752556),
                    new Vector(34.8544458181819, -92.75245699999988),
                    new Vector(34.8538518181818, -92.74121599999989),
                    new Vector(34.8311628181819, -92.740262),
                    new Vector(34.838254818182, -92.779223),
                    new Vector(34.8588468181819, -92.82270200000001),
                    new Vector(34.8624018181819, -93.072317),
                    new Vector(34.7755158181818, -93.075017),
                    new Vector(34.7767038181818, -93.28340300000002),
                    new Vector(34.7788098181819, -93.385436),
                    new Vector(34.7505858181819, -93.386813),
                    new Vector(34.7541768181819, -93.703919),
                    new Vector(34.7560938181819, -93.73874899999988),
                    new Vector(34.7402538181819, -93.736751),
                    new Vector(34.7426658181819, -93.770483),
                    new Vector(34.7285628181818, -93.77081599999988),
                    new Vector(34.7280948181819, -93.80830099999999),
                    new Vector(34.7134698181819, -93.810281),
                    new Vector(34.7137938181819, -93.86292199999998),
                    new Vector(34.6988628181818, -93.86094199999999),
                    new Vector(34.6998528181818, -93.87108499999999),
                    new Vector(34.6784598181819, -93.871544),
                    new Vector(34.6791888181818, -93.924734),
                    new Vector(34.6878738181819, -93.92355499999999),
                    new Vector(34.6898808181818, -94.025516),
                    new Vector(34.6957038181819, -94.02809900000001),
                    new Vector(34.7029668181819, -94.31287699999999),
                    new Vector(34.7285268181818, -94.31054600000002),
                    new Vector(34.7356098181818, -94.44596),
                    new Vector(34.508440818182, -94.452629),
                    new Vector(34.1967618181818, -94.46169199999999),
                    new Vector(33.9393078181818, -94.468586),
                    new Vector(33.6320838181819, -94.47669499999999),
                    new Vector(33.6365658181818, -94.436114),
                    new Vector(33.6169638181819, -94.43653699999999),
                    new Vector(33.6044628181818, -94.451756),
                    new Vector(33.5966148181819, -94.443539),
                    new Vector(33.5972538181818, -94.42867099999999),
                    new Vector(33.5736018181818, -94.406774),
                    new Vector(33.5750778181819, -94.39361599999999),
                    new Vector(33.5934468181819, -94.37931500000002),
                    new Vector(33.5901618181819, -94.37082799999999),
                    new Vector(33.5727828181819, -94.372511),
                    new Vector(33.5604168181819, -94.39546099999998),
                    new Vector(33.5477988181819, -94.37096299999999),
                    new Vector(33.5732508181819, -94.328951),
                    new Vector(33.5570508181819, -94.302581),
                    new Vector(33.5799738181818, -94.29901700000002),
                    new Vector(33.5894508181819, -94.27918099999991),
                    new Vector(33.5847258181819, -94.27227800000001),
                    new Vector(33.5618568181819, -94.27474399999998),
                    new Vector(33.5925468181819, -94.23743899999999),
                    new Vector(33.5858328181818, -94.223237),
                    new Vector(33.5616588181819, -94.235567),
                    new Vector(33.5581128181819, -94.21107800000001),
                    new Vector(33.5852028181819, -94.20554300000002),
                    new Vector(33.5938878181818, -94.15970600000001),
                    new Vector(33.5672118181819, -94.155368),
                    new Vector(33.5731158181817, -94.09889299999999),
                    new Vector(33.5840688181819, -94.08684200000002),
                    new Vector(33.5773368181819, -94.0616239999999),
                    new Vector(33.5560338181818, -94.03611799999999),
                    new Vector(33.2704548181819, -94.03669399999998)
                })
            }
        };
    }
}