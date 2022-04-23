using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Ohio_North_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3734;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Ohio North";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Ohio North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.7],PARAMETER[standard_parallel_2,40.43333333333333],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,-82.5],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,3734],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Ohio North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,41.7],PARAMETER[standard_parallel_2,40.43333333333333],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,-82.5],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-81.32926999999999, 40.2082848181819, 0),
                    new Vector(-81.331142, 40.1646618181819, 0),
                    new Vector(-81.219578, 40.1616558181818, 0),
                    new Vector(-81.10471099999999, 40.1640858181818, 0),
                    new Vector(-80.87779399999999, 40.1531238181818, 0),
                    new Vector(-80.70206, 40.154086818182, 0),
                    new Vector(-80.70089, 40.1681808181819, 0),
                    new Vector(-80.678552, 40.1941548181818, 0),
                    new Vector(-80.65011199999999, 40.2456798181819, 0),
                    new Vector(-80.614688, 40.2764958181818, 0),
                    new Vector(-80.6045179999999, 40.3062498181819, 0),
                    new Vector(-80.60924300000001, 40.3732728181819, 0),
                    new Vector(-80.62924099999999, 40.3886628181818, 0),
                    new Vector(-80.62784600000001, 40.3982298181818, 0),
                    new Vector(-80.601827, 40.4805348181818, 0),
                    new Vector(-80.6252539999999, 40.5044658181819, 0),
                    new Vector(-80.63343500000001, 40.5391968181819, 0),
                    new Vector(-80.668616, 40.568284818182, 0),
                    new Vector(-80.667725, 40.5821358181819, 0),
                    new Vector(-80.637332, 40.6139778181818, 0),
                    new Vector(-80.61155599999999, 40.6200618181817, 0),
                    new Vector(-80.574422, 40.6159758181819, 0),
                    new Vector(-80.521997, 40.6371978181819, 0),
                    new Vector(-80.52030499999989, 40.8541698181818, 0),
                    new Vector(-80.520926, 40.8972708181818, 0),
                    new Vector(-80.5229329999999, 41.1296238181818, 0),
                    new Vector(-80.519999, 41.4892908181819, 0),
                    new Vector(-80.5239229999999, 41.4950958181818, 0),
                    new Vector(-80.522645, 41.8507758181818, 0),
                    new Vector(-80.52059300000001, 41.9868738181819, 0),
                    new Vector(-80.999771, 41.8502538181818, 0),
                    new Vector(-81.362264, 41.7242808181819, 0),
                    new Vector(-81.47826499999999, 41.6317158181818, 0),
                    new Vector(-81.7385, 41.4911538181818, 0),
                    new Vector(-81.9619069999999, 41.5019178181819, 0),
                    new Vector(-82.01561, 41.5153098181819, 0),
                    new Vector(-82.34138299999999, 41.4315018181818, 0),
                    new Vector(-82.548833, 41.3913348181819, 0),
                    new Vector(-82.716944, 41.4505278181818, 0),
                    new Vector(-82.90893199999999, 41.4294768181819, 0),
                    new Vector(-83.070401, 41.4561078181818, 0),
                    new Vector(-82.784705, 41.5074168181818, 0),
                    new Vector(-82.795829, 41.5376478181819, 0),
                    new Vector(-83.003432, 41.5381878181819, 0),
                    new Vector(-83.153741, 41.6260908181818, 0),
                    new Vector(-83.482691, 41.7251268181819, 0),
                    new Vector(-83.763959, 41.7170448181818, 0),
                    new Vector(-83.868638, 41.7159918181819, 0),
                    new Vector(-84.35921, 41.7080358181819, 0),
                    new Vector(-84.38439200000001, 41.7071538181818, 0),
                    new Vector(-84.790373, 41.6974878181819, 0),
                    new Vector(-84.791372, 41.5304928181819, 0),
                    new Vector(-84.791903, 41.4279018181818, 0),
                    new Vector(-84.790976, 41.2838208181818, 0),
                    new Vector(-84.791579, 41.2531398181819, 0),
                    new Vector(-84.790526, 40.9883418181819, 0),
                    new Vector(-84.79103000000001, 40.9377078181818, 0),
                    new Vector(-84.793064, 40.7288628181819, 0),
                    new Vector(-84.79325300000001, 40.5887328181818, 0),
                    new Vector(-84.79455799999999, 40.3530588181819, 0),
                    new Vector(-84.42671, 40.3528608181818, 0),
                    new Vector(-84.4243069999999, 40.1911308181819, 0),
                    new Vector(-84.24857299999999, 40.1961258181818, 0),
                    new Vector(-84.020162, 40.1795298181819, 0),
                    new Vector(-84.009182, 40.2709878181819, 0),
                    new Vector(-83.779844, 40.2589998181818, 0),
                    new Vector(-83.78001500000001, 40.2403518181818, 0),
                    new Vector(-83.544674, 40.2268698181818, 0),
                    new Vector(-83.48990000000001, 40.2213078181819, 0),
                    new Vector(-83.499566, 40.1136228181819, 0),
                    new Vector(-83.20568, 40.1073048181818, 0),
                    new Vector(-83.17193899999999, 40.1070168181818, 0),
                    new Vector(-83.170175, 40.1379858181818, 0),
                    new Vector(-82.7564, 40.1232348181819, 0),
                    new Vector(-82.742756, 40.2741288181817, 0),
                    new Vector(-82.473944, 40.2618528181819, 0),
                    new Vector(-82.47614, 40.2413328181819, 0),
                    new Vector(-82.19139800000001, 40.2313608181818, 0),
                    new Vector(-82.175738, 40.2314868181819, 0),
                    new Vector(-82.1824699999999, 40.1595048181819, 0),
                    new Vector(-81.711203, 40.1448258181818, 0),
                    new Vector(-81.66662599999999, 40.1444928181818, 0),
                    new Vector(-81.66276499999999, 40.2127038181819, 0),
                    new Vector(-81.61394, 40.2124878181818, 0),
                    new Vector(-81.32926999999999, 40.2082848181819, 0)
                })
            }
        };
    }
}