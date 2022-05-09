using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wyoming_West_Central_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3738;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Wyoming West Central";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Wyoming West Central (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",40.5],PARAMETER[\"central_meridian\",-108.75],PARAMETER[\"scale_factor\",0.9999375],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"3738\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Wyoming West Central (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",40.5],PARAMETER[\"central_meridian\",-108.75],PARAMETER[\"scale_factor\",0.9999375],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(42.2590608181818, -107.52431),
                    new Vector(42.4404738181819, -107.524184),
                    new Vector(42.440806818182, -107.545343),
                    new Vector(42.7825368181818, -107.539124),
                    new Vector(42.7826718181818, -107.500388),
                    new Vector(43.1339148181819, -107.501918),
                    new Vector(43.1339598181819, -107.517623),
                    new Vector(43.4708928181819, -107.516615),
                    new Vector(43.4717748181819, -107.534975),
                    new Vector(43.5045618181818, -107.534768),
                    new Vector(43.5056148181819, -107.596706),
                    new Vector(43.6450428181818, -107.595185),
                    new Vector(43.6462758181819, -107.715488),
                    new Vector(43.7310468181819, -107.714399),
                    new Vector(43.7310288181819, -107.950766),
                    new Vector(43.8148998181819, -107.949911),
                    new Vector(43.8159348181819, -108.168899),
                    new Vector(43.8308208181818, -108.188213),
                    new Vector(43.8463908181819, -108.18599),
                    new Vector(43.8465798181819, -108.321872),
                    new Vector(43.9035588181819, -108.322304),
                    new Vector(43.9049088181819, -108.432968),
                    new Vector(43.9938648181818, -108.431753),
                    new Vector(43.9952148181819, -108.499928),
                    new Vector(44.0800128181819, -108.50108),
                    new Vector(44.0807868181818, -108.558482),
                    new Vector(44.1679518181818, -108.557312),
                    new Vector(44.1681228181818, -108.57902),
                    new Vector(44.527303818182, -108.578984),
                    new Vector(44.5277538181819, -108.592475),
                    new Vector(44.8641378181819, -108.599324),
                    new Vector(44.8633098181818, -108.62312),
                    new Vector(44.997589818182, -108.625253),
                    new Vector(44.9995158181818, -109.799384),
                    new Vector(45.0027918181819, -109.99553),
                    new Vector(44.9986248181818, -110.392763),
                    new Vector(44.9922798181819, -110.429645),
                    new Vector(44.9956908181819, -111.053426),
                    new Vector(44.6644908181819, -111.051617),
                    new Vector(44.661313818182, -110.668352),
                    new Vector(44.5794678181819, -110.668613),
                    new Vector(44.5819518181818, -110.374529),
                    new Vector(44.5519818181819, -110.370416),
                    new Vector(44.5437468181819, -110.342021),
                    new Vector(44.5443138181818, -110.310611),
                    new Vector(44.5002048181819, -110.28659),
                    new Vector(44.4284748181819, -110.295941),
                    new Vector(44.3774088181819, -110.235461),
                    new Vector(44.3283048181819, -110.22071),
                    new Vector(44.3257218181819, -110.20766),
                    new Vector(44.3035638181819, -110.192837),
                    new Vector(44.3063718181819, -110.181578),
                    new Vector(44.2957608181818, -110.15438),
                    new Vector(44.2354338181819, -110.135489),
                    new Vector(44.2127448181819, -110.112341),
                    new Vector(44.1987768181818, -110.108525),
                    new Vector(44.1933228181818, -110.117606),
                    new Vector(44.1850338181818, -110.1092),
                    new Vector(44.1651348181819, -110.115077),
                    new Vector(44.1495108181818, -110.107283),
                    new Vector(44.1400248181819, -110.094944),
                    new Vector(44.1339678181818, -110.058008),
                    new Vector(44.0079858181819, -110.057621),
                    new Vector(43.4652048181818, -110.053868),
                    new Vector(43.4647728181818, -109.748597),
                    new Vector(43.368490818182, -109.75064),
                    new Vector(43.3636128181819, -109.747688),
                    new Vector(43.3654488181818, -109.705577),
                    new Vector(43.3568538181819, -109.693499),
                    new Vector(43.3294938181819, -109.693751),
                    new Vector(43.3052478181818, -109.674725),
                    new Vector(43.2816138181819, -109.683482),
                    new Vector(43.1938818181819, -109.668047),
                    new Vector(43.1769438181819, -109.659092),
                    new Vector(43.1545428181819, -109.628951),
                    new Vector(43.1351658181819, -109.624217),
                    new Vector(43.0978518181819, -109.580315),
                    new Vector(43.0382898181819, -109.556024),
                    new Vector(43.0204248181819, -109.558364),
                    new Vector(43.0105338181818, -109.512374),
                    new Vector(42.9443298181819, -109.396094),
                    new Vector(42.9443748181819, -109.372901),
                    new Vector(42.8476788181819, -109.309658),
                    new Vector(42.8016528181818, -109.231673),
                    new Vector(42.7789098181819, -109.242473),
                    new Vector(42.7663278181819, -109.238378),
                    new Vector(42.7685778181819, -109.204772),
                    new Vector(42.7457808181817, -109.159934),
                    new Vector(42.7055598181819, -109.129442),
                    new Vector(42.7055598181819, -109.071356),
                    new Vector(42.439726818182, -109.072472),
                    new Vector(42.4393848181819, -109.046309),
                    new Vector(42.262849818182, -109.046543),
                    new Vector(42.2665128181818, -110.054588),
                    new Vector(41.5822158181819, -110.053391),
                    new Vector(41.4090378181819, -110.051375),
                    new Vector(41.4074358181819, -110.065964),
                    new Vector(40.9978908181819, -110.063183),
                    new Vector(40.9976028181819, -110.002163),
                    new Vector(40.9984398181819, -109.048316),
                    new Vector(41.0033718181819, -107.918672),
                    new Vector(41.4066528181819, -107.916125),
                    new Vector(41.4069588181818, -107.936366),
                    new Vector(41.6627298181818, -107.935952),
                    new Vector(41.6633058181818, -107.524526),
                    new Vector(41.7005118181818, -107.526398),
                    new Vector(41.7014118181819, -107.509838),
                    new Vector(42.0904638181819, -107.506508),
                    new Vector(42.0908778181819, -107.524481),
                    new Vector(42.2590608181818, -107.52431)
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