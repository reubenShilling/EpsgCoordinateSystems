using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_California_zone_4_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2228;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "California zone 4";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / California zone 4 (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.25],PARAMETER[standard_parallel_2,36],PARAMETER[latitude_of_origin,35.33333333333334],PARAMETER[central_meridian,-119],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],AUTHORITY[EPSG,2228],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / California zone 4 (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,37.25],PARAMETER[standard_parallel_2,36],PARAMETER[latitude_of_origin,35.33333333333334],PARAMETER[central_meridian,-119],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-118.007519, 35.7975468181819, 0),
                    new Vector(-117.929831, 35.7981858181818, 0),
                    new Vector(-117.931046, 35.8049808181818, 0),
                    new Vector(-117.642173, 35.8057008181819, 0),
                    new Vector(-116.607317, 35.7966378181818, 0),
                    new Vector(-115.6262, 35.7957018181818, 0),
                    new Vector(-115.885769, 36.0012258181819, 0),
                    new Vector(-117.16043, 36.9595908181819, 0),
                    new Vector(-117.838679, 37.4572998181819, 0),
                    new Vector(-118.770953, 37.453186818182, 0),
                    new Vector(-118.801679, 37.4767758181819, 0),
                    new Vector(-118.843358, 37.4734278181818, 0),
                    new Vector(-118.858631, 37.4813568181818, 0),
                    new Vector(-118.865516, 37.5012018181819, 0),
                    new Vector(-118.887098, 37.5058548181818, 0),
                    new Vector(-118.906808, 37.5277608181819, 0),
                    new Vector(-119.017211, 37.5744978181818, 0),
                    new Vector(-119.279534, 37.3603878181819, 0),
                    new Vector(-119.30747, 37.3457988181818, 0),
                    new Vector(-119.328692, 37.3023288181819, 0),
                    new Vector(-119.312213, 37.2001518181819, 0),
                    new Vector(-119.318729, 37.1868858181819, 0),
                    new Vector(-119.34707, 37.169101818182, 0),
                    new Vector(-119.346161, 37.1586888181819, 0),
                    new Vector(-119.372819, 37.143658818182, 0),
                    new Vector(-119.3873, 37.1447298181819, 0),
                    new Vector(-119.394554, 37.1545668181819, 0),
                    new Vector(-119.413571, 37.1532798181818, 0),
                    new Vector(-119.417702, 37.1382408181818, 0),
                    new Vector(-119.439536, 37.1346138181819, 0),
                    new Vector(-119.455394, 37.1075418181818, 0),
                    new Vector(-119.464673, 37.109170818182, 0),
                    new Vector(-119.48477, 37.1404998181819, 0),
                    new Vector(-119.499701, 37.1379258181819, 0),
                    new Vector(-119.499818, 37.1243178181818, 0),
                    new Vector(-119.510123, 37.1218338181818, 0),
                    new Vector(-119.535467, 37.1367378181818, 0),
                    new Vector(-119.542316, 37.1343168181819, 0),
                    new Vector(-119.544836, 37.1065968181818, 0),
                    new Vector(-119.519825, 37.1012328181819, 0),
                    new Vector(-119.519573, 37.0939788181819, 0),
                    new Vector(-119.542217, 37.0808118181819, 0),
                    new Vector(-119.540705, 37.0704078181819, 0),
                    new Vector(-119.559956, 37.0595718181818, 0),
                    new Vector(-119.579207, 37.0659618181819, 0),
                    new Vector(-119.604362, 37.0259658181818, 0),
                    new Vector(-119.610653, 37.0244718181818, 0),
                    new Vector(-119.619797, 37.0387818181819, 0),
                    new Vector(-119.638391, 37.0261368181819, 0),
                    new Vector(-119.646392, 37.0078218181819, 0),
                    new Vector(-119.716268, 36.9795078181819, 0),
                    new Vector(-119.733764, 36.9219618181818, 0),
                    new Vector(-119.754041, 36.9097128181818, 0),
                    new Vector(-119.771825, 36.876637818182, 0),
                    new Vector(-119.801354, 36.8505558181819, 0),
                    new Vector(-119.825708, 36.8558838181818, 0),
                    new Vector(-119.852609, 36.8516178181818, 0),
                    new Vector(-119.865479, 36.8576658181818, 0),
                    new Vector(-119.920937, 36.8336538181819, 0),
                    new Vector(-119.973344, 36.8350938181819, 0),
                    new Vector(-120.016859, 36.8154108181819, 0),
                    new Vector(-120.071156, 36.821296818182, 0),
                    new Vector(-120.129476, 36.7993818181818, 0),
                    new Vector(-120.156377, 36.7964118181819, 0),
                    new Vector(-120.168185, 36.7765938181819, 0),
                    new Vector(-120.180317, 36.7780878181819, 0),
                    new Vector(-120.187733, 36.790138818182, 0),
                    new Vector(-120.212717, 36.7826688181819, 0),
                    new Vector(-120.213995, 36.7722018181818, 0),
                    new Vector(-120.234821, 36.7752708181819, 0),
                    new Vector(-120.270884, 36.7588728181819, 0),
                    new Vector(-120.327629, 36.7940718181817, 0),
                    new Vector(-120.329951, 36.7817508181818, 0),
                    new Vector(-120.351407, 36.7861518181818, 0),
                    new Vector(-120.348428, 36.7966728181819, 0),
                    new Vector(-120.361784, 36.8121798181818, 0),
                    new Vector(-120.431561, 36.8542188181819, 0),
                    new Vector(-120.444611, 36.8874198181818, 0),
                    new Vector(-120.436763, 36.9044388181819, 0),
                    new Vector(-120.441893, 36.9283248181818, 0),
                    new Vector(-120.483707, 36.9852048181818, 0),
                    new Vector(-120.499106, 36.9938268181818, 0),
                    new Vector(-120.526691, 37.0406628181819, 0),
                    new Vector(-120.905537, 36.7385868181819, 0),
                    new Vector(-120.926543, 36.7556058181819, 0),
                    new Vector(-121.127711, 36.8382798181819, 0),
                    new Vector(-121.13042, 36.8563428181818, 0),
                    new Vector(-121.168229, 36.9045198181818, 0),
                    new Vector(-121.214003, 36.9197208181819, 0),
                    new Vector(-121.218251, 36.9336348181819, 0),
                    new Vector(-121.205642, 36.955396818182, 0),
                    new Vector(-121.401284, 36.958861818182, 0),
                    new Vector(-121.433261, 36.9826578181817, 0),
                    new Vector(-121.469432, 36.9799668181819, 0),
                    new Vector(-121.489016, 36.9701568181818, 0),
                    new Vector(-121.498124, 36.939412818182, 0),
                    new Vector(-121.533692, 36.9176508181819, 0),
                    new Vector(-121.549289, 36.8898228181819, 0),
                    new Vector(-121.568837, 36.8890938181819, 0),
                    new Vector(-121.579151, 36.8977788181818, 0),
                    new Vector(-121.614746, 36.9050418181818, 0),
                    new Vector(-121.626851, 36.8959518181819, 0),
                    new Vector(-121.641611, 36.9108288181819, 0),
                    new Vector(-121.715456, 36.9120438181819, 0),
                    new Vector(-121.734644, 36.9058428181818, 0),
                    new Vector(-121.753445, 36.8842248181818, 0),
                    new Vector(-121.776107, 36.8783388181819, 0),
                    new Vector(-121.791713, 36.8503308181819, 0),
                    new Vector(-121.761392, 36.8189928181819, 0),
                    new Vector(-121.808561, 36.6482178181818, 0),
                    new Vector(-121.867385, 36.6077088181819, 0),
                    new Vector(-121.911413, 36.6404238181819, 0),
                    new Vector(-121.955288, 36.5827698181818, 0),
                    new Vector(-121.882271, 36.3069468181819, 0),
                    new Vector(-121.689806, 36.1811358181819, 0),
                    new Vector(-121.445546, 35.8798518181818, 0),
                    new Vector(-121.329086, 35.8010388181818, 0),
                    new Vector(-120.199235, 35.7932538181818, 0),
                    new Vector(-120.189083, 35.7944328181818, 0),
                    new Vector(-119.52977, 35.7930558181819, 0),
                    new Vector(-118.007519, 35.7975468181819, 0)
                })
            }
        };
    }
}