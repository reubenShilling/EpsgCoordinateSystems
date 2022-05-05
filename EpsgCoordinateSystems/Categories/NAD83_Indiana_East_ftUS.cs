using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Indiana_East_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2965;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Indiana East";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Indiana East (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-85.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,328083.333],PARAMETER[false_northing,820208.3330000002],AUTHORITY[EPSG,2965],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Indiana East (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-85.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,328083.333],PARAMETER[false_northing,820208.3330000002],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-84.81147799999989, 39.1025808181818, 0),
                    new Vector(-84.812072, 39.3030288181818, 0),
                    new Vector(-84.812027, 39.3123348181819, 0),
                    new Vector(-84.811109, 39.5131608181817, 0),
                    new Vector(-84.811037, 39.5640558181818, 0),
                    new Vector(-84.8086969999999, 39.7333008181818, 0),
                    new Vector(-84.80615899999999, 39.9171618181819, 0),
                    new Vector(-84.803567, 40.0139928181817, 0),
                    new Vector(-84.795395, 40.3194978181818, 0),
                    new Vector(-84.79455799999999, 40.3530588181819, 0),
                    new Vector(-84.79325300000001, 40.5887328181818, 0),
                    new Vector(-84.793064, 40.7288628181819, 0),
                    new Vector(-84.79103000000001, 40.9377078181818, 0),
                    new Vector(-84.790526, 40.9883418181819, 0),
                    new Vector(-84.791579, 41.2531398181819, 0),
                    new Vector(-84.790976, 41.2838208181818, 0),
                    new Vector(-84.791903, 41.4279018181818, 0),
                    new Vector(-84.791372, 41.5304928181819, 0),
                    new Vector(-84.790373, 41.6974878181819, 0),
                    new Vector(-84.788483, 41.7609648181819, 0),
                    new Vector(-84.826013, 41.7618738181818, 0),
                    new Vector(-85.19313200000001, 41.7628638181818, 0),
                    new Vector(-85.297208, 41.7635838181819, 0),
                    new Vector(-85.65946700000001, 41.7626298181818, 0),
                    new Vector(-85.799228, 41.7635388181819, 0),
                    new Vector(-86.06830100000001, 41.7646278181819, 0),
                    new Vector(-86.2345669999999, 41.7648618181819, 0),
                    new Vector(-86.52518600000001, 41.7655368181818, 0),
                    new Vector(-86.52530299999999, 41.6610828181819, 0),
                    new Vector(-86.4860089999999, 41.6597058181819, 0),
                    new Vector(-86.4857209999999, 41.5806768181819, 0),
                    new Vector(-86.498591, 41.5668978181819, 0),
                    new Vector(-86.50584499999999, 41.5261908181819, 0),
                    new Vector(-86.530406, 41.5258578181819, 0),
                    new Vector(-86.529128, 41.4399978181818, 0),
                    new Vector(-86.47570399999999, 41.4423828181818, 0),
                    new Vector(-86.47312100000001, 41.1744348181819, 0),
                    new Vector(-86.479232, 40.9171968181819, 0),
                    new Vector(-86.588762, 40.9165848181818, 0),
                    new Vector(-86.582984, 40.7467098181818, 0),
                    new Vector(-86.524772, 40.7453508181819, 0),
                    new Vector(-86.52229699999999, 40.7030868181819, 0),
                    new Vector(-86.377343, 40.7027898181819, 0),
                    new Vector(-86.372546, 40.5774198181819, 0),
                    new Vector(-86.37572299999989, 40.435921818182, 0),
                    new Vector(-86.30747599999999, 40.435129818182, 0),
                    new Vector(-86.305649, 40.3951428181819, 0),
                    new Vector(-86.27369, 40.3938828181819, 0),
                    new Vector(-86.27252, 40.3797798181819, 0),
                    new Vector(-86.240426, 40.3816788181818, 0),
                    new Vector(-86.2431619999999, 40.2288588181819, 0),
                    new Vector(-86.2445299999999, 40.1857848181818, 0),
                    new Vector(-86.25120800000001, 39.9323538181819, 0),
                    new Vector(-86.339462, 39.9314268181819, 0),
                    new Vector(-86.33525899999999, 39.6319518181818, 0),
                    new Vector(-86.25879500000001, 39.6313668181819, 0),
                    new Vector(-86.259596, 39.3343038181819, 0),
                    new Vector(-86.391158, 39.3335658181818, 0),
                    new Vector(-86.382689, 39.0462858181819, 0),
                    new Vector(-86.332919, 39.0459348181818, 0),
                    new Vector(-86.329814, 38.9946078181819, 0),
                    new Vector(-86.29425500000001, 38.9950578181819, 0),
                    new Vector(-86.28404, 38.7707598181818, 0),
                    new Vector(-86.29682, 38.7620298181818, 0),
                    new Vector(-86.30675599999999, 38.7373428181818, 0),
                    new Vector(-86.318609, 38.7362808181819, 0),
                    new Vector(-86.31777200000001, 38.6877438181819, 0),
                    new Vector(-86.311364, 38.4154938181818, 0),
                    new Vector(-86.26438400000001, 38.4147198181819, 0),
                    new Vector(-86.269397, 38.4076008181819, 0),
                    new Vector(-86.25406099999989, 38.3822478181819, 0),
                    new Vector(-86.26559899999999, 38.3739408181818, 0),
                    new Vector(-86.251811, 38.3536278181819, 0),
                    new Vector(-86.25924500000001, 38.3447448181818, 0),
                    new Vector(-86.271152, 38.3545818181818, 0),
                    new Vector(-86.27757800000001, 38.3284548181819, 0),
                    new Vector(-86.293166, 38.3211558181819, 0),
                    new Vector(-86.259038, 38.2830768181819, 0),
                    new Vector(-86.280998, 38.2772988181819, 0),
                    new Vector(-86.274959, 38.2544658181818, 0),
                    new Vector(-86.23688, 38.2271508181818, 0),
                    new Vector(-86.266751, 38.2143438181818, 0),
                    new Vector(-86.281772, 38.2192758181818, 0),
                    new Vector(-86.297819, 38.214244818182, 0),
                    new Vector(-86.32235300000001, 38.1890358181819, 0),
                    new Vector(-86.31925699999989, 38.1794328181818, 0),
                    new Vector(-86.3416129999999, 38.1772908181818, 0),
                    new Vector(-86.297675, 38.1502998181818, 0),
                    new Vector(-86.291438, 38.0784888181819, 0),
                    new Vector(-86.277704, 38.058175818182, 0),
                    new Vector(-86.25215300000001, 38.0407158181819, 0),
                    new Vector(-86.19062, 38.0177568181819, 0),
                    new Vector(-86.104985, 38.0113398181819, 0),
                    new Vector(-86.052722, 37.9667808181819, 0),
                    new Vector(-86.0316169999999, 37.9929528181819, 0),
                    new Vector(-86.00666, 38.0017638181818, 0),
                    new Vector(-85.95858200000001, 38.0118348181818, 0),
                    new Vector(-85.930871, 38.0340468181818, 0),
                    new Vector(-85.91475199999999, 38.0648718181819, 0),
                    new Vector(-85.91207, 38.179999818182, 0),
                    new Vector(-85.85233700000001, 38.2385628181819, 0),
                    new Vector(-85.83990799999999, 38.2762908181818, 0),
                    new Vector(-85.80655400000001, 38.2861818181818, 0),
                    new Vector(-85.786205, 38.2823928181818, 0),
                    new Vector(-85.74692899999999, 38.2703148181819, 0),
                    new Vector(-85.681391, 38.3009508181818, 0),
                    new Vector(-85.654229, 38.3377518181819, 0),
                    new Vector(-85.643591, 38.3836878181818, 0),
                    new Vector(-85.6126399999999, 38.4466698181819, 0),
                    new Vector(-85.50719599999999, 38.4714198181819, 0),
                    new Vector(-85.466381, 38.5181748181819, 0),
                    new Vector(-85.43237000000001, 38.5370208181819, 0),
                    new Vector(-85.417466, 38.5614738181819, 0),
                    new Vector(-85.424396, 38.5848378181818, 0),
                    new Vector(-85.453682, 38.6946738181819, 0),
                    new Vector(-85.44668900000001, 38.7248328181818, 0),
                    new Vector(-85.41818600000001, 38.7384138181818, 0),
                    new Vector(-85.335008, 38.7370098181819, 0),
                    new Vector(-85.271387, 38.7443718181818, 0),
                    new Vector(-85.20516499999999, 38.6958168181819, 0),
                    new Vector(-85.160939, 38.6951688181818, 0),
                    new Vector(-85.11965600000001, 38.7141408181819, 0),
                    new Vector(-85.068455, 38.7504288181818, 0),
                    new Vector(-85.025075, 38.7642888181818, 0),
                    new Vector(-84.975611, 38.7806418181818, 0),
                    new Vector(-84.818786, 38.7934128181819, 0),
                    new Vector(-84.8244289999999, 38.8344618181819, 0),
                    new Vector(-84.7874479999999, 38.8666458181819, 0),
                    new Vector(-84.788663, 38.8843848181818, 0),
                    new Vector(-84.8032249999999, 38.8971918181819, 0),
                    new Vector(-84.859745, 38.9020428181818, 0),
                    new Vector(-84.875252, 38.9094228181819, 0),
                    new Vector(-84.875882, 38.9276028181819, 0),
                    new Vector(-84.846317, 38.9546298181819, 0),
                    new Vector(-84.834446, 38.9827728181818, 0),
                    new Vector(-84.844229, 39.0058308181818, 0),
                    new Vector(-84.876287, 39.0328938181819, 0),
                    new Vector(-84.89000299999999, 39.0506418181819, 0),
                    new Vector(-84.886709, 39.065041818182, 0),
                    new Vector(-84.827867, 39.1036878181819, 0),
                    new Vector(-84.81147799999989, 39.1025808181818, 0)
                })
            }
        };
    }
}