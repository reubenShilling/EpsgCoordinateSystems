using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Indiana_East_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2965;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Indiana East";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Indiana East (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",37.5],PARAMETER[\"central_meridian\",-85.66666666666667],PARAMETER[\"scale_factor\",0.999966667],PARAMETER[\"false_easting\",328083.333],PARAMETER[\"false_northing\",820208.3330000002],AUTHORITY[\"EPSG\",\"2965\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Indiana East (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",37.5],PARAMETER[\"central_meridian\",-85.66666666666667],PARAMETER[\"scale_factor\",0.999966667],PARAMETER[\"false_easting\",328083.333],PARAMETER[\"false_northing\",820208.3330000002],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(39.1025808181818, -84.81147799999989),
                    new Vector(39.3030288181818, -84.812072),
                    new Vector(39.3123348181819, -84.812027),
                    new Vector(39.5131608181817, -84.811109),
                    new Vector(39.5640558181818, -84.811037),
                    new Vector(39.7333008181818, -84.8086969999999),
                    new Vector(39.9171618181819, -84.80615899999999),
                    new Vector(40.0139928181817, -84.803567),
                    new Vector(40.3194978181818, -84.795395),
                    new Vector(40.3530588181819, -84.79455799999999),
                    new Vector(40.5887328181818, -84.79325300000001),
                    new Vector(40.7288628181819, -84.793064),
                    new Vector(40.9377078181818, -84.79103000000001),
                    new Vector(40.9883418181819, -84.790526),
                    new Vector(41.2531398181819, -84.791579),
                    new Vector(41.2838208181818, -84.790976),
                    new Vector(41.4279018181818, -84.791903),
                    new Vector(41.5304928181819, -84.791372),
                    new Vector(41.6974878181819, -84.790373),
                    new Vector(41.7609648181819, -84.788483),
                    new Vector(41.7618738181818, -84.826013),
                    new Vector(41.7628638181818, -85.19313200000001),
                    new Vector(41.7635838181819, -85.297208),
                    new Vector(41.7626298181818, -85.65946700000001),
                    new Vector(41.7635388181819, -85.799228),
                    new Vector(41.7646278181819, -86.06830100000001),
                    new Vector(41.7648618181819, -86.2345669999999),
                    new Vector(41.7655368181818, -86.52518600000001),
                    new Vector(41.6610828181819, -86.52530299999999),
                    new Vector(41.6597058181819, -86.4860089999999),
                    new Vector(41.5806768181819, -86.4857209999999),
                    new Vector(41.5668978181819, -86.498591),
                    new Vector(41.5261908181819, -86.50584499999999),
                    new Vector(41.5258578181819, -86.530406),
                    new Vector(41.4399978181818, -86.529128),
                    new Vector(41.4423828181818, -86.47570399999999),
                    new Vector(41.1744348181819, -86.47312100000001),
                    new Vector(40.9171968181819, -86.479232),
                    new Vector(40.9165848181818, -86.588762),
                    new Vector(40.7467098181818, -86.582984),
                    new Vector(40.7453508181819, -86.524772),
                    new Vector(40.7030868181819, -86.52229699999999),
                    new Vector(40.7027898181819, -86.377343),
                    new Vector(40.5774198181819, -86.372546),
                    new Vector(40.435921818182, -86.37572299999989),
                    new Vector(40.435129818182, -86.30747599999999),
                    new Vector(40.3951428181819, -86.305649),
                    new Vector(40.3938828181819, -86.27369),
                    new Vector(40.3797798181819, -86.27252),
                    new Vector(40.3816788181818, -86.240426),
                    new Vector(40.2288588181819, -86.2431619999999),
                    new Vector(40.1857848181818, -86.2445299999999),
                    new Vector(39.9323538181819, -86.25120800000001),
                    new Vector(39.9314268181819, -86.339462),
                    new Vector(39.6319518181818, -86.33525899999999),
                    new Vector(39.6313668181819, -86.25879500000001),
                    new Vector(39.3343038181819, -86.259596),
                    new Vector(39.3335658181818, -86.391158),
                    new Vector(39.0462858181819, -86.382689),
                    new Vector(39.0459348181818, -86.332919),
                    new Vector(38.9946078181819, -86.329814),
                    new Vector(38.9950578181819, -86.29425500000001),
                    new Vector(38.7707598181818, -86.28404),
                    new Vector(38.7620298181818, -86.29682),
                    new Vector(38.7373428181818, -86.30675599999999),
                    new Vector(38.7362808181819, -86.318609),
                    new Vector(38.6877438181819, -86.31777200000001),
                    new Vector(38.4154938181818, -86.311364),
                    new Vector(38.4147198181819, -86.26438400000001),
                    new Vector(38.4076008181819, -86.269397),
                    new Vector(38.3822478181819, -86.25406099999989),
                    new Vector(38.3739408181818, -86.26559899999999),
                    new Vector(38.3536278181819, -86.251811),
                    new Vector(38.3447448181818, -86.25924500000001),
                    new Vector(38.3545818181818, -86.271152),
                    new Vector(38.3284548181819, -86.27757800000001),
                    new Vector(38.3211558181819, -86.293166),
                    new Vector(38.2830768181819, -86.259038),
                    new Vector(38.2772988181819, -86.280998),
                    new Vector(38.2544658181818, -86.274959),
                    new Vector(38.2271508181818, -86.23688),
                    new Vector(38.2143438181818, -86.266751),
                    new Vector(38.2192758181818, -86.281772),
                    new Vector(38.214244818182, -86.297819),
                    new Vector(38.1890358181819, -86.32235300000001),
                    new Vector(38.1794328181818, -86.31925699999989),
                    new Vector(38.1772908181818, -86.3416129999999),
                    new Vector(38.1502998181818, -86.297675),
                    new Vector(38.0784888181819, -86.291438),
                    new Vector(38.058175818182, -86.277704),
                    new Vector(38.0407158181819, -86.25215300000001),
                    new Vector(38.0177568181819, -86.19062),
                    new Vector(38.0113398181819, -86.104985),
                    new Vector(37.9667808181819, -86.052722),
                    new Vector(37.9929528181819, -86.0316169999999),
                    new Vector(38.0017638181818, -86.00666),
                    new Vector(38.0118348181818, -85.95858200000001),
                    new Vector(38.0340468181818, -85.930871),
                    new Vector(38.0648718181819, -85.91475199999999),
                    new Vector(38.179999818182, -85.91207),
                    new Vector(38.2385628181819, -85.85233700000001),
                    new Vector(38.2762908181818, -85.83990799999999),
                    new Vector(38.2861818181818, -85.80655400000001),
                    new Vector(38.2823928181818, -85.786205),
                    new Vector(38.2703148181819, -85.74692899999999),
                    new Vector(38.3009508181818, -85.681391),
                    new Vector(38.3377518181819, -85.654229),
                    new Vector(38.3836878181818, -85.643591),
                    new Vector(38.4466698181819, -85.6126399999999),
                    new Vector(38.4714198181819, -85.50719599999999),
                    new Vector(38.5181748181819, -85.466381),
                    new Vector(38.5370208181819, -85.43237000000001),
                    new Vector(38.5614738181819, -85.417466),
                    new Vector(38.5848378181818, -85.424396),
                    new Vector(38.6946738181819, -85.453682),
                    new Vector(38.7248328181818, -85.44668900000001),
                    new Vector(38.7384138181818, -85.41818600000001),
                    new Vector(38.7370098181819, -85.335008),
                    new Vector(38.7443718181818, -85.271387),
                    new Vector(38.6958168181819, -85.20516499999999),
                    new Vector(38.6951688181818, -85.160939),
                    new Vector(38.7141408181819, -85.11965600000001),
                    new Vector(38.7504288181818, -85.068455),
                    new Vector(38.7642888181818, -85.025075),
                    new Vector(38.7806418181818, -84.975611),
                    new Vector(38.7934128181819, -84.818786),
                    new Vector(38.8344618181819, -84.8244289999999),
                    new Vector(38.8666458181819, -84.7874479999999),
                    new Vector(38.8843848181818, -84.788663),
                    new Vector(38.8971918181819, -84.8032249999999),
                    new Vector(38.9020428181818, -84.859745),
                    new Vector(38.9094228181819, -84.875252),
                    new Vector(38.9276028181819, -84.875882),
                    new Vector(38.9546298181819, -84.846317),
                    new Vector(38.9827728181818, -84.834446),
                    new Vector(39.0058308181818, -84.844229),
                    new Vector(39.0328938181819, -84.876287),
                    new Vector(39.0506418181819, -84.89000299999999),
                    new Vector(39.065041818182, -84.886709),
                    new Vector(39.1036878181819, -84.827867),
                    new Vector(39.1025808181818, -84.81147799999989)
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