using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Mississippi_East_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2254;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Mississippi East";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Mississippi East (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",29.5],PARAMETER[\"central_meridian\",-88.83333333333333],PARAMETER[\"scale_factor\",0.99995],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2254\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Mississippi East (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",29.5],PARAMETER[\"central_meridian\",-88.83333333333333],PARAMETER[\"scale_factor\",0.99995],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(32.0597748181819, -89.72603599999999),
                    new Vector(32.0571558181819, -89.658995),
                    new Vector(32.0083848181819, -89.649716),
                    new Vector(31.7849238181819, -89.649833),
                    new Vector(31.7783628181818, -89.75272099999999),
                    new Vector(31.6150398181819, -89.75381899999999),
                    new Vector(31.6114488181818, -89.72585599999999),
                    new Vector(31.5955008181819, -89.715065),
                    new Vector(31.5809478181818, -89.6886949999999),
                    new Vector(31.5573138181819, -89.61341899999999),
                    new Vector(31.5454608181819, -89.59997300000001),
                    new Vector(31.5212868181819, -89.58437600000001),
                    new Vector(31.4386938181818, -89.581613),
                    new Vector(31.4372538181818, -89.652416),
                    new Vector(31.0089528181819, -89.652677),
                    new Vector(31.0074498181818, -89.732714),
                    new Vector(31.001527818182, -89.723624),
                    new Vector(30.9846168181818, -89.726783),
                    new Vector(30.9754908181818, -89.719826),
                    new Vector(30.9654018181819, -89.739518),
                    new Vector(30.9498498181818, -89.748536),
                    new Vector(30.9261078181818, -89.740472),
                    new Vector(30.9210498181819, -89.75805800000001),
                    new Vector(30.9101058181819, -89.745755),
                    new Vector(30.9027888181819, -89.746799),
                    new Vector(30.9004758181818, -89.763305),
                    new Vector(30.8620818181819, -89.765852),
                    new Vector(30.861577818182, -89.785031),
                    new Vector(30.8305368181819, -89.774798),
                    new Vector(30.8291058181818, -89.796092),
                    new Vector(30.812653818182, -89.79656),
                    new Vector(30.8116998181819, -89.81093300000001),
                    new Vector(30.7897308181819, -89.82469399999999),
                    new Vector(30.7481688181819, -89.813354),
                    new Vector(30.7426428181819, -89.82556700000001),
                    new Vector(30.73305781818179, -89.823398),
                    new Vector(30.7293678181819, -89.83562000000001),
                    new Vector(30.7124298181819, -89.844053),
                    new Vector(30.70378081818181, -89.830724),
                    new Vector(30.7005588181819, -89.84134400000001),
                    new Vector(30.6795168181819, -89.841785),
                    new Vector(30.675880818182, -89.83539500000001),
                    new Vector(30.6662508181818, -89.845448),
                    new Vector(30.6708768181818, -89.829527),
                    new Vector(30.6512478181818, -89.819357),
                    new Vector(30.6494568181819, -89.805533),
                    new Vector(30.6242748181818, -89.820311),
                    new Vector(30.5539488181819, -89.790845),
                    new Vector(30.5512488181819, -89.7728),
                    new Vector(30.51561781818191, -89.755178),
                    new Vector(30.4978338181818, -89.73231800000001),
                    new Vector(30.4960338181818, -89.719061),
                    new Vector(30.4814178181819, -89.713184),
                    new Vector(30.478249818182, -89.6956789999999),
                    new Vector(30.4681878181818, -89.6945989999999),
                    new Vector(30.4627158181818, -89.683457),
                    new Vector(30.445354818182, -89.675465),
                    new Vector(30.4000758181818, -89.675375),
                    new Vector(30.3790608181818, -89.654675),
                    new Vector(30.3552918181819, -89.646692),
                    new Vector(30.3553098181818, -89.633453),
                    new Vector(30.3434298181819, -89.62019600000001),
                    new Vector(30.3237648181819, -89.618594),
                    new Vector(30.3118488181819, -89.6370799999999),
                    new Vector(30.2958288181819, -89.639177),
                    new Vector(30.29035681818189, -89.625947),
                    new Vector(30.2569668181818, -89.621663),
                    new Vector(30.2478228181818, -89.606309),
                    new Vector(30.2414148181819, -89.609999),
                    new Vector(30.1949388181819, -89.573882),
                    new Vector(30.2009598181818, -89.43811700000001),
                    new Vector(30.25648081818199, -89.415617),
                    new Vector(30.3188508181819, -89.31854300000001),
                    new Vector(30.3652818181819, -89.3575309999999),
                    new Vector(30.3804288181818, -89.3350489999999),
                    new Vector(30.3723828181818, -89.27352500000001),
                    new Vector(30.3148368181818, -89.276117),
                    new Vector(30.3982938181819, -88.885724),
                    new Vector(30.4167978181819, -88.9302289999999),
                    new Vector(30.430270818182, -88.87378099999999),
                    new Vector(30.3423138181819, -88.68326),
                    new Vector(30.3807528181818, -88.57776200000001),
                    new Vector(30.3260688181818, -88.464236),
                    new Vector(30.3528798181818, -88.39922900000001),
                    new Vector(30.3935508181818, -88.401416),
                    new Vector(30.7364508181819, -88.417247),
                    new Vector(31.0006908181818, -88.429199),
                    new Vector(31.1208858181818, -88.434563),
                    new Vector(31.4356158181819, -88.450799),
                    new Vector(31.70224981818181, -88.46510000000001),
                    new Vector(31.8888738181818, -88.47295699999999),
                    new Vector(32.2277508181819, -88.437731),
                    new Vector(32.3092278181819, -88.425788),
                    new Vector(32.5804698181819, -88.393838),
                    new Vector(32.9247558181818, -88.348046),
                    new Vector(32.9875038181819, -88.33946),
                    new Vector(33.2888868181819, -88.304828),
                    new Vector(33.5387988181819, -88.27458799999989),
                    new Vector(33.7427298181819, -88.24819100000001),
                    new Vector(34.0591158181819, -88.2026419999999),
                    new Vector(34.0904448181819, -88.199348),
                    new Vector(34.3241478181819, -88.16760499999999),
                    new Vector(34.4652768181819, -88.151252),
                    new Vector(34.5805038181818, -88.136402),
                    new Vector(34.8956298181819, -88.090475),
                    new Vector(34.8999408181819, -88.10888),
                    new Vector(34.9303068181819, -88.143107),
                    new Vector(35.0044578181818, -88.19399300000001),
                    new Vector(35.0038368181818, -88.351727),
                    new Vector(35.0050428181819, -88.383146),
                    new Vector(35.0031798181819, -88.78504100000001),
                    new Vector(35.0024328181819, -88.812545),
                    new Vector(35.0002368181818, -89.006198),
                    new Vector(35.0008848181818, -89.198132),
                    new Vector(34.9998048181819, -89.342375),
                    new Vector(35.000740818182, -89.64656600000001),
                    new Vector(34.9992648181819, -89.71727),
                    new Vector(34.7812938181818, -89.721698),
                    new Vector(34.6913748181818, -89.716397),
                    new Vector(34.6928148181819, -89.665547),
                    new Vector(34.5660948181819, -89.664152),
                    new Vector(34.5660048181819, -89.71548799999999),
                    new Vector(34.1938998181819, -89.716685),
                    new Vector(34.1954658181818, -89.50508600000001),
                    new Vector(34.1659188181819, -89.5056349999999),
                    new Vector(33.8704668181818, -89.50506799999989),
                    new Vector(33.7245048181817, -89.502836),
                    new Vector(33.6776688181818, -89.502836),
                    new Vector(33.4670958181818, -89.502827),
                    new Vector(33.4642968181819, -89.378474),
                    new Vector(33.4484118181819, -89.407652),
                    new Vector(33.4347678181818, -89.415914),
                    new Vector(33.4466118181818, -89.437361),
                    new Vector(33.4352448181818, -89.4511219999999),
                    new Vector(33.2910288181819, -89.451221),
                    new Vector(33.2932158181818, -89.64501799999999),
                    new Vector(33.2945028181819, -89.69993599999989),
                    new Vector(33.274468818182, -89.705372),
                    new Vector(33.2480178181819, -89.736026),
                    new Vector(33.2243388181818, -89.748023),
                    new Vector(33.2120448181819, -89.746349),
                    new Vector(33.2010828181819, -89.765501),
                    new Vector(33.1828668181818, -89.7725659999999),
                    new Vector(33.1737228181819, -89.78624600000001),
                    new Vector(33.135958818182, -89.7899359999999),
                    new Vector(33.1236018181818, -89.813453),
                    new Vector(33.073507818182, -89.821472),
                    new Vector(33.0652818181819, -89.8356739999999),
                    new Vector(33.0484338181819, -89.836142),
                    new Vector(32.9954958181818, -89.87967500000001),
                    new Vector(32.9389938181818, -89.897441),
                    new Vector(32.9189058181819, -89.91100400000001),
                    new Vector(32.8854708181819, -89.964365),
                    new Vector(32.8861818181818, -89.72949199999999),
                    new Vector(32.6398338181818, -89.727143),
                    new Vector(32.6325168181818, -89.740724),
                    new Vector(32.6152098181819, -89.74286600000001),
                    new Vector(32.6142738181817, -89.75646500000001),
                    new Vector(32.601961818182, -89.757518),
                    new Vector(32.5927998181819, -89.78359999999989),
                    new Vector(32.3546598181818, -89.72686400000001),
                    new Vector(32.2265988181818, -89.72704400000001),
                    new Vector(32.0597748181819, -89.72603599999999)
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