using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Ohio_North_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3734;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Ohio North";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Ohio North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.7],PARAMETER[standard_parallel_2,40.43333333333333],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,-82.5],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,3734],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Ohio North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,41.7],PARAMETER[standard_parallel_2,40.43333333333333],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,-82.5],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(40.2082848181819, -81.32926999999999),
                    new Vector(40.1646618181819, -81.331142),
                    new Vector(40.1616558181818, -81.219578),
                    new Vector(40.1640858181818, -81.10471099999999),
                    new Vector(40.1531238181818, -80.87779399999999),
                    new Vector(40.154086818182, -80.70206),
                    new Vector(40.1681808181819, -80.70089),
                    new Vector(40.1941548181818, -80.678552),
                    new Vector(40.2456798181819, -80.65011199999999),
                    new Vector(40.2764958181818, -80.614688),
                    new Vector(40.3062498181819, -80.6045179999999),
                    new Vector(40.3732728181819, -80.60924300000001),
                    new Vector(40.3886628181818, -80.62924099999999),
                    new Vector(40.3982298181818, -80.62784600000001),
                    new Vector(40.4805348181818, -80.601827),
                    new Vector(40.5044658181819, -80.6252539999999),
                    new Vector(40.5391968181819, -80.63343500000001),
                    new Vector(40.568284818182, -80.668616),
                    new Vector(40.5821358181819, -80.667725),
                    new Vector(40.6139778181818, -80.637332),
                    new Vector(40.6200618181817, -80.61155599999999),
                    new Vector(40.6159758181819, -80.574422),
                    new Vector(40.6371978181819, -80.521997),
                    new Vector(40.8541698181818, -80.52030499999989),
                    new Vector(40.8972708181818, -80.520926),
                    new Vector(41.1296238181818, -80.5229329999999),
                    new Vector(41.4892908181819, -80.519999),
                    new Vector(41.4950958181818, -80.5239229999999),
                    new Vector(41.8507758181818, -80.522645),
                    new Vector(41.9868738181819, -80.52059300000001),
                    new Vector(41.8502538181818, -80.999771),
                    new Vector(41.7242808181819, -81.362264),
                    new Vector(41.6317158181818, -81.47826499999999),
                    new Vector(41.4911538181818, -81.7385),
                    new Vector(41.5019178181819, -81.9619069999999),
                    new Vector(41.5153098181819, -82.01561),
                    new Vector(41.4315018181818, -82.34138299999999),
                    new Vector(41.3913348181819, -82.548833),
                    new Vector(41.4505278181818, -82.716944),
                    new Vector(41.4294768181819, -82.90893199999999),
                    new Vector(41.4561078181818, -83.070401),
                    new Vector(41.5074168181818, -82.784705),
                    new Vector(41.5376478181819, -82.795829),
                    new Vector(41.5381878181819, -83.003432),
                    new Vector(41.6260908181818, -83.153741),
                    new Vector(41.7251268181819, -83.482691),
                    new Vector(41.7170448181818, -83.763959),
                    new Vector(41.7159918181819, -83.868638),
                    new Vector(41.7080358181819, -84.35921),
                    new Vector(41.7071538181818, -84.38439200000001),
                    new Vector(41.6974878181819, -84.790373),
                    new Vector(41.5304928181819, -84.791372),
                    new Vector(41.4279018181818, -84.791903),
                    new Vector(41.2838208181818, -84.790976),
                    new Vector(41.2531398181819, -84.791579),
                    new Vector(40.9883418181819, -84.790526),
                    new Vector(40.9377078181818, -84.79103000000001),
                    new Vector(40.7288628181819, -84.793064),
                    new Vector(40.5887328181818, -84.79325300000001),
                    new Vector(40.3530588181819, -84.79455799999999),
                    new Vector(40.3528608181818, -84.42671),
                    new Vector(40.1911308181819, -84.4243069999999),
                    new Vector(40.1961258181818, -84.24857299999999),
                    new Vector(40.1795298181819, -84.020162),
                    new Vector(40.2709878181819, -84.009182),
                    new Vector(40.2589998181818, -83.779844),
                    new Vector(40.2403518181818, -83.78001500000001),
                    new Vector(40.2268698181818, -83.544674),
                    new Vector(40.2213078181819, -83.48990000000001),
                    new Vector(40.1136228181819, -83.499566),
                    new Vector(40.1073048181818, -83.20568),
                    new Vector(40.1070168181818, -83.17193899999999),
                    new Vector(40.1379858181818, -83.170175),
                    new Vector(40.1232348181819, -82.7564),
                    new Vector(40.2741288181817, -82.742756),
                    new Vector(40.2618528181819, -82.473944),
                    new Vector(40.2413328181819, -82.47614),
                    new Vector(40.2313608181818, -82.19139800000001),
                    new Vector(40.2314868181819, -82.175738),
                    new Vector(40.1595048181819, -82.1824699999999),
                    new Vector(40.1448258181818, -81.711203),
                    new Vector(40.1444928181818, -81.66662599999999),
                    new Vector(40.2127038181819, -81.66276499999999),
                    new Vector(40.2124878181818, -81.61394),
                    new Vector(40.2082848181819, -81.32926999999999)
                })
            }
        };
    }
}