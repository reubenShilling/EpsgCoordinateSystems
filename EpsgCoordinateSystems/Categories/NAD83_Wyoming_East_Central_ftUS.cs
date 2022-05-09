using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wyoming_East_Central_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 3737;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Wyoming East Central";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Wyoming East Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-107.3333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1312333.3333],PARAMETER[false_northing,328083.3333],AUTHORITY[EPSG,3737],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Wyoming East Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-107.3333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1312333.3333],PARAMETER[false_northing,328083.3333],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(42.4347678181818, -106.082285),
                    new Vector(43.4751678181819, -106.07099),
                    new Vector(43.4754558181818, -106.081097),
                    new Vector(43.4945538181819, -106.082312),
                    new Vector(43.4949588181818, -106.028042),
                    new Vector(43.8188328181819, -106.019906),
                    new Vector(43.8181668181819, -106.004048),
                    new Vector(44.1694008181819, -106.008665),
                    new Vector(44.1687618181819, -106.020761),
                    new Vector(44.5298148181819, -106.025144),
                    new Vector(44.5294908181819, -106.01681),
                    new Vector(44.5564098181818, -106.016324),
                    new Vector(44.8745508181818, -106.011032),
                    new Vector(44.876188818182, -106.023317),
                    new Vector(44.9972118181819, -106.021157),
                    new Vector(44.9961678181819, -106.259225),
                    new Vector(44.9997768181819, -107.894363),
                    new Vector(45.0001188181818, -108.259232),
                    new Vector(44.997589818182, -108.625253),
                    new Vector(44.8633098181818, -108.62312),
                    new Vector(44.8641378181819, -108.599324),
                    new Vector(44.5277538181819, -108.592475),
                    new Vector(44.527303818182, -108.578984),
                    new Vector(44.1681228181818, -108.57902),
                    new Vector(44.1679518181818, -108.557312),
                    new Vector(44.0807868181818, -108.558482),
                    new Vector(44.0800128181819, -108.50108),
                    new Vector(43.9952148181819, -108.499928),
                    new Vector(43.9938648181818, -108.431753),
                    new Vector(43.9049088181819, -108.432968),
                    new Vector(43.9035588181819, -108.322304),
                    new Vector(43.8465798181819, -108.321872),
                    new Vector(43.8463908181819, -108.18599),
                    new Vector(43.8308208181818, -108.188213),
                    new Vector(43.8159348181819, -108.168899),
                    new Vector(43.8148998181819, -107.949911),
                    new Vector(43.7310288181819, -107.950766),
                    new Vector(43.7310468181819, -107.714399),
                    new Vector(43.6462758181819, -107.715488),
                    new Vector(43.6450428181818, -107.595185),
                    new Vector(43.5056148181819, -107.596706),
                    new Vector(43.5045618181818, -107.534768),
                    new Vector(43.4717748181819, -107.534975),
                    new Vector(43.4708928181819, -107.516615),
                    new Vector(43.1339598181819, -107.517623),
                    new Vector(43.1339148181819, -107.501918),
                    new Vector(42.7826718181818, -107.500388),
                    new Vector(42.7825368181818, -107.539124),
                    new Vector(42.440806818182, -107.545343),
                    new Vector(42.4404738181819, -107.524184),
                    new Vector(42.2590608181818, -107.52431),
                    new Vector(42.0908778181819, -107.524481),
                    new Vector(42.0904638181819, -107.506508),
                    new Vector(41.7014118181819, -107.509838),
                    new Vector(41.7005118181818, -107.526398),
                    new Vector(41.6633058181818, -107.524526),
                    new Vector(41.6627298181818, -107.935952),
                    new Vector(41.4069588181818, -107.936366),
                    new Vector(41.4066528181819, -107.916125),
                    new Vector(41.0033718181819, -107.918672),
                    new Vector(41.0001408181819, -107.304053),
                    new Vector(40.9984578181819, -106.865438),
                    new Vector(41.0012928181818, -106.329119),
                    new Vector(41.3986428181819, -106.324196),
                    new Vector(41.3997948181818, -106.071908),
                    new Vector(42.4347678181818, -106.082285)
                })
            }
        };
    }
}