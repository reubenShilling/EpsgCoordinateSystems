using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Kentucky_North_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2246;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kentucky North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Kentucky North (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",37.96666666666667],PARAMETER[\"standard_parallel_2\",38.96666666666667],PARAMETER[\"latitude_of_origin\",37.5],PARAMETER[\"central_meridian\",-84.25],PARAMETER[\"false_easting\",1640416.667],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2246\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Kentucky North (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",37.96666666666667],PARAMETER[\"standard_parallel_2\",38.96666666666667],PARAMETER[\"latitude_of_origin\",37.5],PARAMETER[\"central_meridian\",-84.25],PARAMETER[\"false_easting\",1640416.667],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(37.8831618181819, -82.622102),
                    new Vector(37.8901278181818, -82.608593),
                    new Vector(37.9163808181819, -82.60672099999999),
                    new Vector(37.9548468181819, -82.579712),
                    new Vector(37.9640898181819, -82.542542),
                    new Vector(37.9515168181819, -82.497497),
                    new Vector(37.9425078181819, -82.493402),
                    new Vector(37.9543968181818, -82.4801719999999),
                    new Vector(37.9759068181818, -82.47578),
                    new Vector(38.0156598181819, -82.524686),
                    new Vector(38.1099618181818, -82.59321199999989),
                    new Vector(38.1463308181819, -82.646123),
                    new Vector(38.1694338181819, -82.647158),
                    new Vector(38.1780918181818, -82.61376799999999),
                    new Vector(38.193823818182, -82.606649),
                    new Vector(38.238805818182, -82.616225),
                    new Vector(38.2453938181819, -82.589108),
                    new Vector(38.2559688181818, -82.57458200000001),
                    new Vector(38.2925088181818, -82.5800449999999),
                    new Vector(38.3078088181819, -82.57229599999999),
                    new Vector(38.3684598181818, -82.59823400000001),
                    new Vector(38.4125148181819, -82.5865969999999),
                    new Vector(38.4726708181818, -82.613741),
                    new Vector(38.5021368181818, -82.6697659999999),
                    new Vector(38.5391448181818, -82.695578),
                    new Vector(38.5530678181818, -82.7419459999999),
                    new Vector(38.5572888181819, -82.802363),
                    new Vector(38.571661818182, -82.826987),
                    new Vector(38.6004528181819, -82.853852),
                    new Vector(38.6523918181818, -82.860026),
                    new Vector(38.6832978181819, -82.8800059999999),
                    new Vector(38.7190098181819, -82.873193),
                    new Vector(38.742769818182, -82.890311),
                    new Vector(38.7464148181819, -82.92129799999999),
                    new Vector(38.7196488181818, -82.972481),
                    new Vector(38.7145098181819, -83.026949),
                    new Vector(38.6857278181819, -83.060879),
                    new Vector(38.6648388181819, -83.111243),
                    new Vector(38.6193348181819, -83.143157),
                    new Vector(38.6098488181818, -83.181938),
                    new Vector(38.6241768181819, -83.24500999999989),
                    new Vector(38.6092548181819, -83.2727569999999),
                    new Vector(38.5966368181818, -83.290046),
                    new Vector(38.5963218181818, -83.30652499999999),
                    new Vector(38.6065638181819, -83.320331),
                    new Vector(38.6319888181819, -83.3300239999999),
                    new Vector(38.6550018181819, -83.371415),
                    new Vector(38.6637768181818, -83.453621),
                    new Vector(38.6901378181819, -83.50006999999999),
                    new Vector(38.6961048181819, -83.526557),
                    new Vector(38.677969818182, -83.61838400000001),
                    new Vector(38.6649738181819, -83.63324299999999),
                    new Vector(38.6358678181819, -83.64318799999999),
                    new Vector(38.6238798181819, -83.65575200000001),
                    new Vector(38.6209278181819, -83.67853100000001),
                    new Vector(38.6355528181819, -83.7128299999999),
                    new Vector(38.6508168181819, -83.770223),
                    new Vector(38.6938458181819, -83.790464),
                    new Vector(38.7118818181819, -83.83753400000001),
                    new Vector(38.7449208181819, -83.85755899999999),
                    new Vector(38.7579618181818, -83.91254000000001),
                    new Vector(38.7776448181818, -83.962166),
                    new Vector(38.7637398181819, -84.053804),
                    new Vector(38.7655038181818, -84.08886800000001),
                    new Vector(38.7884988181819, -84.17675300000001),
                    new Vector(38.8126908181818, -84.228701),
                    new Vector(38.8745568181819, -84.23528899999999),
                    new Vector(38.9174778181819, -84.26152399999999),
                    new Vector(38.9445408181818, -84.29013500000001),
                    new Vector(39.0140748181818, -84.31331899999989),
                    new Vector(39.0378078181819, -84.345782),
                    new Vector(39.0357468181819, -84.3913129999999),
                    new Vector(39.0473388181818, -84.419735),
                    new Vector(39.0847248181818, -84.425684),
                    new Vector(39.1118238181818, -84.444917),
                    new Vector(39.1073598181818, -84.492059),
                    new Vector(39.0941928181818, -84.515297),
                    new Vector(39.0702618181818, -84.59306599999999),
                    new Vector(39.0749328181818, -84.622649),
                    new Vector(39.0896298181819, -84.66748699999999),
                    new Vector(39.142063818182, -84.74287099999999),
                    new Vector(39.1070358181818, -84.789923),
                    new Vector(39.1025808181818, -84.81147799999989),
                    new Vector(39.1036878181819, -84.827867),
                    new Vector(39.065041818182, -84.886709),
                    new Vector(39.0506418181819, -84.89000299999999),
                    new Vector(39.0328938181819, -84.876287),
                    new Vector(39.0058308181818, -84.844229),
                    new Vector(38.9827728181818, -84.834446),
                    new Vector(38.9546298181819, -84.846317),
                    new Vector(38.9276028181819, -84.875882),
                    new Vector(38.9094228181819, -84.875252),
                    new Vector(38.9020428181818, -84.859745),
                    new Vector(38.8971918181819, -84.8032249999999),
                    new Vector(38.8843848181818, -84.788663),
                    new Vector(38.8666458181819, -84.7874479999999),
                    new Vector(38.8344618181819, -84.8244289999999),
                    new Vector(38.7934128181819, -84.818786),
                    new Vector(38.7806418181818, -84.975611),
                    new Vector(38.7642888181818, -85.025075),
                    new Vector(38.7504288181818, -85.068455),
                    new Vector(38.7141408181819, -85.11965600000001),
                    new Vector(38.6951688181818, -85.160939),
                    new Vector(38.6958168181819, -85.20516499999999),
                    new Vector(38.7443718181818, -85.271387),
                    new Vector(38.7370098181819, -85.335008),
                    new Vector(38.7384138181818, -85.41818600000001),
                    new Vector(38.7248328181818, -85.44668900000001),
                    new Vector(38.6946738181819, -85.453682),
                    new Vector(38.5848378181818, -85.424396),
                    new Vector(38.5614738181819, -85.417466),
                    new Vector(38.5370208181819, -85.43237000000001),
                    new Vector(38.5181748181819, -85.466381),
                    new Vector(38.4714198181819, -85.50719599999999),
                    new Vector(38.4466698181819, -85.6126399999999),
                    new Vector(38.3836878181818, -85.643591),
                    new Vector(38.3377518181819, -85.654229),
                    new Vector(38.3009508181818, -85.681391),
                    new Vector(38.2703148181819, -85.74692899999999),
                    new Vector(38.2823928181818, -85.786205),
                    new Vector(38.2861818181818, -85.80655400000001),
                    new Vector(38.2762908181818, -85.83990799999999),
                    new Vector(38.2385628181819, -85.85233700000001),
                    new Vector(38.179999818182, -85.91207),
                    new Vector(38.0648718181819, -85.91475199999999),
                    new Vector(38.0340468181818, -85.930871),
                    new Vector(38.0118348181818, -85.95858200000001),
                    new Vector(37.9963098181819, -85.943219),
                    new Vector(37.9762308181818, -85.907966),
                    new Vector(37.9509498181819, -85.912115),
                    new Vector(37.9403298181817, -85.9056259999999),
                    new Vector(37.9429398181819, -85.871039),
                    new Vector(37.910953818182, -85.832915),
                    new Vector(37.8920988181819, -85.824518),
                    new Vector(37.8918108181819, -85.84495699999999),
                    new Vector(37.8850968181818, -85.848206),
                    new Vector(37.8669078181817, -85.83160100000001),
                    new Vector(37.8335898181819, -85.765028),
                    new Vector(37.8157698181819, -85.74611),
                    new Vector(37.8206568181819, -85.684055),
                    new Vector(37.8390798181818, -85.649855),
                    new Vector(37.8734328181818, -85.61714000000001),
                    new Vector(37.8947178181818, -85.573409),
                    new Vector(37.9182258181818, -85.58500100000001),
                    new Vector(37.9229958181818, -85.56431000000001),
                    new Vector(37.9444608181818, -85.54038799999999),
                    new Vector(37.9613628181819, -85.54415899999999),
                    new Vector(37.9897758181818, -85.497035),
                    new Vector(37.9743138181818, -85.48210399999989),
                    new Vector(37.9408878181819, -85.391051),
                    new Vector(37.9711638181819, -85.176653),
                    new Vector(37.8855918181819, -85.15598900000001),
                    new Vector(37.9101078181819, -85.1183419999999),
                    new Vector(37.9004508181819, -85.114823),
                    new Vector(37.8769518181819, -85.13024),
                    new Vector(37.8716958181818, -85.12295899999999),
                    new Vector(37.8867978181818, -85.101044),
                    new Vector(37.8925308181819, -85.058672),
                    new Vector(37.8853668181819, -85.024085),
                    new Vector(37.9447758181819, -84.97373),
                    new Vector(37.9510848181819, -84.935948),
                    new Vector(37.9407708181818, -84.91495999999999),
                    new Vector(37.9427058181819, -84.88212799999999),
                    new Vector(37.9676988181818, -84.823286),
                    new Vector(37.9585908181819, -84.810416),
                    new Vector(37.9464228181819, -84.8246359999999),
                    new Vector(37.9305648181819, -84.813377),
                    new Vector(37.9120608181819, -84.83966599999999),
                    new Vector(37.9065708181819, -84.814898),
                    new Vector(37.8878778181818, -84.812585),
                    new Vector(37.9037358181819, -84.788213),
                    new Vector(37.8892908181819, -84.790301),
                    new Vector(37.8746568181818, -84.775469),
                    new Vector(37.8542088181819, -84.78670099999989),
                    new Vector(37.8504378181818, -84.77119399999999),
                    new Vector(37.8590058181818, -84.72336799999999),
                    new Vector(37.8495918181819, -84.70296500000001),
                    new Vector(37.830034818182, -84.72524),
                    new Vector(37.8154548181819, -84.7238449999999),
                    new Vector(37.8263268181819, -84.677054),
                    new Vector(37.7988588181819, -84.682346),
                    new Vector(37.7833158181817, -84.668189),
                    new Vector(37.8070578181819, -84.660224),
                    new Vector(37.7995788181819, -84.63213500000001),
                    new Vector(37.7931798181818, -84.630821),
                    new Vector(37.7889408181817, -84.64975699999989),
                    new Vector(37.7829648181818, -84.64782200000001),
                    new Vector(37.7640378181819, -84.61698800000001),
                    new Vector(37.7441568181818, -84.619472),
                    new Vector(37.7522568181819, -84.595046),
                    new Vector(37.7325378181818, -84.589934),
                    new Vector(37.7652168181819, -84.545213),
                    new Vector(37.7694918181819, -84.527438),
                    new Vector(37.7972928181818, -84.496982),
                    new Vector(37.8049338181818, -84.47313200000001),
                    new Vector(37.8414378181818, -84.4887379999999),
                    new Vector(37.8491598181818, -84.445025),
                    new Vector(37.8663588181818, -84.421661),
                    new Vector(37.8461808181819, -84.39503000000001),
                    new Vector(37.8575208181819, -84.373232),
                    new Vector(37.8740178181819, -84.387857),
                    new Vector(37.8926568181819, -84.388316),
                    new Vector(37.8858258181819, -84.355502),
                    new Vector(37.8915768181819, -84.341084),
                    new Vector(37.9148958181818, -84.28102699999999),
                    new Vector(37.8976518181818, -84.27056),
                    new Vector(37.874971818182, -84.271001),
                    new Vector(37.8799848181818, -84.25021099999999),
                    new Vector(37.8697248181818, -84.2124019999999),
                    new Vector(37.8748548181819, -84.194519),
                    new Vector(37.8481608181819, -84.12405800000001),
                    new Vector(37.8500418181818, -84.094718),
                    new Vector(37.8388548181818, -84.087959),
                    new Vector(37.8253188181818, -84.079607),
                    new Vector(37.8387738181818, -84.065783),
                    new Vector(37.8366408181819, -84.04843099999989),
                    new Vector(37.8437328181818, -84.034481),
                    new Vector(37.8366678181819, -84.028586),
                    new Vector(37.8441288181819, -84.012845),
                    new Vector(37.8638568181819, -84.037667),
                    new Vector(37.8683748181818, -84.016886),
                    new Vector(37.9218438181819, -84.004718),
                    new Vector(37.9375488181819, -83.98018399999999),
                    new Vector(37.9052478181818, -83.879177),
                    new Vector(37.9084428181819, -83.80121),
                    new Vector(37.9231668181819, -83.77610900000001),
                    new Vector(37.8947268181819, -83.750855),
                    new Vector(37.8618768181819, -83.68975399999989),
                    new Vector(37.8318888181819, -83.67052099999999),
                    new Vector(37.8245898181819, -83.641316),
                    new Vector(37.8289188181818, -83.627546),
                    new Vector(37.8193698181818, -83.599124),
                    new Vector(37.8188478181818, -83.569388),
                    new Vector(37.8335448181819, -83.535521),
                    new Vector(37.8595188181818, -83.518817),
                    new Vector(37.8604098181818, -83.500052),
                    new Vector(37.8580338181819, -83.488568),
                    new Vector(37.8468378181819, -83.482466),
                    new Vector(37.8482598181819, -83.4654199999999),
                    new Vector(37.8254988181818, -83.43691699999999),
                    new Vector(37.8158688181819, -83.398595),
                    new Vector(37.8029898181819, -83.38623800000001),
                    new Vector(37.7822358181819, -83.33484799999999),
                    new Vector(37.7627778181819, -83.336477),
                    new Vector(37.7422128181819, -83.29794800000001),
                    new Vector(37.7178408181819, -83.2830799999999),
                    new Vector(37.7140158181819, -83.261831),
                    new Vector(37.7381808181819, -83.24579300000001),
                    new Vector(37.7691858181818, -83.274674),
                    new Vector(37.7926938181818, -83.245847),
                    new Vector(37.7993718181819, -83.225426),
                    new Vector(37.8171648181818, -83.218082),
                    new Vector(37.8198468181819, -83.1997489999999),
                    new Vector(37.8699588181819, -83.123609),
                    new Vector(37.8943758181818, -83.130251),
                    new Vector(37.8923688181818, -83.1006229999999),
                    new Vector(37.8779598181819, -83.068556),
                    new Vector(37.8875268181818, -83.04318499999989),
                    new Vector(37.8581868181819, -83.012432),
                    new Vector(37.8764118181819, -82.979285),
                    new Vector(37.8916758181819, -82.98436100000001),
                    new Vector(37.9011078181819, -82.96539799999989),
                    new Vector(37.9499058181818, -82.977458),
                    new Vector(37.9664838181818, -82.99003999999999),
                    new Vector(37.9864278181819, -82.980662),
                    new Vector(38.0068578181819, -82.954841),
                    new Vector(37.9678518181818, -82.838345),
                    new Vector(37.9147788181819, -82.740803),
                    new Vector(37.8831618181819, -82.622102)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries)
            {
                _boundingBox.Expand(linearRing.CalculateBounds());
            }

            return _boundingBox;
        }
    }
}