using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    public class NAD83_Iowa_South_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3418;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Iowa South";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Iowa South (ft US)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",41.78333333333333],PARAMETER[\"standard_parallel_2\",40.61666666666667],PARAMETER[\"latitude_of_origin\",40],PARAMETER[\"central_meridian\",-93.5],PARAMETER[\"false_easting\",1640416.6667],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"3418\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Iowa South (ft US)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",41.78333333333333],PARAMETER[\"standard_parallel_2\",40.61666666666667],PARAMETER[\"latitude_of_origin\",40],PARAMETER[\"central_meridian\",-93.5],PARAMETER[\"false_easting\",1640416.6667],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(40.6082628181818, -91.946372),
                    new Vector(40.6097838181819, -91.74171200000001),
                    new Vector(40.5934398181819, -91.716971),
                    new Vector(40.5811998181819, -91.68996199999999),
                    new Vector(40.5516798181819, -91.69208599999999),
                    new Vector(40.5328968181819, -91.62253399999999),
                    new Vector(40.5048708181819, -91.61686400000001),
                    new Vector(40.4845218181818, -91.58603000000001),
                    new Vector(40.4637678181818, -91.579379),
                    new Vector(40.4554428181819, -91.533209),
                    new Vector(40.4412948181819, -91.53884300000001),
                    new Vector(40.435084818182, -91.52960899999989),
                    new Vector(40.4101728181818, -91.52769199999999),
                    new Vector(40.4051598181819, -91.50037699999999),
                    new Vector(40.3908048181819, -91.490315),
                    new Vector(40.3910118181819, -91.47704),
                    new Vector(40.3719498181819, -91.448744),
                    new Vector(40.3869168181818, -91.41896300000001),
                    new Vector(40.3924068181818, -91.38590600000001),
                    new Vector(40.4030358181818, -91.37291),
                    new Vector(40.4472888181818, -91.385555),
                    new Vector(40.5037008181819, -91.374944),
                    new Vector(40.5285408181819, -91.38225199999989),
                    new Vector(40.5480348181819, -91.413023),
                    new Vector(40.5730098181819, -91.41127699999991),
                    new Vector(40.6034838181818, -91.37576299999999),
                    new Vector(40.6395918181819, -91.26221000000001),
                    new Vector(40.6438668181819, -91.215068),
                    new Vector(40.6563588181819, -91.162643),
                    new Vector(40.6821888181819, -91.12929800000001),
                    new Vector(40.7054448181818, -91.120136),
                    new Vector(40.7615868181819, -91.092893),
                    new Vector(40.8337668181817, -91.08905900000001),
                    new Vector(40.8796308181819, -91.049351),
                    new Vector(40.923964818182, -90.98341699999999),
                    new Vector(40.9505418181818, -90.9608539999999),
                    new Vector(41.0704038181818, -90.95478799999998),
                    new Vector(41.1043878181819, -90.95792900000001),
                    new Vector(41.1444018181819, -90.990482),
                    new Vector(41.1658578181818, -91.0184),
                    new Vector(41.1762888181818, -91.056461),
                    new Vector(41.2315578181819, -91.1016769999999),
                    new Vector(41.2678458181818, -91.102496),
                    new Vector(41.3349228181819, -91.07342599999988),
                    new Vector(41.4014058181819, -91.0559389999999),
                    new Vector(41.4235368181818, -91.02763400000001),
                    new Vector(41.4311058181819, -91.00084099999989),
                    new Vector(41.4212598181819, -90.94980200000002),
                    new Vector(41.4446508181819, -90.844286),
                    new Vector(41.4498528181819, -90.780044),
                    new Vector(41.4500868181819, -90.70835900000002),
                    new Vector(41.4623538181818, -90.65893099999998),
                    new Vector(41.5096218181818, -90.600836),
                    new Vector(41.526001818182, -90.540977),
                    new Vector(41.5275858181819, -90.45512600000002),
                    new Vector(41.5436058181819, -90.43510099999999),
                    new Vector(41.5673118181819, -90.42314),
                    new Vector(41.586877818182, -90.348494),
                    new Vector(41.6028258181819, -90.339476),
                    new Vector(41.6491218181819, -90.341267),
                    new Vector(41.7227688181819, -90.3261559999999),
                    new Vector(41.7565008181818, -90.305015),
                    new Vector(41.7817728181819, -90.25543399999999),
                    new Vector(41.8061628181818, -90.19596199999999),
                    new Vector(41.9308038181819, -90.15464299999999),
                    new Vector(41.9839938181819, -90.142799),
                    new Vector(42.0334578181818, -90.150665),
                    new Vector(42.0356898181819, -90.89890699999999),
                    new Vector(41.9484708181819, -90.900869),
                    new Vector(41.9443218181819, -91.371038),
                    new Vector(41.851693818182, -91.369787),
                    new Vector(41.8568148181818, -91.83469100000001),
                    new Vector(41.8602258181818, -92.30148500000001),
                    new Vector(41.8628358181819, -92.76960200000001),
                    new Vector(41.8634568181818, -93.23216600000002),
                    new Vector(41.8631688181819, -93.34996700000001),
                    new Vector(41.8616748181819, -93.70332500000001),
                    new Vector(41.8600908181818, -93.81982999999998),
                    new Vector(41.8579488181819, -94.1682739999999),
                    new Vector(41.8589658181818, -94.28927899999998),
                    new Vector(41.8614948181818, -94.63690399999999),
                    new Vector(41.8600548181818, -94.751591),
                    new Vector(41.8614048181818, -95.09738),
                    new Vector(41.8604778181818, -95.5603849999999),
                    new Vector(41.8612968181819, -95.6771779999999),
                    new Vector(41.8626198181818, -96.13562899999999),
                    new Vector(41.7914748181819, -96.076418),
                    new Vector(41.7529728181819, -96.09931400000001),
                    new Vector(41.7315618181819, -96.099773),
                    new Vector(41.7049938181819, -96.085553),
                    new Vector(41.6949048181819, -96.122201),
                    new Vector(41.6840868181819, -96.12026599999999),
                    new Vector(41.6546838181818, -96.099305),
                    new Vector(41.5990098181818, -96.111311),
                    new Vector(41.5759968181819, -96.08083700000002),
                    new Vector(41.5631448181819, -96.09193399999999),
                    new Vector(41.5375218181819, -96.0858319999999),
                    new Vector(41.5243368181818, -96.0501739999999),
                    new Vector(41.5366668181819, -96.004589),
                    new Vector(41.5280988181819, -95.99396),
                    new Vector(41.5115208181819, -95.99668699999999),
                    new Vector(41.4929898181819, -96.013454),
                    new Vector(41.4819558181819, -96.00690199999988),
                    new Vector(41.4723888181819, -95.953181),
                    new Vector(41.4623808181818, -95.9350639999999),
                    new Vector(41.3948088181818, -95.94005900000001),
                    new Vector(41.3400798181819, -95.94289399999998),
                    new Vector(41.3013888181818, -95.88911),
                    new Vector(41.2868628181818, -95.8975879999999),
                    new Vector(41.3084718181818, -95.911196),
                    new Vector(41.3020548181818, -95.93023100000001),
                    new Vector(41.2252488181818, -95.91098),
                    new Vector(41.2078518181819, -95.922257),
                    new Vector(41.1940638181819, -95.916101),
                    new Vector(41.1805368181819, -95.85920299999998),
                    new Vector(41.1668658181818, -95.85979699999999),
                    new Vector(41.1642018181818, -95.87668099999999),
                    new Vector(41.1091938181818, -95.858276),
                    new Vector(41.0658768181819, -95.878805),
                    new Vector(41.0349978181819, -95.85953599999999),
                    new Vector(41.0026518181818, -95.860904),
                    new Vector(40.9742568181819, -95.837603),
                    new Vector(40.9011048181818, -95.836541),
                    new Vector(40.8702978181819, -95.834399),
                    new Vector(40.8483378181817, -95.84643199999991),
                    new Vector(40.7926008181818, -95.85178700000002),
                    new Vector(40.7304378181819, -95.87661799999999),
                    new Vector(40.643119818182, -95.76799699999999),
                    new Vector(40.6208988181819, -95.757548),
                    new Vector(40.5890478181819, -95.767484),
                    new Vector(40.5843408181819, -95.3825539999999),
                    new Vector(40.5818928181818, -95.21743100000002),
                    new Vector(40.5772218181819, -94.92062),
                    new Vector(40.5757458181818, -94.63987400000001),
                    new Vector(40.5742068181818, -94.48522700000001),
                    new Vector(40.5709668181818, -94.238393),
                    new Vector(40.5740178181818, -94.01806400000001),
                    new Vector(40.5784458181819, -93.78629599999999),
                    new Vector(40.5808218181818, -93.5629069999999),
                    new Vector(40.5804888181818, -93.370271),
                    new Vector(40.5843498181819, -93.10093699999999),
                    new Vector(40.5896598181818, -92.717816),
                    new Vector(40.5914598181819, -92.64643700000002),
                    new Vector(40.5995688181819, -92.36150600000001),
                    new Vector(40.6000908181819, -92.19316999999999),
                    new Vector(40.6082628181818, -91.946372)
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