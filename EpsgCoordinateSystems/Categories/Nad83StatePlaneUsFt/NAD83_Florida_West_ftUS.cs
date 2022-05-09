using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Florida_West_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2237;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Florida West";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Florida West (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",24.33333333333333],PARAMETER[\"central_meridian\",-82],PARAMETER[\"scale_factor\",0.999941177],PARAMETER[\"false_easting\",656166.667],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2237\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Florida West (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",24.33333333333333],PARAMETER[\"central_meridian\",-82],PARAMETER[\"scale_factor\",0.999941177],PARAMETER[\"false_easting\",656166.667],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(27.0044118181819, -82.25746700000001),
                    new Vector(26.9370648181819, -82.153211),
                    new Vector(26.9765568181818, -82.012694),
                    new Vector(27.0316728181819, -81.992858),
                    new Vector(27.0316818181819, -81.9791869999999),
                    new Vector(26.9630568181818, -81.99143599999999),
                    new Vector(26.9217828181818, -82.09787),
                    new Vector(26.866711818182, -82.05176299999999),
                    new Vector(26.7669738181818, -82.068269),
                    new Vector(26.7157908181817, -82.083668),
                    new Vector(26.5246848181818, -82.021469),
                    new Vector(26.550721818182, -81.944456),
                    new Vector(26.6637618181819, -81.897098),
                    new Vector(26.7102648181819, -81.773915),
                    new Vector(26.6429898181818, -81.88427299999999),
                    new Vector(26.5349808181818, -81.928769),
                    new Vector(26.5173858181819, -81.96811700000001),
                    new Vector(26.4675618181818, -81.94201700000001),
                    new Vector(26.4395538181818, -81.86421199999999),
                    new Vector(26.3322018181818, -81.84935299999999),
                    new Vector(26.3304108181817, -81.81797899999999),
                    new Vector(26.3183598181819, -81.817475),
                    new Vector(26.3176488181819, -81.6574099999999),
                    new Vector(26.4239748181819, -81.655736),
                    new Vector(26.4220398181819, -81.566816),
                    new Vector(26.5135158181819, -81.564701),
                    new Vector(26.7671628181818, -81.561785),
                    new Vector(27.0309438181818, -81.56347700000001),
                    new Vector(27.339580818182, -81.561065),
                    new Vector(27.6444468181819, -81.563405),
                    new Vector(27.6433848181818, -81.137192),
                    new Vector(27.6653538181819, -81.133493),
                    new Vector(27.6830478181819, -81.14900900000001),
                    new Vector(27.7205508181819, -81.153266),
                    new Vector(27.7327098181818, -81.168566),
                    new Vector(27.7670718181819, -81.1750279999999),
                    new Vector(27.7839648181819, -81.193703),
                    new Vector(27.8229978181819, -81.213314),
                    new Vector(27.8439048181819, -81.240548),
                    new Vector(27.8437338181819, -81.270887),
                    new Vector(27.8613738181818, -81.297275),
                    new Vector(27.8922258181819, -81.3086059999999),
                    new Vector(27.999343818182, -81.386267),
                    new Vector(28.0032948181819, -81.41697499999999),
                    new Vector(28.0321398181818, -81.43672100000001),
                    new Vector(28.0454868181819, -81.46080499999999),
                    new Vector(28.0518498181819, -81.45844699999989),
                    new Vector(28.0537578181819, -81.43619),
                    new Vector(28.0414908181819, -81.4285399999999),
                    new Vector(28.039960818182, -81.4126279999999),
                    new Vector(28.0174878181818, -81.37920200000001),
                    new Vector(28.0522188181819, -81.348647),
                    new Vector(28.0811088181818, -81.34569500000001),
                    new Vector(28.080532818182, -81.450383),
                    new Vector(28.1376918181819, -81.4522819999999),
                    new Vector(28.1405628181818, -81.5161279999999),
                    new Vector(28.1875788181819, -81.518045),
                    new Vector(28.2583188181818, -81.564305),
                    new Vector(28.2604158181818, -81.659795),
                    new Vector(28.3436658181819, -81.65912),
                    new Vector(28.3408488181819, -81.78747799999989),
                    new Vector(28.3589208181818, -81.791348),
                    new Vector(28.3588848181819, -81.85702999999999),
                    new Vector(28.3418838181819, -81.85776799999999),
                    new Vector(28.34280181818181, -81.953384),
                    new Vector(28.9571778181819, -81.950828),
                    new Vector(28.9580238181819, -81.654404),
                    new Vector(29.05185781818181, -81.658427),
                    new Vector(29.0516238181818, -81.63914),
                    new Vector(29.28359881818181, -81.643568),
                    new Vector(29.3103378181819, -81.672674),
                    new Vector(29.3260968181818, -81.677183),
                    new Vector(29.3366268181817, -81.676697),
                    new Vector(29.3392278181819, -81.65930899999999),
                    new Vector(29.3577588181819, -81.664214),
                    new Vector(29.3692428181818, -81.67782200000001),
                    new Vector(29.3731488181818, -81.736799),
                    new Vector(29.4265188181819, -81.741191),
                    new Vector(29.4284988181819, -81.77201599999999),
                    new Vector(29.4837048181819, -81.776876),
                    new Vector(29.48716081818189, -81.838049),
                    new Vector(29.52817381818179, -81.843593),
                    new Vector(29.5205958181818, -81.863843),
                    new Vector(29.5244568181819, -81.883094),
                    new Vector(29.5130178181819, -81.897746),
                    new Vector(29.5200738181818, -81.930992),
                    new Vector(29.5142418181819, -81.934916),
                    new Vector(29.5121988181818, -81.970664),
                    new Vector(29.4776748181818, -82.052312),
                    new Vector(29.4561108181818, -82.05216799999999),
                    new Vector(29.4400728181819, -82.066964),
                    new Vector(29.4319908181818, -82.087205),
                    new Vector(29.4356898181818, -82.117436),
                    new Vector(29.422747818182, -82.143626),
                    new Vector(29.4323148181818, -82.201379),
                    new Vector(29.4526278181819, -82.20580699999989),
                    new Vector(29.4626268181818, -82.18760899999999),
                    new Vector(29.4880248181818, -82.208606),
                    new Vector(29.4850998181819, -82.405265),
                    new Vector(29.4809958181818, -82.5547729999999),
                    new Vector(29.5392438181818, -82.555322),
                    new Vector(29.5414128181819, -82.653836),
                    new Vector(29.5662168181819, -82.6556089999999),
                    new Vector(29.5641828181818, -82.75481600000001),
                    new Vector(29.5797618181818, -82.754825),
                    new Vector(29.5806528181818, -82.772105),
                    new Vector(29.5893738181818, -82.77234799999989),
                    new Vector(29.5900578181819, -82.85574200000001),
                    new Vector(29.5964748181819, -82.85554399999999),
                    new Vector(29.599759818182, -82.935716),
                    new Vector(29.5769808181819, -82.94167400000001),
                    new Vector(29.5496028181818, -82.9666399999999),
                    new Vector(29.5308468181818, -82.968251),
                    new Vector(29.5191828181818, -82.97908699999989),
                    new Vector(29.4812028181819, -82.982345),
                    new Vector(29.4370938181818, -83.018246),
                    new Vector(29.4055128181818, -83.020757),
                    new Vector(29.3810688181819, -83.055497),
                    new Vector(29.3638698181819, -83.06542399999999),
                    new Vector(29.3527818181819, -83.061554),
                    new Vector(29.3433408181818, -83.090597),
                    new Vector(29.3281848181819, -83.1089929999999),
                    new Vector(29.2996548181819, -83.142212),
                    new Vector(29.2656528181818, -83.07392899999989),
                    new Vector(29.17938781818181, -83.03674100000001),
                    new Vector(29.1551328181819, -82.8021559999999),
                    new Vector(29.0086668181818, -82.7553199999999),
                    new Vector(28.8847098181819, -82.6366189999999),
                    new Vector(28.8142848181819, -82.63652),
                    new Vector(28.8083808181819, -82.68138500000001),
                    new Vector(28.6927488181819, -82.63607),
                    new Vector(28.4285088181819, -82.6734739999999),
                    new Vector(28.1730258181819, -82.779143),
                    new Vector(27.8506458181819, -82.844285),
                    new Vector(27.6858738181817, -82.741001),
                    new Vector(27.7177698181819, -82.728167),
                    new Vector(27.8296578181819, -82.79384),
                    new Vector(27.7055928181819, -82.678325),
                    new Vector(27.7157268181818, -82.64462),
                    new Vector(27.8485308181818, -82.623659),
                    new Vector(27.8784648181818, -82.5642679999999),
                    new Vector(27.9405648181819, -82.72548500000001),
                    new Vector(27.9665838181817, -82.6447459999999),
                    new Vector(27.9753588181818, -82.70066300000001),
                    new Vector(28.0105218181819, -82.672718),
                    new Vector(28.0461708181818, -82.69833199999989),
                    new Vector(28.0071648181819, -82.65068599999999),
                    new Vector(28.0288458181819, -82.645565),
                    new Vector(27.9357228181818, -82.53898700000001),
                    new Vector(27.8312328181818, -82.51060099999999),
                    new Vector(27.8219448181817, -82.483133),
                    new Vector(27.9401508181819, -82.46100199999999),
                    new Vector(27.9062208181819, -82.398821),
                    new Vector(27.7916238181819, -82.4043829999999),
                    new Vector(27.6440148181819, -82.552496),
                    new Vector(27.6081048181818, -82.540049),
                    new Vector(27.5551938181819, -82.62637700000001),
                    new Vector(27.5822388181818, -82.55426),
                    new Vector(27.5527098181819, -82.569605),
                    new Vector(27.5366358181819, -82.638761),
                    new Vector(27.5123268181817, -82.57557199999999),
                    new Vector(27.5228658181819, -82.427171),
                    new Vector(27.5119938181819, -82.514201),
                    new Vector(27.4780638181819, -82.488263),
                    new Vector(27.524422818182, -82.681709),
                    new Vector(27.4935888181818, -82.665824),
                    new Vector(27.5034618181819, -82.638887),
                    new Vector(27.4738428181819, -82.68593),
                    new Vector(27.3866778181819, -82.5655639999999),
                    new Vector(27.3317958181819, -82.532732),
                    new Vector(27.2742858181819, -82.569956),
                    new Vector(27.2104578181819, -82.51448000000001),
                    new Vector(27.2602818181819, -82.53113),
                    new Vector(27.2369898181819, -82.506929),
                    new Vector(26.9472978181819, -82.380038),
                    new Vector(26.9479368181819, -82.368662),
                    new Vector(26.9985168181819, -82.398173),
                    new Vector(26.9488998181818, -82.355423),
                    new Vector(26.8498818181819, -82.28984),
                    new Vector(26.7901308181819, -82.153823),
                    new Vector(26.9136918181819, -82.17649400000001),
                    new Vector(26.997904818182, -82.25758399999999),
                    new Vector(27.0245538181819, -82.28218099999999),
                    new Vector(27.0044118181819, -82.25746700000001)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(26.5860828181819, -82.101947),
                    new Vector(26.6936868181818, -82.1286589999999),
                    new Vector(26.6834358181819, -82.183307),
                    new Vector(26.6426298181819, -82.135706),
                    new Vector(26.4939498181818, -82.09745599999999),
                    new Vector(26.4975678181819, -82.06695499999999),
                    new Vector(26.5860828181819, -82.101947)
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