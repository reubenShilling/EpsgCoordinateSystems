using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Kentucky_South_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2247;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kentucky South";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Kentucky South (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",37.93333333333333],PARAMETER[\"standard_parallel_2\",36.73333333333333],PARAMETER[\"latitude_of_origin\",36.33333333333334],PARAMETER[\"central_meridian\",-85.75],PARAMETER[\"false_easting\",1640416.667],PARAMETER[\"false_northing\",1640416.667],AUTHORITY[\"EPSG\",\"2247\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Kentucky South (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",37.93333333333333],PARAMETER[\"standard_parallel_2\",36.73333333333333],PARAMETER[\"latitude_of_origin\",36.33333333333334],PARAMETER[\"central_meridian\",-85.75],PARAMETER[\"false_easting\",1640416.667],PARAMETER[\"false_northing\",1640416.667],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(36.6508098181819, -87.068183),
                    new Vector(36.6520968181819, -86.770535),
                    new Vector(36.6550758181818, -86.51066),
                    new Vector(36.6509358181818, -86.4154489999999),
                    new Vector(36.6432948181818, -86.19898999999999),
                    new Vector(36.6331068181819, -85.9806049999999),
                    new Vector(36.6266808181819, -85.785476),
                    new Vector(36.6182028181819, -85.43737400000001),
                    new Vector(36.6260958181818, -85.300088),
                    new Vector(36.6256188181819, -85.272503),
                    new Vector(36.6209838181819, -84.998462),
                    new Vector(36.6054408181818, -84.791057),
                    new Vector(36.6050718181818, -84.78187699999999),
                    new Vector(36.5954958181819, -84.256772),
                    new Vector(36.5954508181817, -84.25449500000001),
                    new Vector(36.5920938181818, -84.006743),
                    new Vector(36.5912928181818, -83.935598),
                    new Vector(36.5842458181819, -83.6956129999999),
                    new Vector(36.5986998181818, -83.6751739999999),
                    new Vector(36.6169788181818, -83.64679700000001),
                    new Vector(36.6614838181818, -83.530895),
                    new Vector(36.6618348181819, -83.4602179999999),
                    new Vector(36.6723288181819, -83.4041569999999),
                    new Vector(36.6882138181819, -83.385851),
                    new Vector(36.7095348181819, -83.32138399999999),
                    new Vector(36.7342668181819, -83.203655),
                    new Vector(36.7400628181819, -83.138513),
                    new Vector(36.7511598181818, -83.124392),
                    new Vector(36.7791588181819, -83.12821700000001),
                    new Vector(36.8509968181818, -83.067953),
                    new Vector(36.8587908181818, -83.046632),
                    new Vector(36.8640828181818, -82.95080899999989),
                    new Vector(36.8936928181818, -82.878044),
                    new Vector(36.9321678181818, -82.86063799999989),
                    new Vector(36.9745848181819, -82.86655999999989),
                    new Vector(37.0055988181819, -82.81222699999999),
                    new Vector(37.0339938181818, -82.72360399999999),
                    new Vector(37.0659258181819, -82.72005799999999),
                    new Vector(37.0754838181818, -82.709177),
                    new Vector(37.0931148181818, -82.721372),
                    new Vector(37.1100168181818, -82.719104),
                    new Vector(37.1939148181819, -82.56802999999999),
                    new Vector(37.1993778181818, -82.550039),
                    new Vector(37.2506958181818, -82.405886),
                    new Vector(37.2605148181819, -82.353848),
                    new Vector(37.3048668181819, -82.28895799999999),
                    new Vector(37.5311718181819, -81.959576),
                    new Vector(37.5432588181819, -81.97657700000001),
                    new Vector(37.5305148181819, -82.02635600000001),
                    new Vector(37.5514578181819, -82.04913500000001),
                    new Vector(37.5253488181818, -82.05566),
                    new Vector(37.5483078181818, -82.084388),
                    new Vector(37.5574518181818, -82.14251),
                    new Vector(37.5659208181818, -82.14651499999999),
                    new Vector(37.5698988181818, -82.13746999999999),
                    new Vector(37.5905358181819, -82.131782),
                    new Vector(37.5935688181818, -82.1593129999999),
                    new Vector(37.6406658181818, -82.1855479999999),
                    new Vector(37.6240158181818, -82.205438),
                    new Vector(37.6567758181818, -82.23836900000001),
                    new Vector(37.6690518181818, -82.2956269999999),
                    new Vector(37.7441748181819, -82.329404),
                    new Vector(37.7584308181819, -82.3195039999999),
                    new Vector(37.7843958181817, -82.339844),
                    new Vector(37.8117198181818, -82.405805),
                    new Vector(37.8723528181818, -82.42151),
                    new Vector(37.8948528181818, -82.437611),
                    new Vector(37.9222668181819, -82.50020600000001),
                    new Vector(37.9425078181819, -82.493402),
                    new Vector(37.9515168181819, -82.497497),
                    new Vector(37.9640898181819, -82.542542),
                    new Vector(37.9548468181819, -82.579712),
                    new Vector(37.9163808181819, -82.60672099999999),
                    new Vector(37.8901278181818, -82.608593),
                    new Vector(37.8831618181819, -82.622102),
                    new Vector(37.9147788181819, -82.740803),
                    new Vector(37.9678518181818, -82.838345),
                    new Vector(38.0068578181819, -82.954841),
                    new Vector(37.9864278181819, -82.980662),
                    new Vector(37.9664838181818, -82.99003999999999),
                    new Vector(37.9499058181818, -82.977458),
                    new Vector(37.9011078181819, -82.96539799999989),
                    new Vector(37.8916758181819, -82.98436100000001),
                    new Vector(37.8764118181819, -82.979285),
                    new Vector(37.8581868181819, -83.012432),
                    new Vector(37.8875268181818, -83.04318499999989),
                    new Vector(37.8779598181819, -83.068556),
                    new Vector(37.8923688181818, -83.1006229999999),
                    new Vector(37.8943758181818, -83.130251),
                    new Vector(37.8699588181819, -83.123609),
                    new Vector(37.8198468181819, -83.1997489999999),
                    new Vector(37.8171648181818, -83.218082),
                    new Vector(37.7993718181819, -83.225426),
                    new Vector(37.7926938181818, -83.245847),
                    new Vector(37.7691858181818, -83.274674),
                    new Vector(37.7381808181819, -83.24579300000001),
                    new Vector(37.7140158181819, -83.261831),
                    new Vector(37.7178408181819, -83.2830799999999),
                    new Vector(37.7422128181819, -83.29794800000001),
                    new Vector(37.7627778181819, -83.336477),
                    new Vector(37.7822358181819, -83.33484799999999),
                    new Vector(37.8029898181819, -83.38623800000001),
                    new Vector(37.8158688181819, -83.398595),
                    new Vector(37.8254988181818, -83.43691699999999),
                    new Vector(37.8482598181819, -83.4654199999999),
                    new Vector(37.8468378181819, -83.482466),
                    new Vector(37.8580338181819, -83.488568),
                    new Vector(37.8604098181818, -83.500052),
                    new Vector(37.8595188181818, -83.518817),
                    new Vector(37.8335448181819, -83.535521),
                    new Vector(37.8188478181818, -83.569388),
                    new Vector(37.8193698181818, -83.599124),
                    new Vector(37.8289188181818, -83.627546),
                    new Vector(37.8245898181819, -83.641316),
                    new Vector(37.8318888181819, -83.67052099999999),
                    new Vector(37.8618768181819, -83.68975399999989),
                    new Vector(37.8947268181819, -83.750855),
                    new Vector(37.9231668181819, -83.77610900000001),
                    new Vector(37.9084428181819, -83.80121),
                    new Vector(37.9052478181818, -83.879177),
                    new Vector(37.9375488181819, -83.98018399999999),
                    new Vector(37.9218438181819, -84.004718),
                    new Vector(37.8683748181818, -84.016886),
                    new Vector(37.8638568181819, -84.037667),
                    new Vector(37.8441288181819, -84.012845),
                    new Vector(37.8366678181819, -84.028586),
                    new Vector(37.8437328181818, -84.034481),
                    new Vector(37.8366408181819, -84.04843099999989),
                    new Vector(37.8387738181818, -84.065783),
                    new Vector(37.8253188181818, -84.079607),
                    new Vector(37.8388548181818, -84.087959),
                    new Vector(37.8500418181818, -84.094718),
                    new Vector(37.8481608181819, -84.12405800000001),
                    new Vector(37.8748548181819, -84.194519),
                    new Vector(37.8697248181818, -84.2124019999999),
                    new Vector(37.8799848181818, -84.25021099999999),
                    new Vector(37.874971818182, -84.271001),
                    new Vector(37.8976518181818, -84.27056),
                    new Vector(37.9148958181818, -84.28102699999999),
                    new Vector(37.8915768181819, -84.341084),
                    new Vector(37.8858258181819, -84.355502),
                    new Vector(37.8926568181819, -84.388316),
                    new Vector(37.8740178181819, -84.387857),
                    new Vector(37.8575208181819, -84.373232),
                    new Vector(37.8461808181819, -84.39503000000001),
                    new Vector(37.8663588181818, -84.421661),
                    new Vector(37.8491598181818, -84.445025),
                    new Vector(37.8414378181818, -84.4887379999999),
                    new Vector(37.8049338181818, -84.47313200000001),
                    new Vector(37.7972928181818, -84.496982),
                    new Vector(37.7694918181819, -84.527438),
                    new Vector(37.7652168181819, -84.545213),
                    new Vector(37.7325378181818, -84.589934),
                    new Vector(37.7522568181819, -84.595046),
                    new Vector(37.7441568181818, -84.619472),
                    new Vector(37.7640378181819, -84.61698800000001),
                    new Vector(37.7829648181818, -84.64782200000001),
                    new Vector(37.7889408181817, -84.64975699999989),
                    new Vector(37.7931798181818, -84.630821),
                    new Vector(37.7995788181819, -84.63213500000001),
                    new Vector(37.8070578181819, -84.660224),
                    new Vector(37.7833158181817, -84.668189),
                    new Vector(37.7988588181819, -84.682346),
                    new Vector(37.8263268181819, -84.677054),
                    new Vector(37.8154548181819, -84.7238449999999),
                    new Vector(37.830034818182, -84.72524),
                    new Vector(37.8495918181819, -84.70296500000001),
                    new Vector(37.8590058181818, -84.72336799999999),
                    new Vector(37.8504378181818, -84.77119399999999),
                    new Vector(37.8542088181819, -84.78670099999989),
                    new Vector(37.8746568181818, -84.775469),
                    new Vector(37.8892908181819, -84.790301),
                    new Vector(37.9037358181819, -84.788213),
                    new Vector(37.8878778181818, -84.812585),
                    new Vector(37.9065708181819, -84.814898),
                    new Vector(37.9120608181819, -84.83966599999999),
                    new Vector(37.9305648181819, -84.813377),
                    new Vector(37.9464228181819, -84.8246359999999),
                    new Vector(37.9585908181819, -84.810416),
                    new Vector(37.9676988181818, -84.823286),
                    new Vector(37.9427058181819, -84.88212799999999),
                    new Vector(37.9407708181818, -84.91495999999999),
                    new Vector(37.9510848181819, -84.935948),
                    new Vector(37.9447758181819, -84.97373),
                    new Vector(37.8853668181819, -85.024085),
                    new Vector(37.8925308181819, -85.058672),
                    new Vector(37.8867978181818, -85.101044),
                    new Vector(37.8716958181818, -85.12295899999999),
                    new Vector(37.8769518181819, -85.13024),
                    new Vector(37.9004508181819, -85.114823),
                    new Vector(37.9101078181819, -85.1183419999999),
                    new Vector(37.8855918181819, -85.15598900000001),
                    new Vector(37.9711638181819, -85.176653),
                    new Vector(37.9408878181819, -85.391051),
                    new Vector(37.9743138181818, -85.48210399999989),
                    new Vector(37.9897758181818, -85.497035),
                    new Vector(37.9613628181819, -85.54415899999999),
                    new Vector(37.9444608181818, -85.54038799999999),
                    new Vector(37.9229958181818, -85.56431000000001),
                    new Vector(37.9182258181818, -85.58500100000001),
                    new Vector(37.8947178181818, -85.573409),
                    new Vector(37.8734328181818, -85.61714000000001),
                    new Vector(37.8390798181818, -85.649855),
                    new Vector(37.8206568181819, -85.684055),
                    new Vector(37.8157698181819, -85.74611),
                    new Vector(37.8335898181819, -85.765028),
                    new Vector(37.8669078181817, -85.83160100000001),
                    new Vector(37.8850968181818, -85.848206),
                    new Vector(37.8918108181819, -85.84495699999999),
                    new Vector(37.8920988181819, -85.824518),
                    new Vector(37.910953818182, -85.832915),
                    new Vector(37.9429398181819, -85.871039),
                    new Vector(37.9403298181817, -85.9056259999999),
                    new Vector(37.9509498181819, -85.912115),
                    new Vector(37.9762308181818, -85.907966),
                    new Vector(37.9963098181819, -85.943219),
                    new Vector(38.0118348181818, -85.95858200000001),
                    new Vector(38.0017638181818, -86.00666),
                    new Vector(37.9929528181819, -86.0316169999999),
                    new Vector(37.9667808181819, -86.052722),
                    new Vector(38.0113398181819, -86.104985),
                    new Vector(38.0177568181819, -86.19062),
                    new Vector(38.0407158181819, -86.25215300000001),
                    new Vector(38.058175818182, -86.277704),
                    new Vector(38.0784888181819, -86.291438),
                    new Vector(38.1502998181818, -86.297675),
                    new Vector(38.1772908181818, -86.3416129999999),
                    new Vector(38.1932928181819, -86.364356),
                    new Vector(38.1948048181818, -86.388305),
                    new Vector(38.1680208181818, -86.38709900000001),
                    new Vector(38.1555648181819, -86.343125),
                    new Vector(38.1440268181818, -86.3354209999999),
                    new Vector(38.1342708181818, -86.34403399999989),
                    new Vector(38.1232908181819, -86.393669),
                    new Vector(38.1082158181818, -86.407178),
                    new Vector(38.1297528181819, -86.4525289999999),
                    new Vector(38.129158818182, -86.46484100000001),
                    new Vector(38.1117078181819, -86.47433599999999),
                    new Vector(38.0887038181819, -86.442521),
                    new Vector(38.0759868181818, -86.44246699999999),
                    new Vector(38.0591658181818, -86.4583609999999),
                    new Vector(38.0516418181819, -86.503118),
                    new Vector(38.0470428181819, -86.5190929999999),
                    new Vector(38.0186928181818, -86.527832),
                    new Vector(37.9874808181818, -86.53084699999999),
                    new Vector(37.9422468181819, -86.516897),
                    new Vector(37.9278738181818, -86.522738),
                    new Vector(37.9215198181819, -86.541089),
                    new Vector(37.9256598181819, -86.581778),
                    new Vector(37.9210698181819, -86.598311),
                    new Vector(37.8579708181818, -86.61478099999999),
                    new Vector(37.8460008181819, -86.645561),
                    new Vector(37.8473778181818, -86.66592799999999),
                    new Vector(37.8606438181818, -86.6706709999999),
                    new Vector(37.902574818182, -86.660312),
                    new Vector(37.913203818182, -86.668655),
                    new Vector(37.9118538181818, -86.68913000000001),
                    new Vector(37.8946188181818, -86.728874),
                    new Vector(37.8983628181818, -86.75383100000001),
                    new Vector(37.9787958181819, -86.802818),
                    new Vector(37.9915668181819, -86.826308),
                    new Vector(37.986913818182, -86.8632709999999),
                    new Vector(37.9537038181819, -86.900081),
                    new Vector(37.9380348181818, -86.931572),
                    new Vector(37.9306188181819, -86.989028),
                    new Vector(37.9247598181819, -87.01315699999989),
                    new Vector(37.9080108181818, -87.036485),
                    new Vector(37.8071388181818, -87.07130599999989),
                    new Vector(37.7842518181819, -87.106424),
                    new Vector(37.7897328181819, -87.131885),
                    new Vector(37.8269658181819, -87.158084),
                    new Vector(37.8386388181819, -87.17577799999999),
                    new Vector(37.8491148181818, -87.22676300000001),
                    new Vector(37.8708138181818, -87.272744),
                    new Vector(37.8937188181818, -87.310562),
                    new Vector(37.9349748181819, -87.387557),
                    new Vector(37.9365138181819, -87.45229399999999),
                    new Vector(37.9156248181819, -87.5048),
                    new Vector(37.9711548181819, -87.604331),
                    new Vector(37.9234548181819, -87.627137),
                    new Vector(37.8907668181818, -87.594719),
                    new Vector(37.8649098181818, -87.593639),
                    new Vector(37.843813818182, -87.607589),
                    new Vector(37.8281718181818, -87.651698),
                    new Vector(37.8363708181818, -87.684719),
                    new Vector(37.8970488181818, -87.679715),
                    new Vector(37.8997578181818, -87.709406),
                    new Vector(37.8945828181819, -87.72819800000001),
                    new Vector(37.8981288181818, -87.75378499999999),
                    new Vector(37.8782568181818, -87.823643),
                    new Vector(37.8909468181819, -87.857195),
                    new Vector(37.9245978181818, -87.8990359999999),
                    new Vector(37.9199088181818, -87.9218869999999),
                    new Vector(37.9042038181819, -87.9344779999999),
                    new Vector(37.8752238181818, -87.93684500000001),
                    new Vector(37.8386118181818, -87.910223),
                    new Vector(37.8097308181819, -87.920177),
                    new Vector(37.7995518181818, -87.93960800000001),
                    new Vector(37.7762238181818, -87.958733),
                    new Vector(37.8013518181819, -88.01123),
                    new Vector(37.8057258181818, -88.035611),
                    new Vector(37.7354448181818, -88.072502),
                    new Vector(37.7007948181819, -88.1336749999999),
                    new Vector(37.6607358181819, -88.159397),
                    new Vector(37.6285248181818, -88.15766000000001),
                    new Vector(37.5836148181819, -88.134197),
                    new Vector(37.5110388181819, -88.07159299999999),
                    new Vector(37.4763168181819, -88.08790999999999),
                    new Vector(37.4428998181819, -88.31174900000001),
                    new Vector(37.4093658181819, -88.35921500000001),
                    new Vector(37.4203458181818, -88.419893),
                    new Vector(37.4008068181818, -88.46768299999999),
                    new Vector(37.2969108181819, -88.5113599999999),
                    new Vector(37.2578328181819, -88.501469),
                    new Vector(37.2057228181819, -88.45073600000001),
                    new Vector(37.1569608181817, -88.4225569999999),
                    new Vector(37.0987308181818, -88.45051100000001),
                    new Vector(37.072198818182, -88.476845),
                    new Vector(37.0682388181818, -88.490741),
                    new Vector(37.0648278181819, -88.517318),
                    new Vector(37.0728738181818, -88.559321),
                    new Vector(37.1090988181818, -88.614266),
                    new Vector(37.1354598181818, -88.688417),
                    new Vector(37.1412378181818, -88.73916800000001),
                    new Vector(37.1521638181819, -88.746566),
                    new Vector(37.2022488181819, -88.863359),
                    new Vector(37.2184668181819, -88.93256),
                    new Vector(37.2200868181818, -88.99323800000001),
                    new Vector(37.1859048181819, -89.06510299999999),
                    new Vector(37.1121948181819, -89.116889),
                    new Vector(37.0932408181818, -89.1464179999999),
                    new Vector(37.0642878181818, -89.16961999999999),
                    new Vector(37.0257678181817, -89.17439899999999),
                    new Vector(36.9984888181819, -89.15031500000001),
                    new Vector(36.9881658181819, -89.12993),
                    new Vector(36.9775008181819, -89.107214),
                    new Vector(36.9539208181819, -89.105036),
                    new Vector(36.8664948181819, -89.129651),
                    new Vector(36.8434818181819, -89.16656),
                    new Vector(36.8294328181819, -89.1735259999999),
                    new Vector(36.8044758181818, -89.164445),
                    new Vector(36.7924698181819, -89.125907),
                    new Vector(36.7680888181819, -89.12553800000001),
                    new Vector(36.7590978181819, -89.15143999999999),
                    new Vector(36.7609788181819, -89.17726999999999),
                    new Vector(36.7274808181819, -89.19636800000001),
                    new Vector(36.7134228181819, -89.1975649999999),
                    new Vector(36.6716268181819, -89.167901),
                    new Vector(36.6530598181819, -89.177162),
                    new Vector(36.6313518181818, -89.200193),
                    new Vector(36.5819508181819, -89.21012899999999),
                    new Vector(36.5693238181818, -89.24168299999999),
                    new Vector(36.575308818182, -89.28348800000001),
                    new Vector(36.6220728181818, -89.32234099999989),
                    new Vector(36.6289128181818, -89.342393),
                    new Vector(36.6257628181817, -89.3636149999999),
                    new Vector(36.6162498181819, -89.37395600000001),
                    new Vector(36.5106258181819, -89.418209),
                    new Vector(36.5026788181819, -89.41477999999999),
                    new Vector(36.5026068181818, -89.34666799999989),
                    new Vector(36.4998528181819, -88.83037400000001),
                    new Vector(36.4999068181819, -88.82635999999999),
                    new Vector(36.4990428181819, -88.81071799999999),
                    new Vector(36.4995468181818, -88.5126829999999),
                    new Vector(36.4982058181819, -88.49602400000001),
                    new Vector(36.4965768181819, -88.042766),
                    new Vector(36.538201818182, -88.03507999999999),
                    new Vector(36.5827158181818, -88.04109200000001),
                    new Vector(36.6796818181819, -88.071341),
                    new Vector(36.6694308181819, -87.87071299999999),
                    new Vector(36.6415218181818, -87.853532),
                    new Vector(36.6444918181819, -87.69353),
                    new Vector(36.6452208181818, -87.640655),
                    new Vector(36.6492798181819, -87.34660700000001),
                    new Vector(36.6513048181818, -87.112697),
                    new Vector(36.6508098181819, -87.068183)
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