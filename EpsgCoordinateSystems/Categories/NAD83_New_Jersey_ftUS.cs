using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    public class NAD83_New_Jersey_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 3424;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New Jersey";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / New Jersey (ft US),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38.83333333333334],PARAMETER[central_meridian,-74.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,492125],PARAMETER[false_northing,0],AUTHORITY[EPSG,3424],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / New Jersey (ft US),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,38.83333333333334],PARAMETER[central_meridian,-74.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,492125],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(39.9853908181819, -75.06804200000001),
                    new Vector(39.9757338181818, -75.084593),
                    new Vector(39.9766878181819, -75.110963),
                    new Vector(39.9559158181818, -75.13986199999989),
                    new Vector(39.9347388181819, -75.147161),
                    new Vector(39.8968938181819, -75.135812),
                    new Vector(39.8816028181819, -75.142904),
                    new Vector(39.8774088181819, -75.185609),
                    new Vector(39.8504088181819, -75.246989),
                    new Vector(39.8455398181819, -75.253739),
                    new Vector(39.8485188181818, -75.3459349999999),
                    new Vector(39.7989828181818, -75.420464),
                    new Vector(39.7897758181819, -75.41175200000001),
                    new Vector(39.7782468181819, -75.4276459999999),
                    new Vector(39.7633608181819, -75.46038799999999),
                    new Vector(39.7418328181818, -75.474761),
                    new Vector(39.7200798181818, -75.475976),
                    new Vector(39.7148508181818, -75.489278),
                    new Vector(39.6177408181817, -75.570233),
                    new Vector(39.5665758181819, -75.51669200000001),
                    new Vector(39.4905168181819, -75.552764),
                    new Vector(39.3749748181819, -75.415676),
                    new Vector(39.1846878181819, -75.11995400000001),
                    new Vector(39.1983678181819, -75.0144109999999),
                    new Vector(39.1706388181819, -74.9166529999999),
                    new Vector(39.1138668181818, -74.890202),
                    new Vector(38.9717388181819, -74.968124),
                    new Vector(38.9566818181818, -74.87629699999999),
                    new Vector(38.9898468181818, -74.87925799999989),
                    new Vector(39.0263688181819, -74.80229),
                    new Vector(39.2508288181818, -74.624594),
                    new Vector(39.2816358181819, -74.622524),
                    new Vector(39.2872518181819, -74.658236),
                    new Vector(39.381076818182, -74.447501),
                    new Vector(39.4267518181819, -74.460416),
                    new Vector(39.5026308181818, -74.401115),
                    new Vector(39.5426178181819, -74.412392),
                    new Vector(39.5236278181819, -74.32885400000001),
                    new Vector(39.5720838181819, -74.323346),
                    new Vector(39.6240498181819, -74.237675),
                    new Vector(39.7182708181819, -74.1714259999999),
                    new Vector(39.8786058181819, -74.15923100000001),
                    new Vector(40.0422708181819, -74.07733999999989),
                    new Vector(40.0515678181819, -74.12217800000001),
                    new Vector(40.0568508181819, -74.049791),
                    new Vector(40.0913658181818, -74.03429300000001),
                    new Vector(40.0881798181818, -74.083775),
                    new Vector(40.1160798181819, -74.091425),
                    new Vector(40.1018418181819, -74.039225),
                    new Vector(40.3236198181818, -73.97843899999999),
                    new Vector(40.4514558181818, -74.121881),
                    new Vector(40.4435808181818, -74.22449899999989),
                    new Vector(40.463749818182, -74.268914),
                    new Vector(40.5143028181819, -74.278913),
                    new Vector(40.5911898181819, -74.208254),
                    new Vector(40.6754838181819, -74.146856),
                    new Vector(40.7056248181819, -74.115527),
                    new Vector(40.6470708181818, -74.129054),
                    new Vector(40.7039958181819, -74.006186),
                    new Vector(40.7377278181818, -74.00626699999999),
                    new Vector(40.7974878181819, -73.977062),
                    new Vector(40.8860388181819, -73.922387),
                    new Vector(40.9273218181819, -73.908968),
                    new Vector(40.9608738181819, -73.8961429999999),
                    new Vector(40.9985298181819, -73.89670099999999),
                    new Vector(41.1236118181819, -74.213033),
                    new Vector(41.137624818182, -74.24236399999999),
                    new Vector(41.1958548181819, -74.371982),
                    new Vector(41.3505738181819, -74.700068),
                    new Vector(41.3119638181819, -74.791661),
                    new Vector(41.2952148181818, -74.794145),
                    new Vector(41.2827048181819, -74.825204),
                    new Vector(41.2268148181819, -74.866406),
                    new Vector(41.2067718181819, -74.86287799999999),
                    new Vector(41.1411078181818, -74.91476299999999),
                    new Vector(41.1118578181818, -74.949989),
                    new Vector(41.0993838181819, -74.984594),
                    new Vector(41.0817618181819, -74.988878),
                    new Vector(41.0826708181818, -74.96628800000001),
                    new Vector(41.0624838181818, -75.001154),
                    new Vector(41.0282028181819, -75.03525500000001),
                    new Vector(41.0107158181818, -75.069986),
                    new Vector(41.0002488181819, -75.1166149999999),
                    new Vector(40.9775238181818, -75.1393039999999),
                    new Vector(40.9629348181819, -75.135524),
                    new Vector(40.9033458181819, -75.079733),
                    new Vector(40.8846258181819, -75.073685),
                    new Vector(40.8720438181819, -75.056495),
                    new Vector(40.8556728181819, -75.054614),
                    new Vector(40.8392838181819, -75.099542),
                    new Vector(40.8213918181819, -75.08920999999989),
                    new Vector(40.7916648181819, -75.10054100000001),
                    new Vector(40.7727108181819, -75.13032200000001),
                    new Vector(40.7748078181819, -75.170309),
                    new Vector(40.7479968181818, -75.193646),
                    new Vector(40.7238588181818, -75.18775100000001),
                    new Vector(40.6860678181819, -75.205355),
                    new Vector(40.6697868181818, -75.184061),
                    new Vector(40.6507338181819, -75.20891899999999),
                    new Vector(40.6342098181819, -75.19793900000001),
                    new Vector(40.6147428181819, -75.20038700000001),
                    new Vector(40.5837738181818, -75.193511),
                    new Vector(40.5706788181819, -75.1975699999999),
                    new Vector(40.5568008181819, -75.18227899999999),
                    new Vector(40.5648018181819, -75.124526),
                    new Vector(40.5453528181819, -75.079778),
                    new Vector(40.5209988181819, -75.063686),
                    new Vector(40.456252818182, -75.070121),
                    new Vector(40.4201718181819, -75.057458),
                    new Vector(40.4013258181819, -75.02126),
                    new Vector(40.4086158181818, -75.00047000000001),
                    new Vector(40.4044488181818, -74.9728489999999),
                    new Vector(40.3454718181819, -74.950187),
                    new Vector(40.3337718181819, -74.932502),
                    new Vector(40.3140348181819, -74.921153),
                    new Vector(40.2995898181818, -74.880662),
                    new Vector(40.2484518181819, -74.84276300000001),
                    new Vector(40.1777298181819, -74.738831),
                    new Vector(40.1493078181817, -74.72548399999989),
                    new Vector(40.1243508181818, -74.746292),
                    new Vector(40.1161608181819, -74.82902),
                    new Vector(40.0780548181818, -74.8719229999999),
                    new Vector(40.0580208181819, -74.956199),
                    new Vector(40.0340718181819, -74.98347800000001),
                    new Vector(40.0076388181818, -75.045677),
                    new Vector(39.9853908181819, -75.06804200000001)
                })
            }
        };
    }
}