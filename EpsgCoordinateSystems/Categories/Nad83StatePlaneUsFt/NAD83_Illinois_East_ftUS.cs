using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Illinois_East_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3435;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Illinois East";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Illinois East (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",36.66666666666666],PARAMETER[\"central_meridian\",-88.33333333333333],PARAMETER[\"scale_factor\",0.999975],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"3435\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Illinois East (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",36.66666666666666],PARAMETER[\"central_meridian\",-88.33333333333333],PARAMETER[\"scale_factor\",0.999975],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(38.7413298181818, -89.1449149999999),
                    new Vector(38.5015698181818, -89.14549100000001),
                    new Vector(38.4743718181819, -89.14445600000001),
                    new Vector(38.2137858181818, -89.150981),
                    new Vector(38.1294828181819, -89.151971),
                    new Vector(38.127610818182, -89.13326000000001),
                    new Vector(38.1076938181819, -89.1403789999999),
                    new Vector(38.0931408181818, -89.12349500000001),
                    new Vector(38.0474118181818, -89.1400909999999),
                    new Vector(37.9912248181818, -89.145617),
                    new Vector(37.9491678181819, -89.17908799999999),
                    new Vector(37.9490958181819, -89.15516599999999),
                    new Vector(37.8657018181818, -89.154977),
                    new Vector(37.6041528181818, -89.1532849999999),
                    new Vector(37.6033428181819, -89.046392),
                    new Vector(37.3372758181818, -89.0497579999999),
                    new Vector(37.3005558181819, -89.04997400000001),
                    new Vector(37.3170978181819, -88.992581),
                    new Vector(37.3060458181819, -88.952738),
                    new Vector(37.312291818182, -88.930697),
                    new Vector(37.2184668181819, -88.93256),
                    new Vector(37.2022488181819, -88.863359),
                    new Vector(37.1521638181819, -88.746566),
                    new Vector(37.1412378181818, -88.73916800000001),
                    new Vector(37.1354598181818, -88.688417),
                    new Vector(37.1090988181818, -88.614266),
                    new Vector(37.0728738181818, -88.559321),
                    new Vector(37.0648278181819, -88.517318),
                    new Vector(37.0682388181818, -88.490741),
                    new Vector(37.072198818182, -88.476845),
                    new Vector(37.0987308181818, -88.45051100000001),
                    new Vector(37.1569608181817, -88.4225569999999),
                    new Vector(37.2057228181819, -88.45073600000001),
                    new Vector(37.2578328181819, -88.501469),
                    new Vector(37.2969108181819, -88.5113599999999),
                    new Vector(37.4008068181818, -88.46768299999999),
                    new Vector(37.4203458181818, -88.419893),
                    new Vector(37.4093658181819, -88.35921500000001),
                    new Vector(37.4428998181819, -88.31174900000001),
                    new Vector(37.4763168181819, -88.08790999999999),
                    new Vector(37.5110388181819, -88.07159299999999),
                    new Vector(37.5836148181819, -88.134197),
                    new Vector(37.6285248181818, -88.15766000000001),
                    new Vector(37.6607358181819, -88.159397),
                    new Vector(37.7007948181819, -88.1336749999999),
                    new Vector(37.7354448181818, -88.072502),
                    new Vector(37.8057258181818, -88.035611),
                    new Vector(37.8176508181819, -88.086065),
                    new Vector(37.8312948181819, -88.089296),
                    new Vector(37.8275598181818, -88.04217199999999),
                    new Vector(37.8437868181819, -88.03427000000001),
                    new Vector(37.8678528181818, -88.07576899999999),
                    new Vector(37.8953568181818, -88.101491),
                    new Vector(37.9062198181817, -88.100114),
                    new Vector(37.896049818182, -88.044899),
                    new Vector(37.9057968181818, -88.02661999999999),
                    new Vector(37.9176408181819, -88.030472),
                    new Vector(37.9237068181818, -88.08404),
                    new Vector(37.9440468181818, -88.078973),
                    new Vector(37.9298268181819, -88.064654),
                    new Vector(37.9345428181819, -88.041803),
                    new Vector(37.9563048181819, -88.042541),
                    new Vector(37.975096818182, -88.0217329999999),
                    new Vector(38.0082798181818, -88.029248),
                    new Vector(38.0335788181818, -88.02172400000001),
                    new Vector(38.0383488181819, -88.041506),
                    new Vector(38.0451618181818, -88.043126),
                    new Vector(38.0541258181819, -88.03476499999989),
                    new Vector(38.0733588181818, -87.975329),
                    new Vector(38.0967948181818, -87.96489800000001),
                    new Vector(38.0923938181818, -88.01236400000001),
                    new Vector(38.1033468181818, -88.01858300000001),
                    new Vector(38.1318048181819, -87.973538),
                    new Vector(38.1369618181819, -87.950597),
                    new Vector(38.1575718181819, -87.93202100000001),
                    new Vector(38.1711798181819, -87.932318),
                    new Vector(38.2007628181818, -87.9779659999999),
                    new Vector(38.2348638181818, -87.98603900000001),
                    new Vector(38.2411278181819, -87.980054),
                    new Vector(38.304820818182, -87.925955),
                    new Vector(38.3023908181818, -87.913679),
                    new Vector(38.2810878181818, -87.91413799999999),
                    new Vector(38.3007078181818, -87.888497),
                    new Vector(38.3156028181818, -87.883475),
                    new Vector(38.3168358181819, -87.87407),
                    new Vector(38.2854078181819, -87.86303599999999),
                    new Vector(38.2861458181819, -87.850112),
                    new Vector(38.3525748181818, -87.83453299999999),
                    new Vector(38.3781708181818, -87.7840429999999),
                    new Vector(38.4180048181819, -87.748457),
                    new Vector(38.4455268181818, -87.7389799999999),
                    new Vector(38.4571458181818, -87.75869),
                    new Vector(38.4661728181819, -87.756125),
                    new Vector(38.4815808181819, -87.692846),
                    new Vector(38.5040538181818, -87.67994),
                    new Vector(38.5004898181818, -87.653561),
                    new Vector(38.5154208181819, -87.651419),
                    new Vector(38.5474698181819, -87.672974),
                    new Vector(38.5739208181818, -87.6528859999999),
                    new Vector(38.5932258181819, -87.640619),
                    new Vector(38.5992558181818, -87.619856),
                    new Vector(38.6229618181818, -87.628676),
                    new Vector(38.6428518181818, -87.62522),
                    new Vector(38.6722188181818, -87.5884999999999),
                    new Vector(38.6860158181819, -87.543914),
                    new Vector(38.7366858181818, -87.508337),
                    new Vector(38.7697698181818, -87.508031),
                    new Vector(38.776744818182, -87.519047),
                    new Vector(38.7956088181819, -87.50790499999989),
                    new Vector(38.8579338181819, -87.550529),
                    new Vector(38.8698588181819, -87.559079),
                    new Vector(38.9049048181818, -87.539216),
                    new Vector(38.9319678181819, -87.5301979999999),
                    new Vector(38.9637468181818, -87.533492),
                    new Vector(38.9771208181819, -87.547928),
                    new Vector(38.9941308181819, -87.59188399999989),
                    new Vector(38.9957778181819, -87.581777),
                    new Vector(39.0624858181819, -87.585341),
                    new Vector(39.0846438181819, -87.612026),
                    new Vector(39.0890178181819, -87.63088999999999),
                    new Vector(39.1039848181818, -87.631691),
                    new Vector(39.1135068181819, -87.662291),
                    new Vector(39.1306878181818, -87.65948299999999),
                    new Vector(39.1467168181818, -87.670355),
                    new Vector(39.168541818182, -87.644282),
                    new Vector(39.1961088181818, -87.6079579999999),
                    new Vector(39.1981608181818, -87.594233),
                    new Vector(39.2085108181819, -87.588617),
                    new Vector(39.2487948181819, -87.584594),
                    new Vector(39.2581998181819, -87.606914),
                    new Vector(39.2814558181819, -87.615824),
                    new Vector(39.2977008181819, -87.6106489999999),
                    new Vector(39.3074478181819, -87.625265),
                    new Vector(39.3383088181818, -87.597689),
                    new Vector(39.3505668181819, -87.540233),
                    new Vector(39.4774848181819, -87.538595),
                    new Vector(39.6093708181818, -87.53559799999999),
                    new Vector(39.8873358181819, -87.535787),
                    new Vector(40.1662278181819, -87.5353549999999),
                    new Vector(40.4832798181819, -87.53568799999989),
                    new Vector(40.4946468181818, -87.53719100000001),
                    new Vector(40.745449818182, -87.53270000000001),
                    new Vector(41.0099598181818, -87.53205199999999),
                    new Vector(41.1737868181819, -87.531764),
                    new Vector(41.3013348181819, -87.532484),
                    new Vector(41.4697518181819, -87.53268199999999),
                    new Vector(41.7236238181819, -87.52991),
                    new Vector(41.8473648181819, -87.612674),
                    new Vector(42.0598548181819, -87.670607),
                    new Vector(42.1564788181819, -87.760301),
                    new Vector(42.3142398181819, -87.837017),
                    new Vector(42.4891548181819, -87.797381),
                    new Vector(42.4896228181819, -88.194794),
                    new Vector(42.4919898181819, -88.297988),
                    new Vector(42.4896768181818, -88.70662400000001),
                    new Vector(42.4909188181819, -88.765052),
                    new Vector(42.4908828181819, -88.939193),
                    new Vector(42.1524378181819, -88.9431349999999),
                    new Vector(41.8926798181819, -88.94766199999999),
                    new Vector(41.6297718181819, -88.94112800000001),
                    new Vector(41.628754818182, -89.171474),
                    new Vector(41.5897218181819, -89.171654),
                    new Vector(41.3160408181819, -89.17049299999989),
                    new Vector(41.1082038181819, -89.168396),
                    new Vector(41.1069618181819, -89.058668),
                    new Vector(40.9282038181818, -89.057948),
                    new Vector(40.9295358181819, -88.93630400000001),
                    new Vector(40.7548638181819, -88.931012),
                    new Vector(40.7546478181818, -88.987424),
                    new Vector(40.6643868181819, -88.989287),
                    new Vector(40.6627848181819, -89.043233),
                    new Vector(40.6296738181818, -89.04405199999999),
                    new Vector(40.6280628181819, -89.10401899999989),
                    new Vector(40.6149048181819, -89.104703),
                    new Vector(40.6154628181819, -89.138606),
                    new Vector(40.6018548181818, -89.13806599999999),
                    new Vector(40.5999108181819, -89.2749019999999),
                    new Vector(40.3296048181817, -89.269115),
                    new Vector(40.2856218181818, -89.26865599999999),
                    new Vector(40.2858108181818, -89.1547429999999),
                    new Vector(40.0550058181818, -89.15285299999999),
                    new Vector(39.9194478181818, -89.151701),
                    new Vector(39.9187188181819, -89.224862),
                    new Vector(39.8117178181819, -89.22347600000001),
                    new Vector(39.8161818181818, -89.191715),
                    new Vector(39.8015658181818, -89.149271),
                    new Vector(39.6569358181819, -89.14699400000001),
                    new Vector(39.6565668181819, -89.03228),
                    new Vector(39.349216818182, -89.031893),
                    new Vector(39.3500268181818, -89.138975),
                    new Vector(39.2167818181819, -89.142602),
                    new Vector(39.2161428181819, -89.256029),
                    new Vector(39.0253248181818, -89.257847),
                    new Vector(39.0085578181819, -89.256128),
                    new Vector(39.0076668181819, -89.265011),
                    new Vector(38.7420678181818, -89.262905),
                    new Vector(38.7413298181818, -89.1449149999999)
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