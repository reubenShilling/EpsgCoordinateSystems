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
    internal class NAD83_New_Mexico_Central_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2258;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "New Mexico Central";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / New Mexico Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-106.25],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2258],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / New Mexico Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-106.25],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(33.3920358181818, -106.328012),
                    new Vector(33.0596118181819, -106.323386),
                    new Vector(32.8294818181819, -106.878803),
                    new Vector(32.7893868181818, -106.878227),
                    new Vector(32.7812148181819, -107.285477),
                    new Vector(32.6072358181819, -107.286503),
                    new Vector(31.7850858181818, -107.28356),
                    new Vector(31.7863098181818, -106.539521),
                    new Vector(31.8178368181819, -106.614986),
                    new Vector(31.84473781818181, -106.616129),
                    new Vector(31.8952098181819, -106.644083),
                    new Vector(31.9141008181819, -106.633742),
                    new Vector(31.9722138181819, -106.632608),
                    new Vector(31.9803228181819, -106.650068),
                    new Vector(32.0010948181818, -106.623626),
                    new Vector(32.0007438181819, -106.378394),
                    new Vector(32.0016528181818, -106.003238),
                    new Vector(32.0043798181818, -104.922311),
                    new Vector(32.0032638181818, -104.851076),
                    new Vector(32.2534188181818, -104.84024),
                    new Vector(32.2537338181818, -104.848898),
                    new Vector(32.5230588181818, -104.842481),
                    new Vector(32.5253718181819, -105.346292),
                    new Vector(32.9618178181818, -105.342548),
                    new Vector(32.9615568181819, -105.3059),
                    new Vector(33.1368858181819, -105.30482),
                    new Vector(33.1397298181819, -104.893907),
                    new Vector(33.3037278181819, -104.894699),
                    new Vector(33.3028998181819, -104.871641),
                    new Vector(33.4621728181818, -104.88146),
                    new Vector(33.8149188181819, -104.880578),
                    new Vector(33.8157468181818, -104.891036),
                    new Vector(34.0948908181817, -104.884628),
                    new Vector(34.3503828181819, -104.880542),
                    new Vector(34.3503828181819, -105.29996),
                    new Vector(34.6159458181818, -105.301778),
                    new Vector(34.6160898181819, -105.277748),
                    new Vector(35.0473698181818, -105.27764),
                    new Vector(35.0474238181818, -105.705266),
                    new Vector(35.2999368181819, -105.703979),
                    new Vector(35.2996578181819, -105.710198),
                    new Vector(35.6641938181819, -105.706355),
                    new Vector(35.6662638181819, -105.698912),
                    new Vector(35.8882038181819, -105.713105),
                    new Vector(35.9748468181819, -105.711053),
                    new Vector(35.9708328181818, -105.648656),
                    new Vector(35.9974728181819, -105.627569),
                    new Vector(35.9800398181819, -105.557252),
                    new Vector(35.9863758181819, -105.541025),
                    new Vector(36.0220608181818, -105.504107),
                    new Vector(36.0497538181818, -105.473228),
                    new Vector(36.0694008181819, -105.431864),
                    new Vector(36.103564818182, -105.420578),
                    new Vector(36.141994818182, -105.385118),
                    new Vector(36.1920708181819, -105.39014),
                    new Vector(36.2067498181818, -105.409985),
                    new Vector(36.2292048181818, -105.417473),
                    new Vector(36.2705778181818, -105.344699),
                    new Vector(36.2963538181818, -105.312029),
                    new Vector(36.4230288181818, -105.31328),
                    new Vector(36.4555368181819, -105.337436),
                    new Vector(36.497341818182, -105.309617),
                    new Vector(36.5535288181818, -105.350999),
                    new Vector(36.5803848181819, -105.338804),
                    new Vector(36.6213528181819, -105.358046),
                    new Vector(36.6452748181818, -105.338507),
                    new Vector(36.6866118181819, -105.354869),
                    new Vector(36.7019658181818, -105.337463),
                    new Vector(36.7073748181819, -105.306755),
                    new Vector(36.7300098181819, -105.290132),
                    new Vector(36.7326378181819, -105.257822),
                    new Vector(36.7209198181819, -105.231398),
                    new Vector(36.7457688181818, -105.199115),
                    new Vector(36.7843878181818, -105.214991),
                    new Vector(36.8262558181819, -105.204236),
                    new Vector(36.8525268181819, -105.217304),
                    new Vector(36.902305818182, -105.184265),
                    new Vector(36.9614178181819, -105.21698),
                    new Vector(36.9926028181818, -105.213092),
                    new Vector(36.9945648181818, -105.713465),
                    new Vector(36.9922878181819, -105.991988),
                    new Vector(36.9914958181819, -106.472174),
                    new Vector(36.9894978181819, -106.861244),
                    new Vector(36.9990828181819, -106.890377),
                    new Vector(36.9975258181818, -107.41082),
                    new Vector(36.9661788181818, -107.441447),
                    new Vector(36.9064908181819, -107.453615),
                    new Vector(36.8406288181819, -107.592998),
                    new Vector(36.8158518181819, -107.607263),
                    new Vector(36.8110728181819, -107.625182),
                    new Vector(36.2209878181818, -107.623364),
                    new Vector(36.0032418181819, -107.62448),
                    new Vector(36.0018108181818, -107.302055),
                    new Vector(35.3123298181818, -107.294801),
                    new Vector(35.3117988181819, -107.228309),
                    new Vector(35.2252728181818, -107.18078),
                    new Vector(34.9634718181819, -107.054312),
                    new Vector(34.963723818182, -107.217932),
                    new Vector(34.6135248181819, -107.204333),
                    new Vector(34.6109328181819, -107.195486),
                    new Vector(34.5835728181819, -107.195423),
                    new Vector(34.5843108181818, -107.718404),
                    new Vector(34.2690048181819, -107.720825),
                    new Vector(34.2684468181818, -107.711384),
                    new Vector(33.8329818181818, -107.71304),
                    new Vector(33.8315148181819, -107.70422),
                    new Vector(33.4790118181818, -107.701223),
                    new Vector(33.4783818181818, -106.362518),
                    new Vector(33.3923418181819, -106.360997),
                    new Vector(33.3920358181818, -106.328012)
                })
            }
        };
    }
}