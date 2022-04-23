using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_New_Mexico_East_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2257;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New Mexico East";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / New Mexico East (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-104.3333333333333],PARAMETER[scale_factor,0.999909091],PARAMETER[false_easting,541337.5],PARAMETER[false_northing,0],AUTHORITY[EPSG,2257],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / New Mexico East (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-104.3333333333333],PARAMETER[scale_factor,0.999909091],PARAMETER[false_easting,541337.5],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-103.043102, 33.3778248181818, 0),
                    new Vector(-103.038737, 33.5658438181819, 0),
                    new Vector(-103.033256, 33.8261778181819, 0),
                    new Vector(-103.029638, 34.3078218181818, 0),
                    new Vector(-103.022663, 34.7453388181819, 0),
                    new Vector(-103.025255, 34.9647858181819, 0),
                    new Vector(-103.026155, 35.1772668181819, 0),
                    new Vector(-103.022294, 35.6236488181818, 0),
                    new Vector(-103.022609, 35.7423228181818, 0),
                    new Vector(-103.024049, 36.0560628181818, 0),
                    new Vector(-103.027289, 36.4915908181818, 0),
                    new Vector(-102.9974, 36.4923738181818, 0),
                    new Vector(-102.997706, 36.9985248181819, 0),
                    new Vector(-103.07786, 36.9997668181818, 0),
                    new Vector(-103.993637, 36.9944748181818, 0),
                    new Vector(-105.146168, 36.9932058181819, 0),
                    new Vector(-105.213092, 36.9926028181818, 0),
                    new Vector(-105.21698, 36.9614178181819, 0),
                    new Vector(-105.184265, 36.902305818182, 0),
                    new Vector(-105.217304, 36.8525268181819, 0),
                    new Vector(-105.204236, 36.8262558181819, 0),
                    new Vector(-105.214991, 36.7843878181818, 0),
                    new Vector(-105.199115, 36.7457688181818, 0),
                    new Vector(-105.231398, 36.7209198181819, 0),
                    new Vector(-105.257822, 36.7326378181819, 0),
                    new Vector(-105.290132, 36.7300098181819, 0),
                    new Vector(-105.306755, 36.7073748181819, 0),
                    new Vector(-105.337463, 36.7019658181818, 0),
                    new Vector(-105.354869, 36.6866118181819, 0),
                    new Vector(-105.338507, 36.6452748181818, 0),
                    new Vector(-105.358046, 36.6213528181819, 0),
                    new Vector(-105.338804, 36.5803848181819, 0),
                    new Vector(-105.350999, 36.5535288181818, 0),
                    new Vector(-105.309617, 36.497341818182, 0),
                    new Vector(-105.337436, 36.4555368181819, 0),
                    new Vector(-105.31328, 36.4230288181818, 0),
                    new Vector(-105.312029, 36.2963538181818, 0),
                    new Vector(-105.344699, 36.2705778181818, 0),
                    new Vector(-105.417473, 36.2292048181818, 0),
                    new Vector(-105.409985, 36.2067498181818, 0),
                    new Vector(-105.39014, 36.1920708181819, 0),
                    new Vector(-105.385118, 36.141994818182, 0),
                    new Vector(-105.420578, 36.103564818182, 0),
                    new Vector(-105.431864, 36.0694008181819, 0),
                    new Vector(-105.473228, 36.0497538181818, 0),
                    new Vector(-105.504107, 36.0220608181818, 0),
                    new Vector(-105.541025, 35.9863758181819, 0),
                    new Vector(-105.557252, 35.9800398181819, 0),
                    new Vector(-105.627569, 35.9974728181819, 0),
                    new Vector(-105.648656, 35.9708328181818, 0),
                    new Vector(-105.711053, 35.9748468181819, 0),
                    new Vector(-105.713105, 35.8882038181819, 0),
                    new Vector(-105.698912, 35.6662638181819, 0),
                    new Vector(-105.706355, 35.6641938181819, 0),
                    new Vector(-105.710198, 35.2996578181819, 0),
                    new Vector(-105.703979, 35.2999368181819, 0),
                    new Vector(-105.705266, 35.0474238181818, 0),
                    new Vector(-105.27764, 35.0473698181818, 0),
                    new Vector(-105.277748, 34.6160898181819, 0),
                    new Vector(-105.301778, 34.6159458181818, 0),
                    new Vector(-105.29996, 34.3503828181819, 0),
                    new Vector(-104.880542, 34.3503828181819, 0),
                    new Vector(-104.884628, 34.0948908181817, 0),
                    new Vector(-104.891036, 33.8157468181818, 0),
                    new Vector(-104.880578, 33.8149188181819, 0),
                    new Vector(-104.88146, 33.4621728181818, 0),
                    new Vector(-104.871641, 33.3028998181819, 0),
                    new Vector(-104.894699, 33.3037278181819, 0),
                    new Vector(-104.893907, 33.1397298181819, 0),
                    new Vector(-105.30482, 33.1368858181819, 0),
                    new Vector(-105.3059, 32.9615568181819, 0),
                    new Vector(-105.342548, 32.9618178181818, 0),
                    new Vector(-105.346292, 32.5253718181819, 0),
                    new Vector(-104.842481, 32.5230588181818, 0),
                    new Vector(-104.848898, 32.2537338181818, 0),
                    new Vector(-104.84024, 32.2534188181818, 0),
                    new Vector(-104.851076, 32.0032638181818, 0),
                    new Vector(-104.019287, 32.0074038181819, 0),
                    new Vector(-103.981379, 32.0060178181818, 0),
                    new Vector(-103.729442, 32.0062248181819, 0),
                    new Vector(-103.332542, 32.0042808181818, 0),
                    new Vector(-103.05842, 32.0020218181818, 0),
                    new Vector(-103.055639, 32.0851188181819, 0),
                    new Vector(-103.060022, 32.5155438181819, 0),
                    new Vector(-103.049339, 32.9536368181819, 0),
                    new Vector(-103.043102, 33.3778248181818, 0)
                })
            }
        };
    }
}