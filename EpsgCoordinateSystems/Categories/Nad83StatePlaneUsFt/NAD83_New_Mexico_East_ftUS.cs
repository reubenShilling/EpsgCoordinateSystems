using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_New_Mexico_East_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2257;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New Mexico East";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / New Mexico East (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",31],PARAMETER[\"central_meridian\",-104.3333333333333],PARAMETER[\"scale_factor\",0.999909091],PARAMETER[\"false_easting\",541337.5],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2257\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / New Mexico East (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",31],PARAMETER[\"central_meridian\",-104.3333333333333],PARAMETER[\"scale_factor\",0.999909091],PARAMETER[\"false_easting\",541337.5],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(33.3778248181818, -103.043102),
                    new Vector(33.5658438181819, -103.038737),
                    new Vector(33.8261778181819, -103.033256),
                    new Vector(34.3078218181818, -103.029638),
                    new Vector(34.7453388181819, -103.022663),
                    new Vector(34.9647858181819, -103.025255),
                    new Vector(35.1772668181819, -103.026155),
                    new Vector(35.6236488181818, -103.022294),
                    new Vector(35.7423228181818, -103.022609),
                    new Vector(36.0560628181818, -103.024049),
                    new Vector(36.4915908181818, -103.027289),
                    new Vector(36.4923738181818, -102.9974),
                    new Vector(36.9985248181819, -102.997706),
                    new Vector(36.9997668181818, -103.07786),
                    new Vector(36.9944748181818, -103.993637),
                    new Vector(36.9932058181819, -105.146168),
                    new Vector(36.9926028181818, -105.213092),
                    new Vector(36.9614178181819, -105.21698),
                    new Vector(36.902305818182, -105.184265),
                    new Vector(36.8525268181819, -105.217304),
                    new Vector(36.8262558181819, -105.204236),
                    new Vector(36.7843878181818, -105.214991),
                    new Vector(36.7457688181818, -105.199115),
                    new Vector(36.7209198181819, -105.231398),
                    new Vector(36.7326378181819, -105.257822),
                    new Vector(36.7300098181819, -105.290132),
                    new Vector(36.7073748181819, -105.306755),
                    new Vector(36.7019658181818, -105.337463),
                    new Vector(36.6866118181819, -105.354869),
                    new Vector(36.6452748181818, -105.338507),
                    new Vector(36.6213528181819, -105.358046),
                    new Vector(36.5803848181819, -105.338804),
                    new Vector(36.5535288181818, -105.350999),
                    new Vector(36.497341818182, -105.309617),
                    new Vector(36.4555368181819, -105.337436),
                    new Vector(36.4230288181818, -105.31328),
                    new Vector(36.2963538181818, -105.312029),
                    new Vector(36.2705778181818, -105.344699),
                    new Vector(36.2292048181818, -105.417473),
                    new Vector(36.2067498181818, -105.409985),
                    new Vector(36.1920708181819, -105.39014),
                    new Vector(36.141994818182, -105.385118),
                    new Vector(36.103564818182, -105.420578),
                    new Vector(36.0694008181819, -105.431864),
                    new Vector(36.0497538181818, -105.473228),
                    new Vector(36.0220608181818, -105.504107),
                    new Vector(35.9863758181819, -105.541025),
                    new Vector(35.9800398181819, -105.557252),
                    new Vector(35.9974728181819, -105.627569),
                    new Vector(35.9708328181818, -105.648656),
                    new Vector(35.9748468181819, -105.711053),
                    new Vector(35.8882038181819, -105.713105),
                    new Vector(35.6662638181819, -105.698912),
                    new Vector(35.6641938181819, -105.706355),
                    new Vector(35.2996578181819, -105.710198),
                    new Vector(35.2999368181819, -105.703979),
                    new Vector(35.0474238181818, -105.705266),
                    new Vector(35.0473698181818, -105.27764),
                    new Vector(34.6160898181819, -105.277748),
                    new Vector(34.6159458181818, -105.301778),
                    new Vector(34.3503828181819, -105.29996),
                    new Vector(34.3503828181819, -104.880542),
                    new Vector(34.0948908181817, -104.884628),
                    new Vector(33.8157468181818, -104.891036),
                    new Vector(33.8149188181819, -104.880578),
                    new Vector(33.4621728181818, -104.88146),
                    new Vector(33.3028998181819, -104.871641),
                    new Vector(33.3037278181819, -104.894699),
                    new Vector(33.1397298181819, -104.893907),
                    new Vector(33.1368858181819, -105.30482),
                    new Vector(32.9615568181819, -105.3059),
                    new Vector(32.9618178181818, -105.342548),
                    new Vector(32.5253718181819, -105.346292),
                    new Vector(32.5230588181818, -104.842481),
                    new Vector(32.2537338181818, -104.848898),
                    new Vector(32.2534188181818, -104.84024),
                    new Vector(32.0032638181818, -104.851076),
                    new Vector(32.0074038181819, -104.019287),
                    new Vector(32.0060178181818, -103.981379),
                    new Vector(32.0062248181819, -103.729442),
                    new Vector(32.0042808181818, -103.332542),
                    new Vector(32.0020218181818, -103.05842),
                    new Vector(32.0851188181819, -103.055639),
                    new Vector(32.5155438181819, -103.060022),
                    new Vector(32.9536368181819, -103.049339),
                    new Vector(33.3778248181818, -103.043102)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries) _boundingBox.Expand(linearRing.CalculateBounds());

            return _boundingBox;
        }
    }
}