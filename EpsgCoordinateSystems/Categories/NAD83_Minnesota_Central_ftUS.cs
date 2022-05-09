using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Minnesota_Central_ftUS : INad83UsFtCrs
    {
        private const int _srid = 26850;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Minnesota Central";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Minnesota Central (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",47.05],PARAMETER[\"standard_parallel_2\",45.61666666666667],PARAMETER[\"latitude_of_origin\",45],PARAMETER[\"central_meridian\",-94.25],PARAMETER[\"false_easting\",2624666.6667],PARAMETER[\"false_northing\",328083.3333],AUTHORITY[\"EPSG\",\"26850\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Minnesota Central (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",47.05],PARAMETER[\"standard_parallel_2\",45.61666666666667],PARAMETER[\"latitude_of_origin\",45],PARAMETER[\"central_meridian\",-94.25],PARAMETER[\"false_easting\",2624666.6667],PARAMETER[\"false_northing\",328083.3333],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(45.4136688181818, -93.513569),
                    new Vector(45.41228281818191, -93.023015),
                    new Vector(45.2985408181819, -93.01898300000001),
                    new Vector(45.2975958181819, -92.746589),
                    new Vector(45.31819681818191, -92.707385),
                    new Vector(45.3630708181818, -92.684876),
                    new Vector(45.39546181818189, -92.6487589999999),
                    new Vector(45.4394538181818, -92.64497),
                    new Vector(45.4552218181819, -92.654816),
                    new Vector(45.4700538181819, -92.68541600000002),
                    new Vector(45.5472468181818, -92.72815699999998),
                    new Vector(45.5642658181818, -92.76217699999998),
                    new Vector(45.5634018181819, -92.835032),
                    new Vector(45.5788368181818, -92.876828),
                    new Vector(45.6449508181818, -92.885396),
                    new Vector(45.7105608181819, -92.860016),
                    new Vector(45.7308918181819, -92.8336369999999),
                    new Vector(45.7633368181819, -92.779106),
                    new Vector(45.8372988181819, -92.74876700000002),
                    new Vector(45.8449848181818, -92.73409699999999),
                    new Vector(45.8909568181819, -92.706242),
                    new Vector(45.9156978181819, -92.66620999999989),
                    new Vector(45.95127481818179, -92.55267499999988),
                    new Vector(45.9825858181818, -92.523974),
                    new Vector(45.9811998181819, -92.46234199999991),
                    new Vector(46.0254978181818, -92.42500100000001),
                    new Vector(46.0162458181819, -92.36496200000001),
                    new Vector(46.0225998181818, -92.34622400000001),
                    new Vector(46.0568808181819, -92.32736900000002),
                    new Vector(46.0732248181819, -92.289371),
                    new Vector(46.15660081818181, -92.288948),
                    new Vector(46.4159808181819, -92.288678),
                    new Vector(46.6587828181817, -92.287274),
                    new Vector(46.6665768181819, -92.303141),
                    new Vector(46.76429881818191, -92.30213300000001),
                    new Vector(46.7660178181819, -93.059861),
                    new Vector(47.0223018181819, -93.058466),
                    new Vector(47.0304018181818, -93.7752349999999),
                    new Vector(47.2096548181819, -93.77626100000001),
                    new Vector(47.21835781818189, -93.792191),
                    new Vector(47.24146981818191, -93.80306299999999),
                    new Vector(47.25953281818191, -93.784199),
                    new Vector(47.3009868181818, -93.78223699999999),
                    new Vector(47.3017248181819, -93.83243899999999),
                    new Vector(47.3228748181818, -93.876638),
                    new Vector(47.2937688181818, -93.909452),
                    new Vector(47.30570281818189, -93.93901700000001),
                    new Vector(47.3320548181818, -93.963542),
                    new Vector(47.348677818182, -94.018226),
                    new Vector(47.3760468181818, -94.03953799999989),
                    new Vector(47.4192738181819, -94.040519),
                    new Vector(47.4685578181819, -94.08149600000002),
                    new Vector(47.4783678181819, -94.104986),
                    new Vector(47.47602781818191, -94.133651),
                    new Vector(47.41798681818181, -94.30975399999991),
                    new Vector(47.4340428181819, -94.416152),
                    new Vector(47.4132888181817, -94.417277),
                    new Vector(47.4128748181818, -94.66851200000001),
                    new Vector(47.4137568181819, -95.18528299999998),
                    new Vector(47.3263128181819, -95.184365),
                    new Vector(47.3250978181819, -95.16886699999999),
                    new Vector(47.15041681818191, -95.175104),
                    new Vector(47.1517758181819, -95.553788),
                    new Vector(47.1542688181819, -96.071648),
                    new Vector(47.15243281818191, -96.195722),
                    new Vector(47.1518838181819, -96.83916799999999),
                    new Vector(47.0926008181819, -96.81915199999999),
                    new Vector(47.0788398181818, -96.826964),
                    new Vector(47.0339388181819, -96.82260799999999),
                    new Vector(47.0102238181819, -96.83529799999999),
                    new Vector(47.0034378181819, -96.82452499999989),
                    new Vector(46.9697778181819, -96.816776),
                    new Vector(46.9696428181819, -96.79343),
                    new Vector(46.955845818182, -96.80189000000001),
                    new Vector(46.9481958181819, -96.78971300000001),
                    new Vector(46.93218481818201, -96.78793099999999),
                    new Vector(46.9362618181819, -96.763064),
                    new Vector(46.9227798181818, -96.75690800000001),
                    new Vector(46.8673488181818, -96.77806699999999),
                    new Vector(46.84486681818191, -96.76825700000002),
                    new Vector(46.8120348181819, -96.797201),
                    new Vector(46.76230981818181, -96.78037999999999),
                    new Vector(46.7070498181818, -96.781559),
                    new Vector(46.6787988181818, -96.7936909999999),
                    new Vector(46.6297758181819, -96.790244),
                    new Vector(46.6241058181819, -96.784322),
                    new Vector(46.5999858181819, -96.77104700000001),
                    new Vector(46.5886188181819, -96.75122899999998),
                    new Vector(46.4894388181819, -96.74032099999999),
                    new Vector(46.4687208181819, -96.714887),
                    new Vector(46.42717681818191, -96.70968499999999),
                    new Vector(46.4122188181819, -96.68822900000001),
                    new Vector(46.3594338181818, -96.652103),
                    new Vector(46.3508118181818, -96.614861),
                    new Vector(46.3363308181818, -96.60207199999989),
                    new Vector(46.2386808181819, -96.59818399999999),
                    new Vector(46.2154068181818, -96.58645699999991),
                    new Vector(46.1919168181819, -96.58788799999999),
                    new Vector(46.1771748181818, -96.57116600000001),
                    new Vector(46.0955268181819, -96.551924),
                    new Vector(46.02128581818181, -96.576215),
                    new Vector(45.9476838181818, -96.5617969999999),
                    new Vector(45.9341118181819, -96.566918),
                    new Vector(45.8178588181819, -96.58795099999999),
                    new Vector(45.8082648181819, -96.60460999999989),
                    new Vector(45.7389738181819, -96.65739499999999),
                    new Vector(45.65069281818191, -96.832796),
                    new Vector(45.6091218181819, -96.85499),
                    new Vector(45.5840928181818, -96.8430919999999),
                    new Vector(45.58716181818189, -96.257381),
                    new Vector(45.5858928181819, -96.246167),
                    new Vector(45.4118328181819, -96.24485300000001),
                    new Vector(45.4100148181818, -96.124289),
                    new Vector(45.41254381818181, -95.74523600000001),
                    new Vector(45.4093848181819, -95.261054),
                    new Vector(45.4115538181818, -95.13379400000001),
                    new Vector(45.4136238181818, -94.765298),
                    new Vector(45.32529781818181, -94.76548699999999),
                    new Vector(45.3270438181818, -94.3786939999999),
                    new Vector(45.2846358181818, -94.374959),
                    new Vector(45.28458181818179, -94.26142400000001),
                    new Vector(45.3109608181818, -94.25291899999999),
                    new Vector(45.322156818182, -94.19465300000002),
                    new Vector(45.3044088181819, -94.165511),
                    new Vector(45.3292038181818, -94.1230939999999),
                    new Vector(45.3498498181818, -94.094663),
                    new Vector(45.4314078181819, -94.050212),
                    new Vector(45.4862358181817, -94.13331800000002),
                    new Vector(45.5195898181819, -94.147997),
                    new Vector(45.5584428181818, -94.14940999999999),
                    new Vector(45.5616558181819, -93.760808),
                    new Vector(45.5585778181817, -93.51706999999999),
                    new Vector(45.4136688181818, -93.513569)
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