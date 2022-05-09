using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_California_zone_4_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2228;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "California zone 4";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / California zone 4 (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",37.25],PARAMETER[\"standard_parallel_2\",36],PARAMETER[\"latitude_of_origin\",35.33333333333334],PARAMETER[\"central_meridian\",-119],PARAMETER[\"false_easting\",6561666.667],PARAMETER[\"false_northing\",1640416.667],AUTHORITY[\"EPSG\",\"2228\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / California zone 4 (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",37.25],PARAMETER[\"standard_parallel_2\",36],PARAMETER[\"latitude_of_origin\",35.33333333333334],PARAMETER[\"central_meridian\",-119],PARAMETER[\"false_easting\",6561666.667],PARAMETER[\"false_northing\",1640416.667],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(35.7975468181819, -118.007519),
                    new Vector(35.7981858181818, -117.929831),
                    new Vector(35.8049808181818, -117.931046),
                    new Vector(35.8057008181819, -117.642173),
                    new Vector(35.7966378181818, -116.607317),
                    new Vector(35.7957018181818, -115.6262),
                    new Vector(36.0012258181819, -115.885769),
                    new Vector(36.9595908181819, -117.16043),
                    new Vector(37.4572998181819, -117.838679),
                    new Vector(37.453186818182, -118.770953),
                    new Vector(37.4767758181819, -118.801679),
                    new Vector(37.4734278181818, -118.843358),
                    new Vector(37.4813568181818, -118.858631),
                    new Vector(37.5012018181819, -118.865516),
                    new Vector(37.5058548181818, -118.887098),
                    new Vector(37.5277608181819, -118.906808),
                    new Vector(37.5744978181818, -119.017211),
                    new Vector(37.3603878181819, -119.279534),
                    new Vector(37.3457988181818, -119.30747),
                    new Vector(37.3023288181819, -119.328692),
                    new Vector(37.2001518181819, -119.312213),
                    new Vector(37.1868858181819, -119.318729),
                    new Vector(37.169101818182, -119.34707),
                    new Vector(37.1586888181819, -119.346161),
                    new Vector(37.143658818182, -119.372819),
                    new Vector(37.1447298181819, -119.3873),
                    new Vector(37.1545668181819, -119.394554),
                    new Vector(37.1532798181818, -119.413571),
                    new Vector(37.1382408181818, -119.417702),
                    new Vector(37.1346138181819, -119.439536),
                    new Vector(37.1075418181818, -119.455394),
                    new Vector(37.109170818182, -119.464673),
                    new Vector(37.1404998181819, -119.48477),
                    new Vector(37.1379258181819, -119.499701),
                    new Vector(37.1243178181818, -119.499818),
                    new Vector(37.1218338181818, -119.510123),
                    new Vector(37.1367378181818, -119.535467),
                    new Vector(37.1343168181819, -119.542316),
                    new Vector(37.1065968181818, -119.544836),
                    new Vector(37.1012328181819, -119.519825),
                    new Vector(37.0939788181819, -119.519573),
                    new Vector(37.0808118181819, -119.542217),
                    new Vector(37.0704078181819, -119.540705),
                    new Vector(37.0595718181818, -119.559956),
                    new Vector(37.0659618181819, -119.579207),
                    new Vector(37.0259658181818, -119.604362),
                    new Vector(37.0244718181818, -119.610653),
                    new Vector(37.0387818181819, -119.619797),
                    new Vector(37.0261368181819, -119.638391),
                    new Vector(37.0078218181819, -119.646392),
                    new Vector(36.9795078181819, -119.716268),
                    new Vector(36.9219618181818, -119.733764),
                    new Vector(36.9097128181818, -119.754041),
                    new Vector(36.876637818182, -119.771825),
                    new Vector(36.8505558181819, -119.801354),
                    new Vector(36.8558838181818, -119.825708),
                    new Vector(36.8516178181818, -119.852609),
                    new Vector(36.8576658181818, -119.865479),
                    new Vector(36.8336538181819, -119.920937),
                    new Vector(36.8350938181819, -119.973344),
                    new Vector(36.8154108181819, -120.016859),
                    new Vector(36.821296818182, -120.071156),
                    new Vector(36.7993818181818, -120.129476),
                    new Vector(36.7964118181819, -120.156377),
                    new Vector(36.7765938181819, -120.168185),
                    new Vector(36.7780878181819, -120.180317),
                    new Vector(36.790138818182, -120.187733),
                    new Vector(36.7826688181819, -120.212717),
                    new Vector(36.7722018181818, -120.213995),
                    new Vector(36.7752708181819, -120.234821),
                    new Vector(36.7588728181819, -120.270884),
                    new Vector(36.7940718181817, -120.327629),
                    new Vector(36.7817508181818, -120.329951),
                    new Vector(36.7861518181818, -120.351407),
                    new Vector(36.7966728181819, -120.348428),
                    new Vector(36.8121798181818, -120.361784),
                    new Vector(36.8542188181819, -120.431561),
                    new Vector(36.8874198181818, -120.444611),
                    new Vector(36.9044388181819, -120.436763),
                    new Vector(36.9283248181818, -120.441893),
                    new Vector(36.9852048181818, -120.483707),
                    new Vector(36.9938268181818, -120.499106),
                    new Vector(37.0406628181819, -120.526691),
                    new Vector(36.7385868181819, -120.905537),
                    new Vector(36.7556058181819, -120.926543),
                    new Vector(36.8382798181819, -121.127711),
                    new Vector(36.8563428181818, -121.13042),
                    new Vector(36.9045198181818, -121.168229),
                    new Vector(36.9197208181819, -121.214003),
                    new Vector(36.9336348181819, -121.218251),
                    new Vector(36.955396818182, -121.205642),
                    new Vector(36.958861818182, -121.401284),
                    new Vector(36.9826578181817, -121.433261),
                    new Vector(36.9799668181819, -121.469432),
                    new Vector(36.9701568181818, -121.489016),
                    new Vector(36.939412818182, -121.498124),
                    new Vector(36.9176508181819, -121.533692),
                    new Vector(36.8898228181819, -121.549289),
                    new Vector(36.8890938181819, -121.568837),
                    new Vector(36.8977788181818, -121.579151),
                    new Vector(36.9050418181818, -121.614746),
                    new Vector(36.8959518181819, -121.626851),
                    new Vector(36.9108288181819, -121.641611),
                    new Vector(36.9120438181819, -121.715456),
                    new Vector(36.9058428181818, -121.734644),
                    new Vector(36.8842248181818, -121.753445),
                    new Vector(36.8783388181819, -121.776107),
                    new Vector(36.8503308181819, -121.791713),
                    new Vector(36.8189928181819, -121.761392),
                    new Vector(36.6482178181818, -121.808561),
                    new Vector(36.6077088181819, -121.867385),
                    new Vector(36.6404238181819, -121.911413),
                    new Vector(36.5827698181818, -121.955288),
                    new Vector(36.3069468181819, -121.882271),
                    new Vector(36.1811358181819, -121.689806),
                    new Vector(35.8798518181818, -121.445546),
                    new Vector(35.8010388181818, -121.329086),
                    new Vector(35.7932538181818, -120.199235),
                    new Vector(35.7944328181818, -120.189083),
                    new Vector(35.7930558181819, -119.52977),
                    new Vector(35.7975468181819, -118.007519)
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