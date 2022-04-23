using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Minnesota_Central_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 26850;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Minnesota Central";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Minnesota Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,47.05],PARAMETER[standard_parallel_2,45.61666666666667],PARAMETER[latitude_of_origin,45],PARAMETER[central_meridian,-94.25],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],AUTHORITY[EPSG,26850],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Minnesota Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,47.05],PARAMETER[standard_parallel_2,45.61666666666667],PARAMETER[latitude_of_origin,45],PARAMETER[central_meridian,-94.25],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-93.513569, 45.4136688181818, 0),
                    new Vector(-93.023015, 45.41228281818191, 0),
                    new Vector(-93.01898300000001, 45.2985408181819, 0),
                    new Vector(-92.746589, 45.2975958181819, 0),
                    new Vector(-92.707385, 45.31819681818191, 0),
                    new Vector(-92.684876, 45.3630708181818, 0),
                    new Vector(-92.6487589999999, 45.39546181818189, 0),
                    new Vector(-92.64497, 45.4394538181818, 0),
                    new Vector(-92.654816, 45.4552218181819, 0),
                    new Vector(-92.68541600000002, 45.4700538181819, 0),
                    new Vector(-92.72815699999998, 45.5472468181818, 0),
                    new Vector(-92.76217699999998, 45.5642658181818, 0),
                    new Vector(-92.835032, 45.5634018181819, 0),
                    new Vector(-92.876828, 45.5788368181818, 0),
                    new Vector(-92.885396, 45.6449508181818, 0),
                    new Vector(-92.860016, 45.7105608181819, 0),
                    new Vector(-92.8336369999999, 45.7308918181819, 0),
                    new Vector(-92.779106, 45.7633368181819, 0),
                    new Vector(-92.74876700000002, 45.8372988181819, 0),
                    new Vector(-92.73409699999999, 45.8449848181818, 0),
                    new Vector(-92.706242, 45.8909568181819, 0),
                    new Vector(-92.66620999999989, 45.9156978181819, 0),
                    new Vector(-92.55267499999988, 45.95127481818179, 0),
                    new Vector(-92.523974, 45.9825858181818, 0),
                    new Vector(-92.46234199999991, 45.9811998181819, 0),
                    new Vector(-92.42500100000001, 46.0254978181818, 0),
                    new Vector(-92.36496200000001, 46.0162458181819, 0),
                    new Vector(-92.34622400000001, 46.0225998181818, 0),
                    new Vector(-92.32736900000002, 46.0568808181819, 0),
                    new Vector(-92.289371, 46.0732248181819, 0),
                    new Vector(-92.288948, 46.15660081818181, 0),
                    new Vector(-92.288678, 46.4159808181819, 0),
                    new Vector(-92.287274, 46.6587828181817, 0),
                    new Vector(-92.303141, 46.6665768181819, 0),
                    new Vector(-92.30213300000001, 46.76429881818191, 0),
                    new Vector(-93.059861, 46.7660178181819, 0),
                    new Vector(-93.058466, 47.0223018181819, 0),
                    new Vector(-93.7752349999999, 47.0304018181818, 0),
                    new Vector(-93.77626100000001, 47.2096548181819, 0),
                    new Vector(-93.792191, 47.21835781818189, 0),
                    new Vector(-93.80306299999999, 47.24146981818191, 0),
                    new Vector(-93.784199, 47.25953281818191, 0),
                    new Vector(-93.78223699999999, 47.3009868181818, 0),
                    new Vector(-93.83243899999999, 47.3017248181819, 0),
                    new Vector(-93.876638, 47.3228748181818, 0),
                    new Vector(-93.909452, 47.2937688181818, 0),
                    new Vector(-93.93901700000001, 47.30570281818189, 0),
                    new Vector(-93.963542, 47.3320548181818, 0),
                    new Vector(-94.018226, 47.348677818182, 0),
                    new Vector(-94.03953799999989, 47.3760468181818, 0),
                    new Vector(-94.040519, 47.4192738181819, 0),
                    new Vector(-94.08149600000002, 47.4685578181819, 0),
                    new Vector(-94.104986, 47.4783678181819, 0),
                    new Vector(-94.133651, 47.47602781818191, 0),
                    new Vector(-94.30975399999991, 47.41798681818181, 0),
                    new Vector(-94.416152, 47.4340428181819, 0),
                    new Vector(-94.417277, 47.4132888181817, 0),
                    new Vector(-94.66851200000001, 47.4128748181818, 0),
                    new Vector(-95.18528299999998, 47.4137568181819, 0),
                    new Vector(-95.184365, 47.3263128181819, 0),
                    new Vector(-95.16886699999999, 47.3250978181819, 0),
                    new Vector(-95.175104, 47.15041681818191, 0),
                    new Vector(-95.553788, 47.1517758181819, 0),
                    new Vector(-96.071648, 47.1542688181819, 0),
                    new Vector(-96.195722, 47.15243281818191, 0),
                    new Vector(-96.83916799999999, 47.1518838181819, 0),
                    new Vector(-96.81915199999999, 47.0926008181819, 0),
                    new Vector(-96.826964, 47.0788398181818, 0),
                    new Vector(-96.82260799999999, 47.0339388181819, 0),
                    new Vector(-96.83529799999999, 47.0102238181819, 0),
                    new Vector(-96.82452499999989, 47.0034378181819, 0),
                    new Vector(-96.816776, 46.9697778181819, 0),
                    new Vector(-96.79343, 46.9696428181819, 0),
                    new Vector(-96.80189000000001, 46.955845818182, 0),
                    new Vector(-96.78971300000001, 46.9481958181819, 0),
                    new Vector(-96.78793099999999, 46.93218481818201, 0),
                    new Vector(-96.763064, 46.9362618181819, 0),
                    new Vector(-96.75690800000001, 46.9227798181818, 0),
                    new Vector(-96.77806699999999, 46.8673488181818, 0),
                    new Vector(-96.76825700000002, 46.84486681818191, 0),
                    new Vector(-96.797201, 46.8120348181819, 0),
                    new Vector(-96.78037999999999, 46.76230981818181, 0),
                    new Vector(-96.781559, 46.7070498181818, 0),
                    new Vector(-96.7936909999999, 46.6787988181818, 0),
                    new Vector(-96.790244, 46.6297758181819, 0),
                    new Vector(-96.784322, 46.6241058181819, 0),
                    new Vector(-96.77104700000001, 46.5999858181819, 0),
                    new Vector(-96.75122899999998, 46.5886188181819, 0),
                    new Vector(-96.74032099999999, 46.4894388181819, 0),
                    new Vector(-96.714887, 46.4687208181819, 0),
                    new Vector(-96.70968499999999, 46.42717681818191, 0),
                    new Vector(-96.68822900000001, 46.4122188181819, 0),
                    new Vector(-96.652103, 46.3594338181818, 0),
                    new Vector(-96.614861, 46.3508118181818, 0),
                    new Vector(-96.60207199999989, 46.3363308181818, 0),
                    new Vector(-96.59818399999999, 46.2386808181819, 0),
                    new Vector(-96.58645699999991, 46.2154068181818, 0),
                    new Vector(-96.58788799999999, 46.1919168181819, 0),
                    new Vector(-96.57116600000001, 46.1771748181818, 0),
                    new Vector(-96.551924, 46.0955268181819, 0),
                    new Vector(-96.576215, 46.02128581818181, 0),
                    new Vector(-96.5617969999999, 45.9476838181818, 0),
                    new Vector(-96.566918, 45.9341118181819, 0),
                    new Vector(-96.58795099999999, 45.8178588181819, 0),
                    new Vector(-96.60460999999989, 45.8082648181819, 0),
                    new Vector(-96.65739499999999, 45.7389738181819, 0),
                    new Vector(-96.832796, 45.65069281818191, 0),
                    new Vector(-96.85499, 45.6091218181819, 0),
                    new Vector(-96.8430919999999, 45.5840928181818, 0),
                    new Vector(-96.257381, 45.58716181818189, 0),
                    new Vector(-96.246167, 45.5858928181819, 0),
                    new Vector(-96.24485300000001, 45.4118328181819, 0),
                    new Vector(-96.124289, 45.4100148181818, 0),
                    new Vector(-95.74523600000001, 45.41254381818181, 0),
                    new Vector(-95.261054, 45.4093848181819, 0),
                    new Vector(-95.13379400000001, 45.4115538181818, 0),
                    new Vector(-94.765298, 45.4136238181818, 0),
                    new Vector(-94.76548699999999, 45.32529781818181, 0),
                    new Vector(-94.3786939999999, 45.3270438181818, 0),
                    new Vector(-94.374959, 45.2846358181818, 0),
                    new Vector(-94.26142400000001, 45.28458181818179, 0),
                    new Vector(-94.25291899999999, 45.3109608181818, 0),
                    new Vector(-94.19465300000002, 45.322156818182, 0),
                    new Vector(-94.165511, 45.3044088181819, 0),
                    new Vector(-94.1230939999999, 45.3292038181818, 0),
                    new Vector(-94.094663, 45.3498498181818, 0),
                    new Vector(-94.050212, 45.4314078181819, 0),
                    new Vector(-94.13331800000002, 45.4862358181817, 0),
                    new Vector(-94.147997, 45.5195898181819, 0),
                    new Vector(-94.14940999999999, 45.5584428181818, 0),
                    new Vector(-93.760808, 45.5616558181819, 0),
                    new Vector(-93.51706999999999, 45.5585778181817, 0),
                    new Vector(-93.513569, 45.4136688181818, 0)
                })
            }
        };
    }
}