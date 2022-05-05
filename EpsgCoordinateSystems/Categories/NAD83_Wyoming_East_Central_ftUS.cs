using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wyoming_East_Central_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3737;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Wyoming East Central";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Wyoming East Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-107.3333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1312333.3333],PARAMETER[false_northing,328083.3333],AUTHORITY[EPSG,3737],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Wyoming East Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-107.3333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1312333.3333],PARAMETER[false_northing,328083.3333],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-106.082285, 42.4347678181818, 0),
                    new Vector(-106.07099, 43.4751678181819, 0),
                    new Vector(-106.081097, 43.4754558181818, 0),
                    new Vector(-106.082312, 43.4945538181819, 0),
                    new Vector(-106.028042, 43.4949588181818, 0),
                    new Vector(-106.019906, 43.8188328181819, 0),
                    new Vector(-106.004048, 43.8181668181819, 0),
                    new Vector(-106.008665, 44.1694008181819, 0),
                    new Vector(-106.020761, 44.1687618181819, 0),
                    new Vector(-106.025144, 44.5298148181819, 0),
                    new Vector(-106.01681, 44.5294908181819, 0),
                    new Vector(-106.016324, 44.5564098181818, 0),
                    new Vector(-106.011032, 44.8745508181818, 0),
                    new Vector(-106.023317, 44.876188818182, 0),
                    new Vector(-106.021157, 44.9972118181819, 0),
                    new Vector(-106.259225, 44.9961678181819, 0),
                    new Vector(-107.894363, 44.9997768181819, 0),
                    new Vector(-108.259232, 45.0001188181818, 0),
                    new Vector(-108.625253, 44.997589818182, 0),
                    new Vector(-108.62312, 44.8633098181818, 0),
                    new Vector(-108.599324, 44.8641378181819, 0),
                    new Vector(-108.592475, 44.5277538181819, 0),
                    new Vector(-108.578984, 44.527303818182, 0),
                    new Vector(-108.57902, 44.1681228181818, 0),
                    new Vector(-108.557312, 44.1679518181818, 0),
                    new Vector(-108.558482, 44.0807868181818, 0),
                    new Vector(-108.50108, 44.0800128181819, 0),
                    new Vector(-108.499928, 43.9952148181819, 0),
                    new Vector(-108.431753, 43.9938648181818, 0),
                    new Vector(-108.432968, 43.9049088181819, 0),
                    new Vector(-108.322304, 43.9035588181819, 0),
                    new Vector(-108.321872, 43.8465798181819, 0),
                    new Vector(-108.18599, 43.8463908181819, 0),
                    new Vector(-108.188213, 43.8308208181818, 0),
                    new Vector(-108.168899, 43.8159348181819, 0),
                    new Vector(-107.949911, 43.8148998181819, 0),
                    new Vector(-107.950766, 43.7310288181819, 0),
                    new Vector(-107.714399, 43.7310468181819, 0),
                    new Vector(-107.715488, 43.6462758181819, 0),
                    new Vector(-107.595185, 43.6450428181818, 0),
                    new Vector(-107.596706, 43.5056148181819, 0),
                    new Vector(-107.534768, 43.5045618181818, 0),
                    new Vector(-107.534975, 43.4717748181819, 0),
                    new Vector(-107.516615, 43.4708928181819, 0),
                    new Vector(-107.517623, 43.1339598181819, 0),
                    new Vector(-107.501918, 43.1339148181819, 0),
                    new Vector(-107.500388, 42.7826718181818, 0),
                    new Vector(-107.539124, 42.7825368181818, 0),
                    new Vector(-107.545343, 42.440806818182, 0),
                    new Vector(-107.524184, 42.4404738181819, 0),
                    new Vector(-107.52431, 42.2590608181818, 0),
                    new Vector(-107.524481, 42.0908778181819, 0),
                    new Vector(-107.506508, 42.0904638181819, 0),
                    new Vector(-107.509838, 41.7014118181819, 0),
                    new Vector(-107.526398, 41.7005118181818, 0),
                    new Vector(-107.524526, 41.6633058181818, 0),
                    new Vector(-107.935952, 41.6627298181818, 0),
                    new Vector(-107.936366, 41.4069588181818, 0),
                    new Vector(-107.916125, 41.4066528181819, 0),
                    new Vector(-107.918672, 41.0033718181819, 0),
                    new Vector(-107.304053, 41.0001408181819, 0),
                    new Vector(-106.865438, 40.9984578181819, 0),
                    new Vector(-106.329119, 41.0012928181818, 0),
                    new Vector(-106.324196, 41.3986428181819, 0),
                    new Vector(-106.071908, 41.3997948181818, 0),
                    new Vector(-106.082285, 42.4347678181818, 0)
                })
            }
        };
    }
}